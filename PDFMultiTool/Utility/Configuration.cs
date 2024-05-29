using PDFMultiTool.Enums;
using PDFMultiTool.Utility;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PDFMultiTool
{
    [XmlRoot("Configuration")]
    public class ConfigurationData
    {
        [XmlElement("GhostScriptPath")]
        public string GhostScriptPath { get; set; }
    }

    internal class Configuration
    {
        private static readonly Lazy<Configuration> lazy =
            new Lazy<Configuration>(() => new Configuration());

        public static Configuration Instance { get { return lazy.Value; } }

        // Variables
        private const string filePath = "app.config";
        private const string defaultGSPath = "C:\\Program Files\\gs\\";
        private const string defaultGSExe = "gswin64c.exe";
        private ConfigurationData values;

        private Configuration()
        {
            if (!File.Exists(filePath))
            {
                // Create a new file if it does not exist
                using (var stream = File.Create(filePath))
                {
                    values = new ConfigurationData();
                    var serializer = new XmlSerializer(typeof(ConfigurationData));
                    serializer.Serialize(stream, values);
                }
            }

            LoadValues();
        }

        public void InitializeConfig(RichTextBox logRichTextBox, OpenFileDialog openFileDialog)
        {
            // Initialize GhostScript path
            InitializeGhostScriptPath(logRichTextBox, openFileDialog);

            // Log
            Logger.Instance.AppendText(
                $"Config initialization done."
            );
        }

        private void InitializeGhostScriptPath(RichTextBox logRichTextBox, OpenFileDialog openFileDialog)
        {
            // 1) Check GhostScript installation path in config file
            string savedPath = GetValue(ConfigurationOptionsEnum.GhostScriptPath.ToString());
            if (!string.IsNullOrEmpty(savedPath) && File.Exists(savedPath))
            {
                Logger.Instance.AppendText(
                    $"Found '{ConfigurationOptionsEnum.GhostScriptPath}' key in config: " + savedPath
                );
                return;
            }

            // 2) Check the default installation location for GhostScript
            var directories = Directory.GetDirectories(defaultGSPath);

            foreach (var directory in directories)
            {
                // Construct the potential path to the Ghostscript executable
                var potentialPath = Path.Combine(directory, "bin", defaultGSExe);

                // Check if the Ghostscript executable exists at this path
                if (File.Exists(potentialPath))
                {
                    Logger.Instance.AppendText(
                        $"Found '{defaultGSExe}' in default path: " + defaultGSPath
                    );

                    // Store in config file
                    SetValue(ConfigurationOptionsEnum.GhostScriptPath.ToString(), potentialPath);

                    return;
                }
            }

            // 3) Prompt the user for selecting the ghostscript executable and then store this value in the configuration file for next time
            openFileDialog.Filter = "EXE files (*.exe)|*.exe";
            openFileDialog.Title = "Select Ghostscript Executable";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Logger.Instance.AppendText(
                    $"Set GhostScript path: " + openFileDialog.FileName
                );

                // Save the selected path for future use
                SetValue(ConfigurationOptionsEnum.GhostScriptPath.ToString(), openFileDialog.FileName);
            }
            else
            {
                Logger.Instance.AppendText(
                    $"Could not initialize {ConfigurationOptionsEnum.GhostScriptPath}. The application may not function correctly."
                );
            }
        }

        public string GetValue(string key)
        {
            return key == ConfigurationOptionsEnum.GhostScriptPath.ToString() ? values.GhostScriptPath : null;
        }

        public void SetValue(string key, string value)
        {
            if (key == ConfigurationOptionsEnum.GhostScriptPath.ToString())
            {
                values.GhostScriptPath = value;
            }
            SaveValues();
        }

        private void SaveValues()
        {
            var serializer = new XmlSerializer(typeof(ConfigurationData));
            using (var stream = File.Create(filePath))
            {
                serializer.Serialize(stream, values);
            }
        }

        private void LoadValues()
        {
            var serializer = new XmlSerializer(typeof(ConfigurationData));
            using (var stream = File.OpenRead(filePath))
            {
                values = (ConfigurationData)serializer.Deserialize(stream);
            }
        }
    }
}

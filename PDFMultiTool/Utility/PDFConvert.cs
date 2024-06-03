using PDFMultiTool.Enums;
using PDFMultiTool.Models;
using PDFMultiTool.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PDFMultiTool
{
    internal class PDFConvert
    {
        private static PDFConvert instance = null;
        private static readonly object padlock = new object();

        // Hold each extension and what other extensions it is capable of being converted to
        private readonly ExtensionConverterModel[] extensionConversionArray = new ExtensionConverterModel[]
        {
            new ExtensionConverterModel{
                FromExtension="ps",
                ToExtension="pdf",
                Device="pdfwrite",
            },
            new ExtensionConverterModel{
                FromExtension="eps",
                ToExtension="pdf",
                Device="pdfwrite",
            },
            new ExtensionConverterModel{
                FromExtension="pcl",
                ToExtension="pdf",
                Device="pdfwrite",
            },
            new ExtensionConverterModel{
                FromExtension="pdf",
                ToExtension="ps",
                Device="pswrite",
            },
            new ExtensionConverterModel{
                FromExtension="pdf",
                ToExtension="jpeg",
                Device="jpeg",
            },
            new ExtensionConverterModel{
                FromExtension="pdf",
                ToExtension="png",
                Device="png16m",
            },
            new ExtensionConverterModel{
                FromExtension="pdf",
                ToExtension="tiff",
                Device="tiff24nc",
            },
            new ExtensionConverterModel{
                FromExtension="pdf",
                ToExtension="bmp",
                Device="bmp16m",
            },
            new ExtensionConverterModel{
                FromExtension="pdf",
                ToExtension="txt",
                Device="txtwrite",
            },
            new ExtensionConverterModel{
                FromExtension="pdf",
                ToExtension="eps",
                Device="eps2write",
            },
            new ExtensionConverterModel{
                FromExtension="pdf",
                ToExtension="svg",
                Device="svg",
            },
            new ExtensionConverterModel{
                FromExtension="pdf",
                ToExtension="html",
                Device="pdf2htmlEX",
            },
        };

        // List of extensions that enforce the:
        // "Separate Output Files for Each Page" checkbox
        private readonly string[] extensionsEnforceSeparateOutputFiles = new string[]
        {
            "eps"
        };

        /// <summary>
        /// Constructor
        /// </summary>
        PDFConvert()
        {
        }

        /// <summary>
        /// Implement Singleton pattern
        /// </summary>
        public static PDFConvert Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new PDFConvert();
                    }
                    return instance;
                }
            }
        }

        /// <summary>
        /// Get supported extensions to convert from
        /// </summary>
        /// <returns>Array of supported extensions</returns>
        public string[] GetSupportedExtensions()
        {
            return extensionConversionArray.Select(item => item.FromExtension).Distinct().OrderBy(ext => ext).ToArray();
        }

        /// <summary>
        /// Get supported extensions to convert to based on input extension
        /// </summary>
        /// <param name="extension"></param>
        /// <returns>Array of supported extensions</returns>
        public string[] GetConversionExtensions(string extension)
        {
            var models = extensionConversionArray.Where(model => model.FromExtension == extension).ToArray();
            if (models.Length > 0)
            {
                return extensionConversionArray
                    .Where(model => model.FromExtension == extension)
                    .Select(model => model.ToExtension)
                    .Distinct()
                    .OrderBy(ext => ext)
                    .ToArray();
            }
            else
            {
                return new string[] { };
            }
        }

        /// <summary>
        /// Get list of extensions requiring the argument for separating output files
        /// </summary>
        /// <param name="extension"></param>
        /// <returns></returns>
        public bool GetExtensionsEnforceSeparateOutputFiles(string extension)
        {
            // List of extensions that enforce separate output files
            List<string> extensionsEnforceSeparateOutputFiles = new List<string> { "eps", /* other extensions */ };

            // Check if the given extension is in the list
            return extensionsEnforceSeparateOutputFiles.Contains(extension);
        }


        /// <summary>
        /// Get the required device for the conversion
        /// </summary>
        /// <param name="fromExtension"></param>
        /// <param name="toExtension"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private string GetDevice(string fromExtension, string toExtension)
        {
            var model = extensionConversionArray.FirstOrDefault(m => m.FromExtension == fromExtension && m.ToExtension == toExtension);

            if (model != null)
            {
                return model.Device;
            }
            else
            {
                MessageBox.Show(
                    $"No device found for: {fromExtension} -> {toExtension}",
                    "PDF Multi-Tool",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return null;
            }
        }


        /// <summary>
        /// Performs the conversion
        /// </summary>
        /// <param name="filesToConvert"></param>
        /// <param name="fromExtension"></param>
        /// <param name="toExtension"></param>
        /// <param name="outputPath"></param>
        /// <param name="isSeparateOutputFiles"></param>
        /// <param name="resolution"></param>
        public void Convert(
            FileModel[] filesToConvert,
            string fromExtension,
            string toExtension,
            string outputPath,
            bool isSeparateOutputFiles,
            int resolution = 300

        )
        {
            // Get the device to use for the process
            string device = GetDevice(
                fromExtension,
                toExtension
            );

            // Process each file
            foreach (FileModel file in filesToConvert)
            {
                string fileNameNoExt = Path.GetFileNameWithoutExtension(file.FullPath);
                string outputFileName = isSeparateOutputFiles ? $"{fileNameNoExt}.%d.{toExtension}" : $"{fileNameNoExt}.{toExtension}";
                
                var args = $@"-sDEVICE={device} -dNOPAUSE -dBATCH -dSAFER -r{resolution} -sOutputFile=""{outputPath}\\{outputFileName}"" ""{file.FullPath}"" -c quit";

                var startInfo = new ProcessStartInfo(
                    Configuration.Instance.GetValue(ConfigurationOptionsEnum.GhostScriptPath.ToString()),
                    args
                );
                startInfo.CreateNoWindow = true;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.UseShellExecute = false;

                // Redirect the output
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardError = true;

                var process = Process.Start(startInfo);

                // Read the output
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                // Log the output and error strings
                Logger.Instance.AppendText(
                    $"GhostScript process completed."
                    + Environment.NewLine
                    + Environment.NewLine
                    + $"Process output: {output}"
                    + Environment.NewLine
                    + Environment.NewLine
                    + $"Process error: {error}"
                );

                // If no error present:
                if (String.IsNullOrEmpty(error))
                {
                    MessageBox.Show(
                        "Process completed!",
                        "PDF Multi-Tool",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "Process error. See logs.",
                        "PDF Multi-Tool",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }// End of foreach
    }
}

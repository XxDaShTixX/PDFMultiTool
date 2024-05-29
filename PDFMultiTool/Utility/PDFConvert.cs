using PDFMultiTool.Enums;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PDFMultiTool
{
    internal class PDFConvert
    {
        private static PDFConvert instance = null;
        private static readonly object padlock = new object();

        // Hold each extension and what other extensions it is capable of being converted to
        private readonly Dictionary<string, string[]> extensionConversionMap = new Dictionary<string, string[]>
        {
            { "pdf", new string[] { "html", "xps", "svg", "jpeg", "png", "bmp" } },
            { "doc", new string[] { "pdf" } },
            { "docx", new string[] { "pdf" } },
            { "xls", new string[] { "pdf" } },
            { "xlsx", new string[] { "pdf" } },
            { "ppt", new string[] { "pdf" } },
        };

        /// <summary>
        /// Constructor
        /// </summary>
        PDFConvert()
        {
            // Current GhostScript version: GhostPDL 10.03.1
            // Ref: https://github.com/ArtifexSoftware/ghostpdl-downloads/releases
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
        /// <param name="extensionConversionMap"></param>
        /// <returns>Array of supported extensions</returns>
        public string[] GetSupportedExtensions()
        {
            return extensionConversionMap.Keys.OrderBy(key => key).ToArray();
        }

        /// <summary>
        /// Get supported extensions to convert to based on input extension
        /// </summary>
        /// <param name="extensionConversionMap"></param>
        /// <param name="extension"></param>
        /// <returns>Array of supported extensions</returns>
        public string[] GetConversionExtensions(string extension)
        {
            if (extensionConversionMap.ContainsKey(extension))
            {
                return extensionConversionMap[extension].OrderBy(ext => ext).ToArray();
            }
            else
            {
                return new string[] { };
            }
        }

        public void Convert(
            string[] filesToConvert, 
            string outputPath, 
            string outputExtension,
            string device
        )
        {
            foreach ( var file in filesToConvert )
            {
                var args = $"-sDEVICE={device} -dNOPAUSE -sOutputFile={outputPath} {file} -c quit";
                
                var startInfo = new ProcessStartInfo(
                    Configuration.Instance.GetValue(ConfigurationOptionsEnum.GhostScriptPath.ToString()), 
                    args
                );
                startInfo.CreateNoWindow = true;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.UseShellExecute = false;
                var process = Process.Start(startInfo);
                process.WaitForExit();
            }
            
        }
    }
}

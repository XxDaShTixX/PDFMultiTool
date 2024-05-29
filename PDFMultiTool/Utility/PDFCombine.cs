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
    internal class PDFCombine
    {
        private static PDFCombine instance = null;
        private static readonly object padlock = new object();
        private const string device = "pdfwrite";

        /// <summary>
        /// Constructor
        /// </summary>
        PDFCombine()
        {
        }

        /// <summary>
        /// Implement Singleton pattern
        /// </summary>
        public static PDFCombine Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new PDFCombine();
                    }
                    return instance;
                }
            }
        }

        /// <summary>
        /// Performs the combine
        /// </summary>
        /// <param name="filesToConvert"></param>
        /// <param name="inputExtension">pdf, jpg, etc.</param>
        /// <param name="outputExtension"></param>
        /// <param name="outputPath">C:\\output</param>
        /// <param name="device"></param>
        public void Combine(
    string[] filesToCombine,
    string outputPath,
    string outputFileNameNoExt,
    int resolution = 300
)
        {
            string outputFileName = $"{outputFileNameNoExt}.pdf";

            // Prepare the list of files to combine
            string inputFiles = string.Join(" ", filesToCombine.Select(f => $"\"{f}\""));

            var args = $@"
    -sDEVICE={device} 
    -dNOPAUSE 
    -r{resolution} 
    -sOutputFile=""{outputPath}\\{outputFileName}"" {inputFiles}
    -c quit
    ";

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
    }
}

using PDFMultiTool.Enums;
using PDFMultiTool.Models;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System;

namespace PDFMultiTool.Utility
{
    internal class PDFSplit
    {
        private static PDFSplit instance = null;
        private static readonly object padlock = new object();
        private const string device = "pdfwrite";

        /// <summary>
        /// Constructor
        /// </summary>
        PDFSplit() { }

        /// <summary>
        /// Implement Singleton pattern
        /// </summary>
        public static PDFSplit Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new PDFSplit();
                    }
                    return instance;
                }
            }
        }

        /// <summary>
        /// Performs the split
        /// </summary>
        /// <param name="filesToConvert"></param>
        /// <param name="inputExtension">pdf, jpg, etc.</param>
        /// <param name="outputExtension"></param>
        /// <param name="outputPath">C:\\output</param>
        /// <param name="device"></param>
        public void Split(
    string sourceFilePath,
    Int64 fromPage,
    Int64 toPage,
    string outputFolder,
    string outputFileName)
        {
            var args = $@"-sDEVICE={device} -dNOPAUSE -dBATCH -dSAFER -dFirstPage={fromPage} -dLastPage={toPage} -sOutputFile=""{outputFolder}\\{outputFileName}"" ""{sourceFilePath}"" -c quit";

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

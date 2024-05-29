using System;
using System.Windows.Forms;

namespace PDFMultiTool.Utility
{
    internal class Logger
    {
        private static readonly Lazy<Logger> lazy =
            new Lazy<Logger>(() => new Logger());

        public static Logger Instance { get { return lazy.Value; } }

        private RichTextBox logTextBox;

        private const string logNewLineSeparator = "- - -";

        private Logger() { }

        public void AppendText(string text)
        {
            string timestamp = DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss]  ");
            text = timestamp + text;

            if (this.logTextBox.InvokeRequired)
            {
                this.logTextBox.Invoke(new Action(() => {
                    this.logTextBox.AppendText(text);

                    // Separator
                    this.logTextBox.AppendText(Environment.NewLine);
                    this.logTextBox.AppendText(logNewLineSeparator);
                    this.logTextBox.AppendText(Environment.NewLine);
                }));
            }
            else
            {
                this.logTextBox.AppendText(text);

                // Separator
                this.logTextBox.AppendText(Environment.NewLine);
                this.logTextBox.AppendText(logNewLineSeparator);
                this.logTextBox.AppendText(Environment.NewLine);
            }

            this.logTextBox.ScrollToCaret();
        }

        /// <summary>
        /// Sets the logRichTextBox instance to the one that the logger should log to
        /// </summary>
        /// <param name="richTextBox"></param>
        public void SetLogRichTextBox(RichTextBox richTextBox)
        {
            this.logTextBox = richTextBox;

            // Log
            AppendText("Sucessfully referenced output window.");
        }
    }
}

using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PDFMultiTool.Utility
{
    internal class Logger
    {
        private static readonly Lazy<Logger> lazy =
            new Lazy<Logger>(() => new Logger());

        public static Logger Instance { get { return lazy.Value; } }

        private const string logNewLineSeparator = "- - -";

        private Logger() { }

        public void AppendText(RichTextBox richTextBox, string text)
        {
            if (richTextBox.InvokeRequired)
            {
                richTextBox.Invoke(new Action(() => {
                    richTextBox.AppendText(text);

                    // Separator
                    richTextBox.AppendText(Environment.NewLine);
                    richTextBox.AppendText(logNewLineSeparator);
                    richTextBox.AppendText(Environment.NewLine);
                }));
            }
            else
            {
                richTextBox.AppendText(text);

                // Separator
                richTextBox.AppendText(Environment.NewLine);
                richTextBox.AppendText(logNewLineSeparator);
                richTextBox.AppendText(Environment.NewLine);
            }
        }
    }
}

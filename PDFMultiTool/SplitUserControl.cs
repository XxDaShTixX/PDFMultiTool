using PDFMultiTool.Models;
using PDFMultiTool.Utility;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PDFMultiTool
{
    public partial class SplitUserControl : UserControl
    {
        public SplitUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for when the user control loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CombineUserControl_Load(object sender, EventArgs e)
        {
            // Get list of supported extensions to convert from
            string[] supportedExtensions = PDFConvert.Instance.GetSupportedExtensions();

        }

        /// <summary>
        /// Event handler for when the browse button is clicked for the select file(s)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrowseFile_Button_Click(object sender, EventArgs e)
        {
            // Create a new instance of the OpenFileDialog class
            OpenFileDialog openFileDialog = browseFiles_ConvertUserControl_OpenFileDialog;

            // Set filter options
            string selectedExtension = "pdf";
            openFileDialog.Filter = $"{selectedExtension.ToUpper()} Files (*.{selectedExtension})|*.{selectedExtension}";

            // Set filter index
            openFileDialog.FilterIndex = 1;

            // Allow multiple files to be selected
            openFileDialog.Multiselect = false;

            // Call the ShowDialog method to show the dialog box.
            var userClickedOK = openFileDialog.ShowDialog();

            // If the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                // Add list of all file paths to an array
                string[] paths = openFileDialog.FileNames;

                // Go through each file path
                foreach (string path in paths)
                {
                    // Create a FileItem object for each file path
                    FileModel file = new FileModel(path);

                    // Set as the text of the textbox
                    browseFile_Textbox.Text = file.FullPath;
                }

                // Log
                Logger.Instance.AppendText($"Selected {paths.Length} files.");
            }
        }

        /// <summary>
        /// Event handler for when the select output location browse button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseOutput_Button_Click(object sender, EventArgs e)
        {
            // When to NOT process the click?
            if (browseFile_Textbox.Text.Equals(string.Empty)
                || fileFromPage_TextBox.Text.Equals(string.Empty)
                || fileFromPage_TextBox.Text.Equals(string.Empty)
            )
            {
                MessageBox.Show(
                    "Please follow the steps in order.",
                    "PDF Multi-Tool",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Create a new instance of the FolderBrowserDialog class
            FolderBrowserDialog folderBrowserDialog = browseFolder_ConvertUserControl_FolderBrowserDialog;

            // Show the FolderBrowserDialog
            DialogResult result = folderBrowserDialog.ShowDialog();

            // Ff the user clicked OK
            if (result == DialogResult.OK)
            {
                // Get the selected path
                string selectedFolderPath = folderBrowserDialog.SelectedPath;

                // Set the text value of the textbox
                browseOutput_Textbox.Text = selectedFolderPath;

                // Log
                Logger.Instance.AppendText($"Set output location: {selectedFolderPath}");
            }
        }

        private void Resolution_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the input is not a digit
            if (!char.IsDigit(e.KeyChar)
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Handled the event, so the TextBox will ignore this keystroke
            }
        }

        private void FileFromPage_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Handled the event, so the TextBox will ignore this keystroke
            }
        }

        private void FileToPage_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Handled the event, so the TextBox will ignore this keystroke
            }
        }

        private void split_Button_Click(object sender, EventArgs e)
        {
            // When to NOT process the click?
            if (browseFile_Textbox.Text.Equals(string.Empty)
                || fileFromPage_TextBox.Text.Equals(string.Empty)
                || fileFromPage_TextBox.Text.Equals(string.Empty)
                || browseOutput_Textbox.Text.Equals(string.Empty)
                || OutputFileName_TextBox.Text.Equals(string.Empty)
            )
            {
                MessageBox.Show(
                    "Please follow the steps in order.",
                    "PDF Multi-Tool",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            PDFSplit.Instance.Split(
                browseFile_Textbox.Text,
                Int64.Parse(fileFromPage_TextBox.Text),
                Int64.Parse(fileToPage_TextBox.Text),
                browseOutput_Textbox.Text,
                // Append file name with the label extension
                $"{OutputFileName_TextBox.Text}{OutputFileExtension_Label.Text}"
            );
        }
    }
}

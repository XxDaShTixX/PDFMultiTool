using PDFMultiTool.Models;
using PDFMultiTool.Utility;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PDFMultiTool
{
    public partial class CombineUserControl : UserControl
    {
        public CombineUserControl()
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
            openFileDialog.Multiselect = true;

            // Call the ShowDialog method to show the dialog box.
            var userClickedOK = openFileDialog.ShowDialog();

            // If the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                // Add list of all file paths to an array
                string[] paths = openFileDialog.FileNames;

                // Reference the list view in the user control
                ListBox listBox = SelectFiles_ListBox;

                // Clear existing list
                listBox.Items.Clear();

                // Go through each file path
                foreach (string path in paths)
                {
                    // Create a FileItem object for each file path
                    FileModel file = new FileModel(path);

                    // Add them to the list box
                    listBox.Items.Add(file);
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
            if (SelectFiles_ListBox.Items.Count == 0)
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

        private void combine_Button_Click(object sender, EventArgs e)
        {
            // When to NOT process the click?
            if (SelectFiles_ListBox.Items.Count.Equals(0)
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

            PDFCombine.Instance.Combine(
                SelectFiles_ListBox.Items.Cast<FileModel>().ToArray(),
                browseOutput_Textbox.Text,
                OutputFileName_TextBox.Text,
                Int16.Parse(Resolution_TextBox.Text)
            );
        }

        private void MoveFileUp_Button_Click(object sender, EventArgs e)
        {
            MoveItem(-1);
        }

        private void MoveFileDown_Button_Click(object sender, EventArgs e)
        {
            MoveItem(1);
        }

        private void MoveItem(int direction)
        {
            // Checking selected item
            if (SelectFiles_ListBox.SelectedItem == null || SelectFiles_ListBox.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = SelectFiles_ListBox.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= SelectFiles_ListBox.Items.Count)
                return; // Index out of range - nothing to do

            object selected = SelectFiles_ListBox.SelectedItem;

            // Removing removable element
            SelectFiles_ListBox.Items.Remove(selected);
            // Insert it in new position
            SelectFiles_ListBox.Items.Insert(newIndex, selected);
            // Restore selection
            SelectFiles_ListBox.SetSelected(newIndex, true);
        }
    }
}

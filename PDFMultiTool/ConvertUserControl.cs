using PDFMultiTool.Models;
using PDFMultiTool.Utility;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PDFMultiTool
{
    public partial class ConvertUserControl : UserControl
    {
        public ConvertUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for when the user control loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertUserControl_Load(object sender, EventArgs e)
        {
            // Get list of supported extensions to convert from
            string[] supportedExtensions = PDFConvert.Instance.GetSupportedExtensions();

            // Load into combo box
            fromExtension_ComboBox.Items.AddRange(supportedExtensions);
        }

        /// <summary>
        /// Event handler for when a dropdown item is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fromExtension_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear objects as needed
            toExtension_ComboBox.Items.Clear();
            SelectFiles_ListBox.Items.Clear();
            browseOutput_Textbox.Clear();

            // If a fromExtension is still selected, load the toExtension
            if (fromExtension_ComboBox.SelectedIndex != -1)
            {
                // Refresh the ToExtension combobox
                RefreshToExtensionComboBox(sender as ComboBox);
            }
        }

        /// <summary>
        /// Event handler for when a dropdown item is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toExtension_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item from the dropdown
            bool isEnforceSeparateOutputFiles = PDFConvert.Instance.GetExtensionsEnforceSeparateOutputFiles(
                toExtension_ComboBox.SelectedItem.ToString()
            );

            // Check if the selected item has an enforceable extension
            if (isEnforceSeparateOutputFiles)
            {
                // If it is, check the checkbox and make it read-only
                SeparateOutputFiles_CheckBox.Checked = true;
                SeparateOutputFiles_CheckBox.Enabled = false;
            }
            else
            {
                // If it's not, uncheck the checkbox and make it editable
                SeparateOutputFiles_CheckBox.Checked = false;
                SeparateOutputFiles_CheckBox.Enabled = true;
            }
        }


        /// <summary>
        /// Event handler for when the browse button is clicked for the select file(s)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrowseFile_Button_Click(object sender, EventArgs e)
        {
            // When to NOT process the click?
            if(fromExtension_ComboBox.SelectedItem == null
                || toExtension_ComboBox.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please follow the steps in order.", 
                    "PDF Multi-Tool",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Create a new instance of the OpenFileDialog class
            OpenFileDialog openFileDialog = browseFiles_ConvertUserControl_OpenFileDialog;

            // Set filter options
            string selectedExtension = fromExtension_ComboBox.SelectedItem as string;
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
            if (fromExtension_ComboBox.SelectedItem == null
            || toExtension_ComboBox.SelectedItem == null
            || SelectFiles_ListBox.Items.Count == 0)
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

        /// <summary>
        /// Event handler for when key stroke is fired. 
        /// This will only allow numerics
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Resolution_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the input is not a digit
            if (!char.IsDigit(e.KeyChar) 
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Handled the event, so the TextBox will ignore this keystroke
            }
        }

        /// <summary>
        /// Sets the applicable toExtension based on the fromExtenion value
        /// </summary>
        /// <param name="comboBox">ComboBox to populate</param>
        private void RefreshToExtensionComboBox(ComboBox comboBox)
        {
            // Get the selected extension
            string extension = comboBox.SelectedItem as string;

            // Get array of conversion extensions supported for the selected extension
            string[] conversionExtensions = PDFConvert.Instance.GetConversionExtensions(extension);

            // Apply the conversion extendion to the "convert to" dropdown
            toExtension_ComboBox.Items.AddRange(conversionExtensions);
        }

        /// <summary>
        /// Start convertion process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void convert_Button_Click(object sender, EventArgs e)
        {
            // When to NOT process the click?
            if (fromExtension_ComboBox.SelectedItem.Equals(null)
                || toExtension_ComboBox.SelectedItem.Equals(null)
                || SelectFiles_ListBox.Items.Count.Equals(0)
                || browseOutput_Textbox.Text.Equals(string.Empty)
            )
            {
                MessageBox.Show(
                    "Please follow the steps in order.",
                    "PDF Multi-Tool",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            PDFConvert.Instance.Convert(
                SelectFiles_ListBox.Items.Cast<FileModel>().ToArray(),
                fromExtension_ComboBox.Text,
                toExtension_ComboBox.Text,
                browseOutput_Textbox.Text,
                SeparateOutputFiles_CheckBox.Checked,
                Int16.Parse(Resolution_TextBox.Text)
            );
        }
    }
}

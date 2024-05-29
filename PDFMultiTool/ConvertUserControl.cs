using PDFMultiTool.Utility;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
            string[] supportedExtensions = PDFConverter.Instance.GetSupportedExtensions();

            // Load into combo box
            fromExtension_ConverUserControl_ComboBox.Items.AddRange(supportedExtensions);

        }

        /// <summary>
        /// Event handler for when a dropdown item is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fromExtension_ConverUserControl_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear objects as needed
            toExtension_ConverUserControl_ComboBox.Items.Clear();
            SelectFiles_ConverUserControl_ListBox.Items.Clear();
            browseOutput_ConverUserControl_Textbox.Clear();

            // If a fromExtension is still selected, load the toExtension
            if (fromExtension_ConverUserControl_ComboBox.SelectedIndex != -1)
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
        private void toExtension_ConverUserControl_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item from the dropdown
            bool isEnforceSeparateOutputFiles = PDFConverter.Instance.GetExtensionsEnforceSeparateOutputFiles(
                toExtension_ConverUserControl_ComboBox.SelectedItem.ToString()
            );

            // Check if the selected item has an enforceable extension
            if (isEnforceSeparateOutputFiles)
            {
                // If it is, check the checkbox and make it read-only
                SeparateOutputFiles_ConvertUserControl_CheckBox.Checked = true;
                SeparateOutputFiles_ConvertUserControl_CheckBox.Enabled = false;
            }
            else
            {
                // If it's not, uncheck the checkbox and make it editable
                SeparateOutputFiles_ConvertUserControl_CheckBox.Checked = false;
                SeparateOutputFiles_ConvertUserControl_CheckBox.Enabled = true;
            }
        }


        /// <summary>
        /// Event handler for when the browse button is clicked for the select file(s)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrowseFile_ConverUserControl_Button_Click(object sender, EventArgs e)
        {
            // When to NOT process the click?
            if(fromExtension_ConverUserControl_ComboBox.SelectedItem == null
                || toExtension_ConverUserControl_ComboBox.SelectedItem == null)
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
            string selectedExtension = fromExtension_ConverUserControl_ComboBox.SelectedItem as string;
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
                ListBox listBox = SelectFiles_ConverUserControl_ListBox;

                // Clear existing list
                listBox.Items.Clear();

                // Go through each file path
                foreach (string path in paths)
                {
                    // Add them to the list box
                    listBox.Items.Add(path);
                }
            }
        }

        /// <summary>
        /// Event handler for when the select output location browse button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseOutput_ConverUserControl_Button_Click(object sender, EventArgs e)
        {
            // When to NOT process the click?
            if (fromExtension_ConverUserControl_ComboBox.SelectedItem == null
            || toExtension_ConverUserControl_ComboBox.SelectedItem == null
            || SelectFiles_ConverUserControl_ListBox.Items.Count == 0)
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
                browseOutput_ConverUserControl_Textbox.Text = selectedFolderPath;
            }
        }

        /// <summary>
        /// Event handler for when key stroke is fired. 
        /// This will only allow numerics
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Resolution_ConvertUserControl_TextBox_KeyPress(object sender, KeyPressEventArgs e)
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
            string[] conversionExtensions = PDFConverter.Instance.GetConversionExtensions(extension);

            // Apply the conversion extendion to the "convert to" dropdown
            toExtension_ConverUserControl_ComboBox.Items.AddRange(conversionExtensions);
        }

        /// <summary>
        /// Start convertion process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void convert_ConverUserControl_Button_Click(object sender, EventArgs e)
        {
            // When to NOT process the click?
            if (fromExtension_ConverUserControl_ComboBox.SelectedItem.Equals(null)
                || toExtension_ConverUserControl_ComboBox.SelectedItem.Equals(null)
                || SelectFiles_ConverUserControl_ListBox.Items.Count.Equals(0)
                || browseOutput_ConverUserControl_Textbox.Text.Equals(string.Empty)
            )
            {
                MessageBox.Show(
                    "Please follow the steps in order.",
                    "PDF Multi-Tool",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            PDFConverter.Instance.Convert(
                SelectFiles_ConverUserControl_ListBox.Items.Cast<string>().ToArray(),
                fromExtension_ConverUserControl_ComboBox.Text,
                toExtension_ConverUserControl_ComboBox.Text,
                browseOutput_ConverUserControl_Textbox.Text,
                SeparateOutputFiles_ConvertUserControl_CheckBox.Checked,
                Int16.Parse(Resolution_ConvertUserControl_TextBox.Text)
            );
        }
    }
}

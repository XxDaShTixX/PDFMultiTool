using System;
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
            fromExtension_ConverUserControl_ComboBox.Items.AddRange(supportedExtensions);

            //string[] conversionExtensions = GetConversionExtensions(extensionConversionMap, "pdf");

        }

        /// <summary>
        /// Event handler for when a dropdown item is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fromExtension_ConverUserControl_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reference the combobox
            ComboBox comboBox = (ComboBox)sender;

            // Get the selected extension
            string extension = comboBox.SelectedItem as string;

            // Get array of conversion extensions supported for the selected extension
            string[] conversionExtensions = PDFConvert.Instance.GetConversionExtensions(extension);

            // Apply the conversion extendion to the "convert to" dropdown
            toExtension_ConverUserControl_ComboBox.Items.AddRange(conversionExtensions); ;
        }

        /// <summary>
        /// Event handler for when the dropdown is clicked. Used to clea combobox items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fromExtension_ConverUserControl_ComboBox_Click(object sender, EventArgs e)
        {
            // Clear to combobox
            toExtension_ConverUserControl_ComboBox.Items.Clear();
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
            if (fromExtension_ConverUserControl_ComboBox.SelectedItem.Equals(null)
                || toExtension_ConverUserControl_ComboBox.SelectedItem.Equals(null)
                || SelectFiles_ConverUserControl_ListBox.Items.Count.Equals(0))
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

        private void convert_ConverUserControl_Button_Click(object sender, EventArgs e)
        {
        }
    }
}

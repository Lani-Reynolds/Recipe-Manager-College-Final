using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeManager
{
    public partial class frmRecipeManager : Form
    {
        // Global string of where the user's files are kept, this is usually in the %APPDATA% (C:/Users/<user>/AppData/Roaming)
        public string userRecipesPath = Application.UserAppDataPath;

        // Global recipeFilePath string to be used when needed to access the current recipe file
        public string recipeFilePath;

        // Global selection string to be used when constructing the recipeFilePath
        public string selection = "";

        public frmRecipeManager() => InitializeComponent();

        private void Load_Files()
        {
            // Iterate through each file in the directory
            foreach (string recipeFile in Directory.GetFiles(userRecipesPath))
            {
                // Construct an array of the file path split at each `\`, use escape character to reach
                string[] recipeFileArray = recipeFile.Split('\\');

                // Construct a string using the last index in the array and replacing dashes with spaces and removing the `.recipe`
                string recipeFileString = recipeFileArray[recipeFileArray.Length - 1].Replace("-", " ").Replace(".recipe", "");

                // Add recipeFileString to the listbox
                lbRecipeList.Items.Add(recipeFileString);
            }
        }

        private void GenerateRecipePath() => recipeFilePath = Path.Combine(userRecipesPath, selection.Replace(" ", "-") + ".recipe");    // Delcare a string that holds the current recipe file name files end with `.recipe`

        private void ClearContentBoxes()
        {
            // Clear text in the name and decription boxes and reset count on the ingredients and directions boxes
            txtRecipeName.Text = "";
            rtxtDescription.Text = "";
            rtxtIngredients.Text = "1.";
            rtxtDirections.Text = "Step 1.";
        }

        private void tsmiCreateNew_Click(object sender, EventArgs e) => ClearContentBoxes();

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            // Clear selection variable
            selection = "";

            // Strings to display in the message box
            string msg = "Please enter a file name";
            string caption = "Missing File Name";

            // If there is text in the text box
            if (txtRecipeName.Text != "")
            {
                // Set selection variable to text in recipe name textbox
                selection += txtRecipeName.Text;

                GenerateRecipePath();

                // Create recipe using the file path and write 'Hello World' in the file
                File.WriteAllText(recipeFilePath, "Hello World!");

                // Add recipe name to the listbox
                lbRecipeList.Items.Add(txtRecipeName.Text);
            }
            else MessageBox.Show(msg, caption);
            

            /* Code Features */

            //string example = $"Name:{txtRecipeName.Text}\n" +
            //                 $"Description:{rtxtDescription.Text}\n" +
            //                 $"Ingredients:1/4_tsp-Black_Pepper|1_tbsp-Olive_Oil" + //This is an example of how ingredients will be displayed in the file
            //                 $"Directions: {rtxtDirections.Text}";

            // Construct a string to be saved to the file
            // Save contents of text boxes to recipe file

            // Extra credit
            // Analyze the contents of each of the textboxes as raw string, and search for raw newline unicode characters, we're searching for r'\n'
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            GenerateRecipePath();

            // Check if the file exists
            if (File.Exists(recipeFilePath))
            {
                // Strings to display in the message box
                string msg = "Are you sure you would like to delete this recipe?";
                string caption = "Delete Recipe";

                // Yes or no buttons
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                // Get result from the message box
                DialogResult result = MessageBox.Show(msg, caption, buttons);

                // If the result equals yes, clear the contents, delete the file, and remove the recipe name from listbox
                if (result == DialogResult.Yes)
                {
                    ClearContentBoxes();

                    // Delete file
                    File.Delete(recipeFilePath);

                    // Remove selection from the listbox
                    lbRecipeList.Items.Remove(selection);

                    // Set selected item to null
                    lbRecipeList.SelectedItem = null;
                }
            }
            // If the file does not exist, display an error message
            else
            {
                MessageBox.Show("File not found", "Error");
            }
        }

        private void lbRecipeList_SelectedValueChanged(object sender, EventArgs e)
        {
            // Gaurd clause for if the selected item in the list box is null, do nothing
            if (lbRecipeList.SelectedItem == null) return;

            // Clear selection variable
            selection = "";

            // Set selection variable to the selected item in the listbox as a string
            selection += lbRecipeList.SelectedItem.ToString();


            /* Code Features */

            // Load respective recipe file contents into text boxes

        }

        private void frmRecipeManager_Load(object sender, EventArgs e)
        {
            // This is where we load any existing files on startup
            Load_Files();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}

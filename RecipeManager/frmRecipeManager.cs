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
        //Where the user's files are kept, this is usually in the %APPDATA% (C:/Users/<user>/AppData/Roaming)
        public string UserRecipesPath = Application.UserAppDataPath;
        public string recipeFile;

        public frmRecipeManager() => InitializeComponent();

        private void Load_Files()
        {
            /* Code Features */

            // Iterate over each file finding the name of each recipe, and loading them into list box
        }

        private void ClearContentBoxes()
        {
            // Clear text in the name and decription boxes and reset count on the ingredients and directions boxes
            txtRecipeName.Text = "";
            rtxtDescription.Text = "";
            rtxtIngredients.Text = "1.";
            rtxtDirections.Text = "Step 1.";
        }

        private void GenerateRecipePath()
        {
            // Delcare a string that holds the current recipe file name
            // Files end with `.recipe`
            recipeFile = Path.Combine(UserRecipesPath, txtRecipeName.Text.Replace(" ", "-") + ".recipe");
        }

        private void tsmiCreateNew_Click(object sender, EventArgs e)
        {
            ClearContentBoxes();
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            GenerateRecipePath();

            Console.WriteLine(recipeFile);

            File.WriteAllText(recipeFile, "Hello World!");


            /* Code Features */

            string example = $"Name:{txtRecipeName.Text}\n" +
                             $"Description:{rtxtDescription.Text}\n" +
                             $"Ingredients:1/4_tsp-Black_Pepper|1_tbsp-Olive_Oil" + //This is an example of how ingredients will be displayed in the file
                             $"Directions: {rtxtDirections.Text}";

            // Construct a string to be saved to the file
            // Save contents of text boxes to recipe file
            // Add new recipe name to listbox

            // Extra credit
            // Analyze the contents of each of the textboxes as raw string, and search for raw newline unicode characters, we're searching for r'\n'
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            GenerateRecipePath();

            // Check if the file exists
            if (File.Exists(recipeFile))
            {
                // Strings to display in the message box
                string msg = "Are you sure you would like to delete this recipe?";
                string caption = "Delete Recipe";

                // Yes or no buttons
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                // Get result from the message box
                DialogResult result;
                result = MessageBox.Show(msg, caption, buttons);

                // If the result equals yes, clear the contents and delete the file
                if (result == DialogResult.Yes)
                {
                    ClearContentBoxes();
                    File.Delete(recipeFile);
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
            /* Code Features */

            // Load respective recipe file contents into text boxes
        }

        private void frmRecipeManager_Load(object sender, EventArgs e)
        {
            //This is where we would load any existing files on startup
            Load_Files();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}

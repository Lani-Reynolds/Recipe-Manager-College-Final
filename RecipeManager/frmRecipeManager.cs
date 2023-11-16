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
using System.Windows.Forms.VisualStyles;
using System.Text.RegularExpressions;

namespace RecipeManager
{
    public partial class frmRecipeManager : Form
    {
        // Global string of where the user's files are kept, this is usually in the %APPDATA% (C:/Users/<user>/AppData/Roaming)
        public string UserRecipesPath = Application.UserAppDataPath;

        // Global RecipeFilePath string to be used when needed to access the current recipe file
        public string RecipeFilePath;

        // Global CurrentRecipe string to be used when constructing the RecipeFilePath
        public string CurrentRecipe = "";

        public frmRecipeManager() 
        { 
            InitializeComponent();

            // Set the first line of both the ingredients and the directions to bulleted
            rtxtIngredients.SelectionBullet = true;
            rtxtDirections.SelectionBullet = true;
        }

        private void Load_Files()
        {
            // Iterate through each file in the directory
            foreach (string recipeFile in Directory.GetFiles(UserRecipesPath))
            {
                // Construct an array of the file path split at each `\`, use escape character to reach
                string[] recipeFileArray = recipeFile.Split('\\');

                // Construct a string using the last index in the array and replacing dashes with spaces and removing the `.recipe`
                string recipeFileString = recipeFileArray[recipeFileArray.Length - 1].Replace("-", " ").Replace(".recipe", "");

                // Add recipeFileString to the listbox
                lbRecipeList.Items.Add(recipeFileString);
            }
        }

        private void GenerateRecipePath() => RecipeFilePath = Path.Combine(UserRecipesPath, CurrentRecipe.Replace(" ", "-") + ".recipe");    // Delcare a string that holds the current recipe file name files end with `.recipe`

        private void ClearContentBoxes()
        {
            // Clear text in the name and decription boxes and reset count on the ingredients and directions boxes
            txtRecipeName.Text = "";
            rtxtDescription.Text = "";
            rtxtIngredients.Text = "";
            rtxtDirections.Text = "";
        }

        private void frmRecipeManager_Load(object sender, EventArgs e)
        {
            // This is where we load any existing files on startup
            Load_Files();
        }

        private void tsmiCreateNew_Click(object sender, EventArgs e) => ClearContentBoxes();

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            // Clear CurrentRecipe variable (if needed)
            CurrentRecipe = "";

            // Strings to display in the message box
            string msg = "Please enter a file name";
            string caption = "Missing File Name";

            // If there is text in the text box
            if (txtRecipeName.Text != "")
            {
                // Set CurrentRecipe variable to text in recipe name textbox
                CurrentRecipe = txtRecipeName.Text;

                GenerateRecipePath();

                // Add recipe name to the listbox
                lbRecipeList.Items.Add(txtRecipeName.Text);

                // Construct an array that is the size of the current number of lines in the richtextbox
                string[] ingredientArray = new string[rtxtIngredients.Lines.Length];

                // For loop that iterates through each line in the richtextbox
                for (int i = 0; i < rtxtIngredients.Lines.Length; i++)
                {
                    // Get the first character of the current line iteration
                    int currentLineStart = rtxtIngredients.GetFirstCharIndexFromLine(i);

                    // Set the cursor to the current line iteration
                    rtxtIngredients.SelectionStart = currentLineStart;

                    // If the line does not have a bullet point, place a bullet point
                    if (!rtxtIngredients.SelectionBullet)
                    {
                        rtxtIngredients.SelectionBullet = true;
                    }

                    // Place a "~" in front of the current line iteration
                    ingredientArray[i] = "~" + rtxtIngredients.Lines[i];
                }

                // Join the ingredient array with "\n" between each count
                string formattedIngredients = string.Join("\n", ingredientArray);

                // Write to the file, the new formatted ingredient list
                File.WriteAllText(RecipeFilePath, formattedIngredients);
            }
            else MessageBox.Show(msg, caption);


            

            /* Code Features */

            //string example = $"Name:{txtRecipeName.Text}\n" +
            //                 $"Description:{rtxtDescription.Text}\n" +
            //                 $"Ingredients:1/4_tsp-Black_Pepper|1_tbsp-Olive_Oil" + //This is an example of how ingredients will be displayed in the file
            //                 $"Directions: {rtxtDirections.Text}";

            // Construct a string to be saved to the file
            // Save contents of text boxes to recipe file
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            GenerateRecipePath();

            // Check if the file exists
            if (File.Exists(RecipeFilePath))
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
                    File.Delete(RecipeFilePath);

                    // Remove CurrentRecipe from the listbox
                    lbRecipeList.Items.Remove(CurrentRecipe);

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

            // Clear CurrentRecipe variable
            CurrentRecipe = "";

            // Set CurrentRecipe variable to the selected item in the listbox as a string
            CurrentRecipe = lbRecipeList.SelectedItem.ToString();


            /* Code Features */

            // Load respective recipe file contents into text boxes

        }

        // This event handler is attached to the ingredients and direction richtextboxes
        private void rtxt_KeyDown(object sender, KeyEventArgs e)
        {
            // Set the sender to a RichTextBox
            RichTextBox richTextBox = (RichTextBox)sender;

            // If the user presses "control b"
            if (e.Control && e.KeyCode == Keys.B)
            {
                // Bullet tne selected line
                richTextBox.SelectionBullet = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}

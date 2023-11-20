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
using System.Runtime.Remoting.Messaging;

namespace RecipeManager
{
    public partial class frmRecipeManager : Form
    {
        /* 
           Idea - Sara Walker
           Design - Sara Walker 
           Implementation - Sara Walker, Aaron White, Dominiq Holder
           Testing - Sara Walker, Aaron White, Dominiq Holder
        */

        // Global string of where the user's files are kept, this is usually in the %APPDATA% (C:/Users/<user>/AppData/Roaming) - Sara Walker  (EXTRA)
        public string UserRecipesPath = Application.UserAppDataPath;

        // Global RecipeFilePath string to be used when needed to access the current recipe file - Sara Walker
        public string RecipeFilePath;

        // Global CurrentRecipe string to be used when constructing the RecipeFilePath - Sara Walker
        public string CurrentRecipe = "";

        public frmRecipeManager()
        {
            InitializeComponent();

            // Set the first line of both the ingredients and the directions to bulleted - Sara Walker
            rtxtIngredients.SelectionBullet = true;
            rtxtDirections.SelectionBullet = true;
        }

        private void LoadFiles()
        {
            // Iterate through each file in the directory - Sara Walker
            foreach (string recipeFile in Directory.GetFiles(UserRecipesPath))
            {
                // Construct an array of the file path split at each `\`, use escape character to reach - Sara Walker
                string[] recipeFileArray = recipeFile.Split('\\');

                // Construct a string using the last index in the array and replacing dashes with spaces and removing the `.recipe` - Sara Walker
                string recipeFileString = recipeFileArray[recipeFileArray.Length - 1].Replace("-", " ").Replace(".recipe", "");

                // Add recipeFileString to the listbox - Sara Walker
                lbRecipeList.Items.Add(recipeFileString);
            }
        }

        // Method to generate a recipe path when needed - Sara Walker
        // Assigning RecipeFilePath to hold CurrentRecipe file name, and files end with `.recipe` - Sara Walker
        private void GenerateRecipePath() => RecipeFilePath = $"{UserRecipesPath}\\{CurrentRecipe.Replace(" ", "-")}.recipe";

        private void ClearContentBoxes()
        {
            // Clear text in the name and decription boxes and reset count on the ingredients and directions boxes - Sara Walker
            txtRecipeName.Text = "";
            rtxtDescription.Text = "";
            rtxtIngredients.Text = "";
            rtxtDirections.Text = "";
        }

        private string[] ArrayBuilder(RichTextBox richTextBox)
        {
            // Construct an array that is the size of the current number of lines in the richtextbox - Sara Walker
            string[] array = new string[richTextBox.Lines.Length];

            // For loop that iterates through each line in the richtextbox - Sara Walker
            for (int i = 0; i < richTextBox.Lines.Length; i++)
            {
                // Get the first character of the current line iteration - Sara Walker
                int currentLineStart = richTextBox.GetFirstCharIndexFromLine(i);

                // Set the cursor to the current line iteration - Sara Walker
                richTextBox.SelectionStart = currentLineStart;

                // If the line does not have a bullet point, place a bullet point - Sara Walker
                if (!richTextBox.SelectionBullet)
                {
                    richTextBox.SelectionBullet = true;
                }

                // Place a "~" in front of the current line iteration - Sara Walker
                array[i] = "~" + richTextBox.Lines[i];
            }

            return array;
        }

        // Method to contruct the string of file contents - Sara Walker
        private string BuildContentString()
        {
            // Construct a string for the name - Aaron White
            string nameString = $"Name:\n{txtRecipeName.Text}\n";

            // Construct a string for the description - Aaron White
            string descriptionString = $"Description:\n{rtxtDescription.Text}\n";

            // Construct a string for the ingredients using ArrayBuilder and Join methods - Sara Walker
            string formattedIngredients = "Ingredients:\n" + string.Join("\n", ArrayBuilder(rtxtIngredients)) + "\n";

            // Construct a string for the directions using ArrayBuilder and Join methods - Sara Walker
            string formattedDirections = "Directions:\n" + string.Join("\n", ArrayBuilder(rtxtDirections));

            // Return all strings combined together with a newline to separate them - Sara Walker
            return $"{nameString}\n{descriptionString}\n{formattedIngredients}\n{formattedDirections}";
        }

        private string IsPresent(Control control, string name)
        {
            // Check if control is empty - Dominiq Holder
            string message = "";
            if (control.Text == "")
            {
                // Show a pop-up message indicating that the control is empty - Dominiq Holder
                message += name + " is a required field.\n";
          
            }

            return message;
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";
            errorMessage += IsPresent(txtRecipeName, txtRecipeName.Tag.ToString());
            errorMessage += IsPresent(rtxtDescription, rtxtDescription.Tag.ToString());
            errorMessage += IsPresent(rtxtIngredients, rtxtIngredients.Tag.ToString());
            errorMessage += IsPresent(rtxtDirections, rtxtDirections.Tag.ToString());
            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            // Add additional checks for other controls if needed - Dominiq Holder

            return success; // If all checks pass, return true - Dominiq Holder
        }

        private void frmRecipeManager_Load(object sender, EventArgs e)
        {
            // This is where we load any existing files on startup - Sara Walker
            LoadFiles();
        }

        // Call ClearContentBoxes when creating a new recipe - Sara Walker
        private void tsmiCreateNew_Click(object sender, EventArgs e)
        {
            
          
                // Strings to display in the message box - Dominiq Holder
                string msg2 = "Are you sure you would like to create a new recipe?";
                string caption = "Create New Recipe";

                // Yes or no buttons - Dominiq Holder
                MessageBoxButtons clearButtons = MessageBoxButtons.YesNo;

                // Get result from the message box - Dominiq Holder
                DialogResult clearResult = MessageBox.Show(msg2, caption, clearButtons);

                // Handle the result accordingly - Dominiq Holder
                if (clearResult == DialogResult.Yes)
                {
                    // Clear content boxes - Dominiq Holder
                    ClearContentBoxes();
                }
                else if (clearResult == DialogResult.Cancel)
                {
                    // Cancel the save operation - Dominiq Holder
                    return;
                }
            
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            // Clear CurrentRecipe variable (if needed) - Sara Walker
            CurrentRecipe = "";

            // Strings to display in the message box - Sara Walker
            

            // If there is text in the text box - Sara Walker
            if (IsValidData())
            {
                // Set CurrentRecipe variable to text in recipe name textbox - Sara Walker
                CurrentRecipe = txtRecipeName.Text;

                // Call GenerateRecipePath to have RecipeFilePath hold CurrentRecipe - Sara Walker
                GenerateRecipePath();

                // Check if the file exists - Aaron White
                if (File.Exists(RecipeFilePath))
                {
                    // Strings to display in the message box - Aaron White
                    string msg2 = "Would you like to rewrite file?";
                    string caption2 = "File exists";

                    // Yes or no buttons - Aaron White
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                    // Get result from the message box - Aaron White
                    DialogResult result = MessageBox.Show(msg2, caption2, buttons);

                    // If the result equals yes - Aaron White
                    if (result == DialogResult.Yes)
                    {
                        // Write to the file, the new formatted ingredient list - Sara Walker
                        File.WriteAllText(RecipeFilePath, BuildContentString());
                    }
                }
                else
                {
                    // Add recipe name to the listbox - Sara Walker
                    lbRecipeList.Items.Add(txtRecipeName.Text);

                    // Write to the file, the new formatted ingredient list - Sara Walker
                    File.WriteAllText(RecipeFilePath, BuildContentString());
                }
            }
           
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            // Call GenerateRecipePath to have RecipeFilePath hold CurrentRecipe (from SelectedValueChange) - Sara Walker
            GenerateRecipePath();

            // Check if the file exists - Sara Walker
            if (File.Exists(RecipeFilePath))
            {
                // Strings to display in the message box - Sara Walker
                string msg = "Are you sure you would like to delete this recipe?";
                string caption = "Delete Recipe";

                // Yes or no buttons - Sara Walker
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                // Get result from the message box - Sara Walker
                DialogResult result = MessageBox.Show(msg, caption, buttons);

                // If the result equals yes, clear the contents, delete the file, and remove the recipe name from listbox - Sara Walker
                if (result == DialogResult.Yes)
                {
                    ClearContentBoxes();

                    // Delete file - Sara Walker
                    File.Delete(RecipeFilePath);

                    // Remove CurrentRecipe from the listbox - Sara Walker
                    lbRecipeList.Items.Remove(CurrentRecipe);

                    // Set selected item to null - Sara Walker
                    lbRecipeList.SelectedItem = null;
                }
            }
            // If the file does not exist, display an error message - Sara Walker
            else
            {
                MessageBox.Show("File not found", "Error");
            }
        }

        private void tsmiHelp_Click(object sender, EventArgs e)
        {
            // Show frmHelp when clicked apply frmRecipeManager to the parameter - Sara Walker (EXTRA)
            frmHelp frmHelp = new frmHelp(this);
            frmHelp.Show();
        }

        private void txt_Leave(object sender, EventArgs e)
        {

        }


        private void lbRecipeList_SelectedValueChanged(object sender, EventArgs e)
        {
            // Guard clause for if the selected item in the list box is null, do nothing - Dominiq Holder
            if (lbRecipeList.SelectedItem == null) return;

            // Clear CurrentRecipe variable - Dominiq Holder
            CurrentRecipe = "";

            // Set CurrentRecipe variable to the selected item in the listbox as a string - Dominiq Holder
            CurrentRecipe = lbRecipeList.SelectedItem.ToString();

            GenerateRecipePath();

            string[] lines = File.ReadAllLines(RecipeFilePath);

            txtRecipeName.Text = lines[1];
            rtxtDescription.Text = lines[4];

            // Concatenate all lines from line 7 to the end of the document into a string array
            string[] recipeIngredientsDirections = lines.Skip(7).ToArray();
            string ingredientsDirectionsTwo = string.Join("", recipeIngredientsDirections);
            string[] ingredientsDirectionsArray = ingredientsDirectionsTwo.Split(':');

            string ingredientsString = ingredientsDirectionsArray[0].Remove(ingredientsDirectionsArray[0].Length - 10, 10);
            string directionsString = ingredientsDirectionsArray[1];
            string[] ingredientArray = ingredientsString.Split('~');
            string[] directionsArray = directionsString.Split('~');
            Console.WriteLine(ingredientsString);
            Console.WriteLine(directionsString);

            foreach (string element in ingredientArray)
            {
                Console.WriteLine(element);
            }
            foreach (string element in directionsArray)
            {
                Console.WriteLine(element);
            }
            /* Code Features */

            // Load respective recipe file contents into text boxes
        }
        // This event handler is attached to the ingredients and direction richtextboxes - Sara Walker (EXTRA)
        private void rtxt_KeyDown(object sender, KeyEventArgs e)
        {
            // Set the sender to a RichTextBox - Sara Walker
            RichTextBox richTextBox = (RichTextBox)sender;

            // If the user presses "control b" - Sara Walker
            if (e.Control && e.KeyCode == Keys.B)
            {
                // Bullet tne selected line - Sara Walker
                richTextBox.SelectionBullet = true;
            }
        }
        // Close form when pressing escape - Sara Walker
        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Text = numericUpDown1.Value.ToString() + "Days";
        }
    }
}

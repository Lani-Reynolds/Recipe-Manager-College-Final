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
using System.Xml.Linq;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.LinkLabel;

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

        // Global string of where the user's files are kept, this is usually in the %APPDATA% (C:/Users/<user>/AppData/Roaming) - Sara Walker (EXTRA)
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

        // Method to load file names into the listbox - Sara Walker
        private void LoadFiles()
        {
            // Iterate through each file in the directory - Sara Walker
            foreach (string recipeFile in Directory.GetFiles(UserRecipesPath))
            {
                // Construct an array of the file path split at each `\` - Sara Walker
                string[] recipeFileArray = recipeFile.Split('\\');

                // Construct a string from the last element of the array and reformatting it to be displayed - Sara Walker
                string recipeFileString = recipeFileArray[recipeFileArray.Length - 1].Replace("-", " ").Replace(".recipe", "");

                // Add recipeFileString to the listbox - Sara Walker
                lbRecipeList.Items.Add(recipeFileString);
            }
        }

        // Method to generate a recipe path when needed - Sara Walker
        // Assigning RecipeFilePath to hold CurrentRecipe file name, and files end with `.recipe` - Sara Walker
        private void GenerateRecipePath() => RecipeFilePath = $"{UserRecipesPath}\\{CurrentRecipe.Replace(" ", "-")}.recipe";

        // Method to clear the controls in a GroupBox - Sara Walker
        private void ClearGroupBoxes(GroupBox groupBox)
        {
            // Loop through all the controls in the GroupBox - Sara Walker
            foreach (Control control in groupBox.Controls)
            {
                control.Text = "0";
            }
        }

        // Method to clear all the controls in the form - Sara Walker
        private void ClearContentBoxes()
        {
            // Clear text in the name, decription, ingredients and directions boxes and reset count on the prep and cook time - Sara Walker
            txtRecipeName.Text = "";
            ClearGroupBoxes(gbxPrepTime);
            ClearGroupBoxes(gbxCookTime);
            rtxtDescription.Text = "";
            rtxtIngredients.Text = "";
            rtxtDirections.Text = "";
        }

        // Method to build an array to be saved in the file - Sara Walker
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

            // Construct a sting for the time - Sara Walker
            string timeString = $"Time:\n{nudPrepTimeDays.Value}:{nudPrepTimeHours.Value}:{nudPrepTimeMinutes.Value}~{nudCookTimeDays.Value}:{nudCookTimeHours.Value}:{nudCookTimeMinutes.Value}\n";

            // Construct a string for the description - Aaron White
            string descriptionString = $"Description:\n{rtxtDescription.Text}\n";

            // Construct a string for the ingredients using ArrayBuilder and Join methods - Sara Walker
            string formattedIngredients = "Ingredients:\n" + string.Join("\n", ArrayBuilder(rtxtIngredients)) + "\n";

            // Construct a string for the directions using ArrayBuilder and Join methods - Sara Walker
            string formattedDirections = "Directions:\n" + string.Join("\n", ArrayBuilder(rtxtDirections));

            // Return all strings combined together with a newline to separate them - Sara Walker
            return $"{nameString}\n{timeString}\n{descriptionString}\n{formattedIngredients}\n{formattedDirections}";
        }

        // Method to iterate through an array and load contents - Sara Walker
        private void InsertContents(string[] contents, RichTextBox richTextBox)
        {
            // Loop through the contents of the string array that is being passed in the parameter - Sara Walker
            for (int index = 0; index < contents.Length; index++)
            {
                // Check if we are indexing into the last element of the array - Sara Walker
                if (index == (contents.Length - 1))
                {
                    // Add element to the richTextBox that is being passed in the parameter - Sara Walker
                    richTextBox.Text += contents[index];
                    break;
                }
                // Check if the element is not empty - Sara Walker
                if (contents[index] != "")
                {
                    // Add element to the richTextBox that is being passed in the parameter with a newline at the end - Sara Walker
                    richTextBox.Text += contents[index] + "\n";
                }
            }
        }

        // Method to validate if text is present in the textbox and richtextboxes - Dominiq Holder
        private string IsPresent(Control control, string name)
        {
            // Initialize message as an empty string - Dominiq Holder
            string message = "";

            // Check if control is empty - Dominiq Holder
            if (control.Text == "")
            {
                // Message to show indicating that the control is empty - Dominiq Holder
                message += name + " is a required field.\n";
            }
            return message;
        }

        // Method to validate if the NumericUpDowns have a value change - Sara Walker
        private bool TimeIsPresent(GroupBox groupBox)
        {
            // Initialize success bool as true - Sara Walker
            bool success = true;

            // Initialze total time as 0 - Sara Walker
            int totalTime = 0;

            // Loop through all the controls in the GroupBox - Sara Walker
            foreach (Control item in groupBox.Controls)
            {
                // Add the value of the NumericUpDown to the totalTime - Sara Walker
                NumericUpDown caughtControl = (NumericUpDown)item;
                totalTime += Convert.ToInt32(caughtControl.Value);
            }
            // Check if total time equals 0, and if it does, time is not present - Sara Walker
            if (totalTime == 0)
            {
                success = false;
                return success;
            }
            return success;

        }

        // Method to check all validations - Dominiq Holder
        private bool IsValidData()
        {
            // Iniliaize success bool as true - Dominiq Holder
            bool success = true;

            // Initialize errorMessage as an empty string - Dominiq Holder
            string errorMessage = "";

            // Use validation check on all of the required field - Dominiq Holder
            errorMessage += IsPresent(txtRecipeName, txtRecipeName.Tag.ToString());

            if (!TimeIsPresent(gbxPrepTime))
            {
                errorMessage += "Prep time is a required field\n";
            }
            if (!TimeIsPresent(gbxCookTime))
            {
                errorMessage += "Cook time is a required field\n";
            }

            errorMessage += IsPresent(rtxtDescription, rtxtDescription.Tag.ToString());
            errorMessage += IsPresent(rtxtIngredients, rtxtIngredients.Tag.ToString());
            errorMessage += IsPresent(rtxtDirections, rtxtDirections.Tag.ToString());

            // Check if the errorMessage is not empty - Dominiq Holder
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

        private void nud_ValueChange(object sender, EventArgs e)
        {
            // Get the total minutes, hours and days from the NumericUpDown in the form - Sara Walker
            int totalMinutes = Convert.ToInt32(nudPrepTimeMinutes.Value) + Convert.ToInt32(nudCookTimeMinutes.Value);
            int totalHours = Convert.ToInt32(nudPrepTimeHours.Value) + Convert.ToInt32(nudCookTimeHours.Value);
            int totalDays = Convert.ToInt32(nudPrepTimeDays.Value) + Convert.ToInt32(nudCookTimeDays.Value);
            
            // Use TimeSpan to get the total time - Sara Walker
            TimeSpan totalTime = new TimeSpan(totalDays, totalHours, totalMinutes, 0);

            // Display the total time in the total time textbox - Sara Walker
            txtTotalTime.Text = $"{totalTime.Days}:{totalTime.Hours}:{totalTime.Minutes}";
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            // Clear CurrentRecipe variable (if needed) - Sara Walker
            CurrentRecipe = "";

            // Check if the data is valid - Sara Walker
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
            // Show Help MessageBox when clicked - Sara Walker/Dominiq Holder (EXTRA)
            MessageBox.Show("Helpful Tips:\n\nWhen you select \"Create New\" you can create a new recipe. " +
                            "When you select \"Save\", it will save your recipe. " +
                            "When you select \"Delete\" the recipe will be deleted from your computer." +
                            "\n\nThe prep time and cook time are in days, hours, and minutes." +
                            "\n\nIf you accidentally delete a bullet point in the instructions" +
                            " or directions, just press \"CTRL + B\" to add a bullet point!", "Help");
        }

        // This event handler will load the file contents into their respective areas when you select a file from the listbox - Sara Walker/Donimiq Holder
        private void lbRecipeList_SelectedValueChanged(object sender, EventArgs e)
        {
            // Guard clause for if the selected item in the list box is null, do nothing - Dominiq Holder
            if (lbRecipeList.SelectedItem == null) return;

            // Clear the content boxes before repopulating them - Sara Walker
            ClearContentBoxes();

            // Clear CurrentRecipe variable - Dominiq Holder
            CurrentRecipe = "";

            // Set CurrentRecipe variable to the selected item in the listbox as a string - Dominiq Holder
            CurrentRecipe = lbRecipeList.SelectedItem.ToString();

            // Call GenerateRecipePath method - Sara Walker/Dominiq Holder
            GenerateRecipePath();

            // Construct an array of all the lines in the file - Sara Walker/Dominiq Holder
            string[] lines = File.ReadAllLines(RecipeFilePath);

            // Set the Name textbox to the 2nd element in the lines array - Sara Wallker/Dominiq Holder
            txtRecipeName.Text = lines[1];

            // Get the times from the 5th element in the lines array and split at the `~` - Sara Walker
            string[] times = lines[4].Split('~');

            // Get the days, hours, and minutes by splitting at the `:` - Sara Walker
            string[] prepTime = times[0].Split(':');
            string[] cookTime = times[1].Split(':');
            
            // Iterate through each GroupBox to place the time back into prep and cook time - Sara Walker
            for (int index = 0; index < gbxPrepTime.Controls.Count; index++)
            {
                NumericUpDown control = (NumericUpDown)gbxPrepTime.Controls[index];
                control.Value = Convert.ToDecimal(prepTime[index]);
            }
            for (int index = 0; index < gbxCookTime.Controls.Count; index++)
            {
                NumericUpDown control = (NumericUpDown)gbxCookTime.Controls[index];
                control.Value = Convert.ToDecimal(cookTime[index]);
            }

            // Set the Description textbox to the 8th element in the lines array - Sara Walker/Dominiq Holder
            rtxtDescription.Text = lines[7];

            // Construct a to hold the ingredients and directions - Sara Walker/Dominiq Holder
            List<string> ingredientsDirectionsList = new List<string>();


            // Skip to the 11th element in the lines array and loop through remaning elements - Sara Walker/Dominiq Holder
            foreach (string line in lines.Skip(10))
            {
                // Check if the element holds the string `Directions:` - Sara Walker/Dominiq Holder
                if (line == "Directions:")
                {
                    // Replace `Directions:` with an `*` and add element to the recipeIngredientsDirections list - Sara Walker/Dominiq Holder
                    ingredientsDirectionsList.Add(line.Replace("Directions:", "*"));
                }
                else
                {
                    // Add element to the recipeIngredientsDirections list - Sara Walker/Dominiq Holder
                    ingredientsDirectionsList.Add(line);
                }
            }

            // Construct an array of the ingredients and directions by joining the ingredientsDirectionsList and splitting at the `*` - Dominiq Holder
            string[] ingredientsDirectionsArray = string.Join("", ingredientsDirectionsList).Split('*');
            
            // Construct two strings to hold the ingredients and directions seperatly - Dominiq Holder
            string ingredientsString = ingredientsDirectionsArray[0];
            string directionsString = ingredientsDirectionsArray[1];

            // Contruct two array of the ingredients and directions that are split at the `~` - Dominiq Holder
            string[] ingredientArray = ingredientsString.Split('~');
            string[] directionsArray = directionsString.Split('~');

            // Call the InsertContents method for both ingredients and directions arrays - Sara Walker
            InsertContents(ingredientArray, rtxtIngredients);
            InsertContents(directionsArray, rtxtDirections);

        }

        // This event handler is attached to the ingredients and direction richtextboxes - Sara Walker (EXTRA)
        // This is a key down event handler to add a bullet point when the user presses 'CTRL + B' - Sara Walker
        private void rtxt_KeyDown(object sender, KeyEventArgs e)
        {
            RichTextBox richTextBox = (RichTextBox)sender;

            if (e.Control && e.KeyCode == Keys.B)
            {
                richTextBox.SelectionBullet = true;
            }
        }

        // Close form when pressing escape - Sara Walker
        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}

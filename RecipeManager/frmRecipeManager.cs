using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RecipeManager
{
    public partial class frmRecipeManager : Form
    {
        public string UserRecipesPath = Application.UserAppDataPath;
        public string RecipeFilePath;
        public string CurrentRecipe = "";

        public frmRecipeManager()
        {
            InitializeComponent();
            rtxtIngredients.SelectionBullet = true;
            rtxtDirections.SelectionBullet = true;
            KeyPreview = true;
        }
        private void LoadFiles()
        {
            foreach (string recipeFile in Directory.GetFiles(UserRecipesPath))
            {
                string[] recipeFileArray = recipeFile.Split('\\');
                string recipeFileString = recipeFileArray[recipeFileArray.Length - 1].Replace("-", " ").Replace(".recipe", "");

                lbRecipeList.Items.Add(recipeFileString);
            }
        }

        private void GenerateRecipePath() => RecipeFilePath = $"{UserRecipesPath}\\{CurrentRecipe.Replace(" ", "-")}.recipe";

        private void ClearGroupBoxes(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                control.Text = "0";
            }
        }

        private void ClearContentBoxes()
        {
            txtRecipeName.Text = "";
            ClearGroupBoxes(gbxPrepTime);
            ClearGroupBoxes(gbxCookTime);
            rtxtDescription.Text = "";
            rtxtIngredients.Text = "";
            rtxtDirections.Text = "";
        }

        private string[] ArrayBuilder(RichTextBox richTextBox)
        {
            string[] array = new string[richTextBox.Lines.Length];

            for (int i = 0; i < richTextBox.Lines.Length; i++)
            {
                int currentLineStart = richTextBox.GetFirstCharIndexFromLine(i);

                richTextBox.SelectionStart = currentLineStart;

                if (!richTextBox.SelectionBullet)
                {
                    richTextBox.SelectionBullet = true;
                }

                array[i] = "~" + richTextBox.Lines[i];
            }
            return array;
        }

        private string BuildContentString()
        {
            string nameString = $"Name:\n{txtRecipeName.Text}\n";

            string timeString = $"Time:\n{PrepDays.Text}:{PrepHours.Text}:{PrepMinutes.Text}~{CookDays}:{CookHours}:{CookMinutes}\n";

            string descriptionString = $"Description:\n{rtxtDescription.Text}\n";

            string formattedIngredients = "Ingredients:\n" + string.Join("\n", ArrayBuilder(rtxtIngredients)) + "\n";

            string formattedDirections = "Directions:\n" + string.Join("\n", ArrayBuilder(rtxtDirections));

            return $"{nameString}\n{timeString}\n{descriptionString}\n{formattedIngredients}\n{formattedDirections}";
        }

        private void InsertContents(string[] contents, RichTextBox richTextBox)
        {
            for (int index = 0; index < contents.Length; index++)
            {
                if (index == (contents.Length - 1))
                {
                    richTextBox.Text += contents[index];
                    break;
                }
                if (contents[index] != "")
                {
                    richTextBox.Text += contents[index] + "\n";
                }
            }
        }

        private string IsPresent(Control control, string name)
        {
            string message = "";

            if (control.Text == "")
            {
                message += name + " is a required field.\n";
            }
            return message;
        }

        private bool TimeIsPresent(GroupBox groupBox)
        {
            bool success = true;

            int totalTime = 0;

            foreach (Control item in groupBox.Controls)
            {
                NumericUpDown caughtControl = (NumericUpDown)item;
                totalTime += Convert.ToInt32(caughtControl.Value);
            }
            if (totalTime == 0)
            {
                success = false;
                return success;
            }
            return success;
        }

        private bool IsValidData()
        {
            bool success = true;

            string errorMessage = "";

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

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void frmRecipeManager_Load(object sender, EventArgs e)
        {
            LoadFiles();
        }

        private void tsmiCreateNew_Click(object sender, EventArgs e)
        {
            string msg2 = "Are you sure you would like to create a new recipe?";
            string caption = "Create New Recipe";

            MessageBoxButtons clearButtons = MessageBoxButtons.YesNo;

            DialogResult clearResult = MessageBox.Show(msg2, caption, clearButtons);

            if (clearResult == DialogResult.Yes)
            {
                ClearContentBoxes();
                CurrentRecipe = "";
                lbRecipeList.SelectedItem = null;
            }
            else if (clearResult == DialogResult.Cancel)
            {
                return;
            }
        }

        private void nud_ValueChange(object sender, EventArgs e)
        {
            //int totalMinutes = Convert.ToInt32(nudPrepTimeMinutes.Value) + Convert.ToInt32(nudCookTimeMinutes.Value);
            //int totalHours = Convert.ToInt32(nudPrepTimeHours.Value) + Convert.ToInt32(nudCookTimeHours.Value);
            //int totalDays = Convert.ToInt32(nudPrepTimeDays.Value) + Convert.ToInt32(nudCookTimeDays.Value);

            //TimeSpan totalTime = new TimeSpan(totalDays, totalHours, totalMinutes, 0);

            //TotalTime.Text = $"{totalTime.Days}:{totalTime.Hours}:{totalTime.Minutes}";
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            CurrentRecipe = "";

            if (IsValidData())
            {
                CurrentRecipe = txtRecipeName.Text;

                GenerateRecipePath();

                if (File.Exists(RecipeFilePath))
                {
                    string msg2 = "Would you like to rewrite the recipe?";
                    string caption2 = "Recipe exists";

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                    DialogResult result = MessageBox.Show(msg2, caption2, buttons);

                    if (result == DialogResult.Yes)
                    {
                        File.WriteAllText(RecipeFilePath, BuildContentString());
                    }
                }
                else
                {
                    lbRecipeList.Items.Add(txtRecipeName.Text);

                    File.WriteAllText(RecipeFilePath, BuildContentString());
                }
            }
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            GenerateRecipePath();

            if (File.Exists(RecipeFilePath))
            {
                string msg = "Are you sure you would like to delete this recipe?";
                string caption = "Delete Recipe";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                DialogResult result = MessageBox.Show(msg, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    ClearContentBoxes();

                    File.Delete(RecipeFilePath);

                    lbRecipeList.Items.Remove(CurrentRecipe);

                    lbRecipeList.SelectedItem = null;
                }
            }
            else
            {
                MessageBox.Show("Recipe not found", "Error");
            }
        }

        private void tsmiHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Helpful Tips:\n\nWhen you select \"Create New\" you can create a new recipe. " +
                "When you select \"Save\", it will save your recipe. " +
                "When you select \"Delete\" the recipe will be deleted from your computer." +
                "\n\nThe prep time and cook time are in days, hours, and minutes." +
                "\n\nIf you accidentally delete a bullet point in the instructions" +
                " or directions, just press \"CTRL + B\" to add a bullet point!", "Help");
        }

        private void lbRecipeList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbRecipeList.SelectedItem == null) return;

            ClearContentBoxes();

            CurrentRecipe = "";

            CurrentRecipe = lbRecipeList.SelectedItem.ToString();

            GenerateRecipePath();

            string[] lines = File.ReadAllLines(RecipeFilePath);

            txtRecipeName.Text = lines[1];

            string[] times = lines[4].Split('~');

            string[] prepTime = times[0].Split(':');
            string[] cookTime = times[1].Split(':');

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

            rtxtDescription.Text = lines[7];

            List<string> ingredientsDirectionsList = new List<string>();


            foreach (string line in lines.Skip(10))
            {
                if (line == "Directions:")
                {
                    ingredientsDirectionsList.Add(line.Replace("Directions:", "*"));
                }
                else
                {
                    ingredientsDirectionsList.Add(line);
                }
            }

            string[] ingredientsDirectionsArray = string.Join("", ingredientsDirectionsList).Split('*');

            string ingredientsString = ingredientsDirectionsArray[0];
            string directionsString = ingredientsDirectionsArray[1];

            string[] ingredientArray = ingredientsString.Split('~');
            string[] directionsArray = directionsString.Split('~');

            InsertContents(ingredientArray, rtxtIngredients);
            InsertContents(directionsArray, rtxtDirections);

        }

        private void rtxt_KeyDown(object sender, KeyEventArgs e)
        {
            RichTextBox richTextBox = (RichTextBox)sender;

            if (e.Control && e.KeyCode == Keys.B)
            {
                richTextBox.SelectionBullet = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void frmRecipeManager_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the pressed key is Escape
            if (e.KeyCode == Keys.Escape)
            {
                // Close the form
                this.Close();
            }
        }

        private void IncrementTime(Label Label)
        {
            int.TryParse(Label.Text.Split(' ')[0], out int Value);
            Value++;
            Label.Text = Value.ToString() + $" {Label.Tag}";
            ActiveControl = Label;
        }
        private void DecrementTime(Label Label)
        {
            int.TryParse(Label.Text.Split(' ')[0], out int Value);
            Value--;
            Label.Text = Value.ToString() + $" {Label.Tag}";
            ActiveControl = Label;
        }

        private void Time_KeyDown(object sender, KeyEventArgs e)
        {
            Label Label = (Label)sender;
            if (e.KeyCode == Keys.Up)
            {
                IncrementTime(Label);
            }
            if (e.KeyCode == Keys.Down)
            {
                DecrementTime(Label);
            }
        }
        private void Time_MouseClick(object sender, MouseEventArgs e)
        {
            Label Label = (Label)sender;

            if (e.Button == MouseButtons.Left)
            {
                IncrementTime(Label);
            }
            if (e.Button == MouseButtons.Right)
            {
                DecrementTime(Label);
            }
        }
    }
}

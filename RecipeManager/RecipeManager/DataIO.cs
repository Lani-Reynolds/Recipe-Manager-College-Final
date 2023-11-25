using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RecipeManager
{
    public partial class Toolbox
    {
        public string RecipeFilePath;
        public string UserRecipesPath = Application.UserAppDataPath;
        public void Load_Files(ref ListBox RecipeList)
        {
            foreach (string RecipeFile in Directory.GetFiles(UserRecipesPath))
            {
                string RecipeFileString = Path.GetRelativePath(UserRecipesPath, RecipeFile).Replace("-", " ").Replace(".recipe", "");

                RecipeList.Items.Add(RecipeFileString);
            }
        }

        public string[] Load_File(string CurrentRecipe)
        {
            RecipeFilePath = $"{UserRecipesPath}\\{CurrentRecipe.Replace(" ", "-")}.recipe";

            return File.ReadAllLines(RecipeFilePath);
        }
        public string Build_File_Formatted_String(MainForm RM)
        {
            string NameString = $":RecipeName\n{RM.RecipeName.Text}";

            string DescriptionString = $":RecipeDescription\n{RM.RecipeDescription.Text}";

            string FormattedIngredients = ":RecipeIngredients\n" + string.Join("~", RM.RecipeIngredients.Text);

            string FormattedDirections = ":RecipeDirections\n" + string.Join("~", RM.RecipeDirections.Text);

            return $"{NameString}\n{DescriptionString}\n{FormattedIngredients}\n{FormattedDirections}";
        }

        public string Save_Recipe(string RecipeName, MainForm RM)
        {
            if (File.Exists(RecipeFilePath))
            {
                DialogResult Result = Send_Message_Box("Would you like to rewrite the recipe?",
                                                                     "Recipe exists",
                                                                     MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    RecipeFilePath = $"{UserRecipesPath}\\{RM.CurrentRecipe.Replace(" ", "-")}.recipe";
                    File.WriteAllText(RecipeFilePath, Build_File_Formatted_String(RM));
                    return "Old";
                }
            }
            else
            {
                RecipeFilePath = $"{UserRecipesPath}\\{RecipeName.Replace(" ", "-")}.recipe";
                File.WriteAllText(RecipeFilePath, Build_File_Formatted_String(RM));
                return "New";
            }
            return "Failure";
        }

        public void Delete_Recipe(string CurrentRecipe, MainForm RecipeManager)
        {
            RecipeFilePath = $"{UserRecipesPath}\\{CurrentRecipe.Replace(" ", "-")}.recipe";
            if (File.Exists(RecipeFilePath))
            {
                DialogResult Result = Send_Message_Box("Are you sure you would like to delete this recipe?",
                                                                     "Delete Recipe",
                                                                     MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    File.Delete(RecipeFilePath);
                }
            }
            else
            {
                MessageBox.Show("Recipe not found", "Error");
            }
        }
    }
}

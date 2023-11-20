using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeManager
{
    public partial class frmHelp : Form
    {
        // Create a form with a parameter for the 'owner' - Sara Walker
        public frmHelp(Form Owner)
        {
            InitializeComponent();

            // Change the location to be next to frmRecipeManager - Sara Walker/Dominiq Holder
            int newX = Owner.Location.X + Owner.Width;
            Location = new Point(newX, Owner.Location.Y);
        }

        // Attached to each button
        private void btn_Click(object sender, EventArgs e)
        {
            // Get whatever button was pressed - Sara Walker/ Dominiq Holder 
            Button button = (Button)sender;

            // Set the text of the group box to the text of the button pressed - Sara Walker/Dominiq Holder
            gbxHelp.Text = button.Text;

            // Check which button has been pressed - Sara Walker/Dominiq Holder 
            if (button == btnControls)
            {
                rtxtHelp.Text = "";
                string controls = "If you click create new you can create a new recipe.If you save, it will save all your recipes. If you delete a recipe it will delete the recipe from your computer.";
          rtxtHelp.Text = controls;
            }
            else if (button == btnIngredientsFormat)
            {
                rtxtHelp.Text = "";
                string ingredientsFormat = "This will show a list of all ingredients that are required for what you're cooking.";
                rtxtHelp.Text = ingredientsFormat;
            }
           
            else if (button == btnDirectionsFormat)
            {
                rtxtHelp.Text = "";
                string directionsFormat = "This will describe what the food is, cook time and instructions for what you're cooking.";
                rtxtHelp.Text = directionsFormat;
            }
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

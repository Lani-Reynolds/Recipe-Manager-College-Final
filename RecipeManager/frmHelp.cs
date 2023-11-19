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

            // Change the location to be next to frmRecipeManager - Sara Walker
            int newX = Owner.Location.X + Owner.Width;
            Location = new Point(newX, Owner.Location.Y);
        }

        // Attached to each button
        private void btn_Click(object sender, EventArgs e)
        {
            // Get whatever button was pressed - Sara Walker
            Button button = (Button)sender;

            // Set the text of the group box to the text of the button pressed - Sara Walker
            gbxHelp.Text = button.Text;

            // Check which button has been pressed - Sara Walker
            if (button == btnControls)
            {
                Console.WriteLine("Write controls here");
            }
            else if (button == btnIngredientsFormat)
            {
                Console.WriteLine("Write ingredients format here");
            }
            else if (button == btnDirectionsFormat)
            {
                Console.WriteLine("Write directions format here");
            }
        }
    }
}

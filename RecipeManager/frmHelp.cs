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

    }
}

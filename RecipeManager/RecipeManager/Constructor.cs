﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace RecipeManager
{
    public partial class MainForm : Form
    {
        public string CurrentRecipe;
        public Toolbox Manager;

        public MainForm()
        {
            InitializeComponent();
            Manager = new Toolbox(this);
            Manager.Load_Files(ref RecipeList);
            RecipeIngredients.SelectionBullet = true;
            RecipeDirections.SelectionBullet = true;
            KeyPreview = true;
        }
        private void CreateNew_Click(object Sender, EventArgs E)
        {
            Manager.Clear_Content_Boxes();
            CurrentRecipe = "";
            RecipeList.SelectedItem = null;
        }
        private void Save_Click(object Sender, EventArgs E)
        {

            if (Manager.Is_Valid_Recipe())
            {
                if (Manager.Save_Recipe(RecipeName.Text, this) == "New")
                {
                    RecipeList.Items.Add(RecipeName.Text);
                }
            }
        }
        private void Delete_Click(object Sender, EventArgs E)
        {
            CurrentRecipe = RecipeList.SelectedItem.ToString();
            Manager.Delete_Recipe(CurrentRecipe, this);

            Manager.Clear_Content_Boxes();

            RecipeList.Items.Remove(CurrentRecipe);

            RecipeList.SelectedItem = null;
        }
        private void Help_Click(object Sender, EventArgs E)
        {
            MessageBox.Show("Helpful Tips:\n\nWhen you select \"Create New\" you can create a new recipe. " +
                            "When you select \"Save\", it will save your recipe. " +
                            "When you select \"Delete\" the recipe will be deleted from your computer." +
                            "\n\nThe prep time and cook time are in days, hours, and minutes." +
                            "\n\nIf you accidentally delete a bullet point in the instructions" +
                            " or directions, just press \"CTRL + B\" to add a bullet point!", "Help");
        }
        private void Time_MouseClick(object Sender, MouseEventArgs MouseEvent)
        {
            Label Label = (Label)Sender;

            if (MouseEvent.Button == MouseButtons.Left)
            {
                GroupBox LabelGroupBox = (GroupBox)Label.Parent;
                TextBox Input = new TextBox();

                Input.KeyDown += Input_Time_KeyDown;

                Point InputLocation = new Point(LabelGroupBox.Location.X + Label.Left, LabelGroupBox.Location.Y + Label.Bottom);

                Input.Location = InputLocation;
                Input.Size = new Size(30, 50);
                Input.Tag = Label.Name;

                Controls.Add(Input);

                Input.Focus();
                Input.BringToFront();
            }
        }
        private void RecipeList_SelectedValueChanged(object Sender, EventArgs Event)
        {
            if (RecipeList.SelectedItem == null) return;

            Manager.Clear_Content_Boxes();

            CurrentRecipe = RecipeList.SelectedItem.ToString();

            string[] Lines = Manager.Load_File(CurrentRecipe);

            string DataState;
            Control FoundControl = null;

            for (int Index = 0; Index < Lines.Length; Index++)
            {
                if (Lines[Index][0] == ':')
                {
                    DataState = Lines[Index].Substring(1);
                    FoundControl = Controls.Find(DataState, true)[0];
                }
                else if (Index == (Lines.Length - 1))
                {
                    FoundControl.Text += Lines[Index];
                }
                else
                {
                    FoundControl.Text += Lines[Index] + "\n";
                }
            }
            RecipeIngredients.Text = RecipeIngredients.Text.Substring(0, RecipeIngredients.Text.Length - 1);
        }
        private void RichText_KeyDown(object Sender, KeyEventArgs KeyEvent)
        {
            RichTextBox RichTextBox = (RichTextBox)Sender;

            if (KeyEvent.Control && KeyEvent.KeyCode == Keys.B)
            {
                RichTextBox.SelectionBullet = true;
            }
        }
        private void RecipeManager_KeyDown(object Sender, KeyEventArgs KeyEvent)
        {
            if (KeyEvent.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        private void Input_Time_KeyDown(object Sender, KeyEventArgs KeyEvent)
        {
            if (KeyEvent.KeyCode == Keys.Enter)
            {
                KeyEvent.SuppressKeyPress = true;

                TextBox Input = (TextBox)Sender;
                Label InputTimeLabel = (Label)Controls.Find(Input.Tag.ToString(), true)[0];
                GroupBox TimeGroupBox = (GroupBox)InputTimeLabel.Parent;

                InputTimeLabel.Text = $"{Input.Text} {InputTimeLabel.Tag}";

                Manager.Update_Times();

                Controls.Remove(Input);
            }
        }
        private void Time_Leave(object Sender, EventArgs E)
        {
            TextBox Control = (TextBox)Sender;
            Controls.Remove(Control);
        }
    }
    public partial class Toolbox
    {
        private MainForm MF;
        public Toolbox(MainForm MFPassed)
        {
            MF = MFPassed;
        }
    }
}
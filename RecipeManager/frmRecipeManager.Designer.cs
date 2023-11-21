namespace RecipeManager
{
    partial class frmRecipeManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipeManager));
            this.lbRecipeList = new System.Windows.Forms.ListBox();
            this.msOptions = new System.Windows.Forms.MenuStrip();
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxtDirections = new System.Windows.Forms.RichTextBox();
            this.lblDirections = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtxtIngredients = new System.Windows.Forms.RichTextBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TotalTime = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AuthorGroupBox = new System.Windows.Forms.GroupBox();
            this.Author = new System.Windows.Forms.TextBox();
            this.gbxPrepTime = new System.Windows.Forms.GroupBox();
            this.PrepMinutes = new System.Windows.Forms.Label();
            this.PrepHours = new System.Windows.Forms.Label();
            this.PrepDays = new System.Windows.Forms.Label();
            this.gbxCookTime = new System.Windows.Forms.GroupBox();
            this.CookMinutes = new System.Windows.Forms.Label();
            this.CookDays = new System.Windows.Forms.Label();
            this.CookHours = new System.Windows.Forms.Label();
            this.msOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.AuthorGroupBox.SuspendLayout();
            this.gbxPrepTime.SuspendLayout();
            this.gbxCookTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRecipeList
            // 
            this.lbRecipeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRecipeList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbRecipeList.FormattingEnabled = true;
            this.lbRecipeList.ItemHeight = 14;
            this.lbRecipeList.Location = new System.Drawing.Point(10, 41);
            this.lbRecipeList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbRecipeList.Name = "lbRecipeList";
            this.lbRecipeList.Size = new System.Drawing.Size(154, 648);
            this.lbRecipeList.TabIndex = 0;
            this.lbRecipeList.TabStop = false;
            this.lbRecipeList.SelectedValueChanged += new System.EventHandler(this.lbRecipeList_SelectedValueChanged);
            // 
            // msOptions
            // 
            this.msOptions.AutoSize = false;
            this.msOptions.BackColor = System.Drawing.Color.OldLace;
            this.msOptions.Dock = System.Windows.Forms.DockStyle.None;
            this.msOptions.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOptions});
            this.msOptions.Location = new System.Drawing.Point(10, 9);
            this.msOptions.Name = "msOptions";
            this.msOptions.Size = new System.Drawing.Size(70, 26);
            this.msOptions.TabIndex = 0;
            this.msOptions.Text = "menuStrip1";
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreateNew,
            this.tsmiSave,
            this.tsmiDelete,
            this.tsmiHelp});
            this.tsmiOptions.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(56, 22);
            this.tsmiOptions.Text = "Options";
            // 
            // tsmiCreateNew
            // 
            this.tsmiCreateNew.Name = "tsmiCreateNew";
            this.tsmiCreateNew.Size = new System.Drawing.Size(132, 22);
            this.tsmiCreateNew.Text = "Create New";
            this.tsmiCreateNew.Click += new System.EventHandler(this.tsmiCreateNew_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(132, 22);
            this.tsmiSave.Text = "Save";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(132, 22);
            this.tsmiDelete.Text = "Delete";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(132, 22);
            this.tsmiHelp.Text = "Help";
            this.tsmiHelp.Click += new System.EventHandler(this.tsmiHelp_Click);
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecipeName.Location = new System.Drawing.Point(4, 19);
            this.txtRecipeName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(462, 20);
            this.txtRecipeName.TabIndex = 1;
            this.txtRecipeName.Tag = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rtxtDirections);
            this.groupBox1.Controls.Add(this.lblDirections);
            this.groupBox1.Controls.Add(this.lblIngredients);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.rtxtIngredients);
            this.groupBox1.Controls.Add(this.rtxtDescription);
            this.groupBox1.Location = new System.Drawing.Point(181, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 581);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // rtxtDirections
            // 
            this.rtxtDirections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtDirections.Location = new System.Drawing.Point(95, 397);
            this.rtxtDirections.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rtxtDirections.Name = "rtxtDirections";
            this.rtxtDirections.Size = new System.Drawing.Size(600, 175);
            this.rtxtDirections.TabIndex = 17;
            this.rtxtDirections.Tag = "Directions";
            this.rtxtDirections.Text = "";
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Location = new System.Drawing.Point(33, 397);
            this.lblDirections.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(58, 14);
            this.lblDirections.TabIndex = 12;
            this.lblDirections.Text = "&Directions:";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(28, 208);
            this.lblIngredients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(63, 14);
            this.lblIngredients.TabIndex = 13;
            this.lblIngredients.Text = "&Ingredients:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(27, 19);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(64, 14);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "&Description:";
            // 
            // rtxtIngredients
            // 
            this.rtxtIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtIngredients.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtIngredients.Location = new System.Drawing.Point(95, 208);
            this.rtxtIngredients.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rtxtIngredients.Name = "rtxtIngredients";
            this.rtxtIngredients.Size = new System.Drawing.Size(600, 175);
            this.rtxtIngredients.TabIndex = 16;
            this.rtxtIngredients.Tag = "Ingredients";
            this.rtxtIngredients.Text = "";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtDescription.Location = new System.Drawing.Point(95, 19);
            this.rtxtDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(600, 175);
            this.rtxtDescription.TabIndex = 15;
            this.rtxtDescription.Tag = "Description";
            this.rtxtDescription.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TotalTime);
            this.groupBox2.Location = new System.Drawing.Point(775, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(101, 37);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total Time";
            // 
            // TotalTime
            // 
            this.TotalTime.AutoSize = true;
            this.TotalTime.Location = new System.Drawing.Point(6, 16);
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.Size = new System.Drawing.Size(0, 14);
            this.TotalTime.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRecipeName);
            this.groupBox3.Location = new System.Drawing.Point(181, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(471, 52);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Name";
            // 
            // AuthorGroupBox
            // 
            this.AuthorGroupBox.Controls.Add(this.Author);
            this.AuthorGroupBox.Location = new System.Drawing.Point(658, 9);
            this.AuthorGroupBox.Name = "AuthorGroupBox";
            this.AuthorGroupBox.Size = new System.Drawing.Size(214, 52);
            this.AuthorGroupBox.TabIndex = 16;
            this.AuthorGroupBox.TabStop = false;
            this.AuthorGroupBox.Text = "Author";
            // 
            // Author
            // 
            this.Author.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Author.Location = new System.Drawing.Point(4, 19);
            this.Author.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(205, 20);
            this.Author.TabIndex = 1;
            this.Author.Tag = "Name";
            // 
            // gbxPrepTime
            // 
            this.gbxPrepTime.Controls.Add(this.PrepMinutes);
            this.gbxPrepTime.Controls.Add(this.PrepHours);
            this.gbxPrepTime.Controls.Add(this.PrepDays);
            this.gbxPrepTime.Location = new System.Drawing.Point(181, 67);
            this.gbxPrepTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxPrepTime.Name = "gbxPrepTime";
            this.gbxPrepTime.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxPrepTime.Size = new System.Drawing.Size(186, 35);
            this.gbxPrepTime.TabIndex = 18;
            this.gbxPrepTime.TabStop = false;
            this.gbxPrepTime.Text = "Prep Time:";
            // 
            // PrepMinutes
            // 
            this.PrepMinutes.AutoSize = true;
            this.PrepMinutes.Location = new System.Drawing.Point(103, 16);
            this.PrepMinutes.Name = "PrepMinutes";
            this.PrepMinutes.Size = new System.Drawing.Size(53, 14);
            this.PrepMinutes.TabIndex = 2;
            this.PrepMinutes.Tag = "Minutes";
            this.PrepMinutes.Text = "0 Minutes";
            this.PrepMinutes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Time_KeyDown);
            this.PrepMinutes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Time_MouseClick);
            // 
            // PrepHours
            // 
            this.PrepHours.AutoSize = true;
            this.PrepHours.Location = new System.Drawing.Point(52, 16);
            this.PrepHours.Name = "PrepHours";
            this.PrepHours.Size = new System.Drawing.Size(45, 14);
            this.PrepHours.TabIndex = 1;
            this.PrepHours.Tag = "Hours";
            this.PrepHours.Text = "0 Hours";
            this.PrepHours.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Time_KeyDown);
            this.PrepHours.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Time_MouseClick);
            // 
            // PrepDays
            // 
            this.PrepDays.AutoSize = true;
            this.PrepDays.Location = new System.Drawing.Point(5, 16);
            this.PrepDays.Name = "PrepDays";
            this.PrepDays.Size = new System.Drawing.Size(41, 14);
            this.PrepDays.TabIndex = 0;
            this.PrepDays.Tag = "Days";
            this.PrepDays.Text = "0 Days";
            this.PrepDays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Time_KeyDown);
            this.PrepDays.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Time_MouseClick);
            // 
            // gbxCookTime
            // 
            this.gbxCookTime.Controls.Add(this.CookMinutes);
            this.gbxCookTime.Controls.Add(this.CookDays);
            this.gbxCookTime.Controls.Add(this.CookHours);
            this.gbxCookTime.Location = new System.Drawing.Point(478, 67);
            this.gbxCookTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxCookTime.Name = "gbxCookTime";
            this.gbxCookTime.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxCookTime.Size = new System.Drawing.Size(186, 35);
            this.gbxCookTime.TabIndex = 3;
            this.gbxCookTime.TabStop = false;
            this.gbxCookTime.Text = "Cook Time:";
            // 
            // CookMinutes
            // 
            this.CookMinutes.AutoSize = true;
            this.CookMinutes.Location = new System.Drawing.Point(103, 16);
            this.CookMinutes.Name = "CookMinutes";
            this.CookMinutes.Size = new System.Drawing.Size(53, 14);
            this.CookMinutes.TabIndex = 5;
            this.CookMinutes.Tag = "Minutes";
            this.CookMinutes.Text = "0 Minutes";
            this.CookMinutes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Time_KeyDown);
            this.CookMinutes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Time_MouseClick);
            // 
            // CookHours
            // 
            this.CookHours.AutoSize = true;
            this.CookHours.Location = new System.Drawing.Point(52, 16);
            this.CookHours.Name = "CookHours";
            this.CookHours.Size = new System.Drawing.Size(45, 14);
            this.CookHours.TabIndex = 4;
            this.CookHours.Tag = "Hours";
            this.CookHours.Text = "0 Hours";
            this.CookHours.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Time_KeyDown);
            this.CookHours.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Time_MouseClick);
            // 
            // CookDays
            // 
            this.CookDays.AutoSize = true;
            this.CookDays.Location = new System.Drawing.Point(5, 16);
            this.CookDays.Name = "CookDays";
            this.CookDays.Size = new System.Drawing.Size(41, 14);
            this.CookDays.TabIndex = 3;
            this.CookDays.Tag = "Days";
            this.CookDays.Text = "0 Days";
            this.CookDays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Time_KeyDown);
            this.CookDays.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Time_MouseClick);
            // 
            // frmRecipeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(884, 703);
            this.Controls.Add(this.gbxCookTime);
            this.Controls.Add(this.gbxPrepTime);
            this.Controls.Add(this.AuthorGroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbRecipeList);
            this.Controls.Add(this.msOptions);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "frmRecipeManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recipe Manager";
            this.Load += new System.EventHandler(this.frmRecipeManager_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRecipeManager_KeyDown);
            this.msOptions.ResumeLayout(false);
            this.msOptions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.AuthorGroupBox.ResumeLayout(false);
            this.AuthorGroupBox.PerformLayout();
            this.gbxPrepTime.ResumeLayout(false);
            this.gbxPrepTime.PerformLayout();
            this.gbxCookTime.ResumeLayout(false);
            this.gbxCookTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbRecipeList;
        private System.Windows.Forms.MenuStrip msOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxtDirections;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtxtIngredients;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label TotalTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox AuthorGroupBox;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.GroupBox gbxPrepTime;
        private System.Windows.Forms.Label PrepMinutes;
        private System.Windows.Forms.Label PrepHours;
        private System.Windows.Forms.Label PrepDays;
        private System.Windows.Forms.GroupBox gbxCookTime;
        private System.Windows.Forms.Label CookMinutes;
        private System.Windows.Forms.Label CookDays;
        private System.Windows.Forms.Label CookHours;
    }
}


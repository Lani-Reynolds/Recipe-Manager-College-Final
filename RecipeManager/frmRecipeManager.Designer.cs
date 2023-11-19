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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblDirections = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.rtxtIngredients = new System.Windows.Forms.RichTextBox();
            this.rtxtDirections = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblContributors = new System.Windows.Forms.Label();
            this.lblPrepTime = new System.Windows.Forms.Label();
            this.lblCookTime = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.txtPrepTime = new System.Windows.Forms.TextBox();
            this.txtTotalTime = new System.Windows.Forms.TextBox();
            this.txtCookTime = new System.Windows.Forms.TextBox();
            this.msOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRecipeList
            // 
            this.lbRecipeList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbRecipeList.FormattingEnabled = true;
            this.lbRecipeList.Location = new System.Drawing.Point(9, 38);
            this.lbRecipeList.Name = "lbRecipeList";
            this.lbRecipeList.Size = new System.Drawing.Size(154, 407);
            this.lbRecipeList.TabIndex = 0;
            this.lbRecipeList.TabStop = false;
            this.lbRecipeList.SelectedValueChanged += new System.EventHandler(this.lbRecipeList_SelectedValueChanged);
            // 
            // msOptions
            // 
            this.msOptions.AutoSize = false;
            this.msOptions.Dock = System.Windows.Forms.DockStyle.None;
            this.msOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOptions});
            this.msOptions.Location = new System.Drawing.Point(9, 9);
            this.msOptions.Name = "msOptions";
            this.msOptions.Size = new System.Drawing.Size(69, 24);
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
            this.tsmiOptions.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(61, 20);
            this.tsmiOptions.Text = "Options";
            // 
            // tsmiCreateNew
            // 
            this.tsmiCreateNew.Name = "tsmiCreateNew";
            this.tsmiCreateNew.Size = new System.Drawing.Size(134, 22);
            this.tsmiCreateNew.Text = "Create New";
            this.tsmiCreateNew.Click += new System.EventHandler(this.tsmiCreateNew_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(134, 22);
            this.tsmiSave.Text = "Save";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(134, 22);
            this.tsmiDelete.Text = "Delete";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(134, 22);
            this.tsmiHelp.Text = "Help";
            this.tsmiHelp.Click += new System.EventHandler(this.tsmiHelp_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(214, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "&Name:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(172, 115);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "&Description:";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(172, 239);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(79, 13);
            this.lblIngredients.TabIndex = 0;
            this.lblIngredients.Text = "&Ingredients:";
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Location = new System.Drawing.Point(178, 363);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(73, 13);
            this.lblDirections.TabIndex = 0;
            this.lblDirections.Text = "&Directions:";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(257, 41);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(409, 20);
            this.txtRecipeName.TabIndex = 1;
            this.txtRecipeName.Tag = "Name";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(257, 115);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(409, 112);
            this.rtxtDescription.TabIndex = 5;
            this.rtxtDescription.Tag = "Description";
            this.rtxtDescription.Text = "";
            // 
            // rtxtIngredients
            // 
            this.rtxtIngredients.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtIngredients.Location = new System.Drawing.Point(257, 239);
            this.rtxtIngredients.Name = "rtxtIngredients";
            this.rtxtIngredients.Size = new System.Drawing.Size(409, 112);
            this.rtxtIngredients.TabIndex = 6;
            this.rtxtIngredients.Tag = "Ingredients";
            this.rtxtIngredients.Text = "";
            this.rtxtIngredients.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxt_KeyDown);
            // 
            // rtxtDirections
            // 
            this.rtxtDirections.Location = new System.Drawing.Point(257, 363);
            this.rtxtDirections.Name = "rtxtDirections";
            this.rtxtDirections.Size = new System.Drawing.Size(409, 112);
            this.rtxtDirections.TabIndex = 7;
            this.rtxtDirections.Tag = "Directions";
            this.rtxtDirections.Text = "";
            this.rtxtDirections.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxt_KeyDown);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(9, 452);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblContributors
            // 
            this.lblContributors.AutoSize = true;
            this.lblContributors.Location = new System.Drawing.Point(425, 9);
            this.lblContributors.Name = "lblContributors";
            this.lblContributors.Size = new System.Drawing.Size(247, 13);
            this.lblContributors.TabIndex = 0;
            this.lblContributors.Text = "Sara Walker, Aaron White, Dominiq Holder";
            // 
            // lblPrepTime
            // 
            this.lblPrepTime.AutoSize = true;
            this.lblPrepTime.Location = new System.Drawing.Point(257, 68);
            this.lblPrepTime.Name = "lblPrepTime";
            this.lblPrepTime.Size = new System.Drawing.Size(67, 13);
            this.lblPrepTime.TabIndex = 0;
            this.lblPrepTime.Text = "&Prep Time:";
            // 
            // lblCookTime
            // 
            this.lblCookTime.AutoSize = true;
            this.lblCookTime.Location = new System.Drawing.Point(408, 68);
            this.lblCookTime.Name = "lblCookTime";
            this.lblCookTime.Size = new System.Drawing.Size(67, 13);
            this.lblCookTime.TabIndex = 0;
            this.lblCookTime.Text = "&Cook Time:";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Location = new System.Drawing.Point(563, 68);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(73, 13);
            this.lblTotalTime.TabIndex = 0;
            this.lblTotalTime.Text = "Total Time:";
            // 
            // txtPrepTime
            // 
            this.txtPrepTime.Location = new System.Drawing.Point(257, 84);
            this.txtPrepTime.Name = "txtPrepTime";
            this.txtPrepTime.Size = new System.Drawing.Size(100, 20);
            this.txtPrepTime.TabIndex = 2;
            this.txtPrepTime.Tag = "Prep Time";
            this.txtPrepTime.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtTotalTime
            // 
            this.txtTotalTime.Location = new System.Drawing.Point(566, 84);
            this.txtTotalTime.Name = "txtTotalTime";
            this.txtTotalTime.ReadOnly = true;
            this.txtTotalTime.Size = new System.Drawing.Size(100, 20);
            this.txtTotalTime.TabIndex = 4;
            this.txtTotalTime.TabStop = false;
            // 
            // txtCookTime
            // 
            this.txtCookTime.Location = new System.Drawing.Point(411, 84);
            this.txtCookTime.Name = "txtCookTime";
            this.txtCookTime.Size = new System.Drawing.Size(100, 20);
            this.txtCookTime.TabIndex = 3;
            this.txtCookTime.Tag = "Cook Time";
            this.txtCookTime.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // frmRecipeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(684, 486);
            this.Controls.Add(this.txtCookTime);
            this.Controls.Add(this.txtTotalTime);
            this.Controls.Add(this.txtPrepTime);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.lblCookTime);
            this.Controls.Add(this.lblPrepTime);
            this.Controls.Add(this.lblContributors);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rtxtDirections);
            this.Controls.Add(this.rtxtIngredients);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.txtRecipeName);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lbRecipeList);
            this.Controls.Add(this.msOptions);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(700, 525);
            this.Name = "frmRecipeManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recipe Manager";
            this.Load += new System.EventHandler(this.frmRecipeManager_Load);
            this.msOptions.ResumeLayout(false);
            this.msOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbRecipeList;
        private System.Windows.Forms.MenuStrip msOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.RichTextBox rtxtIngredients;
        private System.Windows.Forms.RichTextBox rtxtDirections;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.Label lblContributors;
        private System.Windows.Forms.Label lblPrepTime;
        private System.Windows.Forms.Label lblCookTime;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.TextBox txtPrepTime;
        private System.Windows.Forms.TextBox txtTotalTime;
        private System.Windows.Forms.TextBox txtCookTime;
    }
}


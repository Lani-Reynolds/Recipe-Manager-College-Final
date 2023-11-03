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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblDirections = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.rtxtIngredients = new System.Windows.Forms.RichTextBox();
            this.rtxtDirections = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRecipeList
            // 
            this.lbRecipeList.FormattingEnabled = true;
            this.lbRecipeList.Location = new System.Drawing.Point(9, 38);
            this.lbRecipeList.Name = "lbRecipeList";
            this.lbRecipeList.Size = new System.Drawing.Size(154, 394);
            this.lbRecipeList.TabIndex = 0;
            this.lbRecipeList.TabStop = false;
            this.lbRecipeList.SelectedValueChanged += new System.EventHandler(this.lbRecipeList_SelectedValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOptions});
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(69, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreateNew,
            this.tsmiSave,
            this.tsmiDelete});
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(61, 20);
            this.tsmiOptions.Text = "Options";
            // 
            // tsmiCreateNew
            // 
            this.tsmiCreateNew.Name = "tsmiCreateNew";
            this.tsmiCreateNew.Size = new System.Drawing.Size(180, 22);
            this.tsmiCreateNew.Text = "Create New";
            this.tsmiCreateNew.Click += new System.EventHandler(this.tsmiCreateNew_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(180, 22);
            this.tsmiSave.Text = "Save";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(180, 22);
            this.tsmiDelete.Text = "Delete";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(192, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "&Name:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(172, 70);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "&Description:";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(168, 194);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(62, 13);
            this.lblIngredients.TabIndex = 0;
            this.lblIngredients.Text = "&Ingredients:";
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Location = new System.Drawing.Point(173, 318);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(57, 13);
            this.lblDirections.TabIndex = 0;
            this.lblDirections.Text = "&Directions:";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(236, 41);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(430, 20);
            this.txtRecipeName.TabIndex = 1;
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(236, 70);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(430, 112);
            this.rtxtDescription.TabIndex = 2;
            this.rtxtDescription.Text = "";
            // 
            // rtxtIngredients
            // 
            this.rtxtIngredients.Location = new System.Drawing.Point(236, 194);
            this.rtxtIngredients.Name = "rtxtIngredients";
            this.rtxtIngredients.Size = new System.Drawing.Size(430, 112);
            this.rtxtIngredients.TabIndex = 3;
            this.rtxtIngredients.Text = "1.";
            // 
            // rtxtDirections
            // 
            this.rtxtDirections.Location = new System.Drawing.Point(236, 318);
            this.rtxtDirections.Name = "rtxtDirections";
            this.rtxtDirections.Size = new System.Drawing.Size(430, 112);
            this.rtxtDirections.TabIndex = 4;
            this.rtxtDirections.Text = "Step 1.";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(13, 439);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmRecipeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(680, 467);
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
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(700, 510);
            this.Name = "frmRecipeManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recipe Manager";
            this.Load += new System.EventHandler(this.frmRecipeManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbRecipeList;
        private System.Windows.Forms.MenuStrip menuStrip1;
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
    }
}


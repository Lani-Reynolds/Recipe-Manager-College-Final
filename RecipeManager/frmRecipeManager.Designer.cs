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
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.txtTotalTime = new System.Windows.Forms.TextBox();
            this.lblPrepTimeMinutes = new System.Windows.Forms.Label();
            this.nudPrepTimeMinutes = new System.Windows.Forms.NumericUpDown();
            this.lblPrepTimeHours = new System.Windows.Forms.Label();
            this.nudPrepTimeHours = new System.Windows.Forms.NumericUpDown();
            this.lblPrepTimeDays = new System.Windows.Forms.Label();
            this.nudPrepTimeDays = new System.Windows.Forms.NumericUpDown();
            this.lblCookTimeMinutes = new System.Windows.Forms.Label();
            this.nudCookTimeMinutes = new System.Windows.Forms.NumericUpDown();
            this.lblCookTimeHours = new System.Windows.Forms.Label();
            this.nudCookTimeHours = new System.Windows.Forms.NumericUpDown();
            this.lblCookTimeDays = new System.Windows.Forms.Label();
            this.nudCookTimeDays = new System.Windows.Forms.NumericUpDown();
            this.gbxPrepTime = new System.Windows.Forms.GroupBox();
            this.gbxCookTime = new System.Windows.Forms.GroupBox();
            this.msOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrepTimeMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrepTimeHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrepTimeDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCookTimeMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCookTimeHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCookTimeDays)).BeginInit();
            this.gbxPrepTime.SuspendLayout();
            this.gbxCookTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRecipeList
            // 
            this.lbRecipeList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbRecipeList.FormattingEnabled = true;
            this.lbRecipeList.ItemHeight = 14;
            this.lbRecipeList.Location = new System.Drawing.Point(10, 41);
            this.lbRecipeList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbRecipeList.Name = "lbRecipeList";
            this.lbRecipeList.Size = new System.Drawing.Size(154, 438);
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
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(214, 44);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 14);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "&Name:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(187, 124);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(64, 14);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "&Description:";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(188, 258);
            this.lblIngredients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(63, 14);
            this.lblIngredients.TabIndex = 0;
            this.lblIngredients.Text = "&Ingredients:";
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Location = new System.Drawing.Point(193, 391);
            this.lblDirections.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(58, 14);
            this.lblDirections.TabIndex = 0;
            this.lblDirections.Text = "&Directions:";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(257, 44);
            this.txtRecipeName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(410, 20);
            this.txtRecipeName.TabIndex = 1;
            this.txtRecipeName.Tag = "Name";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(257, 124);
            this.rtxtDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(410, 121);
            this.rtxtDescription.TabIndex = 9;
            this.rtxtDescription.Tag = "Description";
            this.rtxtDescription.Text = "";
            // 
            // rtxtIngredients
            // 
            this.rtxtIngredients.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtIngredients.Location = new System.Drawing.Point(257, 258);
            this.rtxtIngredients.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rtxtIngredients.Name = "rtxtIngredients";
            this.rtxtIngredients.Size = new System.Drawing.Size(410, 121);
            this.rtxtIngredients.TabIndex = 10;
            this.rtxtIngredients.Tag = "Ingredients";
            this.rtxtIngredients.Text = "";
            this.rtxtIngredients.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxt_KeyDown);
            // 
            // rtxtDirections
            // 
            this.rtxtDirections.Location = new System.Drawing.Point(257, 391);
            this.rtxtDirections.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rtxtDirections.Name = "rtxtDirections";
            this.rtxtDirections.Size = new System.Drawing.Size(410, 121);
            this.rtxtDirections.TabIndex = 11;
            this.rtxtDirections.Tag = "Directions";
            this.rtxtDirections.Text = "";
            this.rtxtDirections.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxt_KeyDown);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(10, 487);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 25);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Location = new System.Drawing.Point(569, 73);
            this.lblTotalTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(57, 14);
            this.lblTotalTime.TabIndex = 0;
            this.lblTotalTime.Text = "Total Time:";
            // 
            // txtTotalTime
            // 
            this.txtTotalTime.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtTotalTime.Location = new System.Drawing.Point(572, 90);
            this.txtTotalTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTotalTime.Name = "txtTotalTime";
            this.txtTotalTime.ReadOnly = true;
            this.txtTotalTime.Size = new System.Drawing.Size(100, 20);
            this.txtTotalTime.TabIndex = 8;
            this.txtTotalTime.TabStop = false;
            // 
            // lblPrepTimeMinutes
            // 
            this.lblPrepTimeMinutes.AutoSize = true;
            this.lblPrepTimeMinutes.BackColor = System.Drawing.Color.OldLace;
            this.lblPrepTimeMinutes.Location = new System.Drawing.Point(347, 110);
            this.lblPrepTimeMinutes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrepTimeMinutes.Name = "lblPrepTimeMinutes";
            this.lblPrepTimeMinutes.Size = new System.Drawing.Size(15, 14);
            this.lblPrepTimeMinutes.TabIndex = 0;
            this.lblPrepTimeMinutes.Text = "M";
            // 
            // nudPrepTimeMinutes
            // 
            this.nudPrepTimeMinutes.BackColor = System.Drawing.Color.OldLace;
            this.nudPrepTimeMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudPrepTimeMinutes.Location = new System.Drawing.Point(85, 14);
            this.nudPrepTimeMinutes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudPrepTimeMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudPrepTimeMinutes.Name = "nudPrepTimeMinutes";
            this.nudPrepTimeMinutes.ReadOnly = true;
            this.nudPrepTimeMinutes.Size = new System.Drawing.Size(36, 16);
            this.nudPrepTimeMinutes.TabIndex = 4;
            this.nudPrepTimeMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPrepTimeMinutes.ValueChanged += new System.EventHandler(this.nud_ValueChange);
            // 
            // lblPrepTimeHours
            // 
            this.lblPrepTimeHours.AutoSize = true;
            this.lblPrepTimeHours.BackColor = System.Drawing.Color.OldLace;
            this.lblPrepTimeHours.Location = new System.Drawing.Point(304, 110);
            this.lblPrepTimeHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrepTimeHours.Name = "lblPrepTimeHours";
            this.lblPrepTimeHours.Size = new System.Drawing.Size(14, 14);
            this.lblPrepTimeHours.TabIndex = 0;
            this.lblPrepTimeHours.Text = "H";
            // 
            // nudPrepTimeHours
            // 
            this.nudPrepTimeHours.BackColor = System.Drawing.Color.OldLace;
            this.nudPrepTimeHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudPrepTimeHours.Location = new System.Drawing.Point(43, 14);
            this.nudPrepTimeHours.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudPrepTimeHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudPrepTimeHours.Name = "nudPrepTimeHours";
            this.nudPrepTimeHours.ReadOnly = true;
            this.nudPrepTimeHours.Size = new System.Drawing.Size(36, 16);
            this.nudPrepTimeHours.TabIndex = 3;
            this.nudPrepTimeHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPrepTimeHours.ValueChanged += new System.EventHandler(this.nud_ValueChange);
            // 
            // lblPrepTimeDays
            // 
            this.lblPrepTimeDays.AutoSize = true;
            this.lblPrepTimeDays.BackColor = System.Drawing.Color.OldLace;
            this.lblPrepTimeDays.Location = new System.Drawing.Point(263, 110);
            this.lblPrepTimeDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrepTimeDays.Name = "lblPrepTimeDays";
            this.lblPrepTimeDays.Size = new System.Drawing.Size(14, 14);
            this.lblPrepTimeDays.TabIndex = 0;
            this.lblPrepTimeDays.Text = "D";
            // 
            // nudPrepTimeDays
            // 
            this.nudPrepTimeDays.BackColor = System.Drawing.Color.OldLace;
            this.nudPrepTimeDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudPrepTimeDays.Location = new System.Drawing.Point(1, 14);
            this.nudPrepTimeDays.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudPrepTimeDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nudPrepTimeDays.Name = "nudPrepTimeDays";
            this.nudPrepTimeDays.ReadOnly = true;
            this.nudPrepTimeDays.Size = new System.Drawing.Size(36, 16);
            this.nudPrepTimeDays.TabIndex = 2;
            this.nudPrepTimeDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPrepTimeDays.ValueChanged += new System.EventHandler(this.nud_ValueChange);
            // 
            // lblCookTimeMinutes
            // 
            this.lblCookTimeMinutes.AutoSize = true;
            this.lblCookTimeMinutes.BackColor = System.Drawing.Color.OldLace;
            this.lblCookTimeMinutes.Location = new System.Drawing.Point(505, 110);
            this.lblCookTimeMinutes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCookTimeMinutes.Name = "lblCookTimeMinutes";
            this.lblCookTimeMinutes.Size = new System.Drawing.Size(15, 14);
            this.lblCookTimeMinutes.TabIndex = 0;
            this.lblCookTimeMinutes.Text = "M";
            // 
            // nudCookTimeMinutes
            // 
            this.nudCookTimeMinutes.BackColor = System.Drawing.Color.OldLace;
            this.nudCookTimeMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudCookTimeMinutes.Location = new System.Drawing.Point(85, 14);
            this.nudCookTimeMinutes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudCookTimeMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudCookTimeMinutes.Name = "nudCookTimeMinutes";
            this.nudCookTimeMinutes.ReadOnly = true;
            this.nudCookTimeMinutes.Size = new System.Drawing.Size(36, 16);
            this.nudCookTimeMinutes.TabIndex = 7;
            this.nudCookTimeMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCookTimeMinutes.ValueChanged += new System.EventHandler(this.nud_ValueChange);
            // 
            // lblCookTimeHours
            // 
            this.lblCookTimeHours.AutoSize = true;
            this.lblCookTimeHours.BackColor = System.Drawing.Color.OldLace;
            this.lblCookTimeHours.Location = new System.Drawing.Point(462, 110);
            this.lblCookTimeHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCookTimeHours.Name = "lblCookTimeHours";
            this.lblCookTimeHours.Size = new System.Drawing.Size(14, 14);
            this.lblCookTimeHours.TabIndex = 0;
            this.lblCookTimeHours.Text = "H";
            // 
            // nudCookTimeHours
            // 
            this.nudCookTimeHours.BackColor = System.Drawing.Color.OldLace;
            this.nudCookTimeHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudCookTimeHours.Location = new System.Drawing.Point(43, 14);
            this.nudCookTimeHours.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudCookTimeHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudCookTimeHours.Name = "nudCookTimeHours";
            this.nudCookTimeHours.ReadOnly = true;
            this.nudCookTimeHours.Size = new System.Drawing.Size(36, 16);
            this.nudCookTimeHours.TabIndex = 6;
            this.nudCookTimeHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCookTimeHours.ValueChanged += new System.EventHandler(this.nud_ValueChange);
            // 
            // lblCookTimeDays
            // 
            this.lblCookTimeDays.AutoSize = true;
            this.lblCookTimeDays.BackColor = System.Drawing.Color.OldLace;
            this.lblCookTimeDays.Location = new System.Drawing.Point(421, 110);
            this.lblCookTimeDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCookTimeDays.Name = "lblCookTimeDays";
            this.lblCookTimeDays.Size = new System.Drawing.Size(14, 14);
            this.lblCookTimeDays.TabIndex = 0;
            this.lblCookTimeDays.Text = "D";
            // 
            // nudCookTimeDays
            // 
            this.nudCookTimeDays.BackColor = System.Drawing.Color.OldLace;
            this.nudCookTimeDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudCookTimeDays.Location = new System.Drawing.Point(1, 14);
            this.nudCookTimeDays.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudCookTimeDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nudCookTimeDays.Name = "nudCookTimeDays";
            this.nudCookTimeDays.ReadOnly = true;
            this.nudCookTimeDays.Size = new System.Drawing.Size(36, 16);
            this.nudCookTimeDays.TabIndex = 5;
            this.nudCookTimeDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCookTimeDays.ValueChanged += new System.EventHandler(this.nud_ValueChange);
            // 
            // gbxPrepTime
            // 
            this.gbxPrepTime.Controls.Add(this.nudPrepTimeHours);
            this.gbxPrepTime.Controls.Add(this.nudPrepTimeDays);
            this.gbxPrepTime.Controls.Add(this.nudPrepTimeMinutes);
            this.gbxPrepTime.Location = new System.Drawing.Point(257, 73);
            this.gbxPrepTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxPrepTime.Name = "gbxPrepTime";
            this.gbxPrepTime.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxPrepTime.Size = new System.Drawing.Size(121, 37);
            this.gbxPrepTime.TabIndex = 0;
            this.gbxPrepTime.TabStop = false;
            this.gbxPrepTime.Text = "Prep Time:";
            // 
            // gbxCookTime
            // 
            this.gbxCookTime.Controls.Add(this.nudCookTimeDays);
            this.gbxCookTime.Controls.Add(this.nudCookTimeHours);
            this.gbxCookTime.Controls.Add(this.nudCookTimeMinutes);
            this.gbxCookTime.Location = new System.Drawing.Point(412, 73);
            this.gbxCookTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxCookTime.Name = "gbxCookTime";
            this.gbxCookTime.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxCookTime.Size = new System.Drawing.Size(121, 37);
            this.gbxCookTime.TabIndex = 0;
            this.gbxCookTime.TabStop = false;
            this.gbxCookTime.Text = "Cook Time:";
            // 
            // frmRecipeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(684, 524);
            this.Controls.Add(this.gbxCookTime);
            this.Controls.Add(this.gbxPrepTime);
            this.Controls.Add(this.lblCookTimeMinutes);
            this.Controls.Add(this.lblCookTimeHours);
            this.Controls.Add(this.lblCookTimeDays);
            this.Controls.Add(this.lblPrepTimeMinutes);
            this.Controls.Add(this.lblPrepTimeHours);
            this.Controls.Add(this.lblPrepTimeDays);
            this.Controls.Add(this.txtTotalTime);
            this.Controls.Add(this.lblTotalTime);
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
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(700, 563);
            this.Name = "frmRecipeManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recipe Manager";
            this.Load += new System.EventHandler(this.frmRecipeManager_Load);
            this.msOptions.ResumeLayout(false);
            this.msOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrepTimeMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrepTimeHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrepTimeDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCookTimeMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCookTimeHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCookTimeDays)).EndInit();
            this.gbxPrepTime.ResumeLayout(false);
            this.gbxCookTime.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.TextBox txtTotalTime;
        private System.Windows.Forms.Label lblPrepTimeMinutes;
        private System.Windows.Forms.NumericUpDown nudPrepTimeMinutes;
        private System.Windows.Forms.Label lblPrepTimeHours;
        private System.Windows.Forms.NumericUpDown nudPrepTimeHours;
        private System.Windows.Forms.Label lblPrepTimeDays;
        private System.Windows.Forms.NumericUpDown nudPrepTimeDays;
        private System.Windows.Forms.Label lblCookTimeMinutes;
        private System.Windows.Forms.NumericUpDown nudCookTimeMinutes;
        private System.Windows.Forms.Label lblCookTimeHours;
        private System.Windows.Forms.NumericUpDown nudCookTimeHours;
        private System.Windows.Forms.Label lblCookTimeDays;
        private System.Windows.Forms.NumericUpDown nudCookTimeDays;
        private System.Windows.Forms.GroupBox gbxPrepTime;
        private System.Windows.Forms.GroupBox gbxCookTime;
    }
}


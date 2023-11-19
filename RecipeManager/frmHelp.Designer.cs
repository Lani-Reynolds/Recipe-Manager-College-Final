namespace RecipeManager
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            this.btnControls = new System.Windows.Forms.Button();
            this.btnIngredientsFormat = new System.Windows.Forms.Button();
            this.btnDirectionsFormat = new System.Windows.Forms.Button();
            this.gbxHelp = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnControls
            // 
            this.btnControls.Location = new System.Drawing.Point(13, 13);
            this.btnControls.Name = "btnControls";
            this.btnControls.Size = new System.Drawing.Size(199, 23);
            this.btnControls.TabIndex = 1;
            this.btnControls.Text = "Controls";
            this.btnControls.UseVisualStyleBackColor = true;
            this.btnControls.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnIngredientsFormat
            // 
            this.btnIngredientsFormat.Location = new System.Drawing.Point(13, 42);
            this.btnIngredientsFormat.Name = "btnIngredientsFormat";
            this.btnIngredientsFormat.Size = new System.Drawing.Size(199, 23);
            this.btnIngredientsFormat.TabIndex = 2;
            this.btnIngredientsFormat.Text = "Ingredients Format";
            this.btnIngredientsFormat.UseVisualStyleBackColor = true;
            this.btnIngredientsFormat.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDirectionsFormat
            // 
            this.btnDirectionsFormat.Location = new System.Drawing.Point(12, 71);
            this.btnDirectionsFormat.Name = "btnDirectionsFormat";
            this.btnDirectionsFormat.Size = new System.Drawing.Size(199, 23);
            this.btnDirectionsFormat.TabIndex = 3;
            this.btnDirectionsFormat.Text = "Directions Format";
            this.btnDirectionsFormat.UseVisualStyleBackColor = true;
            this.btnDirectionsFormat.Click += new System.EventHandler(this.btn_Click);
            // 
            // gbxHelp
            // 
            this.gbxHelp.Location = new System.Drawing.Point(218, 13);
            this.gbxHelp.Name = "gbxHelp";
            this.gbxHelp.Size = new System.Drawing.Size(312, 461);
            this.gbxHelp.TabIndex = 4;
            this.gbxHelp.TabStop = false;
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 486);
            this.Controls.Add(this.gbxHelp);
            this.Controls.Add(this.btnDirectionsFormat);
            this.Controls.Add(this.btnIngredientsFormat);
            this.Controls.Add(this.btnControls);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Help";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnControls;
        private System.Windows.Forms.Button btnIngredientsFormat;
        private System.Windows.Forms.Button btnDirectionsFormat;
        private System.Windows.Forms.GroupBox gbxHelp;
    }
}
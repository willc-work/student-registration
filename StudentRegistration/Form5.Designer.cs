namespace StudentRegistration
{
    partial class Form5
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.LinkLabel();
            this.navigationTile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(227, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(308, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(97, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(32, 13);
            this.backButton.TabIndex = 21;
            this.backButton.TabStop = true;
            this.backButton.Text = "Back";
            this.backButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackLink);
            // 
            // navigationTile
            // 
            this.navigationTile.AutoSize = true;
            this.navigationTile.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationTile.Location = new System.Drawing.Point(275, 13);
            this.navigationTile.Name = "navigationTile";
            this.navigationTile.Size = new System.Drawing.Size(212, 29);
            this.navigationTile.TabIndex = 23;
            this.navigationTile.Text = "Course Navigation";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.navigationTile);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.comboBox2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.LinkLabel backButton;
        private System.Windows.Forms.Label navigationTile;
    }
}
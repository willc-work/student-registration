namespace StudentRegistration
{
    partial class Form1
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
            this.headingLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.navigateButton = new System.Windows.Forms.Button();
            this.studentImage = new System.Windows.Forms.PictureBox();
            this.photoUploadButton = new System.Windows.Forms.Button();
            this.imageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(309, 9);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(366, 46);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "Student Registration";
            // 
            // registerButton
            // 
            this.registerButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.registerButton.Location = new System.Drawing.Point(166, 140);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 1;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(166, 221);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(166, 311);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // navigateButton
            // 
            this.navigateButton.Location = new System.Drawing.Point(166, 390);
            this.navigateButton.Name = "navigateButton";
            this.navigateButton.Size = new System.Drawing.Size(75, 23);
            this.navigateButton.TabIndex = 4;
            this.navigateButton.Text = "Navigate";
            this.navigateButton.UseVisualStyleBackColor = true;
            this.navigateButton.Click += new System.EventHandler(this.NavigateButton_Click);
            // 
            // studentImage
            // 
            this.studentImage.Location = new System.Drawing.Point(551, 93);
            this.studentImage.Name = "studentImage";
            this.studentImage.Size = new System.Drawing.Size(330, 330);
            this.studentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.studentImage.TabIndex = 5;
            this.studentImage.TabStop = false;
            // 
            // photoUploadButton
            // 
            this.photoUploadButton.Location = new System.Drawing.Point(681, 429);
            this.photoUploadButton.Name = "photoUploadButton";
            this.photoUploadButton.Size = new System.Drawing.Size(75, 23);
            this.photoUploadButton.TabIndex = 6;
            this.photoUploadButton.Text = "Upload Photo";
            this.photoUploadButton.UseVisualStyleBackColor = true;
            this.photoUploadButton.Click += new System.EventHandler(this.PhotoUploadButton_Click);
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageLabel.Location = new System.Drawing.Point(658, 66);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(133, 24);
            this.imageLabel.TabIndex = 7;
            this.imageLabel.Text = "Student Photo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 537);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.photoUploadButton);
            this.Controls.Add(this.studentImage);
            this.Controls.Add(this.navigateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.headingLabel);
            this.Name = "Form1";
            this.Text = "Home Page";
            ((System.ComponentModel.ISupportInitialize)(this.studentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button navigateButton;
        private System.Windows.Forms.PictureBox studentImage;
        private System.Windows.Forms.Button photoUploadButton;
        private System.Windows.Forms.Label imageLabel;
    }
}


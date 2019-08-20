namespace StudentRegistration
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.courseName = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.lastNameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.genderRadioM = new System.Windows.Forms.RadioButton();
            this.genderRadioF = new System.Windows.Forms.RadioButton();
            this.genderRadioNA = new System.Windows.Forms.RadioButton();
            this.genderRadio = new System.Windows.Forms.Label();
            this.studentAvatar = new System.Windows.Forms.PictureBox();
            this.photoUploadButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backButton = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.courseNameComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(92, 52);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(57, 13);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "First Name";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(91, 90);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(58, 13);
            this.lastName.TabIndex = 1;
            this.lastName.Text = "Last Name";
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Location = new System.Drawing.Point(91, 205);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(112, 13);
            this.phoneNumber.TabIndex = 2;
            this.phoneNumber.Text = "Mobile Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // courseName
            // 
            this.courseName.AutoSize = true;
            this.courseName.Location = new System.Drawing.Point(91, 345);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(40, 13);
            this.courseName.TabIndex = 4;
            this.courseName.Text = "Course";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(307, 45);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(184, 20);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(307, 90);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(184, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(307, 205);
            this.phoneNumberTextBox.Mask = "00000000000";
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(184, 20);
            this.phoneNumberTextBox.TabIndex = 7;
            // 
            // genderRadioM
            // 
            this.genderRadioM.AutoSize = true;
            this.genderRadioM.Location = new System.Drawing.Point(307, 130);
            this.genderRadioM.Name = "genderRadioM";
            this.genderRadioM.Size = new System.Drawing.Size(48, 17);
            this.genderRadioM.TabIndex = 10;
            this.genderRadioM.TabStop = true;
            this.genderRadioM.Text = "Male";
            this.genderRadioM.UseVisualStyleBackColor = true;
            // 
            // genderRadioF
            // 
            this.genderRadioF.AutoSize = true;
            this.genderRadioF.Location = new System.Drawing.Point(307, 153);
            this.genderRadioF.Name = "genderRadioF";
            this.genderRadioF.Size = new System.Drawing.Size(59, 17);
            this.genderRadioF.TabIndex = 11;
            this.genderRadioF.TabStop = true;
            this.genderRadioF.Text = "Female";
            this.genderRadioF.UseVisualStyleBackColor = true;
            // 
            // genderRadioNA
            // 
            this.genderRadioNA.AutoSize = true;
            this.genderRadioNA.Location = new System.Drawing.Point(307, 176);
            this.genderRadioNA.Name = "genderRadioNA";
            this.genderRadioNA.Size = new System.Drawing.Size(110, 17);
            this.genderRadioNA.TabIndex = 12;
            this.genderRadioNA.TabStop = true;
            this.genderRadioNA.Text = "Prefer Not To Say";
            this.genderRadioNA.UseVisualStyleBackColor = true;
            // 
            // genderRadio
            // 
            this.genderRadio.AutoSize = true;
            this.genderRadio.Location = new System.Drawing.Point(91, 132);
            this.genderRadio.Name = "genderRadio";
            this.genderRadio.Size = new System.Drawing.Size(129, 13);
            this.genderRadio.TabIndex = 13;
            this.genderRadio.Text = "Please select your gender";
            // 
            // studentAvatar
            // 
            this.studentAvatar.Location = new System.Drawing.Point(507, 45);
            this.studentAvatar.Name = "studentAvatar";
            this.studentAvatar.Size = new System.Drawing.Size(240, 275);
            this.studentAvatar.TabIndex = 14;
            this.studentAvatar.TabStop = false;
            // 
            // photoUploadButton
            // 
            this.photoUploadButton.Location = new System.Drawing.Point(594, 347);
            this.photoUploadButton.Name = "photoUploadButton";
            this.photoUploadButton.Size = new System.Drawing.Size(75, 23);
            this.photoUploadButton.TabIndex = 15;
            this.photoUploadButton.Text = "Upload Photo";
            this.photoUploadButton.UseVisualStyleBackColor = true;
            this.photoUploadButton.Click += new System.EventHandler(this.PhotoUploadButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(95, 385);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(101, 41);
            this.submitButton.TabIndex = 16;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(307, 243);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(184, 96);
            this.addressTextBox.TabIndex = 17;
            this.addressTextBox.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Location = new System.Drawing.Point(91, 9);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(32, 13);
            this.backButton.TabIndex = 19;
            this.backButton.TabStop = true;
            this.backButton.Text = "Back";
            this.backButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackLink);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(240, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 41);
            this.button1.TabIndex = 21;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Reset_Click);
            // 
            // courseNameComboBox
            // 
            this.courseNameComboBox.FormattingEnabled = true;
            this.courseNameComboBox.Location = new System.Drawing.Point(307, 347);
            this.courseNameComboBox.Name = "courseNameComboBox";
            this.courseNameComboBox.Size = new System.Drawing.Size(184, 21);
            this.courseNameComboBox.TabIndex = 22;
            this.courseNameComboBox.Text = "Select the course";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.courseNameComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.photoUploadButton);
            this.Controls.Add(this.studentAvatar);
            this.Controls.Add(this.genderRadio);
            this.Controls.Add(this.genderRadioNA);
            this.Controls.Add(this.genderRadioF);
            this.Controls.Add(this.genderRadioM);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.courseName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Registration Page";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label phoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label courseName;
        protected System.Windows.Forms.Label lastName;
        private System.Windows.Forms.MaskedTextBox firstNameTextBox;
        private System.Windows.Forms.MaskedTextBox lastNameTextBox;
        private System.Windows.Forms.MaskedTextBox phoneNumberTextBox;
        private System.Windows.Forms.RadioButton genderRadioM;
        private System.Windows.Forms.RadioButton genderRadioF;
        private System.Windows.Forms.RadioButton genderRadioNA;
        private System.Windows.Forms.Label genderRadio;
        private System.Windows.Forms.PictureBox studentAvatar;
        private System.Windows.Forms.Button photoUploadButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.RichTextBox addressTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.LinkLabel backButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox courseNameComboBox;
    }
}
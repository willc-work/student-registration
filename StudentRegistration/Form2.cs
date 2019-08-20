using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void PhotoUploadButton_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog uploadImg = new OpenFileDialog();
                uploadImg.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (uploadImg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = uploadImg.FileName;

                    studentAvatar.ImageLocation = imageLocation;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("An error has ocurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackLink(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            this.firstNameTextBox.Text = "";
            this.lastNameTextBox.Clear();
            //this.courseTextBox.Text = "";
            this.addressTextBox.Text = "";
            this.phoneNumberTextBox.Text = "";
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            List<Student> ls = new List<Student>();
            Student s = new Student();
            s.FirstName = firstNameTextBox.Text;
            s.LastName = lastNameTextBox.Text;
            s.Address = addressTextBox.Text;
            s.PhoneNumber = phoneNumberTextBox.Text;
            s.Course = courseNameComboBox.Text;
          //  s.Gender = if 
            ls.Add(s);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List <String> list = new List<String>();
            list.Add("Computing");
            list.Add("Security");
            list.Add("Networking and Comms");
            foreach (String item in list)
            { courseNameComboBox.Items.Add(item); }
            
        }
    }
}

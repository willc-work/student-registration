using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
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

                    studentImage.ImageLocation = imageLocation;
                }

            }catch(Exception)
            {
                MessageBox.Show("An error has ocurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
             this.Hide();
             Form4 f4 = new Form4();
             f4.ShowDialog();
        }

        private void NavigateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeSaver
{
    public partial class BloodBankEditProfileForm : Form
    {
        string imgloc = "";
        public BloodBankEditProfileForm()
        {
           
            InitializeComponent();
        }

        private void BloodBankEditProfileForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool updateRes = BloodbankOperations.ProfileEdit(nameField.Text, emailField.Text, passwordField.Text, imgloc, textBox2.Text, textBox1.Text, mobileField.Text, checkBox1.Checked);
            if (updateRes)
            {
                MessageBox.Show("Profile edited succesfully");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Flies (*.jpg)|*.jpg|GIF Files (*.gif)|*gif |ALL Files (*.*)|*.*";
                dlg.Title = "Select Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgloc = dlg.FileName.ToString();
                    pictureBox1.ImageLocation = imgloc;

                }
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BloodBankHomeForm uh = new BloodBankHomeForm();
            uh.Show();
            this.Hide();
        }
    }
}

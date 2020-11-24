using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LifeSaver
{
    public partial class SignupForm : Form
    {
        string imgloc = "";
        public SignupForm()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            blood_types[] types = new blood_types[] {
                blood_types.A_pos,
                blood_types.A_neg,
                blood_types.B_pos,
                blood_types.B_neg,
                blood_types.AB_pos,
                blood_types.AB_neg,
                blood_types.O_pos,
                blood_types.O_neg 
            };

            passMessage.Text = "";
            emailMessage.Text = "";
            mobileMessage.Text = "";

            User user = new User();
            user.Name = nameField.Text;
            user.pictureLoc = imgloc;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(emailField.Text);
            if (!match.Success)
            {
                emailMessage.Text = "Enter valid email !";
                return;
            }
            user.Email = emailField.Text;

            if (passwordField.Text != confirmPassField.Text)
            {
                passMessage.Text = "Passwords didn't match";
                return;
            }
            user.Password = passwordField.Text;

            Regex regex2 = new Regex(@"^01[0-2]");
            Match match2 = regex2.Match(mobileField.Text);
            if (!match2.Success || mobileField.Text.Length != 11)
            {
                mobileMessage.Text = "Enter valid mobile !";
                return;
            }
            user.mobileNo = mobileField.Text;

            user.HealthCond = healthCondField.Text;
            user.birthdate = DateTime.Parse(birthDateField.Text);
            user.BloodType = types[bTypeComboBox.SelectedIndex];

            if (!UserOperations.signUp(user))
                emailMessage.Text = "Used Email!";
            else
            {
                UserHomeForm home = new UserHomeForm();
                home.Show();
                this.Hide();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

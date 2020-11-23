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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UserOperations.Login(textBox1.Text,textBox2.Text)){
                UserHomeForm uh = new UserHomeForm();
                uh.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(BloodbankOperations.Login(textBox1.Text, textBox2.Text)){
                BloodBankHomeForm bb = new BloodBankHomeForm();
                bb.Show();
                this.Hide();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetpasswordForm ff = new ForgetpasswordForm();
            ff.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm signup = new SignupForm();
            signup.Show();
            this.Hide();
        }
    }
}

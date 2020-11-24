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
    public partial class UserEditProfileForm : Form
    {
        public UserEditProfileForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserOperations.ProfileEditname(textBox6.Text, textBox1.Text);
            MessageBox.Show("Name edited succesfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserOperations.ProfileEditemail(textBox6.Text, textBox2.Text);
            MessageBox.Show("Email edited succesfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserOperations.ProfileEditpassword(textBox6.Text, textBox3.Text);
            MessageBox.Show("Password edited succesfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserOperations.ProfileEditmobile(textBox6.Text, textBox4.Text);
            MessageBox.Show("Mobile edited succesfully");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserOperations.ProfileEdithealth(textBox6.Text, textBox5.Text);
            MessageBox.Show("HealthCondition edited succesfully");
        }
    }
}

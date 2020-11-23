using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeSaver
{
    public partial class ForgetpasswordForm : Form
    {
        public ForgetpasswordForm()
        {
            InitializeComponent();
        }

        private void forgetPassButton_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(emailText.Text);
            if (!match.Success)
            {
                emailMessage.Text = "Enter valid email !";
                return;
            }
            UserOperations.FrogetPass(emailText.Text);

            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
            
        }

        private void forgetPassButtonforBanks_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(emailText.Text);
            if (!match.Success)
            {
                emailMessage.Text = "Enter valid email !";
                return;
            }
            BloodbankOperations.FrogetPass(emailText.Text);

            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();

        }
    }
}

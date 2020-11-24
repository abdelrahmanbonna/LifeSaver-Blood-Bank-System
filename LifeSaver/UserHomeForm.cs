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
    public partial class UserHomeForm : Form
    {
        public UserHomeForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserEditProfileForm uef = new UserEditProfileForm();
            uef.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RequestBloodForm uef = new RequestBloodForm("user");
            uef.Show();
            this.Hide();
        }
    }
}

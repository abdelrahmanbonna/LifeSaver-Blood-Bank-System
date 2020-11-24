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
    public partial class BloodBankHomeForm : Form
    {
        public BloodBankHomeForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RequestBloodForm rb = new RequestBloodForm("admin");
            rb.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bloodpackOperationsForm bbo = new bloodpackOperationsForm();
            bbo.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }
    }
}

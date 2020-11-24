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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void bankButton_Click(object sender, EventArgs e)
        {
            Bloodpackoperations.SearchbyBloodbank(ref dataGridView1,searchText.Text);
        }

        private void packButton_Click(object sender, EventArgs e)
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

            Bloodpackoperations.SearchbyBloodtype(ref dataGridView1, types[bTypeComboBox.SelectedIndex]);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UserHomeForm rb = new UserHomeForm();
            rb.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeSaver
{
    public partial class SearchForm : Form
    {
        private static string conString = @"data source = (local);database = Bloodbank;integrated security = SSPI";
        private static SqlConnection con = new SqlConnection(conString);
        public SearchForm()
        {
            InitializeComponent();
        }

        public void LoadTable(string q)
        {
            try
            {
                SqlCommand Cmd = new SqlCommand(q, con);
                con.Open();
                SqlDataReader DR = Cmd.ExecuteReader();
                if (DR.HasRows)
                {
                    BindingSource source = new BindingSource();
                    source.DataSource = DR;
                    dataGridView1.DataSource = source;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bankButton_Click(object sender, EventArgs e)
        {
            //add fix
            LoadTable("select bb_name,bb_email,bb_mobile,bb_address,bb_type from BloodBanks where bb_name='" + searchText.Text + "'");
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

            //add fix
            LoadTable("select BloodBanks.bb_name,BloodBanks.bb_email,BloodBanks.bb_mobile,BloodBanks.bb_address,BloodBanks.bb_type from BloodBanks INNER JOIN BloodPacks ON bb_id=bpack_bank and bpack_bloodtype='" + types[bTypeComboBox.SelectedIndex].ToString() + "'");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UserHomeForm rb = new UserHomeForm();
            rb.Show();
            this.Hide();
        }
    }
}

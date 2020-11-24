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
    public partial class bloodpackOperationsForm : Form
    {
        public bloodpackOperationsForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            blood_types Type = (blood_types)Enum.Parse(typeof(blood_types), typeCombo.Text);
            DateTime expireDT = dateTimePicker1.Value.Date + dateTimePicker1.Value.TimeOfDay;
            BloodbankOperations.add_blood_type(Type, bbNameBox.Text, expireDT);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            blood_types Type = (blood_types)Enum.Parse(typeof(blood_types), typeCombo.Text);
            BloodbankOperations.remove_blood_type(Type, bbNameBox.Text);
        }
    }
}

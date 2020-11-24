﻿using System;
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
    public partial class RequestBloodForm : Form
    {
        public RequestBloodForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserOperations.Request_Blood(NameBox.Text, emailBox.Text, bbnameCombo.Text, TypesCombo.Text, int.Parse(AmountBox.Text));
        }

        private void RequestBloodForm_Load(object sender, EventArgs e)
        {
            string Quarey = "select bb_name from BloodBank";
            bbnameCombo.DataSource = DatabaseHandler.getMultiRows(Quarey);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

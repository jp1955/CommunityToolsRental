//-----------------------------------------------------------------------
// <copyright file="Form1.cs" company="Microsoft Corporation">
//     Copyright Microsoft Corporation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunityToolsRental
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Color; // need this in constructor so when it runs it sets the color
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            // init a form before calling it
            frmCustomerList frm = new frmCustomerList();
            frm.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = Properties.Settings.Default.Color;
            }
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            frmToolList frm = new frmToolList();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = Properties.Settings.Default.Color; // change properties of btnSettingsClose DialogResult to OK
            }
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            frmLoanList frm = new frmLoanList();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = Properties.Settings.Default.Color;
            }

        }

     
    }

}

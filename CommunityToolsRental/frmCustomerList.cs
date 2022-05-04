using DataManagement;
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
    public partial class frmCustomerList : Form
    {
        List<Customer> customerList = new List<Customer>();
        Adapter adapter = new Adapter();

        public frmCustomerList()
        {
            InitializeComponent();
            SetupDataTable();
            this.BackColor = Properties.Settings.Default.Color;
        }

        private void SetupDataTable()
        {
            customerList = adapter.GetAllCustomers(); // call the method from Adapter class that uses a SQL command
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = customerList;
            dgvCustomers.Columns["FullName"].Visible = false; // hides any column you specify
            dgvCustomers.Columns["LastName"].HeaderText = "Surname"; // change any columns header text to what you'd like
            dgvCustomers.RowHeadersVisible = false;

            // if use autosizemode for multiple columns they share the excess space
            dgvCustomers.Columns["Phone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // make last column fill the table
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // don't delete if dgv is already empty
            if (dgvCustomers.Rows.Count > 0)
            {
                // grabs the current customer highlighted
                int id = (int)dgvCustomers["CustomerID", dgvCustomers.CurrentCell.RowIndex].Value;

                // store the yes or no result from the message box to pass it somewhere
                DialogResult result = MessageBox.Show("Do you want to delete this customer?", "Delete Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    adapter.DeleteSingleCustomer(id);
                    SetupDataTable();
                }
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerDetails frm = new frmCustomerDetails();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                SetupDataTable();
            }

        }

        private void dgvCustomers_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)dgvCustomers["CustomerID", dgvCustomers.CurrentCell.RowIndex].Value;
            frmCustomerDetails frm = new frmCustomerDetails(id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                SetupDataTable();
            }
        }
    }
}

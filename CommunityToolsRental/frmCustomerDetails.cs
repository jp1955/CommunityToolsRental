using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataManagement;

namespace CommunityToolsRental
{
    public partial class frmCustomerDetails : Form
    {
        Customer customer = new Customer();
        Adapter adapter = new Adapter();
        bool isNew = true; // used to determine which form to open on initialization

        public frmCustomerDetails()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Color;
        }

        // overload constructor for double click from datagridview to get IDs
        public frmCustomerDetails(int id)
        {
            InitializeComponent();
            isNew = false;
            ShowExistingCustomerDetails(id);
            this.BackColor = Properties.Settings.Default.Color;
        }

        private void ShowExistingCustomerDetails(int id)
        {
            customer = adapter.GetSingleCustomerDetails(id);
            txtCustomerID.Text = customer.CustomerID.ToString();
            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
            txtPhone.Text = customer.Phone;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveNewCustomer();
        }

        private void SaveNewCustomer()
        {
            if (AreTextFieldsCompleted())
            {
                customer.FirstName = txtFirstName.Text;
                customer.LastName = txtLastName.Text;
                customer.Phone = txtPhone.Text;

                if (isNew)
                {
                    adapter.AddNewCustomer(customer);
                }
                else
                {
                    adapter.SaveExistingCustomer(customer);
                }

                this.DialogResult = DialogResult.OK;
            } 
            else
            {
                MessageBox.Show("Please enter all fields before saving.");
            }
        }

        // check if text fields are empty, to use in the SaveNewCsutomer() method
        // it only returns true if there is no empty fields
        private bool AreTextFieldsCompleted()
        {
            if (String.IsNullOrWhiteSpace(txtFirstName.Text))
            {  
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtLastName.Text))
            {  
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtPhone.Text))
            {  
                return false;
            }
            return true;

        }

    }
}

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
    public partial class frmMultiReturn : Form
    {
        List<Customer> customerList = new List<Customer>();
        Adapter adapter = new Adapter();
        List<LoanView> loanList = new List<LoanView>();
        
        public frmMultiReturn()
        {
            InitializeComponent();
            PopulateCustomerComboBox();
            this.BackColor = Properties.Settings.Default.Color;
        }

        private void cboCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadLoanTable();
            }
            catch (Exception)
            {

            }

        }

        private void LoadLoanTable()
        {
            if (cboCustomers.SelectedIndex > -1)
            {
                int id = (int)cboCustomers.SelectedValue;
                loanList = adapter.GetAllLoans(id);
                dgvLoanItems.DataSource = null;
                dgvLoanItems.DataSource = loanList;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void PopulateCustomerComboBox()
        {
            customerList = adapter.GetAllCustomers();
            cboCustomers.DataSource = customerList;
            // without these lines the combo box will only display the object type, not the value
            // value member is found behind the scene, and display member will display whatever member the ID (value member) belongs to
            cboCustomers.ValueMember = "CustomerID";
            cboCustomers.DisplayMember = "FullName";
            cboCustomers.SelectedIndex = -1; // -1 is a blank entry, so it starts off empty

        }
        private void dgvLoanItems_DoubleClick(object sender, EventArgs e)
        {
            if (dgvLoanItems.Rows.Count > 0)
            {
                int index = dgvLoanItems.CurrentCell.RowIndex;
                frmReturn frm = new frmReturn(loanList[index]);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadLoanTable();
                }
    
            }
            
        }

        private void btnReturnAll_Click(object sender, EventArgs e)
        {
            if (loanList.Count > 0 && cboCustomers.SelectedIndex > -1 )
            {
                foreach (var loan in loanList)
                {
                    Loan currentLoan = adapter.GetLoanByID(loan.LoanID);
                    currentLoan.DateReturned = System.DateTime.Now;
                    adapter.SaveExistingLoan(currentLoan);

                    adapter.UpdateToolLoanStatus(currentLoan.ToolID, 0);
                    LoadLoanTable();

                    this.DialogResult = DialogResult.OK; // this closes the form, without this line the Loan table doesn't update
                }
            } 

            else
            {
                MessageBox.Show("Please select a customer and the appropriate tools before returning loans.", "Error Message");
            }

        }
    }
}

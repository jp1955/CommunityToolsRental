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
    public partial class frmReturn : Form
    {
        LoanView selectedLoan;
        Loan loanDetails; // use to hold the loanID and pass it back to frmLoanList
        Adapter adapter = new Adapter();

        // requires a LoanView to open
        public frmReturn(LoanView loan)
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Color;
            selectedLoan = loan; // store the currently selected loan from currentCellIndex method of the datagridview
            SetupLabel();
        }

        private void SetupLabel()
        {
            lblReturnPrompt2.Text = $"{selectedLoan.FirstName} {selectedLoan.LastName}: " +
                           $" {selectedLoan.ToolType} ";
            lblReturnPrompt.Text = "Return this loan?";

            txtReturnCondition.Text = selectedLoan.ToolCondition;
            txtReturnNotes.Text = selectedLoan.Notes;
        }

        private void btnReturnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoanReturn_Click(object sender, EventArgs e)
        {
            loanDetails = adapter.GetLoanByID(selectedLoan.LoanID);
            loanDetails.DateReturned = System.DateTime.Now;

            adapter.SaveExistingLoan(loanDetails);
            
            adapter.UpdateToolLoanStatus(updatedTool.ToolID,0);
            adapter.SaveToolAfterLoan(updatedTool);

            this.DialogResult = DialogResult.OKaaaaaa; // this closes the form
        }       
        //private void ReturnTool()
        //{
        //    if (AreTextFieldsCompleted())
        //    {
        //        customer.FirstName = txtFirstName.Text;
        //        customer.LastName = txtLastName.Text;
        //        customer.Phone = txtPhone.Text;

        //        if (isNew)
        //        {
        //            adapter.AddNewCustomer(customer);
        //        }
        //        else
        //        {
        //            adapter.SaveExistingCustomer(customer);
        //        }

        //        this.DialogResult = DialogResult.OK;
        //    } 
        //    else
        //    {
        //        MessageBox.Show("Please enter all fields before saving.");
        //    }
        //}
        private bool AreTextFieldsCompleted()
        {
            if (String.IsNullOrWhiteSpace(txtReturnCondition.Text))
            {  
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtReturnNotes.Text))
            {  
                return false;
            }
            return true;
        }
    }
}

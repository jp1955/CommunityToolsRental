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
    public partial class frmLoanList : Form
    {
        List<LoanView> loanList = new List<LoanView>();
        Adapter adapter = new Adapter();

        public frmLoanList()
        {
            InitializeComponent();            
            this.BackColor = Properties.Settings.Default.Color; // looks at the default setting of colour, changed from the button
            UpdateLoanTable();

        }

        private void UpdateLoanTable()
        {
            loanList = adapter.GetAllLoans();
            dgvLoans.DataSource = null;
            dgvLoans.DataSource = loanList;
            //dgvLoans.Columns["DateRented"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLoans.RowHeadersVisible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewTool_Click(object sender, EventArgs e)
        {
            frmNewLoan frm = new frmNewLoan();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                UpdateLoanTable(); // when Save is pressed it updates the loan list
                this.BackColor = Properties.Settings.Default.Color;
            }
        }

        private void btnLoanReturn_Click(object sender, EventArgs e)
        {
            if (dgvLoans.Rows.Count > 0)
            {
                // grab the currently highlighted cell to pass to the frmReturn
                int id = dgvLoans.CurrentCell.RowIndex;
                LoanView loan = loanList[id];
                if (loan.DateReturned == null)
                {
                    frmReturn frm = new frmReturn(loan);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        UpdateLoanTable(); // when Save is pressed it updates the loan list
                        this.BackColor = Properties.Settings.Default.Color;
                    }
                    return;
                }
                MessageBox.Show("This item has already been returned!");

            }
        }

        private void btnMultiLoan_Click(object sender, EventArgs e)
        {
            frmNewMultiLoan frm = new frmNewMultiLoan();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                UpdateLoanTable(); // so when we press OK to save on the multi loan form it updates the Loan List
            }

        }

        private void btnMultiReturn_Click(object sender, EventArgs e)
        {
            frmMultiReturn frm = new frmMultiReturn();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                UpdateLoanTable(); // so when we press OK to save on the multi loan form it updates the Loan List
            }

        }
    }
}

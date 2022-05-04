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
    public partial class frmNewLoan : Form
    {
        List<Customer> customerList = new List<Customer>();

        // if making a Tool Make list, need a tool make table (list)
        // List<ToolMake> toolMakeList = new List<ToolMake>();

        List<Tool> toolList = new List<Tool>();
        Adapter adapter = new Adapter();

        public frmNewLoan()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Color;
            PopulateCustomerComboBox();
            PopulateToolComboBox();
            SetupConditionAndNotes();
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

        private void PopulateToolComboBox()
        {
            toolList = adapter.GetToolStatus(1,0);
            cboTools.DataSource = toolList;
            cboTools.ValueMember = "ToolID";
            cboTools.DisplayMember = "FullToolDetails";
            cboTools.SelectedIndex = -1;
        }

        private int onLoan(bool loan)
        {
            if (loan)
            {
                return 1;
            } else
            {
                return 0;
            }
        }


        private void SetupConditionAndNotes()
        {
            txtNewLoanCondition.Text = "New";
            txtNewLoanNotes.Text = "None";
        }

        private void btnToolCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnToolSave_Click(object sender, EventArgs e)
        {
            if (cboCustomers.SelectedIndex > -1 && cboTools.SelectedIndex > -1)
            {
                Loan newLoan = new Loan();
                newLoan.ToolID = (int)cboTools.SelectedValue;
                newLoan.CustomerID = (int)cboCustomers.SelectedValue;
                newLoan.DateRented = System.DateTime.Now;

                // set the new loan condition and notes to the default from the textfields

                // how to grab condition from the existing tool? use GetSingleTool?
                //newLoan.Condition = txtNewLoanCondition.Text;
                //newLoan.Notes = txtNewLoanNotes.Text;
                adapter.AddNewLoan(newLoan);

                // save the updated tool to the table
                Tool updatedTool = new Tool();
                updatedTool.ToolID = (int)cboTools.SelectedValue;
                updatedTool.Active = true;
                adapter.UpdateToolLoanStatus(updatedTool.ToolID, 1);

                this.DialogResult = DialogResult.OK;
                return;
            }
            MessageBox.Show("Please pick all the fields before saving!");

        }
    }
}

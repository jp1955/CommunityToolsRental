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
    public partial class frmNewMultiLoan : Form
    {
        Adapter adapter = new Adapter();
        List<Customer> customerList;
        List<Tool> availableTools;
        List<Tool> selectedTools = new List<Tool>();
        public frmNewMultiLoan()
        {
            InitializeComponent();
            SetupComboxBox();
            SetupAvailableToolsTable();
            this.BackColor = Properties.Settings.Default.Color;
        }

        private void SetupAvailableToolsTable()
        {
            availableTools = adapter.GetToolStatus(1, 0);
            dgvAvailableTool.DataSource = availableTools;


            dgvAvailableTool.RowHeadersVisible = false;
            dgvAvailableTool.Columns["FullToolDetails"].Visible = false;
            dgvAvailableTool.Columns["displayToolStatus"].Visible = false;

            dgvSelectedTool.RowHeadersVisible = false;
            //dgvSelectedTool.Columns["FullToolDetails"].Visible = false;
            //dgvSelectedTool.Columns["displayToolStatus"].HeaderText = "Tool Status";
        }

        public void SetupComboxBox()
        {
            customerList = adapter.GetAllCustomers();
            cboCustomers.DataSource = customerList;
            cboCustomers.DisplayMember = "FullName"; // FullName property created in Customer Class
            cboCustomers.ValueMember = "CustomerID";
            cboCustomers.SelectedIndex = -1; // default to an empty selection
        }

        private void btnToolCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAvailableTool_DoubleClick(object sender, EventArgs e)
        {
            // check if list is not empty to be able to click on
            if (dgvAvailableTool.Rows.Count > 0)
            {
                int index = dgvAvailableTool.CurrentCell.RowIndex; // get position of where the entry is in the list
                selectedTools.Add(availableTools[index]); // add the tool to the other dgv
                availableTools.RemoveAt(index);
                RefreshDataTable();
            }
        }

        // to update the dgvs when we select it
        public void RefreshDataTable()
        {
            // put the item back to where it was instead of just adding it to the bottom of the list
            availableTools = availableTools.OrderBy(b => b.ToolID).ToList();

            dgvAvailableTool.DataSource = null;
            dgvAvailableTool.DataSource = availableTools;

            dgvSelectedTool.DataSource = null;
            dgvSelectedTool.DataSource = selectedTools;

        }

        private void dgvSelectedTool_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSelectedTool.Rows.Count > 0)
            {
                int index = dgvSelectedTool.CurrentCell.RowIndex; // get position of where the entry is in the list
                availableTools.Add(selectedTools[index]); // add the tool to the other dgv
                selectedTools.RemoveAt(index);
                RefreshDataTable();
            }
        }
        private void btnMultiLoanAdd_Click(object sender, EventArgs e)
        {
            if (dgvAvailableTool.Rows.Count > 0)
            {
                int index = dgvAvailableTool.CurrentCell.RowIndex; // get position of where the entry is in the list
                selectedTools.Add(availableTools[index]); // add the tool to the other dgv
                availableTools.RemoveAt(index);
                RefreshDataTable();
            }
        }

        private void btnMultiLoanDelete_Click(object sender, EventArgs e)
        {
            if (dgvSelectedTool.Rows.Count > 0)
            {
                int index = dgvSelectedTool.CurrentCell.RowIndex; // get position of where the entry is in the list
                availableTools.Add(selectedTools[index]); // add the tool to the other dgv
                selectedTools.RemoveAt(index);
                RefreshDataTable();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboCustomers.SelectedIndex > -1 && dgvSelectedTool.Rows.Count > 0)
            {
                Loan newLoan = new Loan();
                newLoan.CustomerID = (int)cboCustomers.SelectedValue;
                newLoan.DateRented = System.DateTime.Now;
                foreach (var tool in selectedTools)
                {
                    newLoan.ToolID = tool.ToolID;
                    adapter.AddNewLoan(newLoan);

                    adapter.UpdateToolLoanStatus(tool.ToolID,1); // using method overloading
                }
                this.DialogResult = DialogResult.OK;
                return;
            }

            MessageBox.Show("Please check customers and tools to loan have been selected.", "Error Message");
        }
    }
}

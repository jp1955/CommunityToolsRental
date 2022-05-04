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
    public partial class frmToolDetails : Form
    {
        // create a list and an adapter to use
        Tool tool = new Tool(); // need a tool object to hold details of the double click item
        List<Tool> toolList = new List<Tool>();
        Adapter adapter = new Adapter();
        bool isNew = true;
        public frmToolDetails()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Color;
            cBoxRetire.Enabled = false;
        }

        // existing tool constructor
        public frmToolDetails(int id)
        {
            InitializeComponent();
            isNew = false;
            ShowExistingToolDetails(id);
            this.BackColor = Properties.Settings.Default.Color;
        }

        private void btnToolCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ShowExistingToolDetails(int id)
        {
            tool = adapter.GetSingleToolDetails(id);
            txtToolID.Text = tool.ToolID.ToString();
            txtActive.Text = tool.Active.ToString();
            txtRented.Text = tool.Rented.ToString();
            if (tool.Active == false)
            {
                cBoxRetire.Checked = true;
            }
            txtToolType.Text = tool.ToolType;
            txtToolMake.Text = tool.ToolMake;
            txtToolCondition.Text = tool.ToolCondition;
            txtToolDescription.Text = tool.Notes;
        }

        private void btnToolSave_Click(object sender, EventArgs e)
        {
            SaveNewTool();
        }

        private void SaveNewTool()
        {
            if (AreTextFieldsCompleted())
            {
                tool.ToolType = txtToolType.Text;
                tool.ToolMake = txtToolMake.Text;
                tool.ToolCondition = txtToolCondition.Text;
                tool.Notes = txtToolDescription.Text;

                if (isNew) // check if its a new tool or existing tool, isNew starts out true by default and only becomes false if a tool is double clicked
                {
                    tool.Active = true;
                    adapter.AddNewTool(tool);
                }
                else
                {
                    if (cBoxRetire.Checked == true)
                    {
                        adapter.UpdateToolActiveStatus(0, tool);
                    } else
                    {
                        adapter.UpdateToolActiveStatus(1, tool);
                    }
                    adapter.SaveExistingTool(tool);
                }
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please enter all fields before saving.");
            }

        }

        private bool AreTextFieldsCompleted()
        {
            if (String.IsNullOrWhiteSpace(txtToolType.Text))
            {
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtToolMake.Text))
            {
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtToolCondition.Text))
            {
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtToolDescription.Text))
            {
                return false;
            }
            return true;
        }
    }
}


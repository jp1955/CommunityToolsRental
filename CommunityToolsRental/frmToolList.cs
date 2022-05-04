using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataManagement;

namespace CommunityToolsRental
{
    public partial class frmToolList : Form
    {
        
        List<Tool> toolList = new List<Tool>();
        List<Tool> filteredList = new List<Tool>();
        List<Tool> viewList = new List<Tool>();
        Adapter adapter = new Adapter();

        // 3 list to hold tools for a filter to display
        List<Tool> availableTools = new List<Tool>();
        List<Tool> loanedTools = new List<Tool>();
        List<Tool> activeTools = new List<Tool>();
        List<Tool> retiredTools = new List<Tool>();

        public frmToolList()
        {
            InitializeComponent();
            SetupToolTable();
            SetupFilterList();
            this.BackColor = Properties.Settings.Default.Color;


        }

        #region Setup and Update table
        private void SetupToolTable()
        {
            toolList = adapter.GetAllTools(); // call the method from Adapter class that uses a SQL command
            dgvTools.DataSource = null;
            dgvTools.DataSource = toolList;
            dgvTools.Columns["FullToolDetails"].Visible = false;
            //dgvTools.Columns["Active"].Visible = false; // irrelavant column
            dgvTools.Columns["displayToolStatus"].HeaderText = "Tool Status";

            cboFilter.SelectedIndex = 0; // default the selection to "All"

        }
        private void UpdateToolTable()
        {
            dgvTools.DataSource = null;
            dgvTools.DataSource = viewList; // viewList is used as an updated list, so anytime something changes make viewList = newChangedList;

            // need these in SetupToolTable() and UpdateToolTable() 
            dgvTools.Columns["FullToolDetails"].Visible = false;
            dgvTools.Columns["displayToolStatus"].Visible = false;

        }


        private void SetupFilterList()
        {
            availableTools.Clear();
            loanedTools.Clear();
            activeTools.Clear();
            retiredTools.Clear();

            // Add tools to appropriate list to use for the filter
            foreach (Tool tool in toolList)
            {
                if (tool.Rented == false && tool.Active == true)
                {
                    availableTools.Add(tool);
                }

                if (tool.Rented == true)
                {
                    loanedTools.Add(tool);
                }

                if (tool.Active == true)
                {
                    activeTools.Add(tool);
                }

                if (tool.ToolCondition.Equals("Retired"))
                {
                    retiredTools.Add(tool);
                }

            }
        }

        #endregion

        private void FilterListAndDisplay()
        {
            filteredList.Clear();
            if (String.IsNullOrWhiteSpace(txtSearch.Text)) // if search is empty than viewList just == the default toolList that gets loaded on startup
            {
                viewList = toolList; // the only list that gets called from UpdateToolTable()
                UpdateToolTable();
                return;
            }

            foreach (var tool in toolList)
            {
                bool isMatching = true;

                // check for both tool type and tool make
                if (tool.ToolType.IndexOf(txtSearch.Text,
                    StringComparison.OrdinalIgnoreCase) == -1 && tool.ToolMake.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) == -1)
                {
                    isMatching = false;
                }

                if (isMatching)
                {
                    filteredList.Add(tool);
                }
            }
            viewList = filteredList;
            UpdateToolTable();

        }

        #region Buttons and Combo Boxes
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewTool_Click(object sender, EventArgs e)
        {
            frmToolDetails frm = new frmToolDetails();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                SetupToolTable();
                SetupFilterList();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterListAndDisplay();
        }

        private void dgvTools_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)dgvTools["ToolID", dgvTools.CurrentCell.RowIndex].Value;
            frmToolDetails frm = new frmToolDetails(id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                SetupToolTable();
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cboFilter.SelectedItem == "Available")
            {
                dgvTools.DataSource = null;
                viewList = availableTools;
                UpdateToolTable();
            }

            if (cboFilter.SelectedItem == "Loaned")
            {
                dgvTools.DataSource = null;
                viewList = loanedTools;
                UpdateToolTable();
            }

            if (cboFilter.SelectedItem == "Active")
            {
                dgvTools.DataSource = null;
                viewList = activeTools;
                UpdateToolTable();
            }


            if (cboFilter.SelectedItem == "Retired")
            {
                dgvTools.DataSource = null;
                viewList = retiredTools;
                UpdateToolTable();
            }

            if (cboFilter.SelectedItem == "All")
            {
                dgvTools.DataSource = null;
                viewList = toolList;
                UpdateToolTable();
            }

        }

        private void btnSaveToCSV_Click(object sender, EventArgs e)
        {
            {
                //SaveFileDialog save = new SaveFileDialog();
                //save.Filter =   "Plain Text File(*.txt)|*.txt|" +
                //                "Comma Separated Values(*.csv)|*.csv|" +
                //                "Image File(*.JPEG; *.jpeg; *MP4)|*.JPEG; *.jpeg; *MP4";
                //save.OverwritePrompt = true;


                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // need a write version for each option in the Combo Box (all, available, active, rented, retired)
                    if (cboFilter.SelectedItem == "All") {
                        var filePath = saveDialog.FileName;

                        using (StreamWriter write = new StreamWriter(filePath))
                        {
                            // write the headers first

                            string header = "Tool ID, Active, Rented, Tool Type, Tool Make, Tool ToolCondition, Notes";
                            write.WriteLine(header);

                            foreach (var tool in viewList)
                            {
                                string line = $"{tool.ToolID}, {(bool)tool.Active}, {(bool)tool.Rented}, {tool.ToolType}, {tool.ToolMake}, {tool.ToolCondition}, {tool.Notes}";
                                write.WriteLine(line);
                            }
                        }
                    }
                    if (cboFilter.SelectedItem == "Available") {
                        var filePath = saveDialog.FileName;

                        using (StreamWriter write = new StreamWriter(filePath))
                        {
                            string header = "Tool ID, Active, Rented, Tool Type, Tool Make, Tool ToolCondition, Notes";
                            write.WriteLine(header);

                            foreach (var tool in viewList)
                            {
                                if (tool.Active == true && tool.Rented == false)
                                {
                                    string line = $"{tool.ToolID}, {(bool)tool.Active}, {(bool)tool.Rented}, {tool.ToolType}, {tool.ToolMake}, {tool.ToolCondition}, {tool.Notes}";
                                    write.WriteLine(line);
                                }
                            }
                        }
                    }

                    if (cboFilter.SelectedItem == "Loaned") {
                        var filePath = saveDialog.FileName;

                        using (StreamWriter write = new StreamWriter(filePath))
                        {
                            // write the headers first

                            string header = "Tool ID, Active, Rented, Tool Type, Tool Make, Tool ToolCondition, Notes";
                            write.WriteLine(header);

                            foreach (var tool in viewList)
                            {
                                if (tool.Active == true && tool.Rented == true)
                                {
                                    string line = $"{tool.ToolID}, {(bool)tool.Active}, {(bool)tool.Rented}, {tool.ToolType}, {tool.ToolMake}, {tool.ToolCondition}, {tool.Notes}";
                                    write.WriteLine(line);
                                }
                            }
                        }
                    }

                    if (cboFilter.SelectedItem == "Active") {
                        var filePath = saveDialog.FileName;

                        using (StreamWriter write = new StreamWriter(filePath))
                        {
                            // write the headers first

                            string header = "Tool ID, Active, Rented, Tool Type, Tool Make, Tool ToolCondition, Notes";
                            write.WriteLine(header);

                            foreach (var tool in viewList)
                            {
                                if (tool.Active == true)
                                {
                                    string line = $"{tool.ToolID}, {(bool)tool.Active}, {(bool)tool.Rented}, {tool.ToolType}, {tool.ToolMake}, {tool.ToolCondition}, {tool.Notes}";
                                    write.WriteLine(line);
                                }
                            }
                        }
                    }

                    if (cboFilter.SelectedItem == "Retired") {
                        var filePath = saveDialog.FileName;

                        using (StreamWriter write = new StreamWriter(filePath))
                        {
                            // write the headers first

                            string header = "Tool ID, Active, Rented, Tool Type, Tool Make, Tool ToolCondition, Notes";
                            write.WriteLine(header);

                            foreach (var tool in viewList)
                            {
                                if (tool.Active == false)
                                {
                                    string line = $"{tool.ToolID}, {(bool)tool.Active}, {(bool)tool.Rented}, {tool.ToolType}, {tool.ToolMake}, {tool.ToolCondition}, {tool.Notes}";
                                    write.WriteLine(line);
                                }
                            }
                        }
                    }
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // don't delete if dgv is already empty
            if (dgvTools.Rows.Count > 0)
            {
                // grabs the current customer highlighted
                int id = (int)dgvTools["ToolID", dgvTools.CurrentCell.RowIndex].Value;

                // store the yes or no result from the message box to pass it somewhere
                MessageBox.Show("Do you want to delete this tool?", "Delete Confirmation", MessageBoxButtons.YesNo);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this tool? There might be loans associated with this tool right now.", "Delete Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    adapter.DeleteSingleTool(id);
                    SetupToolTable();
                    SetupFilterList();
                }
            }
        }
        #endregion
    }
}

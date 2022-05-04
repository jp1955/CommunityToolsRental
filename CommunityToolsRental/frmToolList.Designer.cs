
namespace CommunityToolsRental
{
    partial class frmToolList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnNewTool = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvTools = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolsRentalDBDataSet = new CommunityToolsRental.ToolsRentalDBDataSet();
            this.toolsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.btnSaveToCSV = new System.Windows.Forms.Button();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsRentalDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewTool
            // 
            this.btnNewTool.Location = new System.Drawing.Point(12, 386);
            this.btnNewTool.Name = "btnNewTool";
            this.btnNewTool.Size = new System.Drawing.Size(107, 42);
            this.btnNewTool.TabIndex = 8;
            this.btnNewTool.Text = "New Tool";
            this.btnNewTool.UseVisualStyleBackColor = true;
            this.btnNewTool.Click += new System.EventHandler(this.btnNewTool_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(460, 473);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 42);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvTools
            // 
            this.dgvTools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTools.Location = new System.Drawing.Point(12, 50);
            this.dgvTools.Name = "dgvTools";
            this.dgvTools.Size = new System.Drawing.Size(555, 330);
            this.dgvTools.TabIndex = 5;
            this.dgvTools.DoubleClick += new System.EventHandler(this.dgvTools_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filter";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(78, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(149, 20);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 72);
            this.label3.TabIndex = 53;
            this.label3.Text = "Double click on an entry to edit tool details.\r\nTo retire a tool, double click on" +
    " a tool and check\r\n\"Retire Tool\" box.";
            // 
            // toolsRentalDBDataSet
            // 
            this.toolsRentalDBDataSet.DataSetName = "ToolsRentalDBDataSet";
            this.toolsRentalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolsBindingSource
            // 
            this.toolsBindingSource.DataMember = "Tools";
            this.toolsBindingSource.DataSource = this.toolsRentalDBDataSet;
            // 
            // cboFilter
            // 
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Items.AddRange(new object[] {
            "All",
            "Available",
            "Loaned",
            "Active",
            "Retired"});
            this.cboFilter.Location = new System.Drawing.Point(428, 13);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(121, 21);
            this.cboFilter.TabIndex = 55;
            this.cboFilter.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // btnSaveToCSV
            // 
            this.btnSaveToCSV.Location = new System.Drawing.Point(330, 386);
            this.btnSaveToCSV.Name = "btnSaveToCSV";
            this.btnSaveToCSV.Size = new System.Drawing.Size(124, 42);
            this.btnSaveToCSV.TabIndex = 56;
            this.btnSaveToCSV.Text = "Save To CSV";
            this.btnSaveToCSV.UseVisualStyleBackColor = true;
            this.btnSaveToCSV.Click += new System.EventHandler(this.btnSaveToCSV_Click);
            // 
            // saveDialog
            // 
            this.saveDialog.DefaultExt = "csv";
            this.saveDialog.Filter = "Comma Separated Values(*.csv)|*.csv";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(460, 386);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 42);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmToolList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 527);
            this.Controls.Add(this.btnSaveToCSV);
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewTool);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvTools);
            this.Name = "frmToolList";
            this.Text = "Tool List";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsRentalDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewTool;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvTools;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource toolsBindingSource;
        private ToolsRentalDBDataSet toolsRentalDBDataSet;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.Button btnSaveToCSV;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.Button btnDelete;
    }
}
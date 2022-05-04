
namespace CommunityToolsRental
{
    partial class frmNewMultiLoan
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
            this.cboCustomers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAvailableTool = new System.Windows.Forms.DataGridView();
            this.dgvSelectedTool = new System.Windows.Forms.DataGridView();
            this.btnMultiLoanAdd = new System.Windows.Forms.Button();
            this.btnToolCancel = new System.Windows.Forms.Button();
            this.btnMultiLoanDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedTool)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCustomers
            // 
            this.cboCustomers.FormattingEnabled = true;
            this.cboCustomers.Location = new System.Drawing.Point(366, 26);
            this.cboCustomers.Name = "cboCustomers";
            this.cboCustomers.Size = new System.Drawing.Size(153, 21);
            this.cboCustomers.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label1.Location = new System.Drawing.Point(243, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Customer";
            // 
            // dgvAvailableTool
            // 
            this.dgvAvailableTool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableTool.Location = new System.Drawing.Point(12, 95);
            this.dgvAvailableTool.Name = "dgvAvailableTool";
            this.dgvAvailableTool.Size = new System.Drawing.Size(326, 261);
            this.dgvAvailableTool.TabIndex = 40;
            this.dgvAvailableTool.DoubleClick += new System.EventHandler(this.dgvAvailableTool_DoubleClick);
            // 
            // dgvSelectedTool
            // 
            this.dgvSelectedTool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedTool.Location = new System.Drawing.Point(385, 95);
            this.dgvSelectedTool.Name = "dgvSelectedTool";
            this.dgvSelectedTool.Size = new System.Drawing.Size(362, 261);
            this.dgvSelectedTool.TabIndex = 41;
            this.dgvSelectedTool.DoubleClick += new System.EventHandler(this.dgvSelectedTool_DoubleClick);
            // 
            // btnMultiLoanAdd
            // 
            this.btnMultiLoanAdd.Location = new System.Drawing.Point(12, 377);
            this.btnMultiLoanAdd.Name = "btnMultiLoanAdd";
            this.btnMultiLoanAdd.Size = new System.Drawing.Size(70, 31);
            this.btnMultiLoanAdd.TabIndex = 43;
            this.btnMultiLoanAdd.Text = "Add";
            this.btnMultiLoanAdd.UseVisualStyleBackColor = true;
            this.btnMultiLoanAdd.Click += new System.EventHandler(this.btnMultiLoanAdd_Click);
            // 
            // btnToolCancel
            // 
            this.btnToolCancel.Location = new System.Drawing.Point(657, 507);
            this.btnToolCancel.Name = "btnToolCancel";
            this.btnToolCancel.Size = new System.Drawing.Size(107, 42);
            this.btnToolCancel.TabIndex = 42;
            this.btnToolCancel.Text = "Cancel";
            this.btnToolCancel.UseVisualStyleBackColor = true;
            this.btnToolCancel.Click += new System.EventHandler(this.btnToolCancel_Click);
            // 
            // btnMultiLoanDelete
            // 
            this.btnMultiLoanDelete.Location = new System.Drawing.Point(694, 377);
            this.btnMultiLoanDelete.Name = "btnMultiLoanDelete";
            this.btnMultiLoanDelete.Size = new System.Drawing.Size(70, 31);
            this.btnMultiLoanDelete.TabIndex = 44;
            this.btnMultiLoanDelete.Text = "Delete";
            this.btnMultiLoanDelete.UseVisualStyleBackColor = true;
            this.btnMultiLoanDelete.Click += new System.EventHandler(this.btnMultiLoanDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label2.Location = new System.Drawing.Point(129, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Available";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label3.Location = new System.Drawing.Point(533, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Selected";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(537, 507);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 42);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(476, 48);
            this.label4.TabIndex = 54;
            this.label4.Text = "Double click on a tool or click the \"Add\" button\r\nto move it into the selected bo" +
    "x then click save to loan it.";
            // 
            // frmNewMultiLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMultiLoanDelete);
            this.Controls.Add(this.btnMultiLoanAdd);
            this.Controls.Add(this.btnToolCancel);
            this.Controls.Add(this.dgvSelectedTool);
            this.Controls.Add(this.dgvAvailableTool);
            this.Controls.Add(this.cboCustomers);
            this.Controls.Add(this.label1);
            this.Name = "frmNewMultiLoan";
            this.Text = "Multi-Loan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedTool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAvailableTool;
        private System.Windows.Forms.DataGridView dgvSelectedTool;
        private System.Windows.Forms.Button btnMultiLoanAdd;
        private System.Windows.Forms.Button btnToolCancel;
        private System.Windows.Forms.Button btnMultiLoanDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
    }
}
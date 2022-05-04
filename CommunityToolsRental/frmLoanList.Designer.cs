
namespace CommunityToolsRental
{
    partial class frmLoanList
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
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.btnMultiLoan = new System.Windows.Forms.Button();
            this.btnMultiReturn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(460, 473);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 42);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvLoans
            // 
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Location = new System.Drawing.Point(12, 12);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.Size = new System.Drawing.Size(555, 330);
            this.dgvLoans.TabIndex = 9;
            // 
            // btnMultiLoan
            // 
            this.btnMultiLoan.Location = new System.Drawing.Point(12, 360);
            this.btnMultiLoan.Name = "btnMultiLoan";
            this.btnMultiLoan.Size = new System.Drawing.Size(107, 42);
            this.btnMultiLoan.TabIndex = 14;
            this.btnMultiLoan.Text = "Multi-Loan";
            this.btnMultiLoan.UseVisualStyleBackColor = true;
            this.btnMultiLoan.Click += new System.EventHandler(this.btnMultiLoan_Click);
            // 
            // btnMultiReturn
            // 
            this.btnMultiReturn.Location = new System.Drawing.Point(460, 360);
            this.btnMultiReturn.Name = "btnMultiReturn";
            this.btnMultiReturn.Size = new System.Drawing.Size(107, 42);
            this.btnMultiReturn.TabIndex = 15;
            this.btnMultiReturn.Text = "Multi-Return";
            this.btnMultiReturn.UseVisualStyleBackColor = true;
            this.btnMultiReturn.Click += new System.EventHandler(this.btnMultiReturn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 40);
            this.label3.TabIndex = 54;
            this.label3.Text = "NOTE: Damaged returns must be returned individually\r\n and add a condition";
            // 
            // frmLoanList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 527);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMultiReturn);
            this.Controls.Add(this.btnMultiLoan);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvLoans);
            this.Name = "frmLoanList";
            this.Text = "Loan List";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.Button btnMultiLoan;
        private System.Windows.Forms.Button btnMultiReturn;
        private System.Windows.Forms.Label label3;
    }
}
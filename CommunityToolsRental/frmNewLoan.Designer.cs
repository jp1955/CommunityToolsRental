
namespace CommunityToolsRental
{
    partial class frmNewLoan
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
            this.btnToolSave = new System.Windows.Forms.Button();
            this.btnToolCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCustomers = new System.Windows.Forms.ComboBox();
            this.cboTools = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewLoanCondition = new System.Windows.Forms.TextBox();
            this.txtNewLoanNotes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnToolSave
            // 
            this.btnToolSave.Location = new System.Drawing.Point(12, 367);
            this.btnToolSave.Name = "btnToolSave";
            this.btnToolSave.Size = new System.Drawing.Size(107, 42);
            this.btnToolSave.TabIndex = 30;
            this.btnToolSave.Text = "Save";
            this.btnToolSave.UseVisualStyleBackColor = true;
            this.btnToolSave.Click += new System.EventHandler(this.btnToolSave_Click);
            // 
            // btnToolCancel
            // 
            this.btnToolCancel.Location = new System.Drawing.Point(187, 367);
            this.btnToolCancel.Name = "btnToolCancel";
            this.btnToolCancel.Size = new System.Drawing.Size(107, 42);
            this.btnToolCancel.TabIndex = 29;
            this.btnToolCancel.Text = "Cancel";
            this.btnToolCancel.UseVisualStyleBackColor = true;
            this.btnToolCancel.Click += new System.EventHandler(this.btnToolCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tool";
            // 
            // cboCustomers
            // 
            this.cboCustomers.FormattingEnabled = true;
            this.cboCustomers.Location = new System.Drawing.Point(141, 12);
            this.cboCustomers.Name = "cboCustomers";
            this.cboCustomers.Size = new System.Drawing.Size(153, 21);
            this.cboCustomers.TabIndex = 37;
            // 
            // cboTools
            // 
            this.cboTools.FormattingEnabled = true;
            this.cboTools.Location = new System.Drawing.Point(141, 53);
            this.cboTools.Name = "cboTools";
            this.cboTools.Size = new System.Drawing.Size(153, 21);
            this.cboTools.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "ToolCondition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Notes";
            // 
            // txtNewLoanCondition
            // 
            this.txtNewLoanCondition.Location = new System.Drawing.Point(141, 99);
            this.txtNewLoanCondition.Name = "txtNewLoanCondition";
            this.txtNewLoanCondition.Size = new System.Drawing.Size(153, 20);
            this.txtNewLoanCondition.TabIndex = 43;
            // 
            // txtNewLoanNotes
            // 
            this.txtNewLoanNotes.Location = new System.Drawing.Point(141, 143);
            this.txtNewLoanNotes.Name = "txtNewLoanNotes";
            this.txtNewLoanNotes.Size = new System.Drawing.Size(153, 152);
            this.txtNewLoanNotes.TabIndex = 44;
            this.txtNewLoanNotes.Text = "";
            // 
            // frmNewLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 421);
            this.Controls.Add(this.txtNewLoanNotes);
            this.Controls.Add(this.txtNewLoanCondition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTools);
            this.Controls.Add(this.cboCustomers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnToolSave);
            this.Controls.Add(this.btnToolCancel);
            this.Name = "frmNewLoan";
            this.Text = "New Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnToolSave;
        private System.Windows.Forms.Button btnToolCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCustomers;
        private System.Windows.Forms.ComboBox cboTools;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewLoanCondition;
        private System.Windows.Forms.RichTextBox txtNewLoanNotes;
    }
}

namespace CommunityToolsRental
{
    partial class frmReturn
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
            this.txtReturnNotes = new System.Windows.Forms.TextBox();
            this.lblReturnPrompt2 = new System.Windows.Forms.Label();
            this.btnLoanReturn = new System.Windows.Forms.Button();
            this.btnReturnClose = new System.Windows.Forms.Button();
            this.lblReturnPrompt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReturnCondition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtReturnNotes
            // 
            this.txtReturnNotes.Location = new System.Drawing.Point(16, 178);
            this.txtReturnNotes.Multiline = true;
            this.txtReturnNotes.Name = "txtReturnNotes";
            this.txtReturnNotes.Size = new System.Drawing.Size(364, 136);
            this.txtReturnNotes.TabIndex = 2;
            // 
            // lblReturnPrompt2
            // 
            this.lblReturnPrompt2.AutoSize = true;
            this.lblReturnPrompt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblReturnPrompt2.Location = new System.Drawing.Point(12, 42);
            this.lblReturnPrompt2.Name = "lblReturnPrompt2";
            this.lblReturnPrompt2.Size = new System.Drawing.Size(51, 20);
            this.lblReturnPrompt2.TabIndex = 3;
            this.lblReturnPrompt2.Text = "label1";
            // 
            // btnLoanReturn
            // 
            this.btnLoanReturn.Location = new System.Drawing.Point(12, 345);
            this.btnLoanReturn.Name = "btnLoanReturn";
            this.btnLoanReturn.Size = new System.Drawing.Size(107, 42);
            this.btnLoanReturn.TabIndex = 14;
            this.btnLoanReturn.Text = "Return";
            this.btnLoanReturn.UseVisualStyleBackColor = true;
            this.btnLoanReturn.Click += new System.EventHandler(this.btnLoanReturn_Click);
            // 
            // btnReturnClose
            // 
            this.btnReturnClose.Location = new System.Drawing.Point(285, 345);
            this.btnReturnClose.Name = "btnReturnClose";
            this.btnReturnClose.Size = new System.Drawing.Size(107, 42);
            this.btnReturnClose.TabIndex = 0;
            this.btnReturnClose.Text = "Close";
            this.btnReturnClose.UseVisualStyleBackColor = true;
            this.btnReturnClose.Click += new System.EventHandler(this.btnReturnClose_Click);
            // 
            // lblReturnPrompt
            // 
            this.lblReturnPrompt.AutoSize = true;
            this.lblReturnPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblReturnPrompt.Location = new System.Drawing.Point(152, 9);
            this.lblReturnPrompt.Name = "lblReturnPrompt";
            this.lblReturnPrompt.Size = new System.Drawing.Size(51, 20);
            this.lblReturnPrompt.TabIndex = 15;
            this.lblReturnPrompt.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "ToolCondition";
            // 
            // txtReturnCondition
            // 
            this.txtReturnCondition.Location = new System.Drawing.Point(135, 98);
            this.txtReturnCondition.Name = "txtReturnCondition";
            this.txtReturnCondition.Size = new System.Drawing.Size(245, 20);
            this.txtReturnCondition.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Notes";
            // 
            // frmReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 399);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReturnCondition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblReturnPrompt);
            this.Controls.Add(this.btnLoanReturn);
            this.Controls.Add(this.lblReturnPrompt2);
            this.Controls.Add(this.txtReturnNotes);
            this.Controls.Add(this.btnReturnClose);
            this.Name = "frmReturn";
            this.Text = "Return";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtReturnNotes;
        private System.Windows.Forms.Label lblReturnPrompt2;
        private System.Windows.Forms.Button btnLoanReturn;
        private System.Windows.Forms.Button btnReturnClose;
        private System.Windows.Forms.Label lblReturnPrompt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReturnCondition;
        private System.Windows.Forms.Label label2;
    }
}
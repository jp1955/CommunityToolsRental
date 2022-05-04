
namespace CommunityToolsRental
{
    partial class frmRentalList
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRentalClose = new System.Windows.Forms.Button();
            this.dgvTools = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTools)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(460, 348);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 42);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRentalClose
            // 
            this.btnRentalClose.Location = new System.Drawing.Point(460, 473);
            this.btnRentalClose.Name = "btnRentalClose";
            this.btnRentalClose.Size = new System.Drawing.Size(107, 42);
            this.btnRentalClose.TabIndex = 10;
            this.btnRentalClose.Text = "Close";
            this.btnRentalClose.UseVisualStyleBackColor = true;
            // 
            // dgvTools
            // 
            this.dgvTools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTools.Location = new System.Drawing.Point(12, 12);
            this.dgvTools.Name = "dgvTools";
            this.dgvTools.Size = new System.Drawing.Size(555, 330);
            this.dgvTools.TabIndex = 9;
            // 
            // frmRentalList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 527);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRentalClose);
            this.Controls.Add(this.dgvTools);
            this.Name = "frmRentalList";
            this.Text = "Rental List";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTools)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRentalClose;
        private System.Windows.Forms.DataGridView dgvTools;
    }
}
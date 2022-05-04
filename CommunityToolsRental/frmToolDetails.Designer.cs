
namespace CommunityToolsRental
{
    partial class frmToolDetails
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToolMake = new System.Windows.Forms.TextBox();
            this.txtToolType = new System.Windows.Forms.TextBox();
            this.txtToolID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtToolCondition = new System.Windows.Forms.TextBox();
            this.txtToolDescription = new System.Windows.Forms.RichTextBox();
            this.btnToolSave = new System.Windows.Forms.Button();
            this.btnToolCancel = new System.Windows.Forms.Button();
            this.txtActive = new System.Windows.Forms.TextBox();
            this.txtRented = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cBoxRetire = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label4.Location = new System.Drawing.Point(10, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tool Make";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label3.Location = new System.Drawing.Point(10, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tool Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Active";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tool ID";
            // 
            // txtToolMake
            // 
            this.txtToolMake.Location = new System.Drawing.Point(139, 165);
            this.txtToolMake.Name = "txtToolMake";
            this.txtToolMake.Size = new System.Drawing.Size(159, 20);
            this.txtToolMake.TabIndex = 17;
            // 
            // txtToolType
            // 
            this.txtToolType.Location = new System.Drawing.Point(139, 126);
            this.txtToolType.Name = "txtToolType";
            this.txtToolType.Size = new System.Drawing.Size(159, 20);
            this.txtToolType.TabIndex = 16;
            // 
            // txtToolID
            // 
            this.txtToolID.Location = new System.Drawing.Point(139, 9);
            this.txtToolID.Name = "txtToolID";
            this.txtToolID.ReadOnly = true;
            this.txtToolID.Size = new System.Drawing.Size(159, 20);
            this.txtToolID.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label5.Location = new System.Drawing.Point(10, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Notes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label6.Location = new System.Drawing.Point(10, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "ToolCondition";
            // 
            // txtToolCondition
            // 
            this.txtToolCondition.Location = new System.Drawing.Point(139, 204);
            this.txtToolCondition.Name = "txtToolCondition";
            this.txtToolCondition.Size = new System.Drawing.Size(159, 20);
            this.txtToolCondition.TabIndex = 22;
            // 
            // txtToolDescription
            // 
            this.txtToolDescription.Location = new System.Drawing.Point(140, 243);
            this.txtToolDescription.Name = "txtToolDescription";
            this.txtToolDescription.Size = new System.Drawing.Size(157, 114);
            this.txtToolDescription.TabIndex = 26;
            this.txtToolDescription.Text = "";
            // 
            // btnToolSave
            // 
            this.btnToolSave.Location = new System.Drawing.Point(17, 399);
            this.btnToolSave.Name = "btnToolSave";
            this.btnToolSave.Size = new System.Drawing.Size(107, 42);
            this.btnToolSave.TabIndex = 28;
            this.btnToolSave.Text = "Save";
            this.btnToolSave.UseVisualStyleBackColor = true;
            this.btnToolSave.Click += new System.EventHandler(this.btnToolSave_Click);
            // 
            // btnToolCancel
            // 
            this.btnToolCancel.Location = new System.Drawing.Point(187, 398);
            this.btnToolCancel.Name = "btnToolCancel";
            this.btnToolCancel.Size = new System.Drawing.Size(107, 42);
            this.btnToolCancel.TabIndex = 27;
            this.btnToolCancel.Text = "Cancel";
            this.btnToolCancel.UseVisualStyleBackColor = true;
            this.btnToolCancel.Click += new System.EventHandler(this.btnToolCancel_Click);
            // 
            // txtActive
            // 
            this.txtActive.Location = new System.Drawing.Point(139, 48);
            this.txtActive.Name = "txtActive";
            this.txtActive.ReadOnly = true;
            this.txtActive.Size = new System.Drawing.Size(159, 20);
            this.txtActive.TabIndex = 29;
            // 
            // txtRented
            // 
            this.txtRented.Location = new System.Drawing.Point(139, 87);
            this.txtRented.Name = "txtRented";
            this.txtRented.ReadOnly = true;
            this.txtRented.Size = new System.Drawing.Size(159, 20);
            this.txtRented.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label7.Location = new System.Drawing.Point(10, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Rented";
            // 
            // cBoxRetire
            // 
            this.cBoxRetire.AutoSize = true;
            this.cBoxRetire.Location = new System.Drawing.Point(46, 340);
            this.cBoxRetire.Name = "cBoxRetire";
            this.cBoxRetire.Size = new System.Drawing.Size(78, 17);
            this.cBoxRetire.TabIndex = 32;
            this.cBoxRetire.Text = "Retire Tool";
            this.cBoxRetire.UseVisualStyleBackColor = true;
            // 
            // frmToolDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 453);
            this.Controls.Add(this.cBoxRetire);
            this.Controls.Add(this.txtRented);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtActive);
            this.Controls.Add(this.btnToolSave);
            this.Controls.Add(this.btnToolCancel);
            this.Controls.Add(this.txtToolDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtToolCondition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToolMake);
            this.Controls.Add(this.txtToolType);
            this.Controls.Add(this.txtToolID);
            this.Name = "frmToolDetails";
            this.Text = "Tool Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToolMake;
        private System.Windows.Forms.TextBox txtToolType;
        private System.Windows.Forms.TextBox txtToolID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtToolCondition;
        private System.Windows.Forms.RichTextBox txtToolDescription;
        private System.Windows.Forms.Button btnToolSave;
        private System.Windows.Forms.Button btnToolCancel;
        private System.Windows.Forms.TextBox txtActive;
        private System.Windows.Forms.TextBox txtRented;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cBoxRetire;
    }
}

namespace CommunityToolsRental
{
    partial class frmSettings
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
            this.btnColor = new System.Windows.Forms.Button();
            this.btnSettingsClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(75, 97);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(206, 67);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "Set Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnSettingsClose
            // 
            this.btnSettingsClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSettingsClose.Location = new System.Drawing.Point(234, 392);
            this.btnSettingsClose.Name = "btnSettingsClose";
            this.btnSettingsClose.Size = new System.Drawing.Size(107, 42);
            this.btnSettingsClose.TabIndex = 4;
            this.btnSettingsClose.Text = "Close";
            this.btnSettingsClose.UseVisualStyleBackColor = true;
            this.btnSettingsClose.Click += new System.EventHandler(this.btnSettingsClose_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 446);
            this.Controls.Add(this.btnSettingsClose);
            this.Controls.Add(this.btnColor);
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnSettingsClose;
    }
}
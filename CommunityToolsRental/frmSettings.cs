using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunityToolsRental
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Color; // to set the color properties when form initialise

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Color = colorDialog.Color;
                Properties.Settings.Default.Save();
            }
            this.BackColor = Properties.Settings.Default.Color;
        }

        private void btnSettingsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

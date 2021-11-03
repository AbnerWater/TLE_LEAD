using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TLE_Form
{
    public partial class FrmSetting : Form
    {
        Properties.Settings settings;
        public FrmSetting()
        {
            InitializeComponent();
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            settings = new Properties.Settings();
            numMaxEl.Value = (decimal)settings.MaxEl;
            numTrackDue.Value = (decimal)settings.LeadDueTime;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            settings.MaxEl = (double)numMaxEl.Value;
            settings.LeadDueTime = (int)numTrackDue.Value;
            settings.Save();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

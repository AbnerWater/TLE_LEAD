using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TLE_Form
{
    public partial class FrmSunCal : Form
    {
        private double log;
        private double lat;
        public FrmSunCal(double logi,double lati)
        {
            InitializeComponent();
            log = logi;
            lat = lati;
        }
        private void FrmSunCal_Load(object sender, EventArgs e)
        {
            timeStart.Value = DateTime.Now;
            numPridectMin.Value = 10;
        }
        private void generateLeadFile(string fileName)
        {
            double az, el;
            if (!Directory.Exists(Path.Combine(Application.StartupPath, "Sun_LeadFile")))
            {
                Directory.CreateDirectory(Path.Combine(Application.StartupPath, "Sun_LeadFile"));
            }
            string fileFullPath = Path.Combine(Application.StartupPath, "Sun_LeadFile", fileName);
            FileStream fs = new FileStream(fileFullPath, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            DateTime start = timeStart.Value;
            DateTime end = timeStart.Value + TimeSpan.FromMinutes((double)numPridectMin.Value);
            TimeSpan due = TimeSpan.FromMilliseconds(new Properties.Settings().LeadDueTime);
            while (start < end)
            {
                SunCal.CalculateSunPosition(start, lat, log, out az, out el);
                string line = string.Format("{0} {1:f4} {2:f4}",
                    start.ToString("yyyy.MM.dd HH:mm:ss:fff"), el,az);
                sw.WriteLine(line);
                start += due;
            }
            sw.Close();
            fs.Close();
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = string.Format("{0:s}_{1:s}.txt",
                    timeStart.Value.ToString(), timeStart.Value + TimeSpan.FromMinutes((double)numPridectMin.Value).ToString());
                fileName = fileName.Replace(':', '_');
                fileName = fileName.Replace('/', '_');
                generateLeadFile(fileName);
                MessageBox.Show(string.Format("任务导出至文件{0}",
                    Path.Combine(Application.StartupPath, "Sun_LeadFile", fileName)));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

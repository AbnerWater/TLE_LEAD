using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGPdotNET.CoordinateSystem;
using SGPdotNET.Observation;
using SGPdotNET.TLE;
using SGPdotNET.Util;
using System.IO;
using System.Net;

namespace TLE_Form
{
    public partial class FormMain : Form
    {
        public Satellite sat;
        public GroundStation location;
        private Properties.Settings globalSetting;
        public List<SatelliteVisibilityPeriod> missionList;
        public string[] missionHeader = new string[] { "卫星名称", "开始时间", "最高仰角", "结束时间" };
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            globalSetting = new Properties.Settings();
            textSatName.Text = globalSetting.TLEName;
            textSatLine1.Text = globalSetting.TLELine1;
            textSatLine2.Text = globalSetting.TLELine2;
            timeStart.Value = DateTime.Now;
            numLog.Value = (decimal)globalSetting.GPSLog;
            numLat.Value = (decimal)globalSetting.GPSLat;
            numHeight.Value = (decimal)globalSetting.GPSHeight;
            numPridectDay.Value = (decimal)globalSetting.PridectDays;
            numMinEl.Value = (decimal)globalSetting.MinEl;
            numTrackTime.Value = (decimal)globalSetting.TrackTime;
            missionList = new List<SatelliteVisibilityPeriod>();
        }
        public bool CheckValue()
        {
            if (string.IsNullOrEmpty(textSatName.Text))
                return false;
            if (string.IsNullOrEmpty(textSatLine1.Text))
                return false;
            if (string.IsNullOrEmpty(textSatLine2.Text))
                return false;
            return true;
        }
        public void Pridect()
        {
            if(!CheckValue())
            {
                MessageBox.Show("TLE参数缺失！");
                return;
            }
            try
            {
                sat = new Satellite(new Tle(textSatName.Text, textSatLine1.Text, textSatLine2.Text));
                location = new GroundStation(new GeodeticCoordinate(
                    Angle.FromDegrees((double)numLat.Value), Angle.FromDegrees((double)numLog.Value), (double)numHeight.Value));
                DateTime start = timeStart.Value.ToUniversalTime();
                missionList = location.Observe(sat, start, start + TimeSpan.FromDays((double)numPridectDay.Value),
                    TimeSpan.FromMinutes((double)numTrackTime.Value), Angle.FromDegrees((double)numMinEl.Value));
                if (missionList.Count == 0)
                    MessageBox.Show("所选时间段无符合要求的任务！");
                else
                    LoadMission2DGV();
                globalSetting.TLEName = textSatName.Text;
                globalSetting.TLELine1 = textSatLine1.Text;
                globalSetting.TLELine2 = textSatLine2.Text;
                globalSetting.GPSLog = (double)numLog.Value;
                globalSetting.GPSLat = (double)numLat.Value;
                globalSetting.GPSHeight = (double)numHeight.Value;
                globalSetting.PridectDays = (double)numPridectDay.Value;
                globalSetting.MinEl = (double)numMinEl.Value;
                globalSetting.TrackTime = (double)numTrackTime.Value;
                globalSetting.Save();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }
        private void LoadMission2DGV()
        {
            dgvMission.Columns.Clear();
            dgvMission.Rows.Clear();
            int index = 0;
            while (index < missionList.Count)
            {
                if (missionList[index].MaxElevation.Degrees < globalSetting.MaxEl)
                {
                    missionList.RemoveAt(index);
                }
                else
                    index++;
            }
            for (int i = 0; i < missionHeader.Length; i++)
            {
                dgvMission.Columns.Add(" ",missionHeader[i]);
            }
            for (int i = 0; i < missionList.Count; i++)
            {
                dgvMission.Rows.Add();
                dgvMission.Rows[i].Cells[0].Value = sat.Name;
                dgvMission.Rows[i].Cells[1].Value = missionList[i].Start.ToLocalTime().ToShortDateString() + "_" + missionList[i].Start.ToLocalTime().ToShortTimeString();
                dgvMission.Rows[i].Cells[2].Value = string.Format("{0:f3}", missionList[i].MaxElevation.Degrees);
                dgvMission.Rows[i].Cells[3].Value = missionList[i].End.ToLocalTime().ToShortDateString() + "_" + missionList[i].End.ToLocalTime().ToShortTimeString();
            }
        }
        private void ExportLeadFile(int index)
        {
            if(!Directory.Exists(Path.Combine(Application.StartupPath, sat.Name+"LeadFile")))
            {
                Directory.CreateDirectory(Path.Combine(Application.StartupPath, sat.Name + "LeadFile"));
            }
            string fileName = string.Format("{0:s}_{1:s}_{2:s}.txt",
                dgvMission.Rows[index].Cells[0].Value,
                dgvMission.Rows[index].Cells[1].Value,
                dgvMission.Rows[index].Cells[3].Value);
            fileName = fileName.Replace(':', '_');
            fileName = fileName.Replace('/', '_');
            string fileFullPath = Path.Combine(Application.StartupPath, sat.Name + "LeadFile", fileName);
            FileStream fs = new FileStream(fileFullPath, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            DateTime start = missionList[index].Start.ToLocalTime();
            DateTime end= missionList[index].End.ToLocalTime();
            TimeSpan due = TimeSpan.FromMilliseconds(100);
            while(start< end)
            {
                string line = string.Format("{0} {1:f4} {2:f4}",
                    start.ToString("yyyy.MM.dd-HH:mm:ss:fff"),
                    location.Observe(sat, start).Azimuth.Degrees,
                    location.Observe(sat, start).Elevation.Degrees);
                sw.WriteLine(line);
                start += due;
            }
            sw.Close();
            fs.Close();
        }
        private void ExportAll()
        {
            try
            {
                for (int i = 0; i < missionList.Count; i++)
                {
                    ExportLeadFile(i);
                }
                MessageBox.Show(string.Format("所有任务导出至文件夹{0:s}",
                    Path.Combine(Application.StartupPath, sat.Name + "LeadFile")));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public bool HttpDownloadFile(string url)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            if (File.Exists(Path.Combine(Application.StartupPath, "temp.txt")))
                File.Delete(Path.Combine(Application.StartupPath, "temp.txt"));
            WebClient web = new WebClient();
            web.DownloadFile(url, Path.Combine(Application.StartupPath, "temp.txt"));
            if (File.Exists(Path.Combine(Application.StartupPath, "temp.txt")))
            {
                File.Delete(Path.Combine(Application.StartupPath, "active.txt"));
                File.Copy(Path.Combine(Application.StartupPath, "temp.txt"), Path.Combine(Application.StartupPath, "active.txt"));
                return true;
            }
            else
                return false;
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void menuExport_Click(object sender, EventArgs e)
        {
            if(missionList.Count==0||dgvMission.CurrentCell==null)
            {
                MessageBox.Show("请选择一项任务用于导出！");
                return;
            }
            try
            {
                ExportLeadFile(dgvMission.CurrentCell.RowIndex);
                string fileName = string.Format("{0:s}_{1:s}_{2:s}.txt",
                    dgvMission.Rows[dgvMission.CurrentCell.RowIndex].Cells[0].Value,
                    dgvMission.Rows[dgvMission.CurrentCell.RowIndex].Cells[1].Value,
                    dgvMission.Rows[dgvMission.CurrentCell.RowIndex].Cells[3].Value);
                    fileName = fileName.Replace(':', '_');
                    fileName = fileName.Replace('/', '_');
                MessageBox.Show(string.Format("任务导出至文件{0}",
                    Path.Combine(Application.StartupPath, sat.Name + "LeadFile", fileName)));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void 全部导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(missionList.Count==0)
            {
                MessageBox.Show("当前无可导出任务");
                return;
            }
            ExportAll();
        }
        private void btnPridect_Click(object sender, EventArgs e)
        {
            Pridect();
        }
        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSetting setting = new FrmSetting();
            setting.ShowDialog();
            globalSetting.Reload();
        }
        private void 更新TLE数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(HttpDownloadFile(globalSetting.URL))
                {
                    MessageBox.Show("更新成功");
                    FrmTLE tles = new FrmTLE(Path.Combine(Application.StartupPath, "active.txt"));
                    if(tles.ShowDialog()==DialogResult.OK)
                    {
                        textSatName.Text = tles.currenTLE[0];
                        textSatLine1.Text = tles.currenTLE[1];
                        textSatLine2.Text = tles.currenTLE[2];
                        tles.Close();
                    }
                }
                else
                    MessageBox.Show("更新失败");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout();
            about.ShowDialog();
        }
        private void 打开TLE数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!File.Exists(Path.Combine(Application.StartupPath, "active.txt")))
            {
                MessageBox.Show(Path.Combine(Application.StartupPath, "active.txt") + "TLE数据库文件不存在！");
                return;
            }
            FrmTLE tles = new FrmTLE(Path.Combine(Application.StartupPath, "active.txt"));
            if (tles.ShowDialog() == DialogResult.OK)
            {
                textSatName.Text = tles.currenTLE[0];
                textSatLine1.Text = tles.currenTLE[1];
                textSatLine2.Text = tles.currenTLE[2];
                tles.Close();
            }
        }
        private void 导入TLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*.txt|*.txt";
            ofd.Multiselect = false;
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    FrmTLE tles = new FrmTLE(ofd.FileName);
                    if (tles.ShowDialog() == DialogResult.OK)
                    {
                        textSatName.Text = tles.currenTLE[0];
                        textSatLine1.Text = tles.currenTLE[1];
                        textSatLine2.Text = tles.currenTLE[2];
                        tles.Close();
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("导入TLE文件格式不支持！");
                }
            }
        }
    }
}

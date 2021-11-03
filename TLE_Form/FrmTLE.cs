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
    public partial class FrmTLE : Form
    {
        public TLEData tles;
        public string[] currenTLE;
        public FrmTLE(string path)
        {
            InitializeComponent();
            tles = new TLEData(path);
            tle2dgv();
        }
        public void tle2dgv()
        {
            dgvLTE.Rows.Clear();
            dgvLTE.Columns.Clear();
            dgvLTE.Columns.Add("", "卫星名称");
            dgvLTE.Columns.Add("", "卫星数据1");
            dgvLTE.Columns.Add("", "卫星数据2");
            for (int irow=0;irow<tles.Items.Count;irow++)
            {
                dgvLTE.Rows.Add();
                dgvLTE.Rows[irow].Cells[0].Value = tles.Items[irow][0];
                dgvLTE.Rows[irow].Cells[1].Value = tles.Items[irow][1];
                dgvLTE.Rows[irow].Cells[2].Value = tles.Items[irow][2];
            }
        }

        private void dgvLTE_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLTE.CurrentCell != null)
            {
                currenTLE = tles.Items[dgvLTE.CurrentCell.RowIndex];
                DialogResult = DialogResult.OK;
            }
            else
                DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("请输入查找内容！");
                return;
            }
            if (tles.Items.Find(c => c[0] == textBox1.Text) != null)
            {
                int index = tles.Items.FindIndex(c => c[0] == textBox1.Text);
                dgvLTE.Rows[index].Selected = true;
                dgvLTE.CurrentCell = dgvLTE.Rows[index].Cells[0];
            }
            else
                MessageBox.Show("查找不到指定的内容！");
        }
    }
}

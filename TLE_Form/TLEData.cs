using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TLE_Form
{
    public class TLEData
    {
        private List<string[]> LTEs;
        public List<string[]> Items
        {
            get { return LTEs; }
        }
        public string SourcePath { get; set; }
        public TLEData(string path)
        {
            SourcePath = path;
            LTEs = new List<string[]>();
            FileStream fs = new FileStream(SourcePath, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string tmp;
            while(!string.IsNullOrEmpty(tmp=sr.ReadLine()))
            {
                string[] tmpLTE = new string[3];
                tmpLTE[0] = tmp.TrimEnd(' ');
                tmpLTE[1] = sr.ReadLine();
                tmpLTE[2] = sr.ReadLine();
                LTEs.Add(tmpLTE);
            }
        }
        public void UpdateSource()
        {
            LTEs.Clear();
            FileStream fs = new FileStream(SourcePath, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string tmp;
            while (!string.IsNullOrEmpty(tmp = sr.ReadLine()))
            {
                string[] tmpLTE = new string[3];
                tmpLTE[0] = tmp;
                tmpLTE[1] = sr.ReadLine();
                tmpLTE[2] = sr.ReadLine();
                LTEs.Add(tmpLTE);
            }
        }
    }
}

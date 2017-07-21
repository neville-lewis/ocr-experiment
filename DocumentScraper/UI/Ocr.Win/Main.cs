using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ocr.Engine;

namespace Ocr.Win
{
    public partial class main_frm : Form
    {
        public main_frm()
        {
            InitializeComponent();
        }

        private void btn_QueFiles_Click(object sender, EventArgs e)
        {
            openFile.Multiselect = true;
            openFile.Title = "Please select file(s) for detection...";
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach( string file in openFile.FileNames)
                {
                    fileDataGridView.Rows.Add(new object[] { file, "- -" });
                }

            }
        

        }

        private void btn_process_Click(object sender, EventArgs e)
        {
            List<string> files = new List<string>(); //supply list of files - for this sample getting it from grid here. 
            //files.Add("pdf file 1");
            //files.Add("pdf file 2");

            files.AddRange(openFile.FileNames);
            Orchestrator.Run(files);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.IO.Compression;
using System.Diagnostics;

namespace mook_DefaultCompression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            if (this.ofdFile.ShowDialog() == DialogResult.OK)
            {
                foreach(string p in this.ofdFile.FileNames)
                {
                    FileInfo fi = new FileInfo(p);
                    this.lvList.Items.Add(new ListViewItem(new string[] { fi.FullName, fi.Length.ToString() }));
                }
            }
        }

        private void btnComp_Click(object sender, EventArgs e)
        {
            if (lvList.Items.Count > 0)
            {
                if (this.sfdFile.ShowDialog() == DialogResult.OK)
                {
                    for(int i = 0; i < this.lvList.Items.Count; i++)
                    {
                        FileInfo fi = new FileInfo(this.lvList.Items[i].SubItems[0].Text);
                        fi.CopyTo(Application.StartupPath + @"\temp\" + fi.Name);
                    }
                    ZipFile.CreateFromDirectory(Application.StartupPath + @"\temp", this.sfdFile.FileName, CompressionLevel.Fastest, false);
                    DirectoryInfo di = new DirectoryInfo(Application.StartupPath + @"\temp");
                    foreach (FileInfo ffi in di.GetFiles())
                        ffi.Delete();
                    MessageBox.Show("압축을 완료하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.lvList.Items.Clear();
                }
                else
                    MessageBox.Show("압축 파일 이름을 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("압축할 대상 파일이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("temp"))
                Directory.CreateDirectory("temp");
        }

        private void btnDeComp_Click(object sender, EventArgs e)
        {
            if (this.ofdFile.ShowDialog() == DialogResult.OK)
            {
                if (this.fbdFolder.ShowDialog() == DialogResult.OK)
                {
                    ZipFile.ExtractToDirectory(this.ofdFile.FileName, this.fbdFolder.SelectedPath);
                    MessageBox.Show("압축 해제를 완료하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start(this.fbdFolder.SelectedPath);
                }
                else
                    MessageBox.Show("압축을 해제할 경로를 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

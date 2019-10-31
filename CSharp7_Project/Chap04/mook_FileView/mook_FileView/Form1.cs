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
using System.Threading;

namespace mook_FileView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread threadFileView = null; //스레드 개체 생성

        private delegate void OnDelegateFile(string fp, string fn, string fl, string fc);
        private OnDelegateFile OnFile = null; //델리게이트 생성

        bool Flag = true; //일반 / 히든 파일 구분

        int DirCount = 0;
        int FileCount = 0;

        private void btnPath_Click(object sender, EventArgs e)
        {
            if (this.fbdFolder.ShowDialog() == DialogResult.OK)
            {
                ItemsClear();
                this.txtPath.Text = this.fbdFolder.SelectedPath;
                threadFileView = new Thread(new ParameterizedThreadStart(FileView));
                threadFileView.Start(this.fbdFolder.SelectedPath);
            }
        }

        private void ItemsClear()
        {
            DirCount = 0;
            FileCount = 0;
            this.lvFile.Items.Clear();
        }

        private void FileView(object path)
        {
            DirCount++;

            DirectoryInfo di = new DirectoryInfo((string)path);
            DirectoryInfo[] dti = di.GetDirectories();
            
            foreach (var f in di.GetFiles())
            {
                if (Flag == true)
                {
                    FileCount++;
                    Invoke(OnFile, f.DirectoryName, f.Name, f.Length.ToString(),
                        f.CreationTime.ToString());
                }
                else
                {
                    if (f.Attributes.ToString().Contains(FileAttributes.Hidden.ToString()))
                    {
                        FileCount++;
                        Invoke(OnFile, f.DirectoryName, f.Name, f.Length.ToString(),
                            f.CreationTime.ToString());
                    }
                }
            }

            for (int i = 0; i < di.GetDirectories().Length; i++)
            {
                try
                {
                    FileView(dti[i].FullName);
                }
                catch
                {
                    continue;
                }
            }
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            ItemsClear();
            Flag = true;
            if (threadFileView != null)
                threadFileView.Abort();
            if (this.txtPath.Text != "")
            {
                this.lvFile.Items.Clear();
                threadFileView = new Thread(new ParameterizedThreadStart(FileView));
                threadFileView.Start(this.fbdFolder.SelectedPath);
            }
        }

        private void rbtnHidden_CheckedChanged(object sender, EventArgs e)
        {
            ItemsClear();
            Flag = false;
            if (threadFileView != null)
                threadFileView.Abort();
            if (this.txtPath.Text != "")
            {
                this.lvFile.Items.Clear();
                threadFileView = new Thread(new ParameterizedThreadStart(FileView));
                threadFileView.Start(this.fbdFolder.SelectedPath);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnFile = new OnDelegateFile(FileResult);
        }

        private void FileResult(string fp, string fn, string fl, string fc)
        {
            string fSize = GetFileSize(Convert.ToDouble(fl));
            this.lvFile.Items.Add(new ListViewItem(new string[] { fp, fn, fc, fSize }));
            this.tsslblResult.Text = String.Format("폴더 : {0} 개, 파일 : {1} 개", DirCount, FileCount);
        }

        private string GetFileSize(double byteCount)
        {
            string size = "0 Bytes";
            if (byteCount >= 1073741824.0)
                size = String.Format("{0:##.##}", byteCount / 1073741824.0) + " GB";
            else if (byteCount >= 1048576.0)
                size = String.Format("{0:##.##}", byteCount / 1048576.0) + " MB";
            else if (byteCount >= 1024.0)
                size = String.Format("{0:##.##}", byteCount / 1024.0) + " KB";
            else if (byteCount > 0 && byteCount < 1024.0)
                size = byteCount.ToString() + " Bytes";

            return size;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadFileView != null)
                threadFileView.Abort();
        }
    }
}

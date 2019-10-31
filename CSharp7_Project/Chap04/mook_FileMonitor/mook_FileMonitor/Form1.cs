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

namespace mook_FileMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FileSystemWatcher Watcher;
        private string FolderPath = String.Empty; //모니터 경로

        private bool let = false; //더블 모니터 방지

        private delegate void DelegateCreateListBoxItem(string EventName, string DateTime, string FilePath); //델리게이트 선언

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cbMonitor.Text = "ON";
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            if (this.fbdFolder.ShowDialog() == DialogResult.OK)
            {
                this.txtPath.Text = this.fbdFolder.SelectedPath;
                FolderPath = this.fbdFolder.SelectedPath;
            }
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            if (this.txtPath.Text == "") return;

            if (this.btnMonitor.Text == "모니터 ON")
            {
                this.btnMonitor.Text = "모니터 OFF";
                this.btnSave.Enabled = false;

                Watcher = new FileSystemWatcher();
                Watcher.Filter = "*." + this.txtExtension.Text.ToLower();
                Watcher.Path = Environment.ExpandEnvironmentVariables(FolderPath);

                if (this.cbMonitor.Text == "ON")
                    Watcher.IncludeSubdirectories = true;
                else
                    Watcher.IncludeSubdirectories = false;

                Watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                                        | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                Watcher.Changed += new FileSystemEventHandler(OnChanged);
                Watcher.Created += new FileSystemEventHandler(OnCreated);
                Watcher.Deleted += new FileSystemEventHandler(OnDeleted);
                Watcher.Renamed += new RenamedEventHandler(OnRenamed);

                Watcher.EnableRaisingEvents = true;
            }
            else
            {
                if (Watcher != null)
                {
                    Watcher.Changed -= new FileSystemEventHandler(OnChanged);
                    Watcher.Created -= new FileSystemEventHandler(OnCreated);
                    Watcher.Deleted -= new FileSystemEventHandler(OnDeleted);
                    Watcher.Renamed -= new RenamedEventHandler(OnRenamed);

                    Watcher.EnableRaisingEvents = false;
                }
                this.btnMonitor.Text = "모니터 ON";
                this.btnSave.Enabled = true;
            }
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (let == false)
            {
                let = true;
                CreateListBoxItem("Changed", DateTime.Now.ToString(), e.FullPath);
            }
            else
            {
                let = false;
            }
        }

        void CreateListBoxItem(string EventName, string DateTime, string FilePath)
        {
            if (this.lbLog.InvokeRequired)
            {
                DelegateCreateListBoxItem DelView = new DelegateCreateListBoxItem(InvokedCreateListViewItem);
                Invoke(DelView, new object[3] { EventName, DateTime, FilePath });
            }
            else
            {
                InvokedCreateListViewItem(EventName, DateTime, FilePath);
            }
        }

        private void InvokedCreateListViewItem(string EventName, string DateTime, string FilePath)
        {
            this.lbLog.Items.Add(EventName + " : (" + DateTime + ") : " + FilePath);
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            CreateListBoxItem("Created", DateTime.Now.ToString(), e.FullPath);
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            CreateListBoxItem("Deleted", DateTime.Now.ToString(), e.FullPath);
        }

        private void OnRenamed(object sender, FileSystemEventArgs e)
        {
            CreateListBoxItem("Renamed", DateTime.Now.ToString(), e.FullPath);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.sfdFile.ShowDialog() == DialogResult.OK)
            {
                string savepath = this.sfdFile.FileName;

                StreamWriter sw = new StreamWriter(savepath);
                foreach(string s in this.lbLog.Items)
                {
                    sw.WriteLine(s);
                }
                sw.Close();
            }
        }
    }
}

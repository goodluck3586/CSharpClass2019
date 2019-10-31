using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace mook_PortScanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private IPAddress scanIp = null;
        private string strFile = null; //파일 경로
        string IPAddre = ""; //아이피 정보
        int StartNum = 0; //시작 포트
        int EndNum = 0; //마지막 포트

        Thread PortScan = null;
        private delegate void OnPortDeletegate(string a, string b, bool f);
        private OnPortDeletegate OnPort = null;

        private delegate void OnProgressDeletegate(int i);
        private OnProgressDeletegate OnProgress = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            OnPort = new OnPortDeletegate(OnPortScan);
            OnProgress = new OnProgressDeletegate(OnProStatus);
        }

        private void OnPortScan(string a, string b, bool f)
        {
            if (f == true)
            {
                this.lvScan.Items.Add(new ListViewItem(new
                    string[] { a, b }));
            }
            else
            {
                this.btnStart.Enabled = true;
                this.btnFile.Enabled = true;
            }
        }

        private void OnProStatus(int i)
        {
            this.pgbScan.Value = i;
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (this.fbdFile.ShowDialog() == DialogResult.OK)
                strFile = this.fbdFile.SelectedPath + @"\포트스캔("
                    + this.txtIp.Text + ").txt";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (strFile != null)
            {
                IPAddre = this.txtIp.Text;
                StartNum = Convert.ToInt32(this.txtStart.Text);
                EndNum = Convert.ToInt32(this.txtEnd.Text);
                this.pgbScan.Minimum = Convert.ToInt32(this.txtStart.Text);
                this.pgbScan.Maximum = Convert.ToInt32(this.txtEnd.Text);
                this.btnStart.Enabled = false;
                this.btnFile.Enabled = false;

                this.lblFile.Text = "생성파일 : ";
                this.txtPath.Text = strFile;

                PortScan = new Thread(PortScanner);
                PortScan.Start();
            }
        }
        private void PortScanner()
        {

            StreamWriter sw = new StreamWriter(strFile);

            scanIp = IPAddress.Parse(IPAddre);

            sw.WriteLine("************ 스캔 시작 ************ "
                + DateTime.Now);
            sw.WriteLine();
            for (int i = StartNum; i <= EndNum; i++)
            {
                Invoke(OnProgress, i);
                try
                {
                    IPEndPoint endpoint = new IPEndPoint(scanIp, i);
                    Socket sSocket = new Socket(AddressFamily.InterNetwork,
                        SocketType.Stream, ProtocolType.Tcp);
                    sSocket.Connect(endpoint);
                    sw.WriteLine("ScanPort {0} 열려있음", i);

                    Invoke(OnPort, i.ToString(), "open", true);
                    continue;
                }
                catch (SocketException ex)
                {
                    if (ex.ErrorCode != 10061)
                        sw.WriteLine("에러 : {0}", ex.Message);
                }
                sw.WriteLine("ScanPort {0} 닫혀있음", i);

                Invoke(OnPort, i.ToString(), "close", true);
            }
            sw.WriteLine();
            sw.WriteLine("************ 스캔 종료 ************ " + DateTime.Now);
            sw.Close();

            Invoke(OnPort, "", "", false);

            MessageBox.Show("포트 스캔을 완료하였습니다.", "알림",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = strFile;
            myProcess.Start();
            PortScan.Abort();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.NetworkInformation;
using System.Threading;
using System.IO;


namespace mook_NetStat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IPGlobalProperties ipProperties =
            IPGlobalProperties.GetIPGlobalProperties();

        Thread NetThread = null;
        string LocPort, RemoAdd, RemoPort; //포트 정보 저장
        bool CheckBool = true; // 입력 컨트롤 Enabled

        private delegate void OnNetStatDelegate(string a,
            string b, string c, string d, string e, int i, bool f, bool En);
        private OnNetStatDelegate OnNetSate = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            OnNetSate = new OnNetStatDelegate(NetStatView);
            NetThread = new Thread(NetView);
            NetThread.Start();
        }

        private void NetStatView(string a, string b, string c,
            string d, string e, int i, bool f, bool En)
        {
            if (f == true)
            {
                this.lvNetState.Items.Add(a);
                this.lvNetState.Items[i].SubItems.Add(b);
                this.lvNetState.Items[i].SubItems.Add(c);
                this.lvNetState.Items[i].SubItems.Add(d);
                this.lvNetState.Items[i].SubItems.Add(e);

                if (b == LocPort)
                    this.lvNetState.Items[i].SubItems[0].BackColor = Color.GreenYellow;
                if (c == RemoAdd)
                    this.lvNetState.Items[i].SubItems[0].BackColor = Color.LightPink;
                if (d == RemoPort)
                    this.lvNetState.Items[i].SubItems[0].BackColor = Color.Aqua;
            }
            else
            {
                if (En == false)
                    this.lvNetState.Items.Clear();
                NCheck();
            }
        }

        private void NetView()
        {
            while (true)
            {
                this.CheckBool = true;
                Invoke(OnNetSate, "", "", "", "", "", 0, false, false);
                TcpConnectionInformation[] tcpConnections =
                ipProperties.GetActiveTcpConnections();
                int i = 0;
                foreach (TcpConnectionInformation NetInfo in tcpConnections)
                {
                    Invoke(OnNetSate, NetInfo.LocalEndPoint.Address.ToString(),
                        NetInfo.LocalEndPoint.Port.ToString(),
                        NetInfo.RemoteEndPoint.Address.ToString(),
                        NetInfo.RemoteEndPoint.Port.ToString(),
                        NetInfo.State.ToString(), i, true, false);

                    i++;
                }
                this.CheckBool = false;
                Invoke(OnNetSate, "", "", "", "", "", 0, false, true);
                Thread.Sleep(30000);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NetThread != null)
                NetThread.Abort();
            Application.ExitThread();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            this.LocPort = this.txtLocPort.Text;
            this.RemoAdd = this.txtForAdd.Text;
            this.RemoPort = this.txtForPort.Text;
            NCheck();
        }
        private void NCheck()
        {
            if (CheckBool)
            {
                this.txtLocPort.Enabled = false;
                this.txtForPort.Enabled = false;
                this.txtForAdd.Enabled = false;
                this.btnCheck.Enabled = false;
                this.btnSave.Enabled = false;
            }
            else
            {
                this.txtLocPort.Enabled = true;
                this.txtForPort.Enabled = true;
                this.txtForAdd.Enabled = true;
                this.btnCheck.Enabled = true;
                this.btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.sfdFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(this.sfdFile.FileName);
                sw.WriteLine("파일생성 : " + DateTime.Now);
                sw.WriteLine();
                sw.WriteLine("로컬주소	로컬포트	외부주소	외부포트	상태");
                for (int i = 0; i < this.lvNetState.Items.Count - 1; i++)
                {
                    sw.WriteLine(this.lvNetState.Items[i].SubItems[0].Text + "\t" +
                        this.lvNetState.Items[i].SubItems[1].Text + "\t" +
                        this.lvNetState.Items[i].SubItems[2].Text + "\t" +
                        this.lvNetState.Items[i].SubItems[3].Text + "\t" +
                        this.lvNetState.Items[i].SubItems[4].Text);
                }
                sw.WriteLine();
                sw.WriteLine("파일생성 종료 : " + DateTime.Now);
                sw.Close();
            }
        }
    }
}

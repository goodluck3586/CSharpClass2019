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
using System.IO;
using System.Threading;

namespace mook_NetworkChk
{
    public partial class Form1 : Form
    {
        private static Form1 staticForm;

        public Form1()
        {
            InitializeComponent();
            staticForm = this;
        }
        
        public string HostNameEntry = ""; //호스트 아이피
        public string DescriptionEntry = ""; //호스트 설명
        public static int Hostcount = 0; //네트워크 체크 호스트 수

        Ping pingSender = new Ping();
        PingOptions options = new PingOptions();
        string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //32바이트
        const int timeout = 120; //네트워크 체크를 위한 타임아웃

        private Thread SoundPlayThread; //사운드 실행 스레드 개체 생성

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tslcbTime.Text = "5 초";
            MainConfig();
        }

        private void MainConfig()
        {
            if (File.Exists("ICMPConfig.ini") == true)
            {
                string ss = string.Empty;
                using (StreamReader sr = new StreamReader("ICMPConfig.ini"))
                {
                    ss = sr.ReadLine();
                    while (ss != null)
                    {
                        HostNameEntry = sr.ReadLine();
                        DescriptionEntry = sr.ReadLine();
                        AddList(HostNameEntry, DescriptionEntry);
                        ss = sr.ReadLine();
                    }
                    sr.Close();
                }
            }
        }

        public static void AddList(string AnyHostEntry, string DescriptionEntry)
        {
            string[] Entry = new string[8];

            Entry[0] = AnyHostEntry;
            Entry[1] = DescriptionEntry;
            int hold = 0;
            ListViewItem Entries = new ListViewItem(Entry);
            staticForm.lvStatus.Items.Add(Entries);
            Hostcount = Hostcount + 1;
            for (int column = 2; column < 7; column++)
                if (column < 6)
                    staticForm.lvStatus.Items[Hostcount - 1].SubItems[column].Text = hold.ToString();
                else
                    staticForm.lvStatus.Items[Hostcount - 1].SubItems[column].Text = "";

            staticForm.lvStatus.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            staticForm.lvStatus.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void tslcbTime_Click(object sender, EventArgs e)
        {
            switch (this.tslcbTime.Text)
            {
                case "5 초":
                    this.Timer.Interval = 5000;
                    break;
                case "10 초":
                    this.Timer.Interval = 10000;
                    break;
                case "15 초":
                    this.Timer.Interval = 15000;
                    break;
                case "20 초":
                    this.Timer.Interval = 20000;
                    break;
                case "30 초":
                    this.Timer.Interval = 30000;
                    break;
            }
        }

        private void tlsBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string itemname = e.ClickedItem.Text;
            switch (itemname)
            {
                case "AddHost":
                    Form2 frm2 = new Form2();
                    frm2.ShowDialog();
                    break;
                case "Start":
                    this.Timer.Enabled = true;
                    tsslblStatus.Text = "상태 : 시작 ";
                    break;
                case "Stop":
                    this.Timer.Enabled = false;
                    tsslblStatus.Text = "상태 : 정지 ";
                    break;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.lvStatus.Items.Count == 0)
            {
                MessageBox.Show("체크할 IP 정보가 없습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Timer.Enabled = false;
            }
            else
            {
                Byte[] buffer = Encoding.ASCII.GetBytes(data);
                options.DontFragment = true;

                for (int i = 0; i < this.lvStatus.Items.Count; i++)
                {
                    PingReply reply = pingSender.Send(this.lvStatus.Items[i].SubItems[0].Text,
                        timeout, buffer, options);

                    for (int column = 2; column < 7; column++)
                    {
                        if (reply.Status == IPStatus.Success)
                        {
                            this.lvStatus.Items[i].BackColor = Color.Yellow;
                            string[] PingResult = new string[] {DateTime.Now.ToString(), reply.Buffer.Length.ToString() + " Bytes",
                                reply.RoundtripTime.ToString() + " ms", reply.Options.Ttl.ToString() };
                            if (column < 6)
                                this.lvStatus.Items[i].SubItems[column].Text = PingResult[column - 2];
                            else
                                this.lvStatus.Items[i].SubItems[column].Text = "성공";
                        }
                        else
                        {
                            if (column < 6)
                                this.lvStatus.Items[i].SubItems[column].Text = (0).ToString();
                            else
                                this.lvStatus.Items[i].SubItems[column].Text = "실패";
                            this.lvStatus.Items[i].BackColor = Color.Red;
                            SoundPlayThread = new Thread(SoundPlayGo);
                            SoundPlayThread.Start();
                        }
                    }
                }
                this.lvStatus.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                this.lvStatus.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void SoundPlayGo()
        {
            SoundPlay.PlaySoundStart(Application.StartupPath + @"\Sound\ping.wav", new System.IntPtr(), SoundPlay.PlaySoundFlags.SND_SYNC);
            SoundPlayThread.Abort();
        }
    }
}

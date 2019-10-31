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
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace mook_NetFileSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private IPAddress ip = null;
        private int port = 63000;
        private string filename = String.Empty;
        private string FilePath = String.Empty;

        private TcpClient client;
        private FileStream fs;
        private StreamReader myRead; // 스트림 읽기
        private NetworkStream ns;
        private Thread myReader;
        private Thread FileSendThre = null;

        private delegate void OnMessageDelegate(string s);
        private OnMessageDelegate OnMsg = null;

        private delegate void OnCountDelegate(int i);
        private OnCountDelegate OnCount = null;

        List<string> FileList = new List<string>();

        bool Flag = true;
        int Count = 0;

        private void btnPath_Click(object sender, EventArgs e)
        {
            FileList.Clear();
            this.lbFileList.Items.Clear();
            if (this.fbdFolder.ShowDialog() == DialogResult.OK)
            {
                FilePath = this.fbdFolder.SelectedPath + @"\";
                DirectoryInfo di = new DirectoryInfo(FilePath);
                foreach(FileInfo fi in di.GetFiles())
                {
                    this.lbFileList.Items.Add(fi.FullName);
                    FileList.Add(fi.FullName);
                    Count++;
                }
            }
            this.tspgrBar.Maximum = Count;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            ip = IPAddress.Parse(this.txtIp.Text);
            FileSendThre = new Thread(FileSendThreRun);
            FileSendThre.Start();
        }

        private void FileSendThreRun()
        {
            int n = 1;
            foreach (string f in FileList)
            {
                Flag = true;
                FileInfo fi = new FileInfo(f);
                filename = fi.Name;
                string date = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                fs = new FileStream(f, FileMode.Open, FileAccess.Read);
                byte[] buf = new byte[fs.Length];
                fs.Read(buf, 0, buf.Length);
                fs.Close();
                mook_Packet.Packet mypacket = new mook_Packet.Packet(filename, buf.Length, buf, date);
                client = new TcpClient();
                client.Connect(ip, port);
                ns = client.GetStream();
                myRead = new StreamReader(ns);
                myReader = new Thread(Receive);
                myReader.Start();

                BinaryWriter writer = new BinaryWriter(ns);
                byte[] data = ObjectToBytes(mypacket);
                writer.Write(data.Length);
                writer.Write(data);
                Invoke(OnCount, n);
                while(true)
                {
                    if (!Flag) break;
                    Thread.Sleep(1);
                }
                n++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnMsg = new OnMessageDelegate(OnMsgRun);
            OnCount = new OnCountDelegate(OnCountRun);
        }

        private void OnCountRun(int i)
        {
            this.tspgrBar.Value = i;
        }

        private void OnMsgRun(string s)
        {
            this.tsslblMsg.Text = String.Format("결과 : {0} 전송 완료", s);
            Flag = false;
        }

        private byte[] ObjectToBytes(object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }

        private void Receive()
        {
            while (true)
            {
                Thread.Sleep(1);
                if (ns.CanRead)
                {
                    string msg = "";
                    try
                    {
                        msg = myRead.ReadLine();
                        Invoke(OnMsg, msg);
                    }
                    catch { }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null) client.Close();
            if (FileSendThre != null) FileSendThre.Abort();
        }
    }
}

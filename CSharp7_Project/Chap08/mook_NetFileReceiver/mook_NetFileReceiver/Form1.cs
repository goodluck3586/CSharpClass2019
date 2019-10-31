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
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace mook_NetFileReceiver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TcpListener server;
        private IPAddress ip = new IPAddress(0);
        private StreamWriter myWrite; // 스트림 쓰기

        private TcpClient servClient;
        private NetworkStream ns;
        private BinaryReader reader;

        private Thread thread = null;

        delegate void OnFileDelegate(string d, string s);
        OnFileDelegate OnFile = null;

        private void btnReceive_Click(object sender, EventArgs e)
        {
            server = new TcpListener(ip, 63000);
            server.Start();
            thread = new Thread(AcceptFile);
            thread.Start();
            this.tsslblConn.Text = "상태 : 파일 받기 작동";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnFile = new OnFileDelegate(OnFileRun);
            if (!Directory.Exists(Application.StartupPath + @"\File"))
                Directory.CreateDirectory(Application.StartupPath + @"\File");
        }

        private void OnFileRun(string d, string s)
        {
            string data = String.Format("[{0}] : {1}", d, s);
            this.lbFileList.Items.Add(data);
        }

        private void AcceptFile()
        {
            while (true)
            {
                try
                {
                    servClient = server.AcceptTcpClient();
                    ns = servClient.GetStream();
                    myWrite = new StreamWriter(ns);
                    reader = new BinaryReader(ns);
                    int length = reader.ReadInt32();
                    byte[] packet = reader.ReadBytes(length);
                    mook_Packet.Packet mypacket = BytesToObject(packet);

                    FileStream fs = new FileStream(Application.StartupPath + @"\File\" + mypacket.FileName, FileMode.Create);
                    fs.Write(mypacket.Data, 0, mypacket.Size);
                    fs.Close();
                    Invoke(OnFile, mypacket.Date, mypacket.FileName);
                    myWrite.WriteLine(mypacket.FileName);
                    myWrite.Flush();
                }
                catch { }
            }
        }

        private mook_Packet.Packet BytesToObject(byte[] data)
        {
            MemoryStream ms = new MemoryStream();
            IFormatter bf = new BinaryFormatter();
            ms.Write(data, 0, data.Length);
            ms.Seek(0, SeekOrigin.Begin);
            object obj = bf.Deserialize(ms) as object;
            return obj as mook_Packet.Packet;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (servClient != null) servClient.Close();
            if (server != null) server.Stop();
            if (thread != null) thread.Abort();
        }
    }
}

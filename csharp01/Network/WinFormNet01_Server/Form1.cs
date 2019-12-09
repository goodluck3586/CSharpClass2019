using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormNet01_Server
{
    public partial class Form1 : Form
    {
        TcpListener tcpListener;
        TcpClient tcpClient;
        NetworkStream ns;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tcpListener = new TcpListener(3000);
            tcpListener.Start();        // 클라이언트 접속 대기 시작

            // 서버의 ip 주소를 textBox1 에 출력
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            for (int i = 0; i < host.AddressList.Length; i++)
            {
                if(host.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                {
                    textBox1.Text = host.AddressList[i].ToString();
                    break;
                }
            }
        }

        // 접속 시작 버튼 클릭
        private void button1_Click(object sender, EventArgs e)
        {
            tcpClient = tcpListener.AcceptTcpClient();  // 클라이언트가 접속할 때까지 무한 대기

            // 클라이언트가 연결되면 클라이언트의 ip주소를  textBox2에 표시
            if (tcpClient.Connected)
            {
                textBox2.Text = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString();
            }

            ns = tcpClient.GetStream();
        }
    }
}

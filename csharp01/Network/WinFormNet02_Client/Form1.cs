using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormNet02_Client
{
    public partial class Form1 : Form
    {
        TcpClient tcpClient;
        NetworkStream ns;

        public Form1()
        {
            InitializeComponent();
        }

        // 접속 버튼 클릭
        private void button1_Click(object sender, EventArgs e)
        {
            tcpClient = new TcpClient(textBox1.Text, 3000);

            if (tcpClient.Connected)
            {
                ns = tcpClient.GetStream(); // 서버와 연결된 스트림 저장
                labelConnectionState.Text = "서버 연결 성공";
                labelConnectionState.ForeColor = Color.Green;
            }
            else
            {
                labelConnectionState.Text = "서버 연결 실패";
                labelConnectionState.ForeColor = Color.Red;
            }
        }
    }
}

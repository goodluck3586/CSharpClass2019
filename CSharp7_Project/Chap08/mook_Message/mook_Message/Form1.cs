using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net; // IPAddress
using System.Net.Sockets; //TcpListener 클래스사용
using System.Threading; //스레드 클래스 사용
using System.IO; //파일 클래스 사용
using Microsoft.Win32; //레지스트리 클래스 사용
using System.Runtime.InteropServices; //폼 깜박임 구현

namespace mook_Message
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TcpListener Server; // TCP 네트워크 클라이언트에서 연결 수신
        private TcpClient SerClient, client; // TCP 네트워크 서비스에 대한 클라이언트 연결 제공
        private NetworkStream myStream; // 네트워크 스트림
        private StreamReader myRead; // 스트림 읽기
        private StreamWriter myWrite; // 스트림 쓰기
        private Boolean Start = false; // 서버 시작
        private Boolean ClientCon = false; // 클라이언트 시작
        private int myPort; // 포트
        private string myName; // 별칭
        private Thread myReader, myServer; // 스레드
        private Boolean TextChange = false; // 입력 컨트롤의 데이터입력 체크
        private bool TextSend = false;

        private RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\.NETFramework", true); // 레지스트리 쓰기,읽기

        private delegate void AddTextDelegate(string strText); // 델리게이트 개체 생성
        private AddTextDelegate AddText = null; // 델리게이트 개체 생성

        [DllImport("User32.dll")]
        private static extern bool FlashWindow(IntPtr hwnd, bool bInvert);

        private void 설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.설정ToolStripMenuItem.Enabled = false;
            this.plOption.Visible = true;
            this.txtId.Focus();
            this.txtId.Text = (string)key.GetValue("Message_name"); //별칭 입력
            this.txtPort.Text = "62000"; //포트 입력
        }

        private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //폼 닫기
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.cbServer.Checked == true) //서버 모드 실행
            {
                ControlCheck();
            }
            else // 클라이언트 실행
            {
                if (this.txtIp.Text == "")
                {
                    this.txtIp.Focus();
                }
                else
                {
                    ControlCheck();
                }
            }
        }

        private void ControlCheck()
        {
            if (this.txtId.Text == "")
            {
                this.txtId.Focus();
            }
            else if (this.txtPort.Text == "")
            {
                this.txtPort.Focus();
            }
            else
            {
                try
                {
                    var name = this.txtId.Text;
                    var port = this.txtPort.Text;
                    key.SetValue("Message_name", name);
                    key.SetValue("Message_port", port);
                    this.plOption.Visible = false;
                    this.설정ToolStripMenuItem.Enabled = true;
                    this.tsbtnConn.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("설정이 저장되지 않았습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.설정ToolStripMenuItem.Enabled = true; //설정 메뉴 활성화
            this.plOption.Visible = false; //입력창 닫기
            this.txtMessage.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if ((string)key.GetValue("Message_name") == "")
            {
                this.myName = this.txtId.Text;
                this.myPort = 62000;
            }
            else
            {
                try
                {
                    this.myName = (string)key.GetValue("Message_name");
                    this.myPort = 62000;
                }
                catch
                {
                    this.myName = this.txtId.Text;
                    this.myPort = 62000;
                }
            }
            this.txtPort.Text = "62000";
        }

        private void tsbtnConn_Click(object sender, EventArgs e)
        {
            AddText = new AddTextDelegate(MessageView);
            if (this.cbServer.Checked == true)
            {
                var addr = new IPAddress(0);
                try
                {
                    this.myName = (string)key.GetValue("Message_name");
                }
                catch
                {
                    this.myName = this.txtId.Text;
                    this.myPort = Convert.ToInt32(this.txtPort.Text);
                }

                if (!(this.Start))
                {
                    try
                    {
                        Server = new TcpListener(addr, this.myPort);
                        Server.Start();

                        this.Start = true;
                        this.txtMessage.Enabled = true;
                        this.btnSend.Enabled = true;
                        this.txtMessage.Focus();
                        this.tsbtnDisconn.Enabled = true;
                        this.tsbtnConn.Enabled = false;
                        this.cbServer.Enabled = false;

                        myServer = new Thread(ServerStart);
                        myServer.Start();

                        this.설정ToolStripMenuItem.Enabled = false;
                    }
                    catch
                    {
                        Invoke(AddText, "서버를 실행할 수 없습니다.");
                    }
                }
                else
                {
                    ServerStop(); //ServerStop() 함수 호출
                }
            }
            else
            {
                if (!(this.ClientCon))
                {
                    this.myName = (string)key.GetValue("Message_name"); //별칭 설정
                    this.myPort = Convert.ToInt32(key.GetValue("Message_port")); //서버측 포트 설정
                    ClientConnection(); //ClientConnection() 함수 호출
                }
                else
                {
                    this.txtMessage.Enabled = false;
                    this.btnSend.Enabled = false;
                    Disconnection(); //함수 호출
                }
            }
        }

        private void tsbtnDisconn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cbServer.Checked)
                {
                    if (this.SerClient.Connected)
                    {
                        var dt = Convert.ToString(DateTime.Now);
                        myWrite.WriteLine(this.myName + "&" + "채팅 APP가 종료되었습니다." + "&" + dt);
                        myWrite.Flush();
                    }
                }
                else
                {
                    if (this.client.Connected)
                    {
                        var dt = Convert.ToString(DateTime.Now);
                        myWrite.WriteLine(this.myName + "&" + "채팅 APP가 종료되었습니다." + "&" + dt);
                        myWrite.Flush();
                    }
                }
            }
            catch { }
            ServerStop();
            this.설정ToolStripMenuItem.Enabled = true;
        }

        private void ServerStart()
        {
            Invoke(AddText, "서버 실행 : 챗 상대의 접속을 기다립니다...");
            while (Start)
            {
                try
                {
                    SerClient = Server.AcceptTcpClient();
                    Invoke(AddText, "챗 상대 접속..");
                    myStream = SerClient.GetStream();

                    myRead = new StreamReader(myStream);
                    myWrite = new StreamWriter(myStream);
                    this.ClientCon = true;
                    TextSend = true;

                    myReader = new Thread(Receive);
                    myReader.Start();
                }
                catch { }
            }
        }

        private void ServerStop() // 서버 모드 종료
        {
            this.Start = false;
            this.txtMessage.Enabled = false;
            this.txtMessage.Clear();
            this.btnSend.Enabled = false;
            this.tsbtnConn.Enabled = true;
            this.tsbtnDisconn.Enabled = false;
            this.cbServer.Enabled = true;
            this.ClientCon = false;

            if (!(myRead == null))
            {
                myRead.Close(); //StreamReader 클래스 개체 리소스 해제
            }
            if (!(myWrite == null))
            {
                myWrite.Close(); //StreamWriter 클래스 개체 리소스 해제
            }
            if (!(myStream == null))
            {
                myStream.Close(); //NetworkStream 클래스 개체 리소스 해제
            }
            if (!(SerClient == null))
            {
                SerClient.Close(); //TcpClient 클래스 개체 리소스 해제
            }
            if (!(Server == null))
            {
                Server.Stop(); //TcpListen 클래스 개체 리소스 해제
            }
            if (!(myReader == null))
            {
                myReader.Abort(); //외부 스레드 종료
            }
            if (!(myServer == null))
            {
                myServer.Abort(); //외부 스레드 종료
            }
            if (!(AddText == null))
            {
                Invoke(AddText, "연결이 끊어졌습니다.");
            }
        }

        private void ClientConnection()
        {
            try
            {
                client = new TcpClient(this.txtIp.Text, this.myPort);
                Invoke(AddText, "서버에 접속 했습니다.");
                myStream = client.GetStream();

                myRead = new StreamReader(myStream);
                myWrite = new StreamWriter(myStream);
                this.ClientCon = true;
                this.tsbtnConn.Enabled = false;
                this.tsbtnDisconn.Enabled = true;
                this.txtMessage.Enabled = true;
                this.btnSend.Enabled = true;
                this.txtMessage.Focus();

                myReader = new Thread(Receive);
                myReader.Start();
            }
            catch
            {
                this.ClientCon = false;
                Invoke(AddText, "서버에 접속하지 못 했습니다.");
            }
        }

        private void Disconnection()
        {
            this.ClientCon = false;
            try
            {
                if (!(myRead == null))
                {
                    myRead.Close(); //StreamReader 클래스 개체 리소스 해제
                }
                if (!(myWrite == null))
                {
                    myWrite.Close(); //StreamWriter 클래스 개체 리소스 해제
                }
                if (!(myStream == null))
                {
                    myStream.Close(); //NetworkStream 클래스 개체 리소스 해제
                }
                if (!(client == null))
                {
                    client.Close(); //TcpClient 클래스 개체 리소스 해제
                }
                if (!(myReader == null))
                {
                    myReader.Abort(); //외부 스레드 종료
                }
            }
            catch
            {
                return;
            }
        }
        private void Receive()
        {
            try
            {
                while (this.ClientCon)
                {
                    Thread.Sleep(1);
                    if (myStream.CanRead)
                    {
                        var msg = myRead.ReadLine();
                        var Smsg = msg.Split('&');
                        if (Smsg[0] == "S001")
                        {
                            this.tsslblTime.Text = Smsg[1];
                        }
                        else
                        {
                            if (msg.Length > 0)
                            {
                                Invoke(AddText, Smsg[0] + " : " + Smsg[1]);
                            }
                            this.tsslblTime.Text = "마지막으로 받은 시각:" + Smsg[2];
                        }
                    }
                }
            }
            catch { }
        }

        private void MessageView(string strText)
        {
            this.rtbText.AppendText(strText + "\r\n");
            this.rtbText.Focus();
            this.rtbText.ScrollToCaret();
            this.txtMessage.Focus();
            FlashWindow(this.Handle, true);
        }

        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //엔터 키를 누를때
            {
                e.Handled = true; //소리 없앰
                if (this.txtMessage.Text == "")
                {
                    this.txtMessage.Focus();
                }
                else
                {
                    Msg_send(); //Msg_send()함수 호출
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (this.txtMessage.Text == "")
            {
                this.txtMessage.Focus();
            }
            else
            {
                Msg_send(); //Msg_send()함수 호출
            }
        }

        private void Msg_send()
        {
            try
            {
                var dt = Convert.ToString(DateTime.Now);
                myWrite.WriteLine(this.myName + "&" + this.txtMessage.Text + "&" + dt);
                myWrite.Flush();
                MessageView(this.myName + ": " + this.txtMessage.Text);
                this.txtMessage.Clear();

            }
            catch
            {
                Invoke(AddText, "데이터를 보내는 동안 오류가 발생하였습니다.");
                this.txtMessage.Clear();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { ServerStop(); } //서버 종료 메서드 호출
            catch { Disconnection(); } //클라이언트 종료 메서드 호출
        }

        private void cbServer_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbServer.Checked) //서버 또는 클라이언트 체크 해제
            {
                this.txtIp.Enabled = false; //서버 모드 전환
            }
            else
            {
                this.txtIp.Enabled = true; //클라이언트 모드 전환
            }
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            if (TextChange == false && TextSend != false)
            {
                TextChange = true;
                myWrite.WriteLine("S001" + "&" + "상대방이 메시지 입력중입니다." + "&" + " ");
                myWrite.Flush();
            }
            else if (this.txtMessage.Text == "" && TextChange == true && TextSend == true)
            {
                TextChange = false;
            }
        }
    }
}

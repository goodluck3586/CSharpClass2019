using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient; //SqlConnection, SqlCommand 클래스 사용
using System.IO; //파일클래스사용
using System.Threading; //스레드클래스사용
using System.Diagnostics; //Process 클래스사용

namespace mook_AutoUpdate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Thread myDownload; //스레드개체
        private delegate void OnDelegateStatusView(int i, bool f); //델리게이트 선언
        private OnDelegateStatusView OnView = null; //델리게이트 개체 생성
        private delegate void OnDoneDelegate(); //델리게이트 선언
        private OnDoneDelegate OnDone = null; //폼 닫기 델리게이트
        private string Constr = "server=localhost;uid=mook;pwd=p12345!@;database=mook"; //SQL 연결문자열

        private void Form1_Load(object sender, EventArgs e)
        {
            OnView = new OnDelegateStatusView(ProStaus);
            OnDone = new OnDoneDelegate(OnDoneRun);

            try
            {
                var tProcess = Process.GetProcessesByName("mook_AutoMain");
                if (tProcess.Length == 1)
                    tProcess[0].Kill();
            }
            catch { }
            var fs = new FileStream("setup.txt", FileMode.Create);
            var sw = new StreamWriter(fs);
            sw.WriteLine(DataCheck());
            sw.Close();
            fs.Close();
            myDownload = new Thread(DataDownLoding);
            myDownload.Start();

        }
        private string DataCheck()
        {
            var Conn = new SqlConnection(Constr);
            Conn.Open();

            var Comm = new SqlCommand("Select * from File_Update", Conn);
            var myRead = Comm.ExecuteReader();
            if (myRead.Read())
            {
                string Update = myRead["M_Update"].ToString();
                myRead.Close();
                Conn.Close();
                return Update;
            }
            else
            {
                myRead.Close();
                Conn.Close();
                return "1";
            }
        }
        private void DataDownLoding()
        {
            byte[] bytes = DatabaseDownload(1);
            var fs = new FileStream("mook_AutoMain.exe", FileMode.Create);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();
            Invoke(OnDone);
        }

        private void OnDoneRun()
        {
            this.Close();
        }

        private byte[] DatabaseDownload(int M_Num)
        {
            using (var Conn = new SqlConnection(Constr))
            {
                Conn.Open();
                var sql = "Select DataLength(M_File) From File_Infor WHERE M_Num=@M_Num";
                SqlParameter param = new SqlParameter("@M_Num", SqlDbType.Int);
                param.Value = M_Num;
                SqlCommand cmd = new SqlCommand(sql, Conn);
                cmd.Parameters.Add(param);
                int totalLength = Convert.ToInt32(cmd.ExecuteScalar());
                Invoke(OnView, totalLength, true);
                Invoke(OnView, 0, false);
                sql = "Select M_File From File_Infor WHERE M_Num=@M_Num";
                param = new SqlParameter("@M_Num", SqlDbType.Int);
                param.Value = M_Num;
                cmd = new SqlCommand(sql, Conn);
                cmd.Parameters.Add(param);
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SequentialAccess);
                reader.Read();

                long remainder = totalLength;
                int bufferSize = 2048;
                if (totalLength < bufferSize)
                    totalLength = bufferSize;
                byte[] buf = new byte[(int)totalLength];
                int startIndex = 0;
                long retval = reader.GetBytes(0, startIndex, buf, 0, bufferSize);
                remainder -= retval;
                while (remainder > 0)
                {
                    startIndex += bufferSize;
                    if (remainder < bufferSize)
                        bufferSize = (int)remainder;
                    retval = reader.GetBytes(0, startIndex, buf, startIndex, bufferSize);
                    remainder -= retval;
                    Invoke(OnView, startIndex, false);
                    Thread.Sleep(100);
                }
                Invoke(OnView, totalLength, false);
                reader.Close();
                return buf;
            }
        }

        private void ProStaus(int i, bool f)
        {
            if (f == true)
            {
                this.ProgressBar.Maximum = i;
            }
            else
            {
                this.ProgressBar.Value = i;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this != null)
            {
                myDownload.Abort();
                var myProcess = new Process();
                myProcess.StartInfo.FileName = "mook_AutoMain.exe";
                myProcess.Start();
            }
        }
    }
}

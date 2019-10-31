using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO; //파일클래스사용
using System.Data.SqlClient; //SqlConnection 클래스사용
using System.Diagnostics; //Process 클래스사용

namespace mook_AutoMain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Constr = "server=localhost;uid=mook;pwd=p12345!@;database=mook";

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.lbldisUpdate.Text = DateTime.Now.ToString();
            int UpdateNum = 0;
            using (StreamReader srt = File.OpenText("setup.txt"))
            {
                UpdateNum = Convert.ToInt32(srt.ReadLine());
                srt.Close();
            }

            if (UpdateNum == Convert.ToInt32(DataCheck()))
            {
                return;
            }
            else if (UpdateNum < Convert.ToInt32(DataCheck()))
            {
                this.Timer.Enabled = false;
                var dlr = MessageBox.Show("최신 프로그램을 다운로드 받으시겠습니까??", "알림",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == System.Windows.Forms.DialogResult.Yes)
                {
                    var myprocess = new Process();
                    myprocess.StartInfo.FileName = "mook_AutoUpdate.exe";
                    myprocess.Start();
                    Application.Exit();
                }
                else
                {
                    this.Timer.Enabled = true;
                    return;
                }
            }
            else
            {
                MessageBox.Show("잘못된 프로그램입니다.", "알림", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }
        }

        private string DataCheck()
        {
            var Conn = new SqlConnection(Constr);
            Conn.Open();

            var Comm = new SqlCommand("Select * from File_Update", Conn);
            var myRead = Comm.ExecuteReader();
            if (myRead.Read())
            {
                var str = myRead["M_Update"].ToString();
                myRead.Close();
                Conn.Close();
                return str;
            }
            else
            {
                myRead.Close();
                Conn.Close();
                return "1";
            }
        }

        private void cbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbTime.SelectedItem.ToString() == "1초") //1초
            {
                this.Timer.Interval = 1000;
                this.Timer.Enabled = true;
            }
            else if (this.cbTime.SelectedItem.ToString() == "10초") //10초
            {
                this.Timer.Interval = 10000;
                this.Timer.Enabled = true;
            }
            else if (this.cbTime.SelectedItem.ToString() == "1분") //1분
            {
                this.Timer.Interval = 60000;
                this.Timer.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cbTime.Text = "1초"; //cbTime [Text] 속성 값 입력
            if (File.Exists("setup.txt") == false)
            {
                using (StreamWriter sw = new StreamWriter("setup.txt"))
                {
                    sw.WriteLine("1");
                    sw.Close();
                }
            }
        }
    }
}
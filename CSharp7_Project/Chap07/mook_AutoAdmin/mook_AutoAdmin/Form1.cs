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

namespace mook_AutoAdmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FileInfo f = null; //파일정보검색
        string Constr = "server=localhost;uid=mook;pwd=p12345!@;database=mook"; //서버연결문자열
        string FileName = ""; //파일 이름 저장
        string FileSize = ""; //파일 사이즈 저장
        string FileDate = ""; //파일 마지막 쓴날짜 저장

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (this.ofdFile.ShowDialog() == DialogResult.OK)
            {
                this.txtFile.Text = this.ofdFile.FileName;
                f = new FileInfo(this.ofdFile.FileName);
                this.FileName = f.Name;
                this.lblFileName.Text = this.lblFileName.Text.Split(':')[0] + ": " + f.Name;
                this.lblFileSize.Text = this.lblFileSize.Text.Split(':')[0] + ": " + GetFileSize(f.Length);
                FileSize = GetFileSize(f.Length);
                this.lblFileDate.Text = this.lblFileDate.Text.Split(':')[0] + ": " + f.LastWriteTime.ToString();
                FileDate = f.LastWriteTime.ToString();
            }
        }

        private string GetFileSize(double byteCount)
        {
            string size = "0 Bytes";
            if (byteCount >= 1073741824.0)
                size = String.Format("{0:##.##}", byteCount / 1073741824.0) + " GB";
            else if (byteCount >= 1048576.0)
                size = String.Format("{0:##.##}", byteCount / 1048576.0) + " MB";
            else if (byteCount >= 1024.0)
                size = String.Format("{0:##.##}", byteCount / 1024.0) + " KB";
            else if (byteCount > 0 && byteCount < 1024.0)
                size = byteCount.ToString() + " Bytes";

            return size;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            var fs = f.OpenRead();
            var bytebuffer = new byte[fs.Length];
            fs.Read(bytebuffer, 0, Convert.ToInt32(fs.Length));
            fs.Close();

            var conn = new SqlConnection(Constr);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            var Sql = "update File_Infor set M_File=@M_File, M_FileName = '" +
                this.FileName + "', M_Size = '" + this.FileSize + "', M_LastWrite = '" +
                this.FileDate + "', M_Date = '" + DateTime.Now.ToString() + "' where M_Num = 1";


            cmd.CommandText = Sql;
            cmd.Parameters.Add(new SqlParameter("@M_File",
                System.Data.SqlDbType.Image)).Value = bytebuffer;
            int iResult = cmd.ExecuteNonQuery();
            conn.Close();

            if (iResult > 0)
            {
                MessageBox.Show("저장이 정상적으로 되었습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (DataSave() == 0)
                {
                    MessageBox.Show("업데이트가 정상적으로 반영되지 않았습니다.", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("저장이 되지 않았습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int DataSave()
        {
            var Conn = new SqlConnection(Constr);
            Conn.Open();
            var strSQL = "update File_Update set M_Update = M_Update + 1";
            var myCom = new SqlCommand(strSQL, Conn);
            var i = myCom.ExecuteNonQuery();
            Conn.Close();
            return i;
        }
    }
}

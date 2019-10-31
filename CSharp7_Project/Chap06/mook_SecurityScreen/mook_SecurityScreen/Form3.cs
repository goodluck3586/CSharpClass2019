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
using System.Security.Cryptography; //MD5 클래스 등 사용

namespace mook_SecurityScreen
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            if (this.txtPwd.Text != "" && this.txtRePwd.Text != "")
            {
                if (this.txtPwd.Text != this.txtRePwd.Text)
                { this.lblResult.Text = "비밀번호가 다릅니다."; return; }
                else
                {
                    var sw = File.CreateText(@"config.ini");
                    var PassStr = MD5Hash(this.txtPwd.Text);
                    sw.WriteLine(PassStr);
                    sw.Close();
                    DialogResult = MessageBox.Show("비밀번호가 저장되었습니다.", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            else { this.lblResult.Text = "비밀번호를 입력하세요"; return; }
        }
        private string MD5Hash(string PwdStr)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            Byte[] hashed = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(PwdStr));
            var TransPwd = new StringBuilder();
            for (var i = 0; i < hashed.Length - 1; i++)
            {
                TransPwd.AppendFormat("{0:x2}", hashed[i]);
            }
            return TransPwd.ToString();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}

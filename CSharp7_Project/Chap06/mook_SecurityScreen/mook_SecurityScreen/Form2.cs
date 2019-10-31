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
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace mook_SecurityScreen
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(int hhk);

        private void Form2_Load(object sender, EventArgs e)
        {
            var f = new FileInfo(@"config.ini");
            if (f.Exists == true)
            {
                this.txtPwd.Focus();
            }
            else
            {
                this.Hide();
                Form3 frm3 = new Form3();
                if (frm3.ShowDialog() == DialogResult.OK) { }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cursor.Hide();
            this.txtPwd.Focus();
            this.txtPwd.Clear();
            DialogResult = DialogResult.OK;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var StrPwd = "";
            var sr = File.OpenText(@"config.ini");
            if (sr != null) { StrPwd = sr.ReadLine(); }
            sr.Close();

            if (StrPwd == MD5Hash(this.txtPwd.Text))
            {
                Cursor.Show();
                Form1 frm1 = new Form1();
                UnhookWindowsHookEx(frm1.frm2_hookID);
                EnableCtrlAltDel();
                Application.ExitThread(); //폼 종료
            }
            else { this.lblResult.Text = "비밀번호 오류"; }
        }

        public static void EnableCtrlAltDel()
        {
            try
            {
                string subKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
                RegistryKey rk = Registry.CurrentUser;
                RegistryKey sk1 = rk.OpenSubKey(subKey);

                if (sk1 != null)
                    rk.DeleteSubKeyTree(subKey);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK) { e.Cancel = true; }
        }
    }
}


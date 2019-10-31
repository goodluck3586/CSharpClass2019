using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mook_TextView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string OrgStr = ""; //결과 :  문자 저장

        private void txtEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //엔터 키를 누를때
            {
                e.Handled = true; //소리 없앰
                if (TextCheck() == true)
                {
                    this.lblResult.Text = OrgStr + this.txtEdit.Text;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (TextCheck() == true)
            {
                this.lblResult.Text = OrgStr + this.txtEdit.Text;
            }
        }

        private bool TextCheck()
        {
            if (this.txtEdit.Text != "") return true;
            else
            {
                MessageBox.Show("텍스트를 입력하세요!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtEdit.Focus();
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrgStr = this.lblResult.Text;
        }
    }
}

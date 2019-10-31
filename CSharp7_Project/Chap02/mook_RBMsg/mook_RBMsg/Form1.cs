using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mook_RBMsg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MessageBoxButtons mbb; //메시지 버튼 옵션 설정
        MessageBoxIcon mbi; //메시지 버튼 아이콘 설정

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (this.rbOk.Checked == true)
                mbb = MessageBoxButtons.OK;
            else if (this.rbOkCancel.Checked == true)
                mbb = MessageBoxButtons.OKCancel;
            else if (this.rbYesNo.Checked == true)
                mbb = MessageBoxButtons.YesNo;

            if (this.rbError.Checked == true)
                mbi = MessageBoxIcon.Error;
            else if (this.rbInformation.Checked == true)
                mbi = MessageBoxIcon.Information;
            else if (this.rbQuestion.Checked == true)
                mbi = MessageBoxIcon.Question;

            MessageBox.Show("메지시 박스를 확인하세요.", "알림", mbb, mbi);
        }
    }
}
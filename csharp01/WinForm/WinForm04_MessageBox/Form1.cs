using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm04_MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MessageBoxButtons msgBoxBtn;
        MessageBoxIcon msgBoxIcon;

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (this.rbOK.Checked == true)
                msgBoxBtn = MessageBoxButtons.OK;
            else if (this.rbOkCancel.Checked)
                msgBoxBtn = MessageBoxButtons.OKCancel;
            else if (this.rbYesNo.Checked)
                msgBoxBtn = MessageBoxButtons.YesNo;

            if (this.rbError.Checked)
                msgBoxIcon = MessageBoxIcon.Error;
            else if (this.rbInformation.Checked)
                msgBoxIcon = MessageBoxIcon.Information;
            else if (this.rbQuestion.Checked)
                msgBoxIcon = MessageBoxIcon.Question;

            MessageBox.Show("메시지 박스 입니다.", "알림", msgBoxBtn, msgBoxIcon);

        }
    }
}

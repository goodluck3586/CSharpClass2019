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

        MessageBoxButtons msgBtns;
        MessageBoxIcon msgIcon;

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (rbOK.Checked)
                msgBtns = MessageBoxButtons.OK;
            else if (rbOKCancel.Checked)
                msgBtns = MessageBoxButtons.OKCancel;
            else if (rbYesNo.Checked)
                msgBtns = MessageBoxButtons.YesNo;

            if (rbError.Checked)
                msgIcon = MessageBoxIcon.Error;
            else if (rbInformation.Checked)
                msgIcon = MessageBoxIcon.Information;
            else if (rbQuestion.Checked)
                msgIcon = MessageBoxIcon.Question;

            MessageBox.Show("메시지 박스 예제", "연습", msgBtns, msgIcon);
        }
    }
}

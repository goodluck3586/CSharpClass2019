using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm07_ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num;
        bool isFull = false;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isFull)
            {
                btnStart.Text = "시작";
                progressBar1.Value = 0;
                num = 0;
                labelStatus.Text = "진행 상태 : 0%";
                isFull = false;
            }
            else
            {
                timer1.Enabled = true;  // 타이머 켬.
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            num++;
            if (num > 100)
            {
                // 타이머 종료
                timer1.Enabled = false;
                btnStart.Text = "초기화";
                isFull = true;
                return;
            }
            progressBar1.Value = num;
            labelStatus.Text = $"진행 상태 : {num}%";
        }
    }
}

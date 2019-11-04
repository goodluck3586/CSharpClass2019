using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm06_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int countdownNum;

        private void button1_Click(object sender, EventArgs e)
        {
            if (IntCheck())
            {
                this.timer1.Enabled = true;  // 타이머 켬.
            }
            textBox1.Clear();
        }

        private bool IntCheck()
        {
            if(Int32.TryParse(textBox1.Text, out countdownNum))
            {
                return true;
            }
            return false;
        }

        // Timer의 Interval 간격마다 실행(1초 마다 실행)
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countdownNum >= 0)
            {
                label1.Text = countdownNum.ToString();
                countdownNum--;
            }
            else
            {
                timer1.Enabled = false;  // 타이머 종료
                MessageBox.Show("타이머 종료됨.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

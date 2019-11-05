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

        private void button1_Click(object sender, EventArgs e)
        {
            if (isFull)
            {
                progressBar1.Value = 0;
                num = 0;
                label1.Text = "진행 상태 : 0%";
                isFull = false;
                button1.Text = "시작";
            }
            else
            {
                timer1.Enabled = true;
            } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            num++;
            if (num > 100)
            {
                timer1.Enabled = false;
                button1.Text = "초기화";
                isFull = true;
                return;
            }
            progressBar1.Value = num;
            label1.Text = $"진행 상태 : {num}%";
        }
    }
}

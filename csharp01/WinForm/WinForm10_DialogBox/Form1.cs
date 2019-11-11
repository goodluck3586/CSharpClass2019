using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm10_DialogBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Dig = new Form2();
            // Dig.ShowDialog();  // 새로 열린 폼이 종료되야 사용 가능
            // Dig.Show();  // 두 폼 모두 사용 가능

            if (Dig.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("정상 종료");
            }
            
        }

        public string Message { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Dig = new Form2();
            // Form2에서 Form1을 참조할 수 있는 참조 저장
            Dig.Owner = this;  // this = Form1

            Message = textBox1.Text;
            Dig.ShowDialog();  // From2 띄우기

            label1.Text = $"합계: {Dig.num1 + Dig.num2}";
        }
    }
}

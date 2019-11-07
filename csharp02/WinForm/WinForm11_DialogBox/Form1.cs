using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm11_DialogBox
{
    public partial class Form1 : Form
    {
        public string Msg;
        public Form1()
        {
            InitializeComponent();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Dig = new Form2();
            //Dig.ShowDialog();   // 폼 띄우기(Modal)
            //Dig.Show();  // 폼 띄우기(Modaless)

            if (Dig.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("정상 종료");
            }
            Dig.Dispose();  // Form2의 리소스 해제
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Dig = new Form2();
            Dig.Owner = this;  // this = Form1
            Msg = textBox1.Text;
            textBox1.Clear();
            Dig.ShowDialog();

            label1.Text = $"계산 결과: {Dig.num1 + Dig.num2}";

            Dig.Dispose();
        }
    }
}

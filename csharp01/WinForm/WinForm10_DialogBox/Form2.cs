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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int num1, num2;

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2))
            {
                Close();  // 폼2 닫기
            }
            else
            {
                MessageBox.Show("잘못된 입력입니다.");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 mainForm = Owner as Form1;  // unboxing
            if (mainForm != null)
            {
                label1.Text = mainForm.Message;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm03_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextChecker())
                label1.Text = "결과 : " + textBox1.Text;
            textBox1.Clear();  // textBox1.Text="";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if(TextChecker())
                    label1.Text = "결과 : " + textBox1.Text;
                textBox1.Clear();  // textBox1.Text="";
            }
        }

        bool TextChecker()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("텍스트를 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}

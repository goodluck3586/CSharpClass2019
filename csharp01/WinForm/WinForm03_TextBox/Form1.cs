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

        string strResult;
        private void Form1_Load(object sender, EventArgs e)
        {
            strResult = this.label1.Text;  // "결과 : " 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TextBox가 비어있지 않으면 입력된 텍스트를 label1에 출력한다.
            if (TextChecker())
            {
                this.label1.Text = strResult + this.textBox1.Text;
                this.textBox1.Text = "";
            }
        }

        private bool TextChecker()
        {
            if (this.textBox1.Text != "")
                return true;
            else
            {
                MessageBox.Show("텍스트를 입력하세요.");
                this.textBox1.Focus();
                return false;
            }
                
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 엔터키가 눌리면 TextBox의 텍스트를 label1에 출력함.
            if(e.KeyChar == (char)Keys.Enter)
            {
                if (TextChecker())
                {
                    this.label1.Text = strResult + this.textBox1.Text;
                }
                this.textBox1.Text = "";
            }
        }
    }
}

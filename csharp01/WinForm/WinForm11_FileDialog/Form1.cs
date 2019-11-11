using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm11_FileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|이미지 파일|*.jpg";

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    using(StreamWriter sw = new StreamWriter(myStream))
                    {
                        sw.Write(textBox1.Text);
                    }
                    textBox1.Clear();  // 텍스트 박스의 내용 지우기
                }
            }
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if((myStream = openFileDialog1.OpenFile()) != null)
                {
                    using(StreamReader sr = new StreamReader(myStream))
                    {
                        textBox1.Text = sr.ReadToEnd();
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm05_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "")
            {
                this.comboBox1.Items.Add(this.textBox1.Text);
                MessageBox.Show("메뉴가 추가됨.");
            }
            else
            {
                MessageBox.Show("텍스트를 입력하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.textBox1.Focus();
            }
            this.textBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.Text != "")
                this.label1.Text = "선택 결과 : " + this.comboBox1.Text;
        }
    }
}

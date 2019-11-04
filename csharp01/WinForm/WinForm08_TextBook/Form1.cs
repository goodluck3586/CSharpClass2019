using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* 694p 예제 */
namespace WinForm08_TextBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;  // 운영체제에 설치된 폰트 목록 가져오기
            foreach (FontFamily font in Fonts)
            {
                cboFont.Items.Add(font.Name);
            }
        }

        void ChangeFont()
        {
            if (cboFont.SelectedIndex < 0)
                return;

            FontStyle style = FontStyle.Regular;

            if (chbBold.Checked)
                style |= FontStyle.Bold;  // 0 | 1 => 1
            if (chbItalic.Checked)
                style |= FontStyle.Italic;  // 1 | 2 => 3

            txtSampleText.Font = new Font((string)cboFont.SelectedItem, 20, style);
        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chbBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chbItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }
    }
}

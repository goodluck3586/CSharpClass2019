using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm12_Textbook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;  // 운영체제에 설치되어 있는 폰트 목록 검색
            foreach (var font in Fonts)
            {
                cboFont.Items.Add(font.Name);
            }
        }

        void ChangeFont()
        {
            if (cboFont.SelectedIndex < 0)  // 콤보박스에서 선택한 폰트가 없으면 메서드 종료
                return;

            FontStyle style = FontStyle.Regular;  // FontStyle 객체 초기화, public enum class FontStyle

            if (chkBold.Checked)  // "굵게" 체크 박스가 선택된 상태이면 Bold 논리합 수행
                style |= FontStyle.Bold;

            if (chkItalic.Checked)
                style |= FontStyle.Italic;

            // txtSampleText의 폰트를 위에서 만든 style로 수정
            txtSampleText.Font = new Font((string)cboFont.SelectedItem, 20, style);
        }


        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void tbDummy_Scroll(object sender, EventArgs e)
        {
            pbDummy.Value = tbDummy.Value;
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modal Form";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Red;
            frm.ShowDialog();
        }

        private void btnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modaless Form";
            frm.Width = 300;
            frm.Height = 300;
            frm.BackColor = Color.Green;
            frm.Show();
        }

        private void btnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSampleText.Text, "MessageBox Test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}

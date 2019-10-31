using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Imaging;

namespace mook_WaterMark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap ImageFile = null; //비트맵 이미지 리소스 저장
        bool fnset = false; //글꼴
        bool fncol = false; //글 색상

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (this.ofdFile.ShowDialog() == DialogResult.OK)
                this.txtBack.Text = this.ofdFile.FileName;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (txtCheck())
            {
                Mark.BackImgPath = this.txtBack.Text;
                Mark.MarkImgText = this.txtMark.Text;
                Mark.MarkOpacity = this.hsbOpacity.Value;
                this.picbView.Image = Mark.NewImage().Image;
            }
        }
        private bool txtCheck()
        {
            if (this.txtBack.Text == "")
            {
                MessageBox.Show("배경 이미지 파일을 선택하지 않았습니다.",
                    "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (this.txtMark.Text == "")
            {
                MessageBox.Show("마킹 이미지 파일을 선택하지 않았습니다.",
                    "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (!fnset)
            {
                MessageBox.Show("마킹 글꼴을 선택하지 않았습니다.",
                    "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (!fncol)
            {
                MessageBox.Show("마킹 색상을 선택하지 않았습니다.",
                    "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.picbView.Image != null)
            {
                if (this.sfdImage.ShowDialog() == DialogResult.OK)
                {
                    ImageFile = new Bitmap(Mark.ImageSize.Width, Mark.ImageSize.Height);
                    ImageFile = (Bitmap)this.picbView.Image;
                    this.ImageFile.Save(sfdImage.FileName, ImageFormat.Jpeg);
                }
            }
        }

        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.fdlg.ShowDialog() == DialogResult.OK)
            {
                Mark.fnSet = this.fdlg.Font;
                fnset = true;
            }
        }

        private void 색상ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.cdlg.ShowDialog() == DialogResult.OK)
            {
                Mark.fnCol = this.cdlg.Color;
                fncol = true;
            }
        }
    }
}

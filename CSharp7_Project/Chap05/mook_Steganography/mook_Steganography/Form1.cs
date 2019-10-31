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
using System.IO;

namespace mook_Steganography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap ImgBmp = null;
        SteganographyConvert stgpcvt = new SteganographyConvert();

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            this.lbResult.Text = "Result : 0개의 필셀이 변경되었습니다.";
            if (this.pbImgView.Image == null)
            {
                MessageBox.Show("이미지를 선택해 주세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ImgBmp = (Bitmap)this.pbImgView.Image;

            string HiddenText = this.txtData.Text;

            if (HiddenText.Equals(""))
            {
                MessageBox.Show("이미지에 숨길 문자열을 입력하세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtData.Focus();
                return;
            }

            if (this.txtKey.Text.Length < 8)
            {
                MessageBox.Show("비밀키는 8자리 이상 문자를 입력하세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtKey.Focus();
                return;
            }
            else
            {
                HiddenText = Crypto.EncryptStringAES(HiddenText, this.txtKey.Text);
            }
            stgpcvt.runNum += new SteganographyConvert.ProcessEventHandler(StegaStatus);
            ImgBmp = stgpcvt.embedText(HiddenText, ImgBmp);

            if (this.sfdFile.ShowDialog() == DialogResult.OK)
            {
                switch (this.sfdFile.FilterIndex)
                {
                    case 0:
                        {
                            ImgBmp.Save(this.sfdFile.FileName, ImageFormat.Png);
                        }
                        break;
                    case 1:
                        {
                            ImgBmp.Save(this.sfdFile.FileName, ImageFormat.Bmp);
                        }
                        break;
                }
            }
            ControlClearAll();
        }

        private void ControlClearAll()
        {
            this.pbImgView.Image = null;
            this.txtData.Clear();
            this.txtKey.Clear();
            this.btnEncrypt.Enabled = false;
            this.btnDecrypt.Enabled = false;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            this.lbResult.Text = "Result : 0개의 필셀이 변경되었습니다.";
            ImgBmp = (Bitmap)this.pbImgView.Image;

            stgpcvt.runNum += new SteganographyConvert.ProcessEventHandler(StegaStatus);
            string ExtractedText = stgpcvt.ExtractText(ImgBmp);

            try
            {
                ExtractedText = Crypto.DecryptStringAES(ExtractedText, this.txtKey.Text);
            }
            catch
            {
                MessageBox.Show("비밀키가 일치하지 않습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtKey.Focus();
                return;
            }

            this.txtData.Text = ExtractedText;
        }

        private void StegaStatus(int Current)
        {
            this.lbResult.Text = "Result : " + Current.ToString() + "개의 필셀이 변경되었습니다.";
            Application.DoEvents();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ofdFile.ShowDialog() == DialogResult.OK)
            {
                this.pbImgView.Image = Image.FromFile(this.ofdFile.FileName);
                this.btnEncrypt.Enabled = true;
                this.btnDecrypt.Enabled = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mook_Image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int ImgCount = 0; //이미지 번호

        private void Form1_Load(object sender, EventArgs e)
        {
            this.picImg.Image = (Image)this.ImgList.Images[0];
            ImgCount = this.ImgList.Images.Count;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ImgCount--;
            if (ImgCount < 0)
                ImgCount = this.ImgList.Images.Count - 1;

            this.picImg.Image = (Image)this.ImgList.Images[ImgCount];
        }
    }
}

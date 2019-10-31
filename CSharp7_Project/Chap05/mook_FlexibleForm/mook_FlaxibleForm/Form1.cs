using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mook_FlexibleForm
{
    public partial class Form1 : Form
    {

        private Bitmap bmpFrmBg = new Bitmap(typeof(Form1), "bg.bmp");
        private Bitmap bmpcloseUp = new Bitmap(typeof(Form1), "closeup.bmp");
        private Bitmap bmpcloseDown = new Bitmap(typeof(Form1), "closedown.bmp");

        public Form1()
        {
            InitializeComponent();

            FlexibleForm.CreateControlRegion(this, bmpFrmBg);
            FlexibleForm.CreateControlRegion(btnClose, bmpcloseUp);
        }

        private bool FormMouseDown = false;
        Point ptMouseCurrentPos; // 마우스 클릭 좌표 지정
        Point ptMouseNewPos; // 이동시 마우스 좌표
        Point ptFormCurrentPos; // 폼 위치 좌표 지정
        Point ptFormNewPos; // 이동시 폼 위치 좌표

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            FlexibleForm.CreateControlRegion(btnClose, bmpcloseDown);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            FlexibleForm.CreateControlRegion(btnClose, bmpcloseUp);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (FormMouseDown == true) // 왼쪽 마우스 클릭시
            {
                ptMouseNewPos = Control.MousePosition;
                ptFormNewPos.X = ptMouseNewPos.X - ptMouseCurrentPos.X + ptFormCurrentPos.X; //마우스 이동시 가로 좌표
                ptFormNewPos.Y = ptMouseNewPos.Y - ptMouseCurrentPos.Y + ptFormCurrentPos.Y; //마우스 이동시 세로 좌표
                this.Location = ptFormNewPos;
                ptFormCurrentPos = ptFormNewPos;
                ptMouseCurrentPos = ptMouseNewPos;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                FormMouseDown = false; // 왼쪽 마우스 클릭 해체 체크
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormMouseDown = true; // 왼쪽 마우스 클릭 체크
                ptMouseCurrentPos = Control.MousePosition; // 마우스 클릭 좌표
                ptFormCurrentPos = this.Location; // 폼의 위치 좌표
            }
        }
    }
}

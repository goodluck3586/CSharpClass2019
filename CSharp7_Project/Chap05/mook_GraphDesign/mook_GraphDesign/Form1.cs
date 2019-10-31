using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mook_GraphDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();  //랜덤 수 생성을 위한 클래스 생성

        private void Form1_Load(object sender, EventArgs e)
        {
            GraphCore.OpenType =
                mook_GraphCore.mook_GraphCore.ChartControlOpenType.Bar;
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            GraphCore.OpenType =
                mook_GraphCore.mook_GraphCore.ChartControlOpenType.Graph;
        }

        private void btnBar_Click(object sender, EventArgs e)
        {
            GraphCore.OpenType =
                mook_GraphCore.mook_GraphCore.ChartControlOpenType.Bar;
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            double ValueAdd;
            int n = r.Next(1, 45);
            int s = r.Next(1, 3);
            try
            {
                if (s / 2 == 0)
                    ValueAdd = Convert.ToDouble(n);
                else
                    ValueAdd = Convert.ToDouble(-n);
                GraphCore.AddValue((float)ValueAdd);
                GraphCore.RefreshControl();
            }
            catch
            {
                return;
            }
        }
    }
}
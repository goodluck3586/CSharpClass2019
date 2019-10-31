using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mook_GraphCore
{
    public partial class mook_GraphCore : UserControl
    {
        public mook_GraphCore()
        {
            InitializeComponent();

            OpenType = ChartControlOpenType.Bar;

            LoadDefaultValues();

            InitChart();
        }
        public float Maximum
        {
            get
            {
                return m_Maximum;
            }
        }
        public float Minimum
        {
            get
            {
                return m_Minimum;
            }
        }

        public enum ChartControlOpenType
        {
            Bar,
            Graph
        };

        public int PixelsPer; //그래프 그리는 가로 세로 선 간격
        public int LineDifference; //그래프 그리는 가로 세로 선 간격
        public float ValueMultiplier; //진행률과 진행상태
        public Color AboveColor, UnderColor, GridColor, ChartBackColor, AxesColor; //선, 백그라운드 색상
        public ChartControlOpenType OpenType;

        private Graphics g;
        private float[] Values; //그래프 값 저장 배열
        private float m_Maximum, m_Minimum;
        private int CurrentYGridStart; //그래프 시작
        private int CurrentNumberOfValues; //그래프 번호

        private Size CurrentSize = new Size(0, 0); //그래프 사이즈


        private void LoadDefaultValues()
        {
            g = plChart.CreateGraphics();
            PixelsPer = 10;
            ChartBackColor = Color.Black;
            GridColor = Color.Green;
            AboveColor = Color.Chartreuse;
            UnderColor = Color.Red;
            AxesColor = Color.White;
            CurrentYGridStart = 0;
            ValueMultiplier = 1;
            m_Maximum = plChart.Size.Height / 2;
            m_Minimum = (-1) * (plChart.Size.Height / 2);
            LineDifference = 1;

            if (OpenType == ChartControlOpenType.Bar)
                Values = new float[plChart.Size.Width];
            else
                Values = new float[plChart.Size.Width / 2];

            for (int i = 0; i < Values.Length; i++)
                Values[i] = 0;

            CurrentNumberOfValues = 0;
        }

        public void RefreshControl()
        {
            PostInitChart();
            DrawChart();
        }

        public void AddValue(float val)
        {
            if ((Minimum != 0) && (Maximum != 0))
                if ((val * ValueMultiplier > Maximum) || (val * ValueMultiplier < Minimum))
                    return;
            for (int i = 0; i < Values.Length - 1; i++)
                Values[i] = Values[i + 1];
            Values[Values.Length - 1] = val * ValueMultiplier;

            if (CurrentNumberOfValues < Values.Length)
                CurrentNumberOfValues++;

            if (CurrentYGridStart < PixelsPer * LineDifference - 1)
            {
                if (OpenType == ChartControlOpenType.Bar)
                    CurrentYGridStart++;
                else
                    CurrentYGridStart += 2;
            }
            else
            {
                CurrentYGridStart = 0;
            }

            DrawChart();
        }

        public void InitChart()
        {
            CurrentYGridStart = 0;
            PostInitChart();
        }

        public int IntCmp(float num1, float num2)
        {
            if ((num1 >= 0) && (num2 >= 0))
                return 0;
            if ((num1 < 0) && (num2 < 0))
                return 0;
            if ((num1 >= 0) && (num2 < 0))
                return 1;
            if ((num1 < 0) && (num2 >= 0))
                return -1;

            return 0;
        }

        private void plChart_Paint(object sender, PaintEventArgs e)
        {
            if (this.plChart != null)
                OnResize(new EventArgs());
        }

        public void PostInitChart()
        {
            if ((plChart.Height != 0) && (plChart.Width != 0))
            {
                g.Clear(ChartBackColor);

                DrawGrid();
            }
        }

        private void DrawGrid()
        {
            for (int i = (plChart.Size.Height / 2) + PixelsPer * LineDifference; i < plChart.Size.Height; i += PixelsPer * LineDifference)
                g.DrawLine(new Pen(GridColor), 0, i, plChart.Size.Width, i);


            for (int i = (plChart.Size.Height / 2) - PixelsPer * LineDifference; i > 0; i -= PixelsPer * LineDifference)
                g.DrawLine(new Pen(GridColor), 0, i, plChart.Size.Width, i);

            for (int i = CurrentYGridStart; i < plChart.Size.Width; i += PixelsPer * LineDifference)
                g.DrawLine(new Pen(GridColor), i, 0, i, plChart.Size.Height);

            g.DrawLine(new Pen(AxesColor), 0, (int)(plChart.Size.Height / 2), plChart.Size.Width, (int)(plChart.Size.Height / 2));

        }

        private void DrawChart()
        {
            PostInitChart();

            Pen AbovePen = new Pen(AboveColor);
            Pen UnderPen = new Pen(UnderColor);

            if (OpenType == ChartControlOpenType.Bar)
            {

                for (int i = Values.Length - CurrentNumberOfValues; i < Values.Length; i++)
                {
                    if (Values[i] > 0)
                    {
                        g.DrawLine(AbovePen, Values.Length - i - 1, (int)(plChart.Size.Height / 2) - 1, Values.Length - i - 1, (int)(plChart.Size.Height / 2) - Values[i]);
                    }
                    if (Values[i] < 0)
                    {
                        g.DrawLine(UnderPen, Values.Length - i - 1, (int)(plChart.Size.Height / 2) + 1, Values.Length - i - 1, (int)(plChart.Size.Height / 2) - Values[i]);
                    }
                }
            }
            else if (OpenType == ChartControlOpenType.Graph)
            {
                for (int i = Values.Length - CurrentNumberOfValues; i < Values.Length; i++)
                {
                    if (Values[i] >= 0)
                    {
                        if (IntCmp(Values[i], Values[i - 1]) > 0)
                        {
                            g.DrawLine(UnderPen, (Values.Length - i) * 2, (int)(plChart.Size.Height / 2) - Values[i - 1], (Values.Length - i) * 2 - 1, (int)(plChart.Size.Height / 2));
                            g.DrawLine(AbovePen, (Values.Length - i) * 2 - 1, (int)(plChart.Size.Height / 2), (Values.Length - i - 1) * 2, (int)(plChart.Size.Height / 2) - Values[i]);
                        }
                        else
                        {
                            g.DrawLine(AbovePen, (Values.Length - i) * 2, (int)(plChart.Size.Height / 2) - Values[i - 1], (Values.Length - i - 1) * 2, (int)(plChart.Size.Height / 2) - Values[i]);
                        }
                    }
                    if (Values[i] < 0)
                    {
                        if (IntCmp(Values[i], Values[i - 1]) < 0)
                        {
                            g.DrawLine(AbovePen, (Values.Length - i) * 2, (int)(plChart.Size.Height / 2) - Values[i - 1], (Values.Length - i) * 2 - 1, (int)(plChart.Size.Height / 2));
                            g.DrawLine(UnderPen, (Values.Length - i) * 2 - 1, (int)(plChart.Size.Height / 2), (Values.Length - i - 1) * 2, (int)(plChart.Size.Height / 2) - Values[i]);
                        }
                        else
                        {
                            g.DrawLine(UnderPen, (Values.Length - i) * 2, (int)(plChart.Size.Height / 2) - Values[i - 1], (Values.Length - i - 1) * 2, (int)(plChart.Size.Height / 2) - Values[i]);
                        }
                    }
                }
            }

            UnderPen.Dispose();
            AbovePen.Dispose();
        }
        private void RecalculateSize()
        {
            if ((CurrentSize.Height != 0) && (CurrentSize.Width != 0))
            {
                m_Maximum = plChart.Size.Height / 2;
                m_Minimum = (-1) * (plChart.Size.Height / 2);

                float SizeChange = ((float)Size.Height / (float)CurrentSize.Height);

                if (Size.Height != 0)
                    ValueMultiplier *= SizeChange;

                int i, j;

                float[] NewValues = new float[Size.Width];

                for (i = Values.Length - 1, j = NewValues.Length - 1; ((i >= 0) && (j >= 0)); i--, j--)
                {
                    if (SizeChange != 0)
                        NewValues[j] = Values[i] * SizeChange;
                }

                Values = NewValues;

                g.Dispose();
                g = plChart.CreateGraphics();

                DrawChart();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (plChart != null)
            {

                if ((Size.Height == 0) || (Size.Width == 0))
                    return;

                if ((CurrentSize.Height == 0) && (CurrentSize.Width == 0))
                {
                    CurrentSize = Size;
                    return;
                }

                RecalculateSize();
                CurrentSize = Size;
            }
        }
    }
}

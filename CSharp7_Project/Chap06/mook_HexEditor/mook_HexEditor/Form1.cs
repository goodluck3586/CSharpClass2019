using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Threading;

namespace mook_HexEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string fileName = ""; //파일 이름 저장
        private Thread HexAnalysis = null; //파일 헥사 분석 스레드
        private delegate void OnHexViewDelegate(int i, string s); //델리게이트 선언
        private OnHexViewDelegate OnView = null; //델리게이트 선언

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (this.ofdFile.ShowDialog() == DialogResult.OK)
            {
                fileName = ofdFile.FileName;
                this.HexView.Text = "";

                int fsize = getFileSize(fileName);
                if (fsize > 0)
                {
                    HexAnalysis = new Thread(new ParameterizedThreadStart(hexEditor));
                    HexAnalysis.Start(fileName + "?" + fsize);
                }
                else
                {
                    this.HexView.AppendText("\n 파일 선택이 잘 못 되었습니다. \n");
                }
            }
        }

        private int getFileSize(string inFile)
        {
            long size = -1;
            try
            {
                FileInfo fi = new FileInfo(inFile);
                size = fi.Length;
                if (size > 2147483640)
                {
                    return -1;
                }
                else
                {
                    return (int)size;
                }
            }
            catch
            {
                return -1;
            }
        }

        private void hexEditor(object _inFileinSize)
        {
            var inFile = _inFileinSize.ToString().Split('?')[0];
            int inSize = Convert.ToInt32(_inFileinSize.ToString().Split('?')[1]);

            StringBuilder biglocal = new StringBuilder();
            StringBuilder sblocal = new StringBuilder();

            string message = "\n " + fileName + " " + (int)inSize + " bytes\n\n";
            Invoke(OnView, 0, message);
            Invoke(OnView, 1, " " + fileName + " " + (int)inSize + " bytes");

            FileStream fs;
            byte[] MyData;
            try
            {
                fs = new FileStream
                    ((string)inFile, FileMode.OpenOrCreate, FileAccess.Read);
                MyData = new byte[fs.Length];
            }
            catch
            {
                Invoke(OnView, 0, "\n 파일 분석에 오류가 발생하였습니다.\n\n");
                return;
            }

            Invoke(OnView, 1, "하드 디스크 파일 분석");

            fs.Read(MyData, 0, (int)fs.Length);
            fs.Close();

            int newrow = 0; //라인
            int global = 0; //Offset 넘버링
            string hex = " "; //hex 값
            string numb = " "; //offset 값

            Invoke(OnView, 2, MyData.Length.ToString());
            Invoke(OnView, 3, (0).ToString());
            Invoke(OnView, 1, "메모리 영역 분석");

            for (int i = 0; i < MyData.Length; ++i)
            {
                if (i % 1000 == 0)
                {
                    Invoke(OnView, 3, (i).ToString());
                }

                if (newrow == 0)
                {
                    numb = padZeros(global);
                    biglocal.Append(" " + numb + " ");
                    global += 16;
                }

                hex = convertByteToHexString(MyData[i]);
                biglocal.Append(" " + hex);	// 3 characters

                int g = MyData[i];
                if (g > 32 && g < 126)
                {
                    sblocal.Append((char)MyData[i]);
                }
                else
                {
                    sblocal.Append(".");
                }

                ++newrow;
                if (newrow >= 16)
                {
                    biglocal.Append("   " + sblocal.ToString() + "\n");
                    sblocal = new StringBuilder();
                    newrow = 0;
                }
            }

            if (newrow > 0 && newrow < 16)
            {
                for (int i = 0; i < (16 - newrow); ++i)
                {
                    biglocal.Append("   ");
                }
                biglocal.Append("   " + sblocal);
            }
            biglocal.Append("\n");
            Invoke(OnView, 1, "Hex 값을 쓰기");
            Invoke(OnView, 0, biglocal.ToString());
            Invoke(OnView, 1, "작업 완료");
            Invoke(OnView, 3, MyData.Length.ToString());
            HexAnalysis.Abort();
        }

        private string padZeros(int inInt)
        {
            StringBuilder sblocal = new StringBuilder();
            string hex = Convert.ToString(inInt, 16);
            if (hex.Length < 8)
            {
                int ix = 8 - hex.Length;
                for (int i = 0; i < ix; ++i)
                {
                    sblocal.Append("0");
                }
            }
            sblocal.Append(hex);
            return sblocal.ToString().ToUpper();
        }

        public string convertByteToHexString(byte inByte)
        {
            StringBuilder sblocal = new StringBuilder();
            string hex = Convert.ToString(inByte, 16);
            if (hex.Length == 1)
            {
                sblocal.Append("0");
                sblocal.Append(hex);
            }
            else
            {
                sblocal.Append(hex);
            }
            return sblocal.ToString().ToUpper();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnView = new OnHexViewDelegate(OnViewRun);
        }

        private void OnViewRun(int i, string s)
        {
            if (i == 0)
                this.HexView.AppendText(s);
            else if (i == 1)
                this.stbView.Text = s;
            else if (i == 2)
                this.pgbView.Maximum = Convert.ToInt32(s);
            else if (i == 3)
                this.pgbView.Value = Convert.ToInt32(s);
        }
    }
}


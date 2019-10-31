using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace mook_PreventKillAgent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int WM_COPYDATA = 0x4A;

        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;
        }

        protected override void WndProc(ref Message m)
        {
            try
            {
                switch (m.Msg)
                {
                    case WM_COPYDATA:
                        COPYDATASTRUCT cds = (COPYDATASTRUCT)m.GetLParam(typeof(COPYDATASTRUCT));
                        if (cds.lpData.Split('$')[0] == "001") //데이터 전달
                        {
                            Msg = cds.lpData.Split('$')[1];
                            this.lblMsg.Text = "메시지 : " + Msg;
                        }
                        break;
                    default:
                        base.WndProc(ref m);
                        break;
                }
            }
            catch { }
        }

        private void VisibleChange(Boolean FormVisible, Boolean TrayIconVisible)
        {
            this.Visible = FormVisible;
            this.nyiTray.Visible = TrayIconVisible;
        }

        private string Msg = String.Empty; //전달 받은 데이터 저장

        private void Form1_Load(object sender, EventArgs e)
        {
            VisibleChange(true, false);
            var tproc = Process.GetProcessesByName("mook_PreventKill");
            if (tproc.Length == 0)
            {
                var proc = new Process();
                proc.StartInfo.FileName = "mook_PreventKill.exe";
                proc.Start();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            VisibleChange(false, true);
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleChange(true, false);
        }

        private void 종료EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            var tproc = Process.GetProcessesByName("mook_PreventKill");
            if (tproc.Length == 1)
                tproc[0].Kill();
            this.Dispose();
            Application.Exit();
        }

        private void nyiTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VisibleChange(true, false);
        }
    }
}

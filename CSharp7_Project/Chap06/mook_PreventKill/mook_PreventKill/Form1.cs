using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;

namespace mook_PreventKill
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

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, ref COPYDATASTRUCT lParam);

        private Thread MsgSendThre = null; //시스템 시간 전송
        private Thread ProcKillChk = null; //mook_PreventKillAgent 종료 방지
        IntPtr Inthwd; //프로세스 핸들 값

        private void MsgSendThreRun()
        {
            while (true)
            {
                Thread.Sleep(1000);
                var tproc = Process.GetProcessesByName("mook_PreventKillAgent");
                if (tproc.Length != 0)
                {
                    Inthwd = tproc[0].MainWindowHandle;
                    byte[] buff = System.Text.Encoding.Default.GetBytes("001$" + DateTime.Now.ToString());
                    COPYDATASTRUCT cds = new COPYDATASTRUCT();
                    cds.dwData = IntPtr.Zero;
                    cds.cbData = buff.Length + 1;
                    cds.lpData = "001$" + DateTime.Now.ToString();
                    SendMessage(Inthwd, WM_COPYDATA, 0, ref cds);
                }
                Thread.Sleep(2000);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MsgSendThre = new Thread(MsgSendThreRun);
            MsgSendThre.Start();
            ProcKillChk = new Thread(ProcKillChkRun);
            ProcKillChk.Start();
        }

        private void ProcKillChkRun()
        {
            while (true)
            {
                var tproc = Process.GetProcessesByName("mook_PreventKillAgent");
                if (tproc.Length == 1) continue;
                else
                {
                    var proc = new Process();
                    proc.StartInfo.FileName = "mook_PreventKillAgent.exe";
                    proc.Start();
                }
                Thread.Sleep(1);
            }
        }
    }
}

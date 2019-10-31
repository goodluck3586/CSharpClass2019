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
using System.Runtime.InteropServices;
using System.Threading;

namespace mook_NetDrive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string NetDrive = "";
        string NDrive = "";
        string UserID = "";
        string UserPwd = "";
        string Drive = "";

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct NETRESOURCE
        {
            public uint dwScope;
            public uint dwType;
            public uint dwDisplayType;
            public uint dwUsage;
            public string lpLocalName;
            public string lpRemoteName;
            public string lpComment;
            public string lpProvider;
        }

        [DllImport("mpr.dll", CharSet = CharSet.Auto)]
        public static extern int WNetUseConnection(
            IntPtr hwndOwner,
            [MarshalAs(UnmanagedType.Struct)] ref NETRESOURCE lpNetResource,
            string lpPassword,
            string lpUserID,
            uint dwFlags,
            StringBuilder lpAccessName,
            ref int lpBufferSize,
            out uint lpResult);

        [DllImport("mpr.dll")]
        public static extern int WNetCancelConnection2(string lpName, Int32 dwFlags, bool fForce);
        private const int CONNECT_UPDATE_PROFILE = 0x1;
        private const int NO_ERROR = 0;

        [DllImport("wininet.dll")]
        public extern static bool InternetGetConnectedState(out int description, int reservedValue);

        Thread ConnThre = null;
        private delegate void OnDelegateConn(bool Flag);
        private OnDelegateConn OnConn = null;

        Thread FileThre = null;
        private delegate void OnDelegateFile(string fn, string fd, string ft, double fs);
        private OnDelegateFile OnFile = null;

        private void btnConnector_Click(object sender, EventArgs e)
        {
            NDrive = this.txtNDrive.Text;
            UserID = this.txtUserID.Text;
            UserPwd = this.txtUserPwd.Text;
            Drive = this.txtDrive.Text;
            NetDrive = Drive + @"\";

            ConnThre = new Thread(NetDriveCheck);
            ConnThre.Start();
        }


        private void NetDriveCheck()
        {
            int capacity = 64;
            uint resultFlags = 0;
            uint flags = 0;

            string strRemoteConnectString = NDrive;
            string strRemoteUserID = UserID;
            string strRemotePWD = UserPwd;

            StringBuilder sb = new StringBuilder(capacity);
            NETRESOURCE ns = new NETRESOURCE();

            ns.dwType = 1;    //공유디스크
            ns.lpLocalName = Drive;    //로컬 드라이브 지정하지 않음
            ns.lpRemoteName = strRemoteConnectString;
            ns.lpProvider = null;
            int result = 100;
            while (true)
            {
                result = WNetUseConnection(IntPtr.Zero, ref ns, strRemotePWD, strRemoteUserID, flags, sb, ref capacity, out resultFlags);
                if (result == 0)
                {
                    break;
                }
                Thread.Sleep(100);
            }
            Invoke(OnConn, true);
            ConnThre.Abort();
        }

        private void OnDelConn(bool Flag)
        {
            if (Flag == true)
            {
                FileThre = new Thread(FileList);
                FileThre.Start();
            }
            else
                MessageBox.Show("네트워크 드라이브 연결에 실패하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FileList()
        {
            DirectoryInfo di = new DirectoryInfo(NetDrive);
            foreach (var fs in di.GetFiles())
            {
                Invoke(OnFile, fs.Name, fs.LastWriteTime.ToString(), fs.Extension, (double)fs.Length);
            }
            FileThre.Abort();
        }

        private void OnDelFile(string fn, string fd, string ft, double fs)
        {
            string FSize = GetFileSize(fs);
            this.lvFile.Items.Add(new ListViewItem(new string[] { fn, fd, ft, FSize }));
        }

        private string GetFileSize(double byteCount)
        {
            string size = "0 Bytes";
            if (byteCount >= 1073741824.0)
                size = String.Format("{0:##.##}", byteCount / 1073741824.0) + " GB";
            else if (byteCount >= 1048576.0)
                size = String.Format("{0:##.##}", byteCount / 1048576.0) + " MB";
            else if (byteCount >= 1024.0)
                size = String.Format("{0:##.##}", byteCount / 1024.0) + " KB";
            else if (byteCount > 0 && byteCount < 1024.0)
                size = byteCount.ToString() + " Bytes";

            return size;
        }

        public bool IsConnected()
        {
            int description;
            return InternetGetConnectedState(out description, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnConn = new OnDelegateConn(OnDelConn);
            OnFile = new OnDelegateFile(OnDelFile);

            while (true)
            {
                if (IsConnected()) break;
                Thread.Sleep(1000);
            }
        }

        private void btnDisConn_Click(object sender, EventArgs e)
        {
            Drive = this.txtDrive.Text;
            int result = WNetCancelConnection2(Drive, CONNECT_UPDATE_PROFILE, true);
            if (result == 0)
            {
                this.lvFile.Items.Clear();
                MessageBox.Show("네트워크 드라이브가 정상적으로 끊어졌습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("장애가 발생하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

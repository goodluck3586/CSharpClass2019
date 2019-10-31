using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO; // 파일 클래스 사용
using System.Runtime.Serialization.Formatters.Binary; //BinaryFormatter 클래스 사용
using Microsoft.Win32; //RegistryKey 클래스 사용
using System.Collections;  //Hashtable 클래스 사용

namespace mook_PostIt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int SizeY = 300; //세로 사이즈
        Boolean COCheck = true; //열고 숨기기 메뉴 체크
        Boolean FormReSize = true;

        Point ptMouseCurrentPos; // 마우스 클릭 좌표 지정
        Point ptMouseNewPos; // 이동시 마우스 좌표
        Point ptFormCurrentPos; // 폼 위치 좌표 지정
        Point ptFormNewPos; // 이동시 폼 위치 좌표
        bool bFormMouseDown = false;
        RegistryKey regKey = Registry.CurrentUser; //레지스트리 루트 지정
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                regKey = regKey.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
                if (regKey.GetValue("Memo").ToString() != null)
                {
                    this.자동실행ToolStripMenuItem.Checked = true;
                }
            }
            catch { }
            DataView(); //데이터 출력 함수 호출
            FormShow(); //Form1 Loaction 맞춤
        }

        private void DataView()
        {
            try
            {
                Hashtable addresses = new Hashtable();
                FileStream fs = new FileStream("Memo.dat", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                addresses = (Hashtable)(formatter.Deserialize(fs));

                foreach (DictionaryEntry de in addresses)
                {
                    if (de.Key.ToString() != "")
                    {
                        this.rtbMemo.AppendText(de.Key.ToString());
                        this.rtbMemo.AppendText("\r\n");
                        this.rtbMemo.AppendText(de.Value.ToString());
                    }
                }
                fs.Close();
            }
            catch { }
        }
        private void FormShow()
        {
            FileInfo f = new FileInfo(Application.StartupPath + @"\sys.ini");
            if (f.Exists != true)
            {
                System.Drawing.Rectangle fullScreen = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                this.Location = new System.Drawing.Point(fullScreen.Width - 300, 0);
                SysFileSave();
            }
            else
            {
                StreamReader sr = new StreamReader(Application.StartupPath + @"\sys.ini");
                var LocationXY = sr.ReadLine().Split('=')[1].ToString().Split(',');
                this.Location = new Point(Convert.ToInt32(LocationXY[0]), Convert.ToInt32(LocationXY[1]));
                sr.Close();
            }

        }
        private void SysFileSave()
        {
            StreamWriter sw = File.CreateText(Application.StartupPath + @"\sys.ini");
            sw.WriteLine("FormLocation=" + this.Location.X + "," + this.Location.Y);
            sw.Close();
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            FormClose(); //폼 종료 메서드 호출
        }

        private void FormClose()
        {
            DialogResult dlr = MessageBox.Show("저장된 데이터 및 설정을 초기화 합니다.", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                SaveData("");
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void 자동실행ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistryKey regKey = Registry.CurrentUser; //레지스트리 루트 지정
            regKey = regKey.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
            Boolean keyExist = false;

            foreach (string str in regKey.GetValueNames())
            {
                if (str == "Memo")
                {
                    keyExist = true;
                }
            }

            if (!(this.자동실행ToolStripMenuItem.Checked))
            {
                if (!(keyExist))
                {
                    string path = Application.ExecutablePath;
                    regKey.SetValue("Memo", path);
                }
                this.자동실행ToolStripMenuItem.Checked = true;
            }
            else
            {
                if (keyExist)
                {
                    regKey.DeleteValue("Memo");
                }
                this.자동실행ToolStripMenuItem.Checked = false;
            }
        }

        private void 쪽지저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData(DateTime.Now.Month.ToString() + "월" + DateTime.Now.Day.ToString() + "일" + "  메모 " + "\r\n");
        }

        private void SaveData(string StrDate)
        {
            Hashtable addresses = new Hashtable();
            if (StrDate == "")
                addresses.Add("", "");
            else
                addresses.Add(StrDate, this.rtbMemo.Text);

            FileStream fs = new FileStream("Memo.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, addresses);
            }
            catch
            {
                MessageBox.Show("저장할 수 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            fs.Close();
        }

        private void 메모숨김ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (COCheck == true)
            {
                this.tClose.Enabled = true; //[tClose] 컨트롤 활성화
                this.메모숨김ToolStripMenuItem.Text = "메모열기";
                COCheck = false;
            }
            else
            {
                this.tOpen.Enabled = true;//[tOpen] 컨트롤 활성화
                this.메모숨김ToolStripMenuItem.Text = "메모숨김";
                COCheck = true;
            }
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClose(); //폼 종료 메서드 호출
        }

        private void tsBar_DoubleClick(object sender, EventArgs e)
        {
            if (FormReSize == true)
            {
                this.Size = new System.Drawing.Size(60, 25);
                FormReSize = false;
            }
            else
            {
                this.Size = new System.Drawing.Size(300, 300);
                FormReSize = true;
            }
        }

        private void tsBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bFormMouseDown = true; // 왼쪽 마우스 클릭 체크
                ptMouseCurrentPos = Control.MousePosition; // 마우스 클릭 좌표
                ptFormCurrentPos = this.Location; // 폼의 위치 좌표
            }
        }

        private void tsBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                bFormMouseDown = false; // 왼쪽 마우스 클릭 해체 체크
            SysFileSave();
        }

        private void tsBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (bFormMouseDown == true && e.Button == MouseButtons.Left) // 왼쪽 마우스 클릭시
            {
                ptMouseNewPos = Control.MousePosition;
                ptFormNewPos.X = ptMouseNewPos.X - ptMouseCurrentPos.X + ptFormCurrentPos.X; //마우스 이동시 가로 좌표
                ptFormNewPos.Y = ptMouseNewPos.Y - ptMouseCurrentPos.Y + ptFormCurrentPos.Y; //마우스 이동시 세로 좌표
                this.Location = ptFormNewPos;
                ptFormCurrentPos = ptFormNewPos;
                ptMouseCurrentPos = ptMouseNewPos;
            }
        }

        private void tOpen_Tick(object sender, EventArgs e)
        {
            if (SizeY <= 300) //폼 사이즈 늘림
            {
                SizeY += 10;
                this.Size = new System.Drawing.Size(300, SizeY); //폼 사이즈 설정
            }
            else
            {
                this.tOpen.Enabled = false;
            }
        }

        private void tClose_Tick(object sender, EventArgs e)
        {
            if (SizeY > 25) //폼 사이즈 줄임
            {
                SizeY -= 5;
                this.Size = new System.Drawing.Size(300, SizeY); //폼 사이즈 설정
            }
            else
            {
                this.tClose.Enabled = false;
            }
        }
    }
}


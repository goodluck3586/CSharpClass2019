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
using ICSharpCode.SharpZipLib.Zip;
using System.Diagnostics;

namespace mook_Zip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string NewZipFileName = String.Empty; //압축 파일 명

        private void btnPath_Click(object sender, EventArgs e)
        {
            if (this.fbdFolder.ShowDialog() == DialogResult.OK)
            {
                this.txtPath.Text = this.fbdFolder.SelectedPath;
                ListFiles();
            }
        }

        private void ListFiles()
        {
            this.lvZipFile.Items.Clear();
            string strDir = this.txtPath.Text;
            if ((strDir == "") || (!Directory.Exists(strDir))) return;

            string TmpDir = String.Empty;
            string[] files = Directory.GetFiles(strDir, "*.*", SearchOption.AllDirectories);
            foreach (string f in files)
            {
                FileInfo fi = new FileInfo(f);

                TmpDir = fi.DirectoryName.Replace(strDir, "");
                this.lvZipFile.Items.Add(new ListViewItem(new string[] { fi.Name, TmpDir, String.Format("{0:N0}", fi.Length.ToString()) }));
            }
        }

        private void btnZipPath_Click(object sender, EventArgs e)
        {
            if(this.fbdFolder.ShowDialog() == DialogResult.OK)
            {
                this.txtZipPath.Text = this.fbdFolder.SelectedPath;
            }
        }

        private void btnZip_Click(object sender, EventArgs e)
        {
            if (this.txtPath.Text == "") return;
            if (this.txtZipPath.Text == "") return;
            if (this.txtZipName.Text == "") return;
            else
            {
                NewZipFileName = this.txtZipName.Text;
                if (FileNameCheck(this.txtZipPath.Text + @"\" + this.txtZipName.Text))
                    FileCompression();
            }
        }

        private bool FileNameCheck(string FileName)
        {
            int i = 1;
            if (File.Exists(FileName))
            {
                var dlr = MessageBox.Show("같은 이름의 압축파일이 있습니다. 파일 수정 Yes, 파일 삭제 No",
                    "알림", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dlr == DialogResult.Yes)
                {
                    string NewFilePath = String.Empty;
                    do
                    {
                        NewFilePath = Path.GetDirectoryName(FileName) + @"\" +
                            Path.GetFileNameWithoutExtension(FileName) + "(" + i.ToString() + ").zip";
                        i++;
                    } while (File.Exists(NewFilePath));
                    return true;
                }
                else if (dlr == DialogResult.No)
                {
                    if (File.Exists(FileName)) File.Delete(FileName);
                    return true;
                }
                else
                    return false;
            }
            return true;
        }

        private void FileCompression()
        {
            string strOrgDir = this.txtPath.Text;
            string strDir = this.txtZipPath.Text;
            int FileListCnt = this.lvZipFile.Items.Count;
            if (FileListCnt == 0) return;

            string strDestPathFile = strDir + @"\" + NewZipFileName;

            this.ProgressBarZip.Visible = true;
            this.ProgressBarZip.Value = 0;
            this.ProgressBarZip.Minimum = 0;
            this.ProgressBarZip.Maximum = FileListCnt;

            try
            {
                Cursor = Cursors.WaitCursor;

                using (ZipOutputStream s = new ZipOutputStream(File.Create(strDestPathFile)))
                {
                    s.SetLevel(9); //압축률 0~9
                    s.Password = this.txtZipPwd.Text;

                    byte[] buffer = new byte[4096];
                    string strOrgFile = String.Empty;
                    string strOrgPathFile = String.Empty;
                    string strOrgPath = String.Empty;

                    for(int i = 0; i < FileListCnt; i++)
                    {
                        strOrgFile = this.lvZipFile.Items[i].Text;
                        strOrgPath = this.lvZipFile.Items[1].SubItems[1].Text;

                        if (strOrgPath == "")
                            strOrgPathFile = strOrgDir + @"\" + strOrgFile;
                        else
                            strOrgPathFile = strOrgDir + strOrgPath + @"\" + strOrgFile;

                        ZipEntry entry = new ZipEntry(Path.GetFileName(strOrgPathFile));
                        entry.Comment = strOrgPath; //폴더생성
                        s.PutNextEntry(entry);

                        using (FileStream fs =File.OpenRead(strOrgPathFile))
                        {
                            int sourcebyte = 0;
                            do
                            {
                                sourcebyte = fs.Read(buffer, 0, buffer.Length);
                                s.Write(buffer, 0, sourcebyte);
                            } while (sourcebyte > 0);
                        }

                        this.ProgressBarZip.Value = i + 1;
                    }
                    s.Finish();
                    s.Close();

                    Cursor = Cursors.Default;
                    MessageBox.Show("압축을 완료하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ProgressBarZip.Visible = false;
                }
            }
            catch {
                Cursor = Cursors.Default;
                this.ProgressBarZip.Visible = false;
                MessageBox.Show("정상적으로 압축을 완료하지 못하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUnPath_Click(object sender, EventArgs e)
        {
            if (this.ofdFile.ShowDialog() == DialogResult.OK)
                this.txtUnPath.Text = this.ofdFile.FileName;
        }

        private void btnUnZipPath_Click(object sender, EventArgs e)
        {
            if (this.fbdFolder.ShowDialog() == DialogResult.OK)
                this.txtUnZipPath.Text = this.fbdFolder.SelectedPath;
        }

        private void btnUnZip_Click(object sender, EventArgs e)
        {
            if (this.txtUnPath.Text == "") return;
            if (this.txtUnZipPath.Text == "") return;
            FileUnCompression();
        }

        private void FileUnCompression()
        {
            this.lvUnZipFile.Items.Clear();
            this.ProgressBarUnZip.Visible = true;
            this.ProgressBarUnZip.Value = 0;
            this.ProgressBarUnZip.Minimum = 0;

            string strUnZipDir = String.Empty;

            try
            {
                List<string> FList = new List<string>();
                using (ZipFile zFile = new ZipFile(this.txtUnPath.Text))
                {
                    foreach(ZipEntry z in zFile)
                    {
                        if (z.IsFile)
                            FList.Add(z.Comment);
                    }
                }
                int TotCnt = FList.Count;
                this.ProgressBarUnZip.Maximum = TotCnt;

                int FNum = 0;
                using (ZipInputStream s = new ZipInputStream(File.OpenRead(this.txtUnPath.Text)))
                {
                    s.Password = this.txtUnZipPwd.Text;
                    int i = 0;
                    ZipEntry theEntry = s.GetNextEntry();
                    while(theEntry != null)
                    {
                        string fileName = theEntry.Name;
                        string FolderName = FList[FNum];
                        strUnZipDir = this.txtUnZipPath.Text;

                        if (FolderName != null)
                        {
                            if (FolderName.Length > 0)
                            {
                                strUnZipDir = this.txtUnZipPath.Text + @"\" +  FolderName;
                                DirectoryInfo di = new DirectoryInfo(strUnZipDir);
                                if (di.Exists)
                                    Directory.CreateDirectory(strUnZipDir);
                            }
                        }
                        
                        if (fileName != "")
                        {
                            string struz = strUnZipDir + @"\" + fileName;
                            this.lvUnZipFile.Items.Add(fileName);

                            using (FileStream fs = File.Create(struz))
                            {
                                int size = 0;
                                byte[] unZipData = new byte[4096];
                                while(true)
                                {
                                    size = s.Read(unZipData, 0, unZipData.Length);
                                    if (size > 0)
                                        fs.Write(unZipData, 0, size);
                                    else
                                        break;
                                }
                            }

                            FileInfo fi = new FileInfo(struz);
                            if (FList[FNum] == "")
                                this.lvUnZipFile.Items[i].SubItems.Add("");
                            else
                                this.lvUnZipFile.Items[i].SubItems.Add(FList[FNum]);
                            this.lvUnZipFile.Items[i].SubItems.Add(String.Format("{0:N0}", fi.Length));
                        }
                        i++;
                        FNum++;
                        this.ProgressBarUnZip.Value = FNum;
                        theEntry = s.GetNextEntry();
                    }
                    s.Close();
                }
                Cursor = Cursors.Default;
                MessageBox.Show("압축풀기가 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ProgressBarUnZip.Visible = false;
                Process.Start(this.txtUnZipPath.Text);
            }
            catch
            {
                Cursor = Cursors.Default;
                this.ProgressBarUnZip.Visible = false;
                MessageBox.Show("압축풀기를 완료하지 못하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

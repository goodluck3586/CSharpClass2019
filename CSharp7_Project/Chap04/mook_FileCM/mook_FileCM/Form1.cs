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

namespace mook_FileCM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string FileSrc = ""; //복사 및 이동 소스 파일의 경로
        string FileDest = ""; //복사 및 이동 목적지 파일의 경로

        private void btnSrc_Click(object sender, EventArgs e)
        {
            if (this.fbdFolder.ShowDialog() == DialogResult.OK)
            {
                this.lvSrc.Items.Clear();
                this.txtSrc.Text = this.fbdFolder.SelectedPath;
                FileSrc = this.fbdFolder.SelectedPath;

                DirectoryInfo di = new DirectoryInfo(this.txtSrc.Text);
                foreach (var fs in di.GetFiles())
                {
                    this.lvSrc.Items.Add(new ListViewItem(new string[] { fs.Name }));
                }
            }
        }

        private void btnDest_Click(object sender, EventArgs e)
        {
            if (this.fbdFolder.ShowDialog() == DialogResult.OK)
            {
                this.lvDest.Items.Clear();
                this.txtDest.Text = this.fbdFolder.SelectedPath;
                FileDest = this.fbdFolder.SelectedPath;
                DirectoryInfo di = new DirectoryInfo(FileDest);
                foreach (var fs in di.GetFiles())
                {
                    this.lvDest.Items.Add(new ListViewItem(new string[] { fs.Name }));
                }
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (this.txtDest.Text == this.txtSrc.Text)
            {
                MessageBox.Show("경로가 같을 수 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int i = 0;
            int sum = this.lvSrc.SelectedItems.Count;

            foreach (ListViewItem Items in this.lvSrc.SelectedItems)
            {
                i++;
                if (File.Exists(FileSrc + @"\" +
                    Items.Text) == false)
                {
                    MessageBox.Show("존재하지 않는 파일입니다.", "에러",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                FileInfo fi = new FileInfo(FileSrc + @"\" +
                    Items.Text);
                Form2 frm2 = new Form2(FileSrc + @"\" +
                    Items.Text, FileDest + @"\" +
                    Items.Text);
                frm2.FileName = Items.Text;
                if (frm2.ShowDialog() == DialogResult.OK)
                {
                    frm2.Close();

                    ListViewItem item = this.lvDest.FindItemWithText(Items.Text);
                    if (item == null)
                    {
                        this.lvDest.Items.Add(new ListViewItem(new string[] { Items.Text }));
                    }

                    if (rbMove.Checked == true)
                    {
                        fi.Delete();
                        this.lvSrc.Items.RemoveAt(Items.Index);
                    }
                }
                int v = (int)(i * 100 / sum);
                this.tspgrbar.Value = v;
                this.tsslblStatus.Text = " " + v.ToString() + " %";
            }
        }
    }
}


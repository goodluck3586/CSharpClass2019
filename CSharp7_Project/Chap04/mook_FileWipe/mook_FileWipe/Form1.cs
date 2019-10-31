using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mook_FileWipe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FileDelete fd = null;

        private void btnWipe_Click(object sender, EventArgs e)
        {
            if (this.cbWipe.Text == "")
            {
                MessageBox.Show("WIpe 방법을 선택하세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cbWipe.Focus();
                return;
            }
            else if (this.txtPath.Text == "")
            {
                MessageBox.Show("삭제할 파일을 선택하세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnPath.Focus();
                return;
            }

            switch (this.cbWipe.Text)
            {
                case "British HMG IS5 (Base Line)":
                    fd = new FileDelete(this.txtPath.Text);
                    fd.runPer += new FileDelete.ProcessEventHandler(WipeStatus);
                    fd.British_HMG_IS5_BaseLine(this.txtPath.Text);
                    break;
                case "British HMG IS5 (Enhanced)":
                    fd = new FileDelete(this.txtPath.Text);
                    fd.runPer += new FileDelete.ProcessEventHandler(WipeStatus);
                    fd.British_HMG_IS5_Enhanced(this.txtPath.Text);
                    break;
            }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            if (this.ofdFile.ShowDialog() == DialogResult.OK)
            {
                this.txtPath.Text = this.ofdFile.FileName;
            }
        }

        private void WipeStatus(int Current)
        {
            switch (Current)
            {
                case 0:
                    this.lblPgb.Text = Current + "%";
                    this.pgbBar.Value = Current;
                    break;
                default:
                    this.lblPgb.Text = Current + "%";
                    this.pgbBar.Value = Current;
                    if (Current == 100)
                    {
                        this.txtPath.Text = "";
                    }
                    break;
            }
            Application.DoEvents();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mook_FontControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsbtnFont_Click(object sender, EventArgs e)
        {
            if (this.fontDlg.ShowDialog() == DialogResult.OK)
            {
                this.rtbText.SelectionFont = this.fontDlg.Font;
            }
        }

        private void tsbtnColor_Click(object sender, EventArgs e)
        {
            if (this.colorDlg.ShowDialog() == DialogResult.OK)
            {
                this.rtbText.SelectionColor = this.colorDlg.Color;
            }
        }
    }
}
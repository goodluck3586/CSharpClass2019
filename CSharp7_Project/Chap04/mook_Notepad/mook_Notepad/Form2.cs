using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mook_Notepad
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //폼2 종료
        }

        private void txtWord_TextChanged(object sender, EventArgs e)
        {
            if (this.txtWord.Text == "")
            {
                this.btnOk.Enabled = false; //버튼 비활성화
            }
            else
            {
                this.btnOk.Enabled = true; //버튼 활성화
            }
        }
    }
}

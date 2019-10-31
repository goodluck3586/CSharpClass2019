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

namespace mook_NetworkChk
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (File.Exists("ICMPConfig.ini") == true)
            {
                AddHost();
            }
            else
            {
                FileStream file = new FileStream("ICMPConfig.ini",
                    FileMode.Create, FileAccess.ReadWrite);
                file.Close();
                AddHost();
            }
        }

        private void AddHost()
        {
            FileStream file = new FileStream("ICMPConfig.ini",
                FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(file);

            sw.WriteLine("[" + this.txtHostName.Text + "]");
            sw.WriteLine(this.txtHostName.Text);
            sw.WriteLine(this.txtHostDescription.Text);
            sw.Close();

            Form1.AddList(this.txtHostName.Text, this.txtHostDescription.Text);

            file.Close();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

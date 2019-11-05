using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm09_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(new ListViewItem(new string[] { 1.ToString(), 100.ToString(), 100.ToString(), 100.ToString(), 300.ToString(), 100.ToString() }));
        }
    }
}

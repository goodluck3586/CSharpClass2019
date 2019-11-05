using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrom09_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int serialNum;
        int c, cpp, cs, total;

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (CheckInputScore())
            {
                total = c + cpp + cs;
                avg = total / 3;

                listView1.SelectedItems[0].SubItems[1].Text = c.ToString();
                listView1.SelectedItems[0].SubItems[2].Text = cpp.ToString();
                listView1.SelectedItems[0].SubItems[3].Text = cs.ToString();
                listView1.SelectedItems[0].SubItems[4].Text = total.ToString();
                listView1.SelectedItems[0].SubItems[5].Text = avg.ToString("f1");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 100; i > 50; i-=10)
            {
                serialNum++;
                listView1.Items.Add(new ListViewItem(new string[] { serialNum.ToString(),
                i.ToString(), i.ToString(), i.ToString(), (i*3).ToString(), i.ToString()}));
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Remove();
            //listView1.Items.RemoveAt(0);
        }

        float avg;

        private void btnAdd_Click(object sender, EventArgs e)
        {   
            if (CheckInputScore())
            {
                serialNum++;
                total = c + cpp + cs;
                avg = total / 3;
                listView1.Items.Add(new ListViewItem(new string[] {serialNum.ToString(),
                c.ToString(), cpp.ToString(), cs.ToString(), total.ToString(), avg.ToString("f1")}));
            }
        }

        private bool CheckInputScore()
        {
            if(int.TryParse(textBox1.Text, out c) && 
                int.TryParse(textBox2.Text, out cpp) && 
                int.TryParse(textBox3.Text, out cs))
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                return true;
            }
            MessageBox.Show("잘못된 입력입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}

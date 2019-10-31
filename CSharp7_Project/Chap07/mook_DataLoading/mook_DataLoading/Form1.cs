using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mook_DataLoading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String StrSQL = "Server = localhost; Database=mook;Uid=root;Password=p12345!@;port=3306;CharSet=utf8;SslMode=none";

        List<DataResult.DBResult> DataItems = new List<DataResult.DBResult>();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.lvList.Items.Clear();
            this.DataItems.Clear();
            Form2 frm2 = new Form2();
            frm2.URL = this.txtUrl.Text;
            frm2.SQL = StrSQL;
            if (frm2.ShowDialog() == DialogResult.OK)
            {
                DataItems = frm2.Result;
                frm2.Close();

                int n = 1;
                foreach(DataResult.DBResult data in DataItems)
                {
                    this.lvList.Items.Add(new ListViewItem(new string[] { n.ToString(), data.num.ToString(), data.url.ToString(),
                        data.ip.ToString(), data.cc.ToString(), data.date.ToString()}));
                    n++;
                }
            }
        }
    }
}

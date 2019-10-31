using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using System.Threading;

namespace mook_DataLoading
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string URL { get; set; }
        public string SQL { get; set; }
        public List<DataResult.DBResult> Result { get; set; }

        public delegate void PreviewHandler(object sender, EventArgs e);
        public event PreviewHandler Preview;
        public delegate void InvokeDelegate(List<DataResult.DBResult> data);

        private DBAccess dbc;
        Thread Workstart = null;

        List<DataResult.DBResult> DataItems = new List<DataResult.DBResult>();

        private void Form2_Load(object sender, EventArgs e)
        {
            dbc = new DBAccess();
            this.Preview += new PreviewHandler(ControlEventMethod);

            Workstart = new Thread(new ThreadStart(GetData));
            Workstart.Priority = ThreadPriority.Lowest;
            Workstart.IsBackground = true;
            Workstart.Start();
        }

        public void ControlEventMethod(object sender, EventArgs e)
        {
            if (lbltmp.InvokeRequired)
            {
                InvokeDelegate del = new InvokeDelegate(InvokeController);
                lbltmp.BeginInvoke(del, (List<DataResult.DBResult>)sender);
            }
        }

        public void InvokeController(List<DataResult.DBResult> Data)
        {
            Result = Data;
            DialogResult = DialogResult.OK;
        }

        public void GetData()
        {
            dbc.SQL = SQL;
            dbc.URL = URL;
            List<DataResult.DBResult> tmpDataItems = dbc.Select();
            this.Preview(tmpDataItems, null);
        }
    }

    public class DBAccess
    {
        public string SQL { get; set; }
        public string URL { get; set; }

        List<DataResult.DBResult> DataItems = new List<DataResult.DBResult>();

        public List<DataResult.DBResult> Select()
        {
            string url = URL;
            string sql = SQL;

            var Conn = new MySqlConnection(sql);
            Conn.Open();
            var Comm = new MySqlCommand("Select id, url, ip, cc, datetime From test_data where url = '" + url + "' order by id asc", Conn);
            var myRead = Comm.ExecuteReader();
            while (myRead.Read())
            {
                DataResult.DBResult dr = new DataResult.DBResult();
                dr.num = myRead[0].ToString();
                dr.url = myRead[1].ToString();
                dr.ip = myRead[2].ToString();
                dr.cc = myRead[3].ToString();
                dr.date = myRead[4].ToString();
                DataItems.Add(dr);
            }
            myRead.Close();
            Conn.Close();

            return DataItems;
        }
    }
}

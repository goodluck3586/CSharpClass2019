using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Threading;
using System.Net;

namespace mook_StaticCrawler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Constr = "server=localhost;uid=mook;pwd=p12345!@;database=mook"; //SQL 연결문자열

        List<string> UrlList = new List<string>();

        bool Flag = true;

        Thread CrawlerThr = null;
        Thread WebChkThre = null;

        delegate void OnCrawlerDelegate(string nt, string dt, string r, int i);
        OnCrawlerDelegate OnCrawler = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            OnCrawler = new OnCrawlerDelegate(OnCrawlerRun);
            var Conn = new SqlConnection(Constr);
            Conn.Open();

            var Comm = new SqlCommand("Select id, url from t_url", Conn);
            var myRead = Comm.ExecuteReader();
            while (myRead.Read())
            {
                this.lvUrlList.Items.Add(new ListViewItem(new string[] { myRead[0].ToString(), myRead[1].ToString(), "", "", "", "" }));
                UrlList.Add(myRead[1].ToString());
            }
            myRead.Close();
            Conn.Close();
        }

        private void OnCrawlerRun(string nt, string dt, string r, int i)
        {
            var Conn = new SqlConnection(Constr);
            Conn.Open();
            var strSQL = "update t_url set chk_date = '" + nt + "', load_time = '" + dt + "', chk_result = '" + r + "' where id = " + (i + 1) + "";
            var myCom = new SqlCommand(strSQL, Conn);
            myCom.ExecuteNonQuery();
            Conn.Close();

            this.lvUrlList.Items[i].SubItems[2].Text = nt;
            this.lvUrlList.Items[i].SubItems[3].Text = dt;
            this.lvUrlList.Items[i].SubItems[4].Text = r;
        }

        private void btnCrawling_Click(object sender, EventArgs e)
        {
            CrawlerThr = new Thread(CrawlerThrRun);
            CrawlerThr.Start();
        }

        private void CrawlerThrRun()
        {
            int i = 0;
            foreach (string u in UrlList)
            {
                Flag = true;
                object[] o = new object[] { u, i };
                WebChkThre = new Thread(new ParameterizedThreadStart(HTMLParser));
                WebChkThre.Start(o);

                while (true)
                {
                    if (!Flag) break;
                    Thread.Sleep(1000);
                }
                i++;
            }
        }

        private void HTMLParser(object o)
        {
            string url = ((object[])o)[0].ToString();
            int i = Convert.ToInt32(((object[])o)[1]);
            string Reqtime = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            string Donetime = String.Empty;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.KeepAlive = false;
                request.Timeout = 10000;
                request.Proxy = null;
                string responseString = String.Empty;
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        Donetime = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                        Invoke(OnCrawler, Reqtime, Donetime, "200", i);
                        Flag = false;
                    }
                }
            }
            catch(WebException ex)
            {
                HttpWebResponse webResponse = ex.Response as HttpWebResponse;
                Donetime = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                switch (webResponse.StatusCode)
                {
                    case HttpStatusCode.NotFound:
                        Invoke(OnCrawler, Reqtime, Donetime, "404", i);
                        Flag = false;
                        break;
                    case HttpStatusCode.InternalServerError:
                        Invoke(OnCrawler, Reqtime, Donetime, "500", i);
                        Flag = false;
                        break;
                    default:
                        Invoke(OnCrawler, Reqtime, Donetime, "etc", i);
                        Flag = false;
                        break;
                }
            }
        }
    }
}

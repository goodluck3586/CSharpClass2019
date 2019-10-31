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

namespace mook_DynamicCrawler
{
    public partial class Form1 : Form
    {
        private static Form1 DynamicForm;

        public Form1()
        {
            InitializeComponent();
            DynamicForm = this;
        }

        private string Constr = "server=localhost;uid=mook;pwd=p12345!@;database=mook"; //SQL 연결문자열

        List<string> UrlList = new List<string>();

        bool Flag = true;
        int LoadTime = 2000;
        int i = 0;
        string Accesstime = String.Empty;
        string Donetime = String.Empty;

        Thread CrawlerThr = null;

        delegate void OnCrawlerDelegate(bool f, string u);
        OnCrawlerDelegate OnCrawler = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cbLoadTime.Text = "2초";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            OnCrawler = new OnCrawlerDelegate(OnCrawlerRun);
            var Conn = new SqlConnection(Constr);
            Conn.Open();

            var Comm = new SqlCommand("Select id, url from t_url", Conn);
            var myRead = Comm.ExecuteReader();
            while (myRead.Read())
            {
                this.lvUrlList.Items.Add(new ListViewItem(new string[] { myRead[0].ToString(), myRead[1].ToString(), "", "", "" }));
                UrlList.Add(myRead[1].ToString());
            }
            myRead.Close();
            Conn.Close();
        }

        private void OnCrawlerRun(bool f, string u)
        {
            this.plGroup.Visible = f;
            if (f)
            {
                this.wbBrowser.Navigate(u);
                this.tsslblUrl.Text = String.Format("결과 : {0}", u);
            }
            else
                this.tsslblUrl.Text = "결과 :";
        }

        private void btnCrawling_Click(object sender, EventArgs e)
        {
            CrawlerThr = new Thread(CrawlerThrRun);
            CrawlerThr.Start();
        }

        private void CrawlerThrRun()
        {
            i = 0;
            Accesstime = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            foreach (string u in UrlList)
            {
                Flag = true;
                Invoke(OnCrawler, true, u);

                while (true)
                {
                    if (!Flag) break;
                    Thread.Sleep(1000);
                }
                i++;
                Thread.Sleep(LoadTime);
                Invoke(OnCrawler, false, "");
            }
        }

        private void wbBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (this.wbBrowser.ReadyState != WebBrowserReadyState.Complete)
                return;
            else
            {
                Donetime = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                this.lvUrlList.Items[i].SubItems[2].Text = Accesstime;
                this.lvUrlList.Items[i].SubItems[3].Text = Donetime;
                this.lvUrlList.Items[i].SubItems[4].Text = GetStringSha256Hash(this.wbBrowser.Document.Body.InnerHtml);
                Flag = false;
            }
        }

        private string GetStringSha256Hash(string text)
        {
            if (String.IsNullOrEmpty(text))
                return String.Empty;

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }

        private void cbLoadTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.cbLoadTime.SelectedText)
            {
                case "2초":
                    LoadTime = 2000;
                    break;
                case "3초":
                    LoadTime = 3000;
                    break;
                case "5초":
                    LoadTime = 5000;
                    break;
                case "7초":
                    LoadTime = 6000;
                    break;
            }
        }
    }
}

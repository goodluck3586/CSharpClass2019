using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Xml;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace mook_WebXMLParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string LocalURL = "http://localhost/";
        const string WeatherURL = "http://www.kma.go.kr/XML/weather/sfc_web_map.xml";
        Dictionary<string, string> DictNews = new Dictionary<string, string>();
        Thread NewsChkThre = null;
        delegate void OnXmlDelegate(string k, string v);
        OnXmlDelegate OnXml = null;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            OnXml = new OnXmlDelegate(OnXmlRun);
            GetXMLNews();
            NewsChkThre = new Thread(DisplayNews);
            NewsChkThre.Start();
        }

        private void OnXmlRun(string k, string v)
        {
            this.tsslblNews.Text = k;
            this.tsslblNews.ToolTipText = v;
        }

        private void DisplayNews()
        {
            while(true)
            {
                foreach(KeyValuePair<string, string> news in DictNews)
                {
                    Invoke(OnXml, news.Key, news.Value);
                    Thread.Sleep(3000);
                }
            }
        }

        private void GetXMLNews()
        {
            XmlDocument xd = new XmlDocument();
            xd.Load(WeatherURL);
            XmlNode xnd = xd.DocumentElement;
            foreach(XmlNode xn in xnd.FirstChild.ChildNodes)
            {
                string XmlDataKey = String.Format("지역 : {0} / {1} / {2}", xn.InnerText, xn.Attributes["desc"].Value, xn.Attributes["ta"].Value);
                string XmlDataValue = "http://www.weather.go.kr/weather/forecast/mid-term_01.jsp";
                DictNews.Add(XmlDataKey, XmlDataValue);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.lvXml.Items.Clear();

            WebClient wc = new WebClient();
            string WebData = wc.DownloadString(String.Format("{0}WebXml.xml", LocalURL));
            wc.Dispose();

            StringReader sr = new StringReader(WebData);
            XmlDocument xd = new XmlDocument();
            xd.Load(sr);
            sr.Close();

            XmlNodeList subNodes = xd.SelectNodes("xml_reply/human/human_entry");

            foreach(XmlNode node in subNodes)
            {
                this.lvXml.Items.Add(new ListViewItem(new string[] { GetNodeValue(node, "title") }));
            }
        }

        private string GetNodeValue(XmlNode parent, string strXML)
        {
            string Result = String.Empty;
            XmlAttribute attr = parent.SelectSingleNode(strXML).Attributes["Name"];
            if (attr.Value != "")
                Result = attr.Value;
            return Result;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NewsChkThre != null) NewsChkThre.Abort();
        }

        private void tsslblNews_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void tsslblNews_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void tsslblNews_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = tsslblNews.ToolTipText;
            p.Start();
        }
    }
}

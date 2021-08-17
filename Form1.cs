using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MySqlConnect2
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string url = "http://localhost:8888";
                this.webBrowser1.Navigate(url);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void databtn_Click(object sender, EventArgs e)
        {

            //http://apis.data.go.kr/6260000/FoodService/getFoodKr
            //?serviceKey=3mT7ae1E4CYoFuMU%2Fn6Dfbg5oVKVn5NEToLZPfNxc8mmJsvqpBVsb3YNq72tRLSYpVmLxWHpmXOyF9uFcGQSzQ%3D%3D&
            //pageNo=1&numOfRows=10
            //3mT7ae1E4CYoFuMU%2Fn6Dfbg5oVKVn5NEToLZPfNxc8mmJsvqpBVsb3YNq72tRLSYpVmLxWHpmXOyF9uFcGQSzQ%3D%3D&
            string mykey = textBox1.Text;

            //pageNo1&numOfRows=10 기준으로 total 184개 이여서 모든 정보 출력하기 위해 pageNo1&numOfRows=1840으로 설정함
            string query = "http://apis.data.go.kr/6260000/FoodService/getFoodKr?serviceKey=3mT7ae1E4CYoFuMU%2Fn6Dfbg5oVKVn5NEToLZPfNxc8mmJsvqpBVsb3YNq72tRLSYpVmLxWHpmXOyF9uFcGQSzQ%3D%3D&pageNo=1&numOfRows=1840";

            WebClient wc = new WebClient();
            WebRequest wrq = WebRequest.Create(query);
            wrq.Method = "GET";

            WebResponse wrs = wrq.GetResponse();
            Stream s = wrs.GetResponseStream();
            StreamReader sr = new StreamReader(s);

            string response = sr.ReadToEnd();

            //richTextBox1.Text = response;

            XmlDocument xd = new XmlDocument();
            xd.LoadXml(response);

            XmlNode xn = xd["response"]["body"]["items"];

            //richTextBox1.Text = xn.ChildNodes.Count.ToString();


            for (int i = 0; i < xn.ChildNodes.Count; i++)
            {

                ListViewItem lvi = new ListViewItem();
                lvi.Text += xn.ChildNodes[i]["PLACE"].InnerText;

               
                lvi.SubItems.Add(xn.ChildNodes[i]["USAGE_DAY_WEEK_AND_TIME"].InnerText);
                lvi.SubItems.Add(xn.ChildNodes[i]["ADDR1"].InnerText);
                lvi.SubItems.Add(xn.ChildNodes[i]["LAT"].InnerText);
                lvi.SubItems.Add(xn.ChildNodes[i]["LNG"].InnerText);
                //lvi.SubItems.Add(xn.ChildNodes[i]["LNG"].InnerText);

                listView1.Items.Add(lvi);


                /*
                richTextBox1.Text += xn.ChildNodes[i]["PLACE"].InnerText + "\t";
                richTextBox1.Text += xn.ChildNodes[i]["USAGE_DAY_WEEK_AND_TIME"].InnerText + "\t";
                richTextBox1.Text += xn.ChildNodes[i]["ADDR1"].InnerText + "\t";
                richTextBox1.Text += xn.ChildNodes[i]["LAT"].InnerText + "\t";
                richTextBox1.Text += xn.ChildNodes[i]["LNG"].InnerText + "\n";*/
            }
        }
    }
}

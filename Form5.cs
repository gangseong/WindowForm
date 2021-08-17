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
using System.IO;
using System.Xml;

namespace MySqlConnect2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        const string targetURL = "http://openapi-lib.sen.go.kr/openapi/service/lib/openApi";
        const string serviceKey = "Bo%2Fp6a0%2BcjryOgiWUl2oa6YdzLrO4Pag3r2ioslPJx41ZE3WLklxy3bP%2BOsednoOvP0ZWBK5xR35jta8NyWZ1w%3D%3D";

		public static string getResults()
		{
			string result = string.Empty;

			try
			{
				WebClient client = new WebClient();
				string url = string.Format(@"{0}?serviceKey={1}", targetURL, serviceKey);
				using (Stream data = client.OpenRead(url))
				{
					using (StreamReader reader = new StreamReader(data))
					{
						string s = reader.ReadToEnd();
						result = s;

						reader.Close();
						data.Close();
					}
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}

			return result;
		}

        /*private void ApiBtn_Click(object sender, EventArgs e)
        {
			string result = getResults();

			XmlDocument xml = new XmlDocument();
			xml.LoadXml(result);
			XmlNodeList list = xml.GetElementsByTagName("busLocationList");

			listViewResults.Items.Clear();
			int idx = 0;
			foreach (XmlNode bus in list)
			{
				ListViewItem item = new ListViewItem((idx++).ToString());
				item.SubItems.Add(bus["plateNo"].InnerText);
				string endBus = "N";
				if (bus["endBus"].InnerText == "1")
					endBus = "Y";
				item.SubItems.Add(endBus);

				item.SubItems.Add(bus["remainSeatCnt"].InnerText);

				listViewResults.Items.Add(item);
			}
		}*/
        //...
    }

}

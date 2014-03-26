using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DNSKit_Controller.Classes;
using DNSController;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DNSKit_Controller
{
    public partial class DNSKit_Controller : Form
    {
        NetworkManager myManager = new NetworkManager();
        public IPAddress cur_ip;
        public IPAddress subnet;
        public IPAddress gateway;
        public string[] cur_dns;
        public bool minimizedYet = false;

        public JObject GetAll;

        public DNSKit_Controller()
        {
            InitializeComponent();

            this.cur_ip = myManager.getIP();
            this.subnet = myManager.GetSubnetMask(this.cur_ip);
            this.gateway = myManager.GetDefaultGateway();
            this.cur_dns = myManager.getDNS();

            this.GetAll = getAll();
        }

        private void DNSKit_Controller_Load(object sender, EventArgs e)
        {
            foreach (JObject item in GetAll["dns_entries"])
            {
                foreach (var itm in item)
                {
                    selectDNS.Items.Add(new ComboBoxItem(itm.Key, itm.Value[2].ToString()));
                }
                GetAll = item;
            }

            CurDNS();
            selectDNS.SelectedIndex = 0;
        }

        public JObject getAll()
        {
            string dns_string = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://mustafage.pythonanywhere.com/get_all");
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "Accept=text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                dns_string = reader.ReadToEnd();
            }

            JObject json = JObject.Parse(dns_string);
            return json;
        }

        public void CurDNS()
        {
            bool updated = false;
            foreach(var item in GetAll)
            {
                if(item.Value[0].ToString() == myManager.getDNS()[0])
                {
                    ComboBoxItem selected = (ComboBoxItem)selectDNS.SelectedItem;
                    mainName.Text = GetAll[selected.Value][2].ToString();
                    updated = true;
                    break;
                }
            }

            if (updated == false)
            {
                mainName.Text = "Local Settings";
            }
            dnsList.Text = myManager.getDNS()[0] + ", " + myManager.getDNS()[1];
        }

        private void setDNS(string[] dns)
        {
            myManager.setIP(cur_ip.ToString(), subnet.ToString());
            myManager.setGateway(gateway.ToString());
            myManager.setDNS(new string[] { dns[0], dns[1] });
        }

        private void DNSKit_Controller_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disable();
        }

        private void disableBtn_Click(object sender, EventArgs e)
        {
            Disable();
        }

        private void Disable()
        {
            myManager.setAuto();
            myManager.setDNS(null);
            CurDNS();
        }

        private void useSelected_Click(object sender, EventArgs e)
        {
            ComboBoxItem selected = (ComboBoxItem)selectDNS.SelectedItem;
            setDNS(new string[] { GetAll[selected.Value][0].ToString(), GetAll[selected.Value][1].ToString() });
            CurDNS();
        }

        private void randBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int newIndex = -1;

            do
            {
                newIndex = random.Next(selectDNS.Items.Count);
            } while (newIndex == selectDNS.SelectedIndex && selectDNS.Items.Count > 1);

            selectDNS.SelectedIndex = random.Next(selectDNS.Items.Count);
            useSelected.PerformClick();
        }

        private void DNSKit_Controller_Resize(object sender, EventArgs e)
        {
            DNSKit.BalloonTipTitle = "DNSKit minimized";
            DNSKit.BalloonTipText = "The application is minimized to the tray!";

            if (FormWindowState.Minimized == this.WindowState)
            {
                DNSKit.Visible = true;
                if(minimizedYet == false)
                {
                    DNSKit.ShowBalloonTip(500);
                }
                this.Hide();
                minimizedYet = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                DNSKit.Visible = false;
            }
        }

        private void DNSKit_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}

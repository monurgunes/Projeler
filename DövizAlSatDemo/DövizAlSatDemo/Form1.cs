using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace DövizAlSatDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dovizBox.Items.Add("TL");
            dovizBox.Items.Add("Dolar");
            dovizBox.Items.Add("Euro");
            bakiyeBox.Items.Add("100");
            bakiyeBox.Items.Add("1000");
            bakiyeBox.Items.Add("10000");
            textGrsSfr.PasswordChar = '*';
            textKytSfr.PasswordChar = '*';
            textKytsfrT.PasswordChar = '*';

        }
        private void XMLInsert()
        {
            if (File.Exists(@"users.xml") == false)
            {
                XmlTextWriter xmlCreated = new XmlTextWriter(@"users.xml", UTF8Encoding.UTF8);
                xmlCreated.WriteStartDocument();
                xmlCreated.WriteStartElement("Users");
                xmlCreated.WriteEndDocument();
                xmlCreated.Close();
            }

            XDocument xDoc = XDocument.Load(@"users.xml");

            XElement rootElement = xDoc.Root;

            XElement newElement = new XElement("User");
            int userid = Convert.ToInt32(XMLIDRead());

            XAttribute idAttribute = new XAttribute("id", userid + 1);


            XElement nickElement = new XElement("Nick", textKytAd.Text);
            XElement passElement = new XElement("Şifre", textKytSfr.Text);
            XElement roleElement = new XElement("Role", "Kullanıcı");
            XElement statusElement = new XElement("Status", "Aktif");
            newElement.Add(idAttribute, nickElement, passElement, roleElement, statusElement);


            if (dovizBox.SelectedItem.ToString() == "TL")
            {
                XElement tlbalanceElement = new XElement("TlBakiye", Convert.ToInt32(bakiyeBox.SelectedItem.ToString()));
                XElement dlbalanceElement = new XElement("DlBakiye", 0);
                XElement eubalanceElement = new XElement("EuBakiye", 0);
                newElement.Add(tlbalanceElement, dlbalanceElement, eubalanceElement);
            }
            else if (dovizBox.SelectedItem.ToString() == "Dolar")
            {
                XElement tlbalanceElement = new XElement("TlBakiye", 0);
                XElement dlbalanceElement = new XElement("DlBakiye", Convert.ToInt32(bakiyeBox.SelectedItem.ToString()));
                XElement eubalanceElement = new XElement("EuBakiye", 0);
                newElement.Add(tlbalanceElement, dlbalanceElement, eubalanceElement);
            }
            else if (dovizBox.SelectedItem.ToString() == "Euro")
            {
                XElement tlbalanceElement = new XElement("TlBakiye", 0);
                XElement dlbalanceElement = new XElement("DlBakiye", 0);
                XElement eubalanceElement = new XElement("EuBakiye", Convert.ToInt32(bakiyeBox.SelectedItem.ToString()));
                newElement.Add(tlbalanceElement, dlbalanceElement, eubalanceElement);
            }

            rootElement.Add(newElement);
            xDoc.Save(@"users.xml");
        }
        public string XMLIDRead()
        {
            if (File.Exists(@"users.xml") == true)
            {
                XDocument xDoc = XDocument.Load(@"users.xml");
                XElement rootElement = xDoc.Root;

                var ID = rootElement.Elements("User").Last().Attribute("id").Value;

                return ID;
            }
            return null;
        }
        public List<String> XMLNickList()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("users.xml");
            List<string> ni = new List<string>();
            XmlNodeList nickList = doc.GetElementsByTagName("Nick");
            for (int i = 0; i < nickList.Count; i++)
            {
                ni.Add(nickList[i].InnerXml);
            }
            return ni;

        }
        public List<String> XMLSifreList()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("users.xml");
            List<string> si = new List<string>();
            XmlNodeList nickList = doc.GetElementsByTagName("Şifre");
            for (int i = 0; i < nickList.Count; i++)
            {
                si.Add(nickList[i].InnerXml);
            }
            return si;

        }
        public List<String> XMLTlBalanceList()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("users.xml");
            List<string> tlb = new List<string>();
            XmlNodeList nickList = doc.GetElementsByTagName("TlBakiye");
            for (int i = 0; i < nickList.Count; i++)
            {
                tlb.Add(nickList[i].InnerXml);
            }
            return tlb;

        }
        public List<String> XMLEuBalanceList()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("users.xml");
            List<string> eub = new List<string>();
            XmlNodeList nickList = doc.GetElementsByTagName("EuBakiye");
            for (int i = 0; i < nickList.Count; i++)
            {
                eub.Add(nickList[i].InnerXml);
            }
            return eub;

        }
        public List<String> XMLDlBalanceList()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("users.xml");
            List<string> dlb = new List<string>();
            XmlNodeList nickList = doc.GetElementsByTagName("DlBakiye");
            for (int i = 0; i < nickList.Count; i++)
            {
                dlb.Add(nickList[i].InnerXml);
            }
            return dlb;

        }
        public string Nickname()
        {
            User us = new User();
            us.Id = XMLNickList().IndexOf(textGrsAd.Text);
            XmlDocument doc = new XmlDocument();
            doc.Load("users.xml");
            var nodes = doc.GetElementsByTagName("Nick");
            XmlNode node = nodes[us.Id];

            us.NickName = node.InnerText;
            return us.NickName;
        }
        public double TlBakiye()
        {
            User us = new User();
            us.Id = XMLNickList().IndexOf(textGrsAd.Text);
            XmlDocument doc = new XmlDocument();
            doc.Load("users.xml");
            var tlnodes = doc.GetElementsByTagName("TlBakiye");
            XmlNode tlnode = tlnodes[us.Id];
            us.TlBakiye = Convert.ToDouble(tlnode.InnerText);
            return us.TlBakiye;
        }
        public double DlBakiye()
        {
            User us = new User();
            us.Id = XMLNickList().IndexOf(textGrsAd.Text);
            XmlDocument doc = new XmlDocument();
            doc.Load("users.xml");
            var dlnodes = doc.GetElementsByTagName("DlBakiye");
            XmlNode dlnode = dlnodes[us.Id];
            us.DlBakiye = Convert.ToDouble(dlnode.InnerText);
            return us.DlBakiye;
        }
        public double EuBakiye()
        {
            User us = new User();
            us.Id = XMLNickList().IndexOf(textGrsAd.Text);
            XmlDocument doc = new XmlDocument();
            doc.Load("users.xml");
            var eunodes = doc.GetElementsByTagName("EuBakiye");
            XmlNode eunode = eunodes[us.Id];
            us.EuBakiye = Convert.ToDouble(eunode.InnerText);
            return us.EuBakiye;
        }
        public string Role()
        {
            User us = new User();
            us.Id = XMLNickList().IndexOf(textGrsAd.Text);
            XmlDocument doc = new XmlDocument();
            doc.Load("users.xml");
            var rolenodes = doc.GetElementsByTagName("Role");
            XmlNode rolenode = rolenodes[us.Id];
            us.Role = rolenode.InnerText;
            return us.Role;
        }
        public string Status()
        {
            User us = new User();
            us.Id = XMLNickList().IndexOf(textGrsAd.Text);
            XmlDocument doc = new XmlDocument();
            doc.Load("users.xml");
            var statusnodes = doc.GetElementsByTagName("Status");
            XmlNode statusnode = statusnodes[us.Id];
            us.Status = statusnode.InnerText;
            return us.Status;
        }

        private void btnGrs_Click(object sender, EventArgs e)
        {
            string nick = textGrsAd.Text;
            string sifre = textGrsSfr.Text;
            int n1sira = XMLNickList().IndexOf(textGrsAd.Text);
            if (XMLNickList().Contains(textGrsAd.Text))
            {
                if (XMLSifreList().Contains(textGrsSfr.Text))
                {
                    int nsira = XMLNickList().IndexOf(textGrsAd.Text);
                    int ssira = XMLSifreList().IndexOf(textGrsSfr.Text);
                    if (nsira == ssira)
                    {
                        if(Status() == "Aktif")
                        {
                            MessageBox.Show("Giris Basarili");
                            Form2 f2 = new Form2(this);
                            this.Hide();
                            f2.Show();
                        }
                        else
                        {
                            MessageBox.Show("Hesabınız belirlenmeye bir süre boyunca kullanıma kapatılmıştır");
                        }
                    
                        
                    }

                }
                else
                {
                    MessageBox.Show("Kullanıcı Adınız veya Şifreni hatalidir.");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız veya Şifreni hatalidir.");


            }
        }

        private void btnKyt_Click(object sender, EventArgs e)
        {
            if (textKytSfr.Text != textKytsfrT.Text)
            {
                MessageBox.Show("Şifreler Eşleşmiyor");
            }
            else if (textKytAd.Text.Length < 6)
            {
                MessageBox.Show("Kullanıcı adınız 6 karakterden az olamaz!");
            }
            else if (textKytSfr.Text.Length < 6)
            {
                MessageBox.Show("Şifreniz 6 karakterden az olamaz");
            }
            else if (XMLNickList().Contains(textKytAd.Text))
            {
                MessageBox.Show("Bu kullanıcı adı mevcut, lütfen farklı bir kullanıcı adı belirleyiniz!");
            }
            else if (dovizBox.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir döviz tipi seçiniz");
            }
            else if (bakiyeBox.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir döviz miktarı seçiniz");
            }
            else
            {
                MessageBox.Show("Kayıt başarılı. Giriş yapabilirsiniz.");
                XMLInsert();
                textKytAd.Text = "";
                textKytSfr.Text = "";
                textKytsfrT.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textGrsAd.Text = "onurgunes";
            textGrsSfr.Text = "onurgunes";
        }
    }
}

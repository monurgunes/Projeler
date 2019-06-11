using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace DövizAlSatDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            admnPnl.Visible = false;
            dovizAlbox.Items.Add("TL");
            dovizAlbox.Items.Add("Dolar");
            dovizAlbox.Items.Add("Euro");
            dovizBox.Items.Add("TL");
            dovizBox.Items.Add("Dolar");
            dovizBox.Items.Add("Euro");
            User us2 = new User();
            us2.NickName = _form1.Nickname();
            us2.Role = _form1.Role();
            if(us2.Role == "Admin")
            {
                admnPnl.Visible = true;
            }
            us2.TlBakiye = _form1.TlBakiye();
            us2.DlBakiye = _form1.DlBakiye();
            us2.EuBakiye = _form1.EuBakiye();
            Tl.Text = Convert.ToString(us2.TlBakiye);
            Dl.Text = Convert.ToString(us2.DlBakiye);
            Eu.Text = Convert.ToString(us2.EuBakiye);
            label2.Text = Convert.ToString(Tl.Text + "₺");
            label3.Text = Convert.ToString(Dl.Text + "$");
            label4.Text = Convert.ToString(Eu.Text + "€");
            label6.Text = us2.NickName;
            Tl.Visible = false;
            Dl.Visible = false;
            Eu.Visible = false;

        }
        private Form1 _form1;

        public Form2(Form1 form1)
        {
            _form1 = form1;
            InitializeComponent();
        }

        private void kurGncl_Click(object sender, EventArgs e)
        {
            var serializer = new XmlSerializer(typeof(Tarih_Date));

            using (var client = new WebClient())
            {
                using (var stream = client.OpenRead("http://www.tcmb.gov.tr/kurlar/today.xml"))
                {
                    var currency = (Tarih_Date)serializer.Deserialize(stream);
                    var dolar = currency.Kurlistesi[0];
                    var euro = currency.Kurlistesi[3];
                    textDolarbuy.Text = dolar.BanknoteBuying;
                    textEurobuy.Text = euro.BanknoteBuying;
                    textDolarsell.Text = dolar.BanknoteSelling;
                    textEurosell.Text = euro.BanknoteSelling;

                }
            }
        }

        private void dvzAl_Click(object sender, EventArgs e)
        {
            if (dovizBox.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen almak istediğiniz döviz türü seçiniz");
            }
            else if(dovizAlbox.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen kullanmak istediğiniz bakiyeyi seçiniz");
            }
            else if (dvzMiktar.Text == "")
            {
                MessageBox.Show("Lütfen miktarı giriniz");
            }
            else if (textDolarbuy.Text == "")
            {
                MessageBox.Show("Lütfen önce kuru güncelleyiniz");
            }
            else
            {
                if(dovizAlbox.SelectedItem.ToString() == "TL")
                {
                    if (dovizBox.SelectedItem.ToString() == "TL")
                    {
                        MessageBox.Show("Tl/Tl türünde işlem yapamazsınız");

                    }
                    else if(dovizBox.SelectedItem.ToString() == "Dolar")
                    {
                        if(Convert.ToDouble(Tl.Text) - Convert.ToDouble(textDolarbuy.Text) * Convert.ToDouble(dvzMiktar.Text) / 10000 < 0)
                        {
                            MessageBox.Show("Bakiyeniz yetersiz");
                        }
                        else
                        {
                            Tl.Text = Convert.ToString(Convert.ToDouble(Tl.Text) - Convert.ToDouble(textDolarbuy.Text) * Convert.ToDouble(dvzMiktar.Text) / 10000);
                            label2.Text = Convert.ToString(Tl.Text + "₺");
                            double mevcutdolar = Convert.ToDouble(Dl.Text) + Convert.ToDouble(dvzMiktar.Text);
                            Dl.Text = Convert.ToString(mevcutdolar);
                            label3.Text = Convert.ToString(Dl.Text + "$");
                            dvzMiktar.Text = "";
                            MessageBox.Show("İşleminiz gerçekleşti");

                        }
                        
                    }
                    else if (dovizBox.SelectedItem.ToString() == "Euro")
                    {
                        if (Convert.ToDouble(Tl.Text) - Convert.ToDouble(textEurobuy.Text) * Convert.ToDouble(dvzMiktar.Text) / 10000 < 0)
                        {
                            MessageBox.Show("Bakiyeniz yetersiz");
                        }
                        else
                        {
                            Tl.Text = Convert.ToString(Convert.ToDouble(Tl.Text) - Convert.ToDouble(textEurobuy.Text) * Convert.ToDouble(dvzMiktar.Text) / 10000);
                            label2.Text = Convert.ToString(Tl.Text + "₺");
                            double mevcuteuro = Convert.ToDouble(Eu.Text) + Convert.ToDouble(dvzMiktar.Text);
                            Eu.Text = Convert.ToString(mevcuteuro);
                            label4.Text = Convert.ToString(Eu.Text + "€");
                            dvzMiktar.Text = "";
                            MessageBox.Show("İşleminiz gerçekleşti");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Bir şeyler ters gitti!");
                    }
                }
                else if (dovizAlbox.SelectedItem.ToString() == "Dolar")
                {
                    if (dovizBox.SelectedItem.ToString() == "Dolar")
                    {
                        MessageBox.Show("Dolar/Dolar türünde işlem yapamazsınız");

                    }
                    else if (dovizBox.SelectedItem.ToString() == "TL")
                    {
                        if (Convert.ToDouble(Dl.Text) - Convert.ToDouble(dvzMiktar.Text) / Convert.ToDouble(textDolarbuy.Text) * 10000 < 0)
                        {
                            MessageBox.Show("Bakiyeniz yetersiz");
                        }
                        else
                        {
                            Dl.Text = Convert.ToString(Convert.ToDouble(Dl.Text) -  Convert.ToDouble(dvzMiktar.Text) / Convert.ToDouble(textDolarbuy.Text) * 10000);
                            label3.Text = Convert.ToString(Dl.Text + "$");
                            double mevcuttl = Convert.ToDouble(Tl.Text) + Convert.ToDouble(dvzMiktar.Text);
                            Tl.Text = Convert.ToString(mevcuttl);
                            label2.Text = Convert.ToString(Tl.Text + "₺");
                            dvzMiktar.Text = "";
                            MessageBox.Show("İşleminiz gerçekleşti");

                        }

                    }
                    else if (dovizBox.SelectedItem.ToString() == "Euro")
                    {
                        if (Convert.ToDouble(Dl.Text) - Convert.ToDouble(textEurobuy.Text) / Convert.ToDouble(textDolarbuy.Text) * Convert.ToDouble(dvzMiktar.Text) < 0)
                        {
                            MessageBox.Show("Bakiyeniz yetersiz");
                        }
                        else
                        {
                            Dl.Text = Convert.ToString(Convert.ToDouble(Dl.Text) - Convert.ToDouble(textEurobuy.Text) / Convert.ToDouble(textDolarbuy.Text) * Convert.ToDouble(dvzMiktar.Text));
                            label3.Text = Convert.ToString(Dl.Text + "$");
                            double mevcuteuro = Convert.ToDouble(Eu.Text) + Convert.ToDouble(dvzMiktar.Text);
                            Eu.Text = Convert.ToString(mevcuteuro);
                            label4.Text = Convert.ToString(Eu.Text + "€");
                            dvzMiktar.Text = "";
                            MessageBox.Show("İşleminiz gerçekleşti");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Bir şeyler ters gitti!");
                    }
                }
                else if (dovizAlbox.SelectedItem.ToString() == "Euro")
                {
                    if (dovizBox.SelectedItem.ToString() == "Euro")
                    {
                        MessageBox.Show("Euro/Euro türünde işlem yapamazsınız");

                    }
                    else if (dovizBox.SelectedItem.ToString() == "TL")
                    {
                        if (Convert.ToDouble(Eu.Text) - Convert.ToDouble(dvzMiktar.Text) / Convert.ToDouble(textEurobuy.Text) * 10000 < 0)
                        {
                            MessageBox.Show("Bakiyeniz yetersiz");
                        }
                        else
                        {
                            Eu.Text = Convert.ToString(Convert.ToDouble(Eu.Text) - Convert.ToDouble(dvzMiktar.Text) / Convert.ToDouble(textEurobuy.Text) * 10000);
                            label4.Text = Convert.ToString(Eu.Text + "€");
                            double mevcuttl = Convert.ToDouble(Tl.Text) + Convert.ToDouble(dvzMiktar.Text);
                            Tl.Text = Convert.ToString(mevcuttl);
                            label2.Text = Convert.ToString(Tl.Text + "₺");
                            dvzMiktar.Text = "";
                            MessageBox.Show("İşleminiz gerçekleşti");

                        }

                    }
                    else if (dovizBox.SelectedItem.ToString() == "Dolar")
                    {
                        if (Convert.ToDouble(Eu.Text) - Convert.ToDouble(textDolarbuy.Text) / Convert.ToDouble(textEurobuy.Text) * Convert.ToDouble(dvzMiktar.Text) < 0)
                        {
                            MessageBox.Show("Bakiyeniz yetersiz");
                        }
                        else
                        {
                            Eu.Text = Convert.ToString(Convert.ToDouble(Eu.Text) - Convert.ToDouble(textDolarbuy.Text) / Convert.ToDouble(textEurobuy.Text) * Convert.ToDouble(dvzMiktar.Text));
                            label4.Text = Convert.ToString(Eu.Text + "€");
                            double mevcutdolar = Convert.ToDouble(Dl.Text) + Convert.ToDouble(dvzMiktar.Text);
                            Dl.Text = Convert.ToString(mevcutdolar);
                            label3.Text = Convert.ToString(Dl.Text + "$");
                            dvzMiktar.Text = "";
                            MessageBox.Show("İşleminiz gerçekleşti");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Bir şeyler ters gitti!");
                    }
                }
            }
        }

        private void usrSfrl_Click(object sender, EventArgs e)
        {
            User us2 = new User();
            us2.NickName = _form1.Nickname();
            us2.TlBakiye = _form1.TlBakiye();
            us2.DlBakiye = _form1.DlBakiye();
            us2.EuBakiye = _form1.EuBakiye();
            Tl.Text = Convert.ToString(us2.TlBakiye);
            Dl.Text = Convert.ToString(us2.DlBakiye);
            Eu.Text = Convert.ToString(us2.EuBakiye);
            label2.Text = Convert.ToString(Tl.Text + "₺");
            label3.Text = Convert.ToString(Dl.Text + "$");
            label4.Text = Convert.ToString(Eu.Text + "€");
            label6.Text = us2.NickName;
            Tl.Visible = false;
            Dl.Visible = false;
            Eu.Visible = false;
        }

        private void usrKydt_Click(object sender, EventArgs e)
        {
            User us = new User();
            us.Id = _form1.XMLNickList().IndexOf(label6.Text);
            XmlDocument doc = new XmlDocument();
            doc.Load("users.xml");
            var tlnodes = doc.GetElementsByTagName("TlBakiye");
            XmlNode tlnode = tlnodes[us.Id];
            tlnode.InnerText = Tl.Text;
            var dlnodes = doc.GetElementsByTagName("DlBakiye");
            XmlNode dlnode = dlnodes[us.Id];
            dlnode.InnerText = Dl.Text;
            var eunodes = doc.GetElementsByTagName("EuBakiye");
            XmlNode eunode = eunodes[us.Id];
            eunode.InnerText = Eu.Text;
            doc.Save("users.xml");
            MessageBox.Show("Kayıt Başarılı");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Eğer kaydetmediyseniz değişiklikleri kaybolabilir. Yine de çıkış yapmak istiyor musunuz ? ", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo);
            if(secenek == DialogResult.Yes)
            {
                _form1.Close();
                this.Close();
            }
            else
            {

            }
        }

        private void admnPnl_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace DövizAlSatDemo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            
        }
        DataSet ds = new DataSet();

        private void veriGetir_Click(object sender, EventArgs e)
        {
            try
            {
                using (XmlReader xmlFileToRead = XmlReader.Create("users.xml", new XmlReaderSettings()))
                {
                    ds = new DataSet();
                    ds.ReadXml(xmlFileToRead);
                    dataGridView1.DataSource = ds.Tables[0];
                    xmlFileToRead.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void veriKyt_Click(object sender, EventArgs e)
        {
            try
            {
                using (XmlWriter xmlFileToWrite = XmlWriter.Create("users.xml", new XmlWriterSettings()))
                {
                    ds.WriteXml(xmlFileToWrite);
                    xmlFileToWrite.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}

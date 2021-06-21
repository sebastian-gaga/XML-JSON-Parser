using DotNetBrowser.WinForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DotNetBrowser;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace XIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Initializare fereastra de browse
        OpenFileDialog ofd = new OpenFileDialog();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Initializare textbox pentru path
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            //Parsare XML
            XmlDocument doc = new XmlDocument();
            String path = ofd.FileName;
            doc.Load(path);
            int i = 0;
            String[] nodes = new String[1000];
            foreach (XmlNode node in doc.DocumentElement)
            {
                listView1.Items.Add(Environment.NewLine);
                listView1.Items.Add(node.Name);
                listView1.Items.Add(Environment.NewLine);

                foreach (XmlNode child in node.ChildNodes)
                {
                    listView1.Items.Add(child.Name + ": " + child.InnerText);
                    nodes[i] = child.InnerText;
                    i++;
                    //Afisare XML
                }
                
            }
            //Console.WriteLine(values[3]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            //Parsare JSON
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            String path = textBox1.Text;
            string json = File.ReadAllText(path);
            JsonTextReader reader = new JsonTextReader(new StringReader(json));

            using (StreamReader r = new StreamReader(path))
            {
                string jason = r.ReadToEnd();
                List<Ferma> items = JsonConvert.DeserializeObject<List<Ferma>>(jason);
                for (int i = 0; i < items.Count; i++)
                {   
                    //Afisarea obiectelor deserializate din fisierul JSON
                    listView1.Items.Add("numarIncinta: "+ items[i].numarIncinta);
                    listView1.Items.Add("tip: " + items[i].tip);
                    listView1.Items.Add("spatiu: " + items[i].spatiu);
                    listView1.Items.Add("animal: " + items[i].animal);
                    listView1.Items.Add("familie: " + items[i].familie);
                    listView1.Items.Add("numar capete: " + items[i].numarCapete);
                    listView1.Items.Add("hrana: " + items[i].hrana);
                    listView1.Items.Add("nume: " + items[i].ingrijitor.nume);
                    listView1.Items.Add("salariu: " + items[i].ingrijitor.salariu);
                    listView1.Items.Add(Environment.NewLine);
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Afisare foi de stiluri
            String path = textBox1.Text;
            XPathDocument myXPathDoc = new XPathDocument(path);
            XslCompiledTransform myXslTrans = new XslCompiledTransform();
            myXslTrans.Load("XSLTFile1.xslt");
            System.Diagnostics.Process.Start("iexplore", path);
        }
    }
}

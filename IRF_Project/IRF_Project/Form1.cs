using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace IRF_Project
{
    public partial class Form1 : Form
    {
        BindingList<players> Chelsea = new BindingList<players>();

        public Form1()
        {
            InitializeComponent();

            XmlDocument xml = new XmlDocument();
            xml.Load("chelsea.xml");
            dGVAttributes.DataSource = Chelsea;


            foreach (XmlElement element in xml.DocumentElement)
            {
                var player = new players();
                Chelsea.Add(player);

                player.Name = element.GetAttribute("name");

                var childElement = (XmlElement)element.ChildNodes[0];
                player.Country = childElement.GetAttribute("country");
                player.BirthDate = childElement.GetAttribute("born");
                player.Position = childElement.GetAttribute("position");
                player.Goals = childElement.GetAttribute("goals");
            }
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {

        }
    }
}

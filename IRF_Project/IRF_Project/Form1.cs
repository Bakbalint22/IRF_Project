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

namespace IRF_Project
{
    public partial class Form1 : Form
    {
        BindingList<players> Chelsea = new BindingList<players>();
        List<players> filterplayers;
        XmlDocument xml = new XmlDocument();

        public Form1()
        {
            InitializeComponent();

            
            xml.Load("chelsea.xml");

            dataGridView1.DataSource = Chelsea;

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
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                foreach (var c in filterplayers)
                {
                    sw.Write(c.Name);
                    sw.Write(";");
                    sw.Write(c.Country);
                    sw.Write(";");
                    sw.Write(c.BirthDate);
                    sw.Write(";");
                    sw.Write(c.Position);
                    sw.Write(";");
                    sw.Write(c.Goals);
                    sw.WriteLine();
                }
            }
        }

       

        private void Reload()
        {
            
            dataGridView1.DataSource = Chelsea;
            filterplayers = new List<players>();
            foreach (var player in Chelsea)
            {
                filterplayers.Add(player);
            }
            
        }

        private void btnForwards_Click(object sender, EventArgs e)
        {
            filterplayers = new List<players>();


            

            foreach (var player in Chelsea)
            {
                filterplayers.Add(player);
                if (player.Position != "Forward")
                {
                    
                    filterplayers.Remove(player);
                }
            }

            dataGridView1.DataSource = filterplayers;


        }

        private void btnMidfilders_Click(object sender, EventArgs e)
        {
            filterplayers = new List<players>();

            foreach (var player in Chelsea)
            {
                filterplayers.Add(player);
                if (player.Position != "Midfilder")
                {

                    filterplayers.Remove(player);
                }
            }

            dataGridView1.DataSource = filterplayers;
        }

        private void btnDefenders_Click(object sender, EventArgs e)
        {
            filterplayers = new List<players>();

            foreach (var player in Chelsea)
            {
                filterplayers.Add(player);
                if (player.Position != "Defender")
                {

                    filterplayers.Remove(player);
                }
            }

            dataGridView1.DataSource = filterplayers;
        }

        private void btnGoalkeepers_Click(object sender, EventArgs e)
        {
            filterplayers = new List<players>();

            foreach (var player in Chelsea)
            {
                filterplayers.Add(player);
                if (player.Position != "Goal-keeper")
                {

                    filterplayers.Remove(player);
                }
            }

            dataGridView1.DataSource = filterplayers;
        }

        private void btnAnimation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Animation anim = new Animation();
            anim.Show();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
        }

       
    }
}

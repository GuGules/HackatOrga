using HackatOrga.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackatOrga
{
    public partial class editConf : Form
    {
        public editConf()
        {
            InitializeComponent();
        }

        private List<Conf> listeConferences = Program.cnx.Conferences.ToList();

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editConf_Load(object sender, EventArgs e)
        {
            confCbx.DataSource = listeConferences;
            confCbx.DisplayMember = "nom";
            hackathonCbx.DataSource = Program.cnx.Hackathons.ToList();
            hackathonCbx.DisplayMember = "nom";


            // Chargement des infos
            hackathonCbx.SelectedItem = listeConferences[confCbx.SelectedIndex].Hackathon;
            nameTbx.Text = listeConferences[confCbx.SelectedIndex].nom;
            dateDtp.Value = listeConferences[confCbx.SelectedIndex].date;
            roomTbx.Text = listeConferences[confCbx.SelectedIndex].salle;
            durationTp.Value = DateTime.Today + listeConferences[confCbx.SelectedIndex].duree.ToTimeSpan();
            intervenantTbx.Text = listeConferences[confCbx.SelectedIndex].intervenant;
            themeTbx.Text = listeConferences[confCbx.SelectedIndex].theme;
        }

        private void confCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Chargement des infos
            hackathonCbx.SelectedItem = listeConferences[confCbx.SelectedIndex].Hackathon;
            nameTbx.Text = listeConferences[confCbx.SelectedIndex].nom;
            dateDtp.Value = listeConferences[confCbx.SelectedIndex].date;
            roomTbx.Text = listeConferences[confCbx.SelectedIndex].salle;
            durationTp.Value = DateTime.Today + listeConferences[confCbx.SelectedIndex].duree.ToTimeSpan();
            intervenantTbx.Text = listeConferences[confCbx.SelectedIndex].intervenant;
            themeTbx.Text = listeConferences[confCbx.SelectedIndex].theme;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conf conference = listeConferences[confCbx.SelectedIndex]; 
            conference.nom = nameTbx.Text;
            conference.date = dateDtp.Value;
            conference.duree = TimeOnly.FromDateTime(durationTp.Value);
            conference.salle = roomTbx.Text;
            conference.Hackathon = Program.cnx.Hackathons.ToList()[hackathonCbx.SelectedIndex];
            conference.theme = themeTbx.Text;
            conference.intervenant = intervenantTbx.Text;
            Program.cnx.SaveChanges();
            MessageBox.Show("Modifications Sauvegardées");
            this.Close();
        }
    }
}

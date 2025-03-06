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
    public partial class addConference : Form
    {
        public addConference()
        {
            InitializeComponent();
        }

        private void addConference_Load(object sender, EventArgs e)
        {
            hackathonCbx.DataSource = Program.cnx.Hackathons.ToList();
            hackathonCbx.DisplayMember = "nom";

            durationTp.Format = DateTimePickerFormat.Time;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conf conference = new Conf();
            conference.nom = nameTbx.Text;
            conference.date = dateDtp.Value;
            conference.duree = TimeOnly.FromDateTime(durationTp.Value);
            conference.salle = roomTbx.Text;
            conference.Hackathon = Program.cnx.Hackathons.ToList()[hackathonCbx.SelectedIndex];
            conference.theme = themeTbx.Text;
            conference.intervenant = intervenantTbx.Text;
            Program.cnx.Conferences.Add(conference);
            Program.cnx.SaveChanges();
            MessageBox.Show("Conférence programmée");
            this.Close();
        }
    }
}

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
    public partial class addAtelier : Form
    {
        public addAtelier()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atelier at = new Atelier();
            at.nom = nameTbx.Text;
            at.salle = roomTbx.Text;
            at.date = dateDtp.Value;
            at.Hackathon = Program.cnx.Hackathons.ToList()[hackathonCbx.SelectedIndex];
            at.nbPlaces = (int)nbPlacesNUD.Value;
            at.duree = TimeOnly.FromDateTime(durationTp.Value);

            Program.cnx.Ateliers.Add(at);
            Program.cnx.SaveChanges();

            MessageBox.Show("Atelier enregistré");
            this.Close();


        }

        private void addAtelier_Load(object sender, EventArgs e)
        {
            durationTp.Format = DateTimePickerFormat.Time;
            hackathonCbx.DataSource = Program.cnx.Hackathons.ToList();
            hackathonCbx.DisplayMember = "nom";
            
        }
    }
}

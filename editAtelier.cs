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
    public partial class editAtelier : Form
    {
        public editAtelier()
        {
            InitializeComponent();
        }

        private List<Atelier> AteliersList = Program.cnx.Ateliers.ToList();

        private void editAtelier_Load(object sender, EventArgs e)
        {
            /*
             * Chargement de la page
             */

            //Configuration des éléments
            durationTp.Format = DateTimePickerFormat.Time;
            atelierCbx.DataSource = AteliersList;
            atelierCbx.DisplayMember = "nom";
            hackathonCbx.DataSource = Program.cnx.Hackathons.ToList();
            hackathonCbx.DisplayMember = "nom";

            // Chargement des infos
            hackathonCbx.SelectedItem = AteliersList[atelierCbx.SelectedIndex].Hackathon;
            nbPlacesNUD.Value = AteliersList[atelierCbx.SelectedIndex].nbPlaces;
            nameTbx.Text = AteliersList[atelierCbx.SelectedIndex].nom;
            dateDtp.Value = AteliersList[atelierCbx.SelectedIndex].date;
            roomTbx.Text = AteliersList[atelierCbx.SelectedIndex].salle;
            durationTp.Value = DateTime.Today + AteliersList[atelierCbx.SelectedIndex].duree.ToTimeSpan();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            /*
             * Fermeture de la fenêtre
             */

            this.Close();
        }

        private void atelierCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             * Mise à jour des champs lorsque nouvel atelier sélectionné
             */

            nbPlacesNUD.Value = AteliersList[atelierCbx.SelectedIndex].nbPlaces;
            nameTbx.Text = AteliersList[atelierCbx.SelectedIndex].nom;
            dateDtp.Value = AteliersList[atelierCbx.SelectedIndex].date;
            roomTbx.Text = AteliersList[atelierCbx.SelectedIndex].salle;
            hackathonCbx.SelectedItem = AteliersList[atelierCbx.SelectedIndex].Hackathon;
            durationTp.Value = DateTime.Today + AteliersList[atelierCbx.SelectedIndex].duree.ToTimeSpan();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            /*
             * Sauvegarde des modifications
             */

            Atelier at = AteliersList[atelierCbx.SelectedIndex];
            at.nom = nameTbx.Text;
            at.salle = roomTbx.Text;
            at.date = dateDtp.Value;
            at.Hackathon = Program.cnx.Hackathons.ToList()[hackathonCbx.SelectedIndex];
            at.nbPlaces = (int)nbPlacesNUD.Value;
            at.duree = TimeOnly.FromDateTime(durationTp.Value);
            Program.cnx.SaveChanges();

            MessageBox.Show("Modifications Sauvegardées");
            this.Close();
        }
    }
}

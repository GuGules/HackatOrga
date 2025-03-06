using HackatOrga.models;
using Microsoft.EntityFrameworkCore;
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
    public partial class modifierHackathon : Form
    {

        public int idHackathon = -1;

        Hackathon unHackathon = new Hackathon();
        public modifierHackathon()
        {
            InitializeComponent();
        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifierHackathon_Load(object sender, EventArgs e)
        {
            // TODO : Injecter tout les hackathons dans la comboBox

            hackathonCbx.DataSource = Program.cnx.Hackathons.ToList();

            if (this.idHackathon == -1) { 
                hackathonCbx.SelectedItem = Program.cnx.Hackathons.ToList()[0];
            } else
            {
                hackathonCbx.SelectedItem = Program.cnx.Hackathons.ToList()[this.idHackathon];
            }

                tbnom.Text = Program.cnx.Hackathons.ToList()[hackathonCbx.SelectedIndex].nom;
            dtpdateDeb.Value = Program.cnx.Hackathons.ToList()[hackathonCbx.SelectedIndex].dateDeb;
            dtpdateFin.Value = Program.cnx.Hackathons.ToList()[hackathonCbx.SelectedIndex].dateFin;
            dtpdateLim.Value = Program.cnx.Hackathons.ToList()[hackathonCbx.SelectedIndex].dateLim;
            nudnbPlaces.Value = Program.cnx.Hackathons.ToList()[hackathonCbx.SelectedIndex].nbPlaces;
            cityTbx.Text = Program.cnx.Hackathons.ToList()[hackathonCbx.SelectedIndex].ville;
            streetTbx.Text = Program.cnx.Hackathons.ToList()[hackathonCbx.SelectedIndex].rue;
            postalCodeTbx.Text = Program.cnx.Hackathons.ToList()[hackathonCbx.SelectedIndex].codePostal;
        }

        private void hackathonCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbnom.Text = Program.cnx.Hackathons.ToList()[hackathonCbx.SelectedIndex].nom;
            dtpdateDeb.Value = Program.cnx.Hackathons.ToList()[hackathonCbx.SelectedIndex].dateDeb;
            dtpdateFin.Value = Program.cnx.Hackathons.ToList()[hackathonCbx.SelectedIndex].dateFin;
            dtpdateLim.Value = Program.cnx.Hackathons.ToList()[hackathonCbx.SelectedIndex].dateLim;
            nudnbPlaces.Value = Program.cnx.Hackathons.ToList()[hackathonCbx.SelectedIndex].nbPlaces;
            cityTbx.Text = Program.cnx.Hackathons.ToList()[hackathonCbx.SelectedIndex].ville;
            streetTbx.Text = Program.cnx.Hackathons.ToList()[hackathonCbx.SelectedIndex].rue;
            postalCodeTbx.Text = Program.cnx.Hackathons.ToList()[hackathonCbx.SelectedIndex].codePostal;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Récupération du hackathon sélectionné
            Hackathon hck = Program.cnx.Hackathons.ToList()[hackathonCbx.SelectedIndex];

            //Suppression du hackathon
            Program.cnx.Hackathons.Remove(hck);
            Program.cnx.SaveChanges();
            MessageBox.Show("Le hackathon a été supprimé");
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Hackathon hck = Program.cnx.Hackathons.ToList()[hackathonCbx.SelectedIndex];
            hck.nom = tbnom.Text;
            hck.dateDeb = dtpdateDeb.Value;
            hck.dateFin = dtpdateFin.Value;
            hck.dateLim = dtpdateLim.Value;
            hck.nbPlaces = (int)nudnbPlaces.Value;
            hck.ville = cityTbx.Text;
            hck.rue = streetTbx.Text;
            hck.codePostal = postalCodeTbx.Text;

            // On enregistre les modifs / We save the updates

            Program.cnx.SaveChanges();
            MessageBox.Show("Modifications sauvegardées");
            this.Close();
        }
    }
}

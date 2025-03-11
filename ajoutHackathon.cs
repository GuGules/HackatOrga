using HackatOrga.models;
using HackatOrga.Models;
using System.Net;


namespace HackatOrga
{
    public partial class ajoutHackathon : Form
    {
        public ajoutHackathon()
        {
            InitializeComponent();
        }

        private void addHackathon(object sender, EventArgs e)
        {
            if (dtpdateDeb.Value < dtpdateLim.Value && dtpdateDeb.Value < dtpdateFin.Value)
            {
                /*
                 * Création d'un nouvel hackathon
                 */
                Hackathon hackathon = new Hackathon();
                hackathon.nom = tbnom.Text;
                hackathon.dateDeb = dtpdateDeb.Value;
                hackathon.dateLim = dtpdateLim.Value;
                hackathon.dateFin = dtpdateFin.Value;
                hackathon.nbPlaces = (int)nudnbPlaces.Value;
                // Ajout infos sur la localisation
                hackathon.ville = cityTbx.Text;
                hackathon.rue = streeTbx.Text;
                hackathon.codePostal = postalCodeTbx.Text;
                Program.cnx.Hackathons.Add(hackathon);
                Program.cnx.SaveChanges();
                MessageBox.Show("Hackathon Enregistré");
                this.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

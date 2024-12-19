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
        Hackathon unHackathon =new Hackathon();
        public modifierHackathon()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tbnom_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bQuitter_Click(object sender, EventArgs e)
        {

        }

        private void modifierHackathon_Load(object sender, EventArgs e)
        {
            unHackathon = Program.cnx.Hackathons.Include("evenements").Where(w => w.hackathonId == 1).Single();
            tbnom.Text = unHackathon.nom;
            dtpdateDeb.Value = unHackathon.dateDeb;
            dtpdateFin.Value = unHackathon.dateFin;
            dtpdateLim.Value = unHackathon.dateLim;
            nudnbPlaces.Value = unHackathon.nbPlaces;
        }

        private void nudnbPlaces_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

using HackatOrga.models;
using HackatOrga.Models;
using System.Net;


namespace HackatOrga
{
    public partial class ajoutHackathon : Form
    {
        private MonDbContext cnx = new MonDbContext();
        public ajoutHackathon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ajoutHackathon_Load(object sender, EventArgs e)
        {
            Hackathon hackathon = new Hackathon
            {
                nom = tbnom.Text,
                dateDeb = dtpdateDeb.Value,
                dateLim = dtpdateLim.Value,
                dateFin = dtpdateFin.Value,
                nbPlaces = nudnbPlaces.Value
            };
            Console.WriteLine(hackathon);
            //cnx.Hackathons.Add(hackathon);
            //cnx.SaveChanges();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class listeHackathon : Form
    {
        public listeHackathon()
        {
            InitializeComponent();
        }

        private void closeListBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listeHackathon_Load(object sender, EventArgs e)
        {
            hackathonList.DataSource = Program.cnx.Hackathons.ToList();
        }

        private void addHackathonBtn_Click(object sender, EventArgs e)
        {
            ajoutHackathon addForm = new ajoutHackathon();
            addForm.Show();
        }

        private void manageHackathonBtn_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show("Fonctionnalité à venir");
        }
    }
}

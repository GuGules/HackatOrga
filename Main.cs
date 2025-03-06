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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void quitterLapplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listerLesHackathonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listeHackathon lst = new listeHackathon();
            lst.Show();
        }

        private void ajouterUnHackathonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajoutHackathon frm = new ajoutHackathon();
            frm.Show();
        }

        private void gérerHackathonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            modifierHackathon frm = new modifierHackathon();
            frm.Show();
        }

        private void créerAtelierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addAtelier addAt = new addAtelier();
            addAt.Show();
        }

        private void listerAteliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listeAteliers listeAt = new listeAteliers();
            listeAt.Show();
        }
    }
}

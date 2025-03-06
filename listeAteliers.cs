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
    public partial class listeAteliers : Form
    {
        public listeAteliers()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newAtBtn_Click(object sender, EventArgs e)
        {
            addAtelier addAt = new addAtelier();
            addAt.Show();
        }

        private void listeAteliers_Load(object sender, EventArgs e)
        {
            listeDGV.DataSource = Program.cnx.Ateliers.ToList();
        }
    }
}

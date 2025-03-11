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
    public partial class listeConference : Form
    {
        public listeConference()
        {
            InitializeComponent();
        }

        private void listeConference_Load(object sender, EventArgs e)
        {
            confDGV.DataSource = Program.cnx.Conferences.ToList();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newConfBtn_Click(object sender, EventArgs e)
        {
            addConference addC = new addConference();
            addC.Show();
        }
    }
}

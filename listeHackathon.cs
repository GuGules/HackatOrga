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
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Xml.Linq;

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

        private void printPDFBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int row = hackathonList.SelectedRows[0].Index;
                MessageBox.Show("Ligne sélectionné : " + row.ToString());
                try
                {
                    Hackathon h = Program.cnx.Hackathons.ToList()[row];

                    string filename = "pdfs\\"+$"{DateTime.Now.ToString("yyyy_MM_dd")}_Hackathon{h.nom}.pdf";

                    PdfDocument pdf = new PdfDocument();

                    pdf.Info.Title = "Participants de "+h.nom;

                    // Create an empty page
                    PdfPage page = pdf.AddPage();

                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);

                    // Create a font
                    XFont font = new XFont("Verdana", 20);

                    // Draw the text
                    gfx.DrawString("Hello, World!", font, XBrushes.Black,
                      new XRect(0, 0, page.Width, page.Height),
                      XStringFormats.Center);

                    // Save the document...
                    pdf.Save(filename);
                    // ...and start a viewer.
                    var process = new Process();
                    process.StartInfo = new ProcessStartInfo(filename)
                    {
                        UseShellExecute = true
                    };
                    process.Start();

                    //Process.Start(@filename);
                } catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }


            } catch (Exception err)
            {
                MessageBox.Show("Aucune ligne n'a été sélectionnée");
            }
        }
    }
}

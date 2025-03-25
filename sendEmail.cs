using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Text.Json;
using HackatOrga.models;
using System.Text.RegularExpressions;
using System.Net.Mail;

using Microsoft.Toolkit.Uwp.Notifications;

namespace HackatOrga
{
    public partial class sendEmail : Form
    {

        public sendEmail()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendEmail_Load(object sender, EventArgs e)
        {
            confCbx.DataSource = Program.cnx.Conferences.ToList();
            confCbx.DisplayMember = "nom";
        }

        private async void sendEmailBtn_Click(object sender, EventArgs e)
        {
            string resendToken = ConfigurationManager.AppSettings["tokenResend"];

            Conf c = Program.cnx.Conferences.ToList()[confCbx.SelectedIndex];

            if (c.emailIntervenant != "")
            {
                try
                {
                    string mail = new MailAddress(c.emailIntervenant).Address;

                    using (HttpClient client = new HttpClient())
                    {

                        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {resendToken}");
                        client.DefaultRequestHeaders.Add("Accept", "application/json");


                        var emailData = new
                        {
                            from = "HackatAgence <hackatagence@jules-pillot.fr>",
                            to = new string[] { c.emailIntervenant.ToString() }, // Tableau pour gérer plusieurs destinataires
                            subject = "Rappel de session : " + c.theme,
                            html = "<p>Bonjour,</p>\n<p>Merci de votre participation à notre hackathon.</p>\n" +
                            "<p>Pour rappel, votre conférence sur le theme de \"" + c.theme + "\" a lieu le " + c.date.ToString() + "\n" +
                            "<br><br><p>En vous remerciant de votre participation,</p>\n" +
                            "<p>Cordialement,</p>\n" +
                            "<p>HackatAgence</p>"
                        };

                        var content = new StringContent(JsonSerializer.Serialize(emailData), Encoding.UTF8, "application/json");

                        HttpResponseMessage response = await client.PostAsync("https://api.resend.com/emails", content);
                        string responseContent = await response.Content.ReadAsStringAsync();

                        if ((int)response.StatusCode == 200)
                        {
                            new ToastContentBuilder()
                            .AddText("Email Envoyé")
                            .AddText(c.intervenant.ToString()+" a été informé de la date de sa conférence")
                            .Show(); 

                        } else
                        {
                            MessageBox.Show("Il y a une erreur lors de l'envoi du mail",
                                "Email non envoyé",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Adresse email incorrecte\n" + ex.Message);
                }
            }
        }
    }
}

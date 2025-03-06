namespace HackatOrga
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            applicationToolStripMenuItem = new ToolStripMenuItem();
            quitterLapplicationToolStripMenuItem = new ToolStripMenuItem();
            hackathonToolStripMenuItem = new ToolStripMenuItem();
            listerLesHackathonsToolStripMenuItem = new ToolStripMenuItem();
            gérerHackathonToolStripMenuItem = new ToolStripMenuItem();
            ajouterUnHackathonToolStripMenuItem = new ToolStripMenuItem();
            gérerHackathonToolStripMenuItem1 = new ToolStripMenuItem();
            ateliersToolStripMenuItem = new ToolStripMenuItem();
            listerAteliersToolStripMenuItem = new ToolStripMenuItem();
            gérerAteliersToolStripMenuItem = new ToolStripMenuItem();
            créerAtelierToolStripMenuItem = new ToolStripMenuItem();
            modifierAtelierToolStripMenuItem = new ToolStripMenuItem();
            participantsToolStripMenuItem = new ToolStripMenuItem();
            gérerParticipantsToolStripMenuItem = new ToolStripMenuItem();
            ajouterUnParticipantsToolStripMenuItem = new ToolStripMenuItem();
            editerSupprimerUnParticipantToolStripMenuItem = new ToolStripMenuItem();
            listerLesParticipantsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { applicationToolStripMenuItem, hackathonToolStripMenuItem, ateliersToolStripMenuItem, participantsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1119, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            applicationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quitterLapplicationToolStripMenuItem });
            applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            applicationToolStripMenuItem.Size = new Size(80, 20);
            applicationToolStripMenuItem.Text = "Application";
            // 
            // quitterLapplicationToolStripMenuItem
            // 
            quitterLapplicationToolStripMenuItem.Name = "quitterLapplicationToolStripMenuItem";
            quitterLapplicationToolStripMenuItem.Size = new Size(179, 22);
            quitterLapplicationToolStripMenuItem.Text = "Quitter l'application";
            quitterLapplicationToolStripMenuItem.Click += quitterLapplicationToolStripMenuItem_Click;
            // 
            // hackathonToolStripMenuItem
            // 
            hackathonToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listerLesHackathonsToolStripMenuItem, gérerHackathonToolStripMenuItem });
            hackathonToolStripMenuItem.Name = "hackathonToolStripMenuItem";
            hackathonToolStripMenuItem.Size = new Size(77, 20);
            hackathonToolStripMenuItem.Text = "Hackathon";
            // 
            // listerLesHackathonsToolStripMenuItem
            // 
            listerLesHackathonsToolStripMenuItem.Name = "listerLesHackathonsToolStripMenuItem";
            listerLesHackathonsToolStripMenuItem.Size = new Size(183, 22);
            listerLesHackathonsToolStripMenuItem.Text = "Lister les hackathons";
            listerLesHackathonsToolStripMenuItem.Click += listerLesHackathonsToolStripMenuItem_Click;
            // 
            // gérerHackathonToolStripMenuItem
            // 
            gérerHackathonToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterUnHackathonToolStripMenuItem, gérerHackathonToolStripMenuItem1 });
            gérerHackathonToolStripMenuItem.Name = "gérerHackathonToolStripMenuItem";
            gérerHackathonToolStripMenuItem.Size = new Size(183, 22);
            gérerHackathonToolStripMenuItem.Text = "Gérer Hackathon";
            // 
            // ajouterUnHackathonToolStripMenuItem
            // 
            ajouterUnHackathonToolStripMenuItem.Name = "ajouterUnHackathonToolStripMenuItem";
            ajouterUnHackathonToolStripMenuItem.Size = new Size(191, 22);
            ajouterUnHackathonToolStripMenuItem.Text = "Ajouter un Hackathon";
            ajouterUnHackathonToolStripMenuItem.Click += ajouterUnHackathonToolStripMenuItem_Click;
            // 
            // gérerHackathonToolStripMenuItem1
            // 
            gérerHackathonToolStripMenuItem1.Name = "gérerHackathonToolStripMenuItem1";
            gérerHackathonToolStripMenuItem1.Size = new Size(191, 22);
            gérerHackathonToolStripMenuItem1.Text = "Gérer Hackathon";
            gérerHackathonToolStripMenuItem1.Click += gérerHackathonToolStripMenuItem1_Click;
            // 
            // ateliersToolStripMenuItem
            // 
            ateliersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listerAteliersToolStripMenuItem, gérerAteliersToolStripMenuItem });
            ateliersToolStripMenuItem.Name = "ateliersToolStripMenuItem";
            ateliersToolStripMenuItem.Size = new Size(83, 20);
            ateliersToolStripMenuItem.Text = "Evenements";
            // 
            // listerAteliersToolStripMenuItem
            // 
            listerAteliersToolStripMenuItem.Name = "listerAteliersToolStripMenuItem";
            listerAteliersToolStripMenuItem.Size = new Size(180, 22);
            listerAteliersToolStripMenuItem.Text = "Lister Ateliers";
            listerAteliersToolStripMenuItem.Click += listerAteliersToolStripMenuItem_Click;
            // 
            // gérerAteliersToolStripMenuItem
            // 
            gérerAteliersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { créerAtelierToolStripMenuItem, modifierAtelierToolStripMenuItem });
            gérerAteliersToolStripMenuItem.Name = "gérerAteliersToolStripMenuItem";
            gérerAteliersToolStripMenuItem.Size = new Size(180, 22);
            gérerAteliersToolStripMenuItem.Text = "Gérer Ateliers";
            // 
            // créerAtelierToolStripMenuItem
            // 
            créerAtelierToolStripMenuItem.Name = "créerAtelierToolStripMenuItem";
            créerAtelierToolStripMenuItem.Size = new Size(156, 22);
            créerAtelierToolStripMenuItem.Text = "Créer Atelier";
            créerAtelierToolStripMenuItem.Click += créerAtelierToolStripMenuItem_Click;
            // 
            // modifierAtelierToolStripMenuItem
            // 
            modifierAtelierToolStripMenuItem.Name = "modifierAtelierToolStripMenuItem";
            modifierAtelierToolStripMenuItem.Size = new Size(156, 22);
            modifierAtelierToolStripMenuItem.Text = "Modifier Atelier";
            // 
            // participantsToolStripMenuItem
            // 
            participantsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gérerParticipantsToolStripMenuItem, listerLesParticipantsToolStripMenuItem });
            participantsToolStripMenuItem.Name = "participantsToolStripMenuItem";
            participantsToolStripMenuItem.Size = new Size(81, 20);
            participantsToolStripMenuItem.Text = "Participants";
            // 
            // gérerParticipantsToolStripMenuItem
            // 
            gérerParticipantsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterUnParticipantsToolStripMenuItem, editerSupprimerUnParticipantToolStripMenuItem });
            gérerParticipantsToolStripMenuItem.Name = "gérerParticipantsToolStripMenuItem";
            gérerParticipantsToolStripMenuItem.Size = new Size(184, 22);
            gérerParticipantsToolStripMenuItem.Text = "Gérer participants";
            // 
            // ajouterUnParticipantsToolStripMenuItem
            // 
            ajouterUnParticipantsToolStripMenuItem.Name = "ajouterUnParticipantsToolStripMenuItem";
            ajouterUnParticipantsToolStripMenuItem.Size = new Size(241, 22);
            ajouterUnParticipantsToolStripMenuItem.Text = "Ajouter un participant";
            // 
            // editerSupprimerUnParticipantToolStripMenuItem
            // 
            editerSupprimerUnParticipantToolStripMenuItem.Name = "editerSupprimerUnParticipantToolStripMenuItem";
            editerSupprimerUnParticipantToolStripMenuItem.Size = new Size(241, 22);
            editerSupprimerUnParticipantToolStripMenuItem.Text = "Editer/Supprimer un participant";
            // 
            // listerLesParticipantsToolStripMenuItem
            // 
            listerLesParticipantsToolStripMenuItem.Name = "listerLesParticipantsToolStripMenuItem";
            listerLesParticipantsToolStripMenuItem.Size = new Size(184, 22);
            listerLesParticipantsToolStripMenuItem.Text = "Lister les participants";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1119, 702);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "HackatOrga";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem applicationToolStripMenuItem;
        private ToolStripMenuItem quitterLapplicationToolStripMenuItem;
        private ToolStripMenuItem hackathonToolStripMenuItem;
        private ToolStripMenuItem listerLesHackathonsToolStripMenuItem;
        private ToolStripMenuItem gérerHackathonToolStripMenuItem;
        private ToolStripMenuItem ajouterUnHackathonToolStripMenuItem;
        private ToolStripMenuItem gérerHackathonToolStripMenuItem1;
        private ToolStripMenuItem ateliersToolStripMenuItem;
        private ToolStripMenuItem listerAteliersToolStripMenuItem;
        private ToolStripMenuItem gérerAteliersToolStripMenuItem;
        private ToolStripMenuItem participantsToolStripMenuItem;
        private ToolStripMenuItem gérerParticipantsToolStripMenuItem;
        private ToolStripMenuItem ajouterUnParticipantsToolStripMenuItem;
        private ToolStripMenuItem editerSupprimerUnParticipantToolStripMenuItem;
        private ToolStripMenuItem listerLesParticipantsToolStripMenuItem;
        private ToolStripMenuItem créerAtelierToolStripMenuItem;
        private ToolStripMenuItem modifierAtelierToolStripMenuItem;
    }
}
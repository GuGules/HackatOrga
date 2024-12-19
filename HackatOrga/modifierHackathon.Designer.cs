namespace HackatOrga
{
    partial class modifierHackathon
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label2 = new Label();
            CLBEvenement = new CheckedListBox();
            CLBParticipants = new CheckedListBox();
            label3 = new Label();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            nudnbPlaces = new NumericUpDown();
            dtpdateLim = new DateTimePicker();
            dtpdateFin = new DateTimePicker();
            dtpdateDeb = new DateTimePicker();
            tbnom = new TextBox();
            bEnregistrer = new Button();
            bQuitter = new Button();
            bSupprimer = new Button();
            label9 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudnbPlaces).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(nudnbPlaces);
            groupBox1.Controls.Add(dtpdateLim);
            groupBox1.Controls.Add(dtpdateFin);
            groupBox1.Controls.Add(dtpdateDeb);
            groupBox1.Controls.Add(tbnom);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(596, 355);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(CLBEvenement);
            groupBox2.Controls.Add(CLBParticipants);
            groupBox2.Location = new Point(309, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(265, 313);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 161);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 29;
            label4.Text = "liste des événements";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 17);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 27;
            label2.Text = "liste des participants";
            // 
            // CLBEvenement
            // 
            CLBEvenement.FormattingEnabled = true;
            CLBEvenement.Location = new Point(28, 184);
            CLBEvenement.Name = "CLBEvenement";
            CLBEvenement.Size = new Size(216, 112);
            CLBEvenement.TabIndex = 28;
            // 
            // CLBParticipants
            // 
            CLBParticipants.FormattingEnabled = true;
            CLBParticipants.Location = new Point(28, 40);
            CLBParticipants.Name = "CLBParticipants";
            CLBParticipants.Size = new Size(216, 112);
            CLBParticipants.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 32);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 26;
            label3.Text = "Nom";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(41, 91);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 25;
            label8.Text = "Date de début";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 155);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 23;
            label6.Text = "date de fin";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(41, 213);
            label7.Name = "label7";
            label7.Size = new Size(177, 20);
            label7.TabIndex = 22;
            label7.Text = "Date limite d'inscription";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 271);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 20;
            label5.Text = "Nombre de places";
            label5.Click += label5_Click;
            // 
            // nudnbPlaces
            // 
            nudnbPlaces.Location = new Point(41, 294);
            nudnbPlaces.Name = "nudnbPlaces";
            nudnbPlaces.Size = new Size(200, 23);
            nudnbPlaces.TabIndex = 16;
            nudnbPlaces.ValueChanged += nudnbPlaces_ValueChanged;
            // 
            // dtpdateLim
            // 
            dtpdateLim.Location = new Point(41, 238);
            dtpdateLim.Name = "dtpdateLim";
            dtpdateLim.Size = new Size(200, 23);
            dtpdateLim.TabIndex = 15;
            // 
            // dtpdateFin
            // 
            dtpdateFin.Location = new Point(41, 178);
            dtpdateFin.Name = "dtpdateFin";
            dtpdateFin.Size = new Size(200, 23);
            dtpdateFin.TabIndex = 14;
            // 
            // dtpdateDeb
            // 
            dtpdateDeb.Location = new Point(41, 120);
            dtpdateDeb.Name = "dtpdateDeb";
            dtpdateDeb.Size = new Size(200, 23);
            dtpdateDeb.TabIndex = 13;
            // 
            // tbnom
            // 
            tbnom.Location = new Point(41, 56);
            tbnom.Name = "tbnom";
            tbnom.Size = new Size(200, 23);
            tbnom.TabIndex = 12;
            tbnom.TextChanged += tbnom_TextChanged;
            // 
            // bEnregistrer
            // 
            bEnregistrer.Location = new Point(653, 141);
            bEnregistrer.Name = "bEnregistrer";
            bEnregistrer.Size = new Size(107, 48);
            bEnregistrer.TabIndex = 2;
            bEnregistrer.Text = "enregistrer";
            bEnregistrer.UseVisualStyleBackColor = true;
            // 
            // bQuitter
            // 
            bQuitter.Location = new Point(653, 273);
            bQuitter.Name = "bQuitter";
            bQuitter.Size = new Size(107, 48);
            bQuitter.TabIndex = 3;
            bQuitter.Text = "quitter";
            bQuitter.UseVisualStyleBackColor = true;
            bQuitter.Click += bQuitter_Click;
            // 
            // bSupprimer
            // 
            bSupprimer.Location = new Point(653, 206);
            bSupprimer.Name = "bSupprimer";
            bSupprimer.Size = new Size(107, 48);
            bSupprimer.TabIndex = 4;
            bSupprimer.Text = "supprimer";
            bSupprimer.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label9.Location = new Point(613, 46);
            label9.Name = "label9";
            label9.Size = new Size(194, 25);
            label9.TabIndex = 28;
            label9.Text = "Ajouter ou modifier ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(628, 67);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 29;
            label1.Text = "mon hackathon";
            // 
            // modifierHackathon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 391);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(bSupprimer);
            Controls.Add(bQuitter);
            Controls.Add(bEnregistrer);
            Controls.Add(groupBox1);
            Name = "modifierHackathon";
            Text = "modifierHackathon";
            Load += modifierHackathon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudnbPlaces).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button bEnregistrer;
        private Button bQuitter;
        private Label label5;
        private NumericUpDown nudnbPlaces;
        private DateTimePicker dtpdateLim;
        private DateTimePicker dtpdateFin;
        private DateTimePicker dtpdateDeb;
        private TextBox tbnom;
        private Label label3;
        private Label label8;
        private Label label6;
        private Label label7;
        private CheckedListBox CLBParticipants;
        private GroupBox groupBox2;
        private CheckedListBox CLBEvenement;
        private Label label2;
        private Button bSupprimer;
        private Label label4;
        private Label label9;
        private Label label1;
    }
}
namespace HackatOrga
{
    partial class ajoutHackathon
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbnom = new TextBox();
            dtpdateDeb = new DateTimePicker();
            dtpdateFin = new DateTimePicker();
            dtpdateLim = new DateTimePicker();
            nudnbPlaces = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            bajout = new Button();
            ((System.ComponentModel.ISupportInitialize)nudnbPlaces).BeginInit();
            SuspendLayout();
            // 
            // tbnom
            // 
            tbnom.Location = new Point(322, 170);
            tbnom.Name = "tbnom";
            tbnom.Size = new Size(200, 23);
            tbnom.TabIndex = 0;
            tbnom.TextChanged += textBox1_TextChanged;
            // 
            // dtpdateDeb
            // 
            dtpdateDeb.Location = new Point(322, 199);
            dtpdateDeb.Name = "dtpdateDeb";
            dtpdateDeb.Size = new Size(200, 23);
            dtpdateDeb.TabIndex = 1;
            dtpdateDeb.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dtpdateFin
            // 
            dtpdateFin.Location = new Point(322, 228);
            dtpdateFin.Name = "dtpdateFin";
            dtpdateFin.Size = new Size(200, 23);
            dtpdateFin.TabIndex = 2;
            dtpdateFin.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dtpdateLim
            // 
            dtpdateLim.Location = new Point(322, 257);
            dtpdateLim.Name = "dtpdateLim";
            dtpdateLim.Size = new Size(200, 23);
            dtpdateLim.TabIndex = 3;
            dtpdateLim.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // nudnbPlaces
            // 
            nudnbPlaces.Location = new Point(322, 286);
            nudnbPlaces.Name = "nudnbPlaces";
            nudnbPlaces.Size = new Size(200, 23);
            nudnbPlaces.TabIndex = 4;
            nudnbPlaces.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 137);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 5;
            label1.Text = "ajouter un hackathon";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 178);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 6;
            label2.Text = "nom";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(236, 205);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 7;
            label3.Text = "date de début";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 232);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 8;
            label4.Text = "date de fin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(208, 288);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 9;
            label5.Text = "nombre de places";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(184, 263);
            label6.Name = "label6";
            label6.Size = new Size(132, 15);
            label6.TabIndex = 11;
            label6.Text = "date limite d'inscription";
            // 
            // bajout
            // 
            bajout.Location = new Point(377, 328);
            bajout.Name = "bajout";
            bajout.Size = new Size(75, 23);
            bajout.TabIndex = 12;
            bajout.Text = "ajouter";
            bajout.UseVisualStyleBackColor = true;
            bajout.Click += bajout_Click;
            // 
            // ajoutHackathon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bajout);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudnbPlaces);
            Controls.Add(dtpdateLim);
            Controls.Add(dtpdateFin);
            Controls.Add(dtpdateDeb);
            Controls.Add(tbnom);
            Name = "ajoutHackathon";
            Text = "ajoutHackathon";
            Load += ajoutHackathon_Load;
            ((System.ComponentModel.ISupportInitialize)nudnbPlaces).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbnom;
        private DateTimePicker dtpdateDeb;
        private DateTimePicker dtpdateFin;
        private DateTimePicker dtpdateLim;
        private NumericUpDown nudnbPlaces;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button bajout;
    }
}

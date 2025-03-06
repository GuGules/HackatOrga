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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
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
            saveBtn = new Button();
            cancelBtn = new Button();
            deleteBtn = new Button();
            label1 = new Label();
            hackathonCbx = new ComboBox();
            hackathonBindingSource = new BindingSource(components);
            groupBox2 = new GroupBox();
            postalCodeTbx = new TextBox();
            streetTbx = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label9 = new Label();
            cityTbx = new TextBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudnbPlaces).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hackathonBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(12, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 343);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informations Générales";
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
            // 
            // nudnbPlaces
            // 
            nudnbPlaces.Location = new Point(41, 294);
            nudnbPlaces.Name = "nudnbPlaces";
            nudnbPlaces.Size = new Size(200, 23);
            nudnbPlaces.TabIndex = 16;
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
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(18, 22);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(233, 24);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "Enregistrer";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(18, 81);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(233, 23);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Annuler";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += bQuitter_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(18, 52);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(233, 23);
            deleteBtn.TabIndex = 4;
            deleteBtn.Text = "Supprimer";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 5;
            label1.Text = "Choix du hackathon : ";
            // 
            // hackathonCbx
            // 
            hackathonCbx.DataSource = hackathonBindingSource;
            hackathonCbx.DisplayMember = "nom";
            hackathonCbx.FormattingEnabled = true;
            hackathonCbx.Location = new Point(12, 27);
            hackathonCbx.Name = "hackathonCbx";
            hackathonCbx.Size = new Size(561, 23);
            hackathonCbx.TabIndex = 6;
            hackathonCbx.SelectedIndexChanged += hackathonCbx_SelectedIndexChanged;
            // 
            // hackathonBindingSource
            // 
            hackathonBindingSource.DataSource = typeof(models.Hackathon);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(postalCodeTbx);
            groupBox2.Controls.Add(streetTbx);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cityTbx);
            groupBox2.Location = new Point(300, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(273, 219);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informations sur le lieu";
            // 
            // postalCodeTbx
            // 
            postalCodeTbx.Location = new Point(41, 178);
            postalCodeTbx.Name = "postalCodeTbx";
            postalCodeTbx.Size = new Size(200, 23);
            postalCodeTbx.TabIndex = 28;
            // 
            // streetTbx
            // 
            streetTbx.Location = new Point(41, 123);
            streetTbx.Name = "streetTbx";
            streetTbx.Size = new Size(200, 23);
            streetTbx.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 32);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 26;
            label2.Text = "Ville";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 91);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 25;
            label4.Text = "Rue";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(41, 155);
            label9.Name = "label9";
            label9.Size = new Size(91, 20);
            label9.TabIndex = 23;
            label9.Text = "Code Postal";
            // 
            // cityTbx
            // 
            cityTbx.Location = new Point(41, 56);
            cityTbx.Name = "cityTbx";
            cityTbx.Size = new Size(200, 23);
            cityTbx.TabIndex = 12;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(saveBtn);
            groupBox3.Controls.Add(deleteBtn);
            groupBox3.Controls.Add(cancelBtn);
            groupBox3.Location = new Point(300, 288);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(273, 118);
            groupBox3.TabIndex = 29;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informations sur le lieu";
            // 
            // modifierHackathon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 414);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(hackathonCbx);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "modifierHackathon";
            Text = "Modifier un hackathon";
            Load += modifierHackathon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudnbPlaces).EndInit();
            ((System.ComponentModel.ISupportInitialize)hackathonBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button saveBtn;
        private Button cancelBtn;
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
        private Button deleteBtn;
        private Label label1;
        private ComboBox hackathonCbx;
        private GroupBox groupBox2;
        private TextBox postalCodeTbx;
        private TextBox streetTbx;
        private Label label2;
        private Label label4;
        private Label label9;
        private TextBox cityTbx;
        private GroupBox groupBox3;
        private BindingSource hackathonBindingSource;
    }
}
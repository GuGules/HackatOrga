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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            bajout = new Button();
            cancelBtn = new Button();
            cityTbx = new TextBox();
            streeTbx = new TextBox();
            postalCodeTbx = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudnbPlaces).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tbnom
            // 
            tbnom.Location = new Point(145, 33);
            tbnom.Name = "tbnom";
            tbnom.Size = new Size(200, 23);
            tbnom.TabIndex = 0;
            // 
            // dtpdateDeb
            // 
            dtpdateDeb.Location = new Point(145, 62);
            dtpdateDeb.Name = "dtpdateDeb";
            dtpdateDeb.Size = new Size(200, 23);
            dtpdateDeb.TabIndex = 1;
            // 
            // dtpdateFin
            // 
            dtpdateFin.Location = new Point(145, 91);
            dtpdateFin.Name = "dtpdateFin";
            dtpdateFin.Size = new Size(200, 23);
            dtpdateFin.TabIndex = 2;
            // 
            // dtpdateLim
            // 
            dtpdateLim.Location = new Point(145, 120);
            dtpdateLim.Name = "dtpdateLim";
            dtpdateLim.Size = new Size(200, 23);
            dtpdateLim.TabIndex = 3;
            // 
            // nudnbPlaces
            // 
            nudnbPlaces.Location = new Point(145, 149);
            nudnbPlaces.Name = "nudnbPlaces";
            nudnbPlaces.Size = new Size(200, 23);
            nudnbPlaces.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 36);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 6;
            label2.Text = "Nom :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 68);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 7;
            label3.Text = "Date de début : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 97);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 8;
            label4.Text = "Date de fin : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 151);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 9;
            label5.Text = "Nombre de places : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 126);
            label6.Name = "label6";
            label6.Size = new Size(139, 15);
            label6.TabIndex = 11;
            label6.Text = "Date limite d'inscription: ";
            // 
            // bajout
            // 
            bajout.Location = new Point(99, 15);
            bajout.Name = "bajout";
            bajout.Size = new Size(75, 23);
            bajout.TabIndex = 12;
            bajout.Text = "Enregistrer";
            bajout.UseVisualStyleBackColor = true;
            bajout.Click += addHackathon;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(207, 15);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 13;
            cancelBtn.Text = "Annuler";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // cityTbx
            // 
            cityTbx.Location = new Point(145, 22);
            cityTbx.Name = "cityTbx";
            cityTbx.Size = new Size(200, 23);
            cityTbx.TabIndex = 14;
            // 
            // streeTbx
            // 
            streeTbx.Location = new Point(145, 51);
            streeTbx.Name = "streeTbx";
            streeTbx.Size = new Size(200, 23);
            streeTbx.TabIndex = 15;
            // 
            // postalCodeTbx
            // 
            postalCodeTbx.Location = new Point(145, 80);
            postalCodeTbx.Name = "postalCodeTbx";
            postalCodeTbx.Size = new Size(200, 23);
            postalCodeTbx.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbnom);
            groupBox1.Controls.Add(dtpdateDeb);
            groupBox1.Controls.Add(dtpdateFin);
            groupBox1.Controls.Add(dtpdateLim);
            groupBox1.Controls.Add(nudnbPlaces);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 207);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informations Générales";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cityTbx);
            groupBox2.Controls.Add(streeTbx);
            groupBox2.Controls.Add(postalCodeTbx);
            groupBox2.Location = new Point(12, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(374, 122);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informations sur le lieu";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(bajout);
            groupBox3.Controls.Add(cancelBtn);
            groupBox3.Location = new Point(12, 353);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(374, 44);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Validation";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 30);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 12;
            label1.Text = "Ville : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(106, 54);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 17;
            label7.Text = "Rue :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(63, 83);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 18;
            label8.Text = "Code Postal :";
            // 
            // ajoutHackathon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 413);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ajoutHackathon";
            Text = "Ajouter un hackathon";
            ((System.ComponentModel.ISupportInitialize)nudnbPlaces).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbnom;
        private DateTimePicker dtpdateDeb;
        private DateTimePicker dtpdateFin;
        private DateTimePicker dtpdateLim;
        private NumericUpDown nudnbPlaces;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button bajout;
        private Button cancelBtn;
        private TextBox cityTbx;
        private TextBox streeTbx;
        private TextBox postalCodeTbx;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private Label label1;
        private GroupBox groupBox3;
    }
}

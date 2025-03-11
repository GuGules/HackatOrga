namespace HackatOrga
{
    partial class addAtelier
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
            durationTp = new DateTimePicker();
            dateDtp = new DateTimePicker();
            roomTbx = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            nameTbx = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            nbPlacesNUD = new NumericUpDown();
            label1 = new Label();
            groupBox3 = new GroupBox();
            hackathonCbx = new ComboBox();
            label6 = new Label();
            groupBox4 = new GroupBox();
            cancelBtn = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbPlacesNUD).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(durationTp);
            groupBox1.Controls.Add(dateDtp);
            groupBox1.Controls.Add(roomTbx);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nameTbx);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 227);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informations sur l'évènement";
            // 
            // durationTp
            // 
            durationTp.CustomFormat = "HH:MM:ss";
            durationTp.Location = new Point(75, 148);
            durationTp.Name = "durationTp";
            durationTp.ShowUpDown = true;
            durationTp.Size = new Size(200, 23);
            durationTp.TabIndex = 13;
            // 
            // dateDtp
            // 
            dateDtp.Location = new Point(75, 74);
            dateDtp.Name = "dateDtp";
            dateDtp.Size = new Size(200, 23);
            dateDtp.TabIndex = 11;
            // 
            // roomTbx
            // 
            roomTbx.Location = new Point(75, 111);
            roomTbx.Name = "roomTbx";
            roomTbx.Size = new Size(200, 23);
            roomTbx.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 153);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 5;
            label5.Text = "Durée : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 114);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 4;
            label4.Text = "Salle :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 77);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 3;
            label3.Text = "Date :";
            // 
            // nameTbx
            // 
            nameTbx.Location = new Point(75, 39);
            nameTbx.Name = "nameTbx";
            nameTbx.Size = new Size(200, 23);
            nameTbx.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 42);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Nom : ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nbPlacesNUD);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(306, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(335, 69);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Information sur l'atelier";
            // 
            // nbPlacesNUD
            // 
            nbPlacesNUD.Location = new Point(135, 33);
            nbPlacesNUD.Name = "nbPlacesNUD";
            nbPlacesNUD.Size = new Size(182, 23);
            nbPlacesNUD.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 35);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre de places : ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(hackathonCbx);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(306, 75);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(335, 67);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hackathon";
            // 
            // hackathonCbx
            // 
            hackathonCbx.FormattingEnabled = true;
            hackathonCbx.Location = new Point(92, 29);
            hackathonCbx.Name = "hackathonCbx";
            hackathonCbx.Size = new Size(235, 23);
            hackathonCbx.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 32);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 2;
            label6.Text = "Hackathon :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cancelBtn);
            groupBox4.Controls.Add(button1);
            groupBox4.Location = new Point(306, 148);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(335, 79);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Actions";
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(15, 51);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(302, 22);
            cancelBtn.TabIndex = 1;
            cancelBtn.Text = "Annuler";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(15, 17);
            button1.Name = "button1";
            button1.Size = new Size(302, 28);
            button1.TabIndex = 0;
            button1.Text = "Enregistrer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addAtelier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 239);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "addAtelier";
            Text = "Nouvel Atelier";
            Load += addAtelier_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbPlacesNUD).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker dateDtp;
        private TextBox roomTbx;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox nameTbx;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private ComboBox hackathonCbx;
        private Label label6;
        private NumericUpDown nbPlacesNUD;
        private GroupBox groupBox4;
        private Button cancelBtn;
        private Button button1;
        private DateTimePicker durationTp;
    }
}
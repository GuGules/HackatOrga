namespace HackatOrga
{
    partial class addConference
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
            groupBox4 = new GroupBox();
            cancelBtn = new Button();
            button1 = new Button();
            groupBox3 = new GroupBox();
            hackathonCbx = new ComboBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            durationTp = new DateTimePicker();
            label7 = new Label();
            intervenantTbx = new TextBox();
            dateDtp = new DateTimePicker();
            roomTbx = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            nameTbx = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            themeTbx = new TextBox();
            label1 = new Label();
            emailTbx = new TextBox();
            label8 = new Label();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cancelBtn);
            groupBox4.Controls.Add(button1);
            groupBox4.Location = new Point(318, 199);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(335, 79);
            groupBox4.TabIndex = 12;
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
            // groupBox3
            // 
            groupBox3.Controls.Add(hackathonCbx);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(318, 89);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(335, 67);
            groupBox3.TabIndex = 11;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(emailTbx);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(durationTp);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(intervenantTbx);
            groupBox1.Controls.Add(dateDtp);
            groupBox1.Controls.Add(roomTbx);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nameTbx);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 266);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informations sur l'évènement";
            // 
            // durationTp
            // 
            durationTp.CustomFormat = "HH:MM:ss";
            durationTp.Location = new Point(75, 223);
            durationTp.Name = "durationTp";
            durationTp.ShowUpDown = true;
            durationTp.Size = new Size(200, 23);
            durationTp.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 228);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 14;
            label7.Text = "Durée : ";
            // 
            // intervenantTbx
            // 
            intervenantTbx.Location = new Point(75, 153);
            intervenantTbx.Name = "intervenantTbx";
            intervenantTbx.Size = new Size(200, 23);
            intervenantTbx.TabIndex = 12;
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
            label5.Location = new Point(0, 156);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 5;
            label5.Text = "Intervenant :";
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
            groupBox2.Controls.Add(themeTbx);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(318, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(335, 69);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informations sur la conférence";
            // 
            // themeTbx
            // 
            themeTbx.Location = new Point(76, 32);
            themeTbx.Name = "themeTbx";
            themeTbx.Size = new Size(200, 23);
            themeTbx.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 35);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Thème : ";
            // 
            // emailTbx
            // 
            emailTbx.Location = new Point(75, 188);
            emailTbx.Name = "emailTbx";
            emailTbx.Size = new Size(200, 23);
            emailTbx.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 191);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 16;
            label8.Text = "Email :";
            // 
            // addConference
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 290);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "addConference";
            Text = "Programmer une conférence";
            Load += addConference_Load;
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private Button cancelBtn;
        private Button button1;
        private GroupBox groupBox3;
        private ComboBox hackathonCbx;
        private Label label6;
        private GroupBox groupBox1;
        private DateTimePicker dateDtp;
        private TextBox roomTbx;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox nameTbx;
        private Label label2;
        private TextBox intervenantTbx;
        private GroupBox groupBox2;
        private TextBox themeTbx;
        private Label label1;
        private DateTimePicker durationTp;
        private Label label7;
        private TextBox emailTbx;
        private Label label8;
    }
}
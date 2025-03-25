namespace HackatOrga
{
    partial class sendEmail
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
            label1 = new Label();
            confCbx = new ComboBox();
            sendEmailBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Conférence :";
            // 
            // confCbx
            // 
            confCbx.FormattingEnabled = true;
            confCbx.Location = new Point(99, 20);
            confCbx.Name = "confCbx";
            confCbx.Size = new Size(260, 23);
            confCbx.TabIndex = 1;
            // 
            // sendEmailBtn
            // 
            sendEmailBtn.Location = new Point(115, 58);
            sendEmailBtn.Name = "sendEmailBtn";
            sendEmailBtn.Size = new Size(151, 23);
            sendEmailBtn.TabIndex = 2;
            sendEmailBtn.Text = "Envoyer le rappel";
            sendEmailBtn.UseVisualStyleBackColor = true;
            sendEmailBtn.Click += sendEmailBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(115, 87);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(151, 23);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Annuler";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // sendEmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 128);
            Controls.Add(cancelBtn);
            Controls.Add(sendEmailBtn);
            Controls.Add(confCbx);
            Controls.Add(label1);
            Name = "sendEmail";
            Text = "Envoyer un rappel";
            Load += sendEmail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox confCbx;
        private Button sendEmailBtn;
        private Button cancelBtn;
    }
}
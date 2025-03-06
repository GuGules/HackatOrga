namespace HackatOrga
{
    partial class listeConference
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
            confDGV = new DataGridView();
            closeBtn = new Button();
            newConfBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)confDGV).BeginInit();
            SuspendLayout();
            // 
            // confDGV
            // 
            confDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            confDGV.Location = new Point(12, 12);
            confDGV.Name = "confDGV";
            confDGV.Size = new Size(565, 456);
            confDGV.TabIndex = 0;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(583, 12);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(185, 23);
            closeBtn.TabIndex = 1;
            closeBtn.Text = "Fermer la liste";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // newConfBtn
            // 
            newConfBtn.Location = new Point(583, 41);
            newConfBtn.Name = "newConfBtn";
            newConfBtn.Size = new Size(185, 23);
            newConfBtn.TabIndex = 2;
            newConfBtn.Text = "Programmer une conférence";
            newConfBtn.UseVisualStyleBackColor = true;
            newConfBtn.Click += newConfBtn_Click;
            // 
            // listeConference
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 480);
            Controls.Add(newConfBtn);
            Controls.Add(closeBtn);
            Controls.Add(confDGV);
            Name = "listeConference";
            Text = "listeConference";
            Load += listeConference_Load;
            ((System.ComponentModel.ISupportInitialize)confDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView confDGV;
        private Button closeBtn;
        private Button newConfBtn;
    }
}
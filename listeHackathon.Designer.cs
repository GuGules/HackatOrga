namespace HackatOrga
{
    partial class listeHackathon
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
            hackathonList = new DataGridView();
            closeListBtn = new Button();
            addHackathonBtn = new Button();
            printPDFBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)hackathonList).BeginInit();
            SuspendLayout();
            // 
            // hackathonList
            // 
            hackathonList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hackathonList.Location = new Point(12, 12);
            hackathonList.Name = "hackathonList";
            hackathonList.Size = new Size(627, 426);
            hackathonList.TabIndex = 0;
            // 
            // closeListBtn
            // 
            closeListBtn.Location = new Point(645, 12);
            closeListBtn.Name = "closeListBtn";
            closeListBtn.Size = new Size(150, 23);
            closeListBtn.TabIndex = 1;
            closeListBtn.Text = "Fermer la liste";
            closeListBtn.UseVisualStyleBackColor = true;
            closeListBtn.Click += closeListBtn_Click;
            // 
            // addHackathonBtn
            // 
            addHackathonBtn.Location = new Point(645, 41);
            addHackathonBtn.Name = "addHackathonBtn";
            addHackathonBtn.Size = new Size(150, 23);
            addHackathonBtn.TabIndex = 2;
            addHackathonBtn.Text = "Ajouter un Hackathon";
            addHackathonBtn.UseVisualStyleBackColor = true;
            addHackathonBtn.Click += addHackathonBtn_Click;
            // 
            // printPDFBtn
            // 
            printPDFBtn.Location = new Point(645, 70);
            printPDFBtn.Name = "printPDFBtn";
            printPDFBtn.Size = new Size(150, 23);
            printPDFBtn.TabIndex = 3;
            printPDFBtn.Text = "Imprimer les participants";
            printPDFBtn.UseVisualStyleBackColor = true;
            printPDFBtn.Click += printPDFBtn_Click;
            // 
            // listeHackathon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(printPDFBtn);
            Controls.Add(addHackathonBtn);
            Controls.Add(closeListBtn);
            Controls.Add(hackathonList);
            Name = "listeHackathon";
            Text = "Liste des hackathons";
            Load += listeHackathon_Load;
            ((System.ComponentModel.ISupportInitialize)hackathonList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView hackathonList;
        private Button closeListBtn;
        private Button addHackathonBtn;
        private Button printPDFBtn;
    }
}
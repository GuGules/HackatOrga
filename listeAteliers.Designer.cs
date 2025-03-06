namespace HackatOrga
{
    partial class listeAteliers
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
            listeDGV = new DataGridView();
            closeBtn = new Button();
            newAtBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)listeDGV).BeginInit();
            SuspendLayout();
            // 
            // listeDGV
            // 
            listeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listeDGV.Location = new Point(12, 12);
            listeDGV.Name = "listeDGV";
            listeDGV.Size = new Size(559, 426);
            listeDGV.TabIndex = 0;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(577, 12);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(211, 23);
            closeBtn.TabIndex = 1;
            closeBtn.Text = "Fermer la liste";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // newAtBtn
            // 
            newAtBtn.Location = new Point(577, 41);
            newAtBtn.Name = "newAtBtn";
            newAtBtn.Size = new Size(211, 23);
            newAtBtn.TabIndex = 2;
            newAtBtn.Text = "Nouvel Atelier";
            newAtBtn.UseVisualStyleBackColor = true;
            newAtBtn.Click += newAtBtn_Click;
            // 
            // listeAteliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(newAtBtn);
            Controls.Add(closeBtn);
            Controls.Add(listeDGV);
            Name = "listeAteliers";
            Text = "Liste des ateliers";
            Load += listeAteliers_Load;
            ((System.ComponentModel.ISupportInitialize)listeDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView listeDGV;
        private Button closeBtn;
        private Button newAtBtn;
    }
}
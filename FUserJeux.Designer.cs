namespace BibliothèqueDeJeux
{
    partial class FUserJeux
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
            dataGridView1 = new DataGridView();
            txtRecherche = new TextBox();
            listTrie = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(359, 19);
            label1.Name = "label1";
            label1.Size = new Size(144, 31);
            label1.TabIndex = 0;
            label1.Text = "Bibliothèque";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(851, 485);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtRecherche
            // 
            txtRecherche.Location = new Point(869, 73);
            txtRecherche.Name = "txtRecherche";
            txtRecherche.PlaceholderText = "Rechercher";
            txtRecherche.Size = new Size(288, 27);
            txtRecherche.TabIndex = 2;
            // 
            // listTrie
            // 
            listTrie.DropDownStyle = ComboBoxStyle.DropDownList;
            listTrie.IntegralHeight = false;
            listTrie.Items.AddRange(new object[] { "Nom", "Nombre de joueurs", "Nombre de cartes", "Editeur", "Tous" });
            listTrie.Location = new Point(869, 148);
            listTrie.Name = "listTrie";
            listTrie.Size = new Size(288, 28);
            listTrie.TabIndex = 3;
            listTrie.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(869, 120);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 4;
            label2.Text = "Trier par :";
            label2.Click += label2_Click;
            // 
            // FUserJeux
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 570);
            Controls.Add(label2);
            Controls.Add(listTrie);
            Controls.Add(txtRecherche);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "FUserJeux";
            Text = "x";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtRecherche;
        private ComboBox listTrie;
        private Label label2;
    }
}
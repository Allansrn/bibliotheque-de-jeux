namespace BibliothèqueDeJeux
{
    partial class FAdminJeux
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
            label2 = new Label();
            listTrie = new ComboBox();
            label3 = new Label();
            numJeux = new NumericUpDown();
            btnSuppr = new Button();
            label4 = new Label();
            panelSuppr = new Panel();
            btnAjoutJeux = new Button();
            btnModifierJeux = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJeux).BeginInit();
            panelSuppr.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(305, 30);
            label1.Name = "label1";
            label1.Size = new Size(144, 31);
            label1.TabIndex = 0;
            label1.Text = "Bibliothèque";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(791, 461);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtRecherche
            // 
            txtRecherche.Location = new Point(809, 86);
            txtRecherche.Name = "txtRecherche";
            txtRecherche.PlaceholderText = "Rechercher";
            txtRecherche.Size = new Size(355, 27);
            txtRecherche.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(809, 129);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 6;
            label2.Text = "Trier par :";
            // 
            // listTrie
            // 
            listTrie.DropDownStyle = ComboBoxStyle.DropDownList;
            listTrie.FormattingEnabled = true;
            listTrie.Items.AddRange(new object[] { "Nom", "Nombre de joueurs", "Nombre de cartes", "Editeur", "Tous" });
            listTrie.Location = new Point(809, 157);
            listTrie.Name = "listTrie";
            listTrie.Size = new Size(355, 28);
            listTrie.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(105, 13);
            label3.Name = "label3";
            label3.Size = new Size(156, 25);
            label3.TabIndex = 9;
            label3.Text = "Supprimer un jeux";
            // 
            // numJeux
            // 
            numJeux.Location = new Point(105, 80);
            numJeux.Name = "numJeux";
            numJeux.Size = new Size(150, 27);
            numJeux.TabIndex = 10;
            // 
            // btnSuppr
            // 
            btnSuppr.BackColor = Color.White;
            btnSuppr.Location = new Point(128, 128);
            btnSuppr.Name = "btnSuppr";
            btnSuppr.Size = new Size(94, 29);
            btnSuppr.TabIndex = 11;
            btnSuppr.Text = "Supprimer";
            btnSuppr.UseVisualStyleBackColor = false;
            btnSuppr.Click += btnSuppr_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 57);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 12;
            label4.Text = "ID du jeux";
            // 
            // panelSuppr
            // 
            panelSuppr.BorderStyle = BorderStyle.FixedSingle;
            panelSuppr.Controls.Add(label4);
            panelSuppr.Controls.Add(btnSuppr);
            panelSuppr.Controls.Add(numJeux);
            panelSuppr.Controls.Add(label3);
            panelSuppr.Location = new Point(808, 380);
            panelSuppr.Name = "panelSuppr";
            panelSuppr.Size = new Size(356, 168);
            panelSuppr.TabIndex = 13;
            // 
            // btnAjoutJeux
            // 
            btnAjoutJeux.Location = new Point(809, 208);
            btnAjoutJeux.Name = "btnAjoutJeux";
            btnAjoutJeux.Size = new Size(355, 29);
            btnAjoutJeux.TabIndex = 14;
            btnAjoutJeux.Text = "Ajouter un jeux";
            btnAjoutJeux.UseVisualStyleBackColor = true;
            btnAjoutJeux.Click += btnAjoutJeux_Click;
            // 
            // btnModifierJeux
            // 
            btnModifierJeux.Location = new Point(808, 243);
            btnModifierJeux.Name = "btnModifierJeux";
            btnModifierJeux.Size = new Size(355, 29);
            btnModifierJeux.TabIndex = 15;
            btnModifierJeux.Text = "Modifier un jeux";
            btnModifierJeux.UseVisualStyleBackColor = true;
            btnModifierJeux.Click += btnModifierJeux_Click;
            // 
            // FAdminJeux
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 559);
            Controls.Add(btnModifierJeux);
            Controls.Add(btnAjoutJeux);
            Controls.Add(panelSuppr);
            Controls.Add(label2);
            Controls.Add(listTrie);
            Controls.Add(txtRecherche);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "FAdminJeux";
            Text = "FAdminJeux";
            Load += FAdminJeux_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJeux).EndInit();
            panelSuppr.ResumeLayout(false);
            panelSuppr.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtRecherche;
        private Label label2;
        private ComboBox listTrie;
        private Label label3;
        private NumericUpDown numJeux;
        private Button btnSuppr;
        private Label label4;
        private Panel panelSuppr;
        private Button btnAjoutJeux;
        private Button btnModifierJeux;
    }
}
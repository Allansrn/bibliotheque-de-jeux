namespace BibliothèqueDeJeux
{
    partial class FAjoutJeux
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
            txtNom = new TextBox();
            txtEditeur = new TextBox();
            numJoueurs = new TextBox();
            txtType = new TextBox();
            numCartes = new NumericUpDown();
            txtDescription = new RichTextBox();
            label1 = new Label();
            btnAjouter = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numCartes).BeginInit();
            SuspendLayout();
            // 
            // txtNom
            // 
            txtNom.Location = new Point(248, 78);
            txtNom.Name = "txtNom";
            txtNom.PlaceholderText = "nom";
            txtNom.Size = new Size(221, 27);
            txtNom.TabIndex = 0;
            // 
            // txtEditeur
            // 
            txtEditeur.Location = new Point(248, 304);
            txtEditeur.Name = "txtEditeur";
            txtEditeur.PlaceholderText = "editeur";
            txtEditeur.Size = new Size(169, 27);
            txtEditeur.TabIndex = 2;
            // 
            // numJoueurs
            // 
            numJoueurs.Location = new Point(248, 203);
            numJoueurs.Name = "numJoueurs";
            numJoueurs.PlaceholderText = "nombre de joueurs";
            numJoueurs.Size = new Size(169, 27);
            numJoueurs.TabIndex = 3;
            // 
            // txtType
            // 
            txtType.Location = new Point(248, 250);
            txtType.Name = "txtType";
            txtType.PlaceholderText = "type";
            txtType.Size = new Size(169, 27);
            txtType.TabIndex = 4;
            // 
            // numCartes
            // 
            numCartes.Location = new Point(423, 251);
            numCartes.Name = "numCartes";
            numCartes.Size = new Size(128, 27);
            numCartes.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(248, 133);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(306, 54);
            txtDescription.TabIndex = 6;
            txtDescription.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(334, 21);
            label1.Name = "label1";
            label1.Size = new Size(169, 31);
            label1.TabIndex = 7;
            label1.Text = "Ajouter un jeux";
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(365, 360);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(94, 29);
            btnAjouter.TabIndex = 8;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += Ajouter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(423, 228);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 9;
            label2.Text = "Nombre de cartes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 110);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 10;
            label3.Text = "Description";
            label3.Click += label3_Click;
            // 
            // FAjoutJeux
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAjouter);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(numCartes);
            Controls.Add(txtType);
            Controls.Add(numJoueurs);
            Controls.Add(txtEditeur);
            Controls.Add(txtNom);
            Name = "FAjoutJeux";
            Text = "FAjoutJeux";
            Load += FAjoutJeux_Load;
            ((System.ComponentModel.ISupportInitialize)numCartes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNom;
        private TextBox txtEditeur;
        private TextBox numJoueurs;
        private TextBox txtType;
        private NumericUpDown numCartes;
        private RichTextBox txtDescription;
        private Label label1;
        private Button btnAjouter;
        private Label label2;
        private Label label3;
    }
}
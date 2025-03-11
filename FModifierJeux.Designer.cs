namespace BibliothèqueDeJeux
{
    partial class FModifierJeux
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
            label4 = new Label();
            numJeux = new NumericUpDown();
            txtNom = new TextBox();
            txtDescription = new TextBox();
            txtNbJoueurs = new TextBox();
            txtTypes = new TextBox();
            txtEditeur = new TextBox();
            txtType = new Panel();
            nbCartes = new NumericUpDown();
            btnModifierJeux = new Button();
            ((System.ComponentModel.ISupportInitialize)numJeux).BeginInit();
            txtType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbCartes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(432, 37);
            label1.Name = "label1";
            label1.Size = new Size(101, 31);
            label1.TabIndex = 0;
            label1.Text = "Modifier";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(404, 89);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 14;
            label4.Text = "Sélectionner l'id du jeux";
            label4.Click += label4_Click;
            // 
            // numJeux
            // 
            numJeux.Location = new Point(404, 112);
            numJeux.Name = "numJeux";
            numJeux.Size = new Size(165, 27);
            numJeux.TabIndex = 13;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(130, 28);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(198, 27);
            txtNom.TabIndex = 15;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(11, 81);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(431, 85);
            txtDescription.TabIndex = 16;
            // 
            // txtNbJoueurs
            // 
            txtNbJoueurs.Location = new Point(11, 172);
            txtNbJoueurs.Name = "txtNbJoueurs";
            txtNbJoueurs.Size = new Size(198, 27);
            txtNbJoueurs.TabIndex = 17;
            // 
            // txtTypes
            // 
            txtTypes.Location = new Point(11, 219);
            txtTypes.Name = "txtTypes";
            txtTypes.Size = new Size(198, 27);
            txtTypes.TabIndex = 18;
            // 
            // txtEditeur
            // 
            txtEditeur.Location = new Point(244, 219);
            txtEditeur.Name = "txtEditeur";
            txtEditeur.Size = new Size(198, 27);
            txtEditeur.TabIndex = 20;
            // 
            // txtType
            // 
            txtType.Controls.Add(nbCartes);
            txtType.Controls.Add(btnModifierJeux);
            txtType.Controls.Add(txtEditeur);
            txtType.Controls.Add(txtTypes);
            txtType.Controls.Add(txtNbJoueurs);
            txtType.Controls.Add(txtDescription);
            txtType.Controls.Add(txtNom);
            txtType.Location = new Point(256, 145);
            txtType.Name = "txtType";
            txtType.Size = new Size(457, 309);
            txtType.TabIndex = 21;
            // 
            // nbCartes
            // 
            nbCartes.Location = new Point(244, 173);
            nbCartes.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nbCartes.Name = "nbCartes";
            nbCartes.Size = new Size(198, 27);
            nbCartes.TabIndex = 22;
            // 
            // btnModifierJeux
            // 
            btnModifierJeux.Location = new Point(162, 268);
            btnModifierJeux.Name = "btnModifierJeux";
            btnModifierJeux.Size = new Size(130, 29);
            btnModifierJeux.TabIndex = 21;
            btnModifierJeux.Text = "Modifier";
            btnModifierJeux.UseVisualStyleBackColor = true;
            btnModifierJeux.Click += btnModifierJeux_Click;
            // 
            // FModifierJeux
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 515);
            Controls.Add(txtType);
            Controls.Add(label4);
            Controls.Add(numJeux);
            Controls.Add(label1);
            Name = "FModifierJeux";
            Text = "FModifierJeux";
            ((System.ComponentModel.ISupportInitialize)numJeux).EndInit();
            txtType.ResumeLayout(false);
            txtType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbCartes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private NumericUpDown numJeux;
        private TextBox txtNom;
        private TextBox txtDescription;
        private TextBox txtNbJoueurs;
        private TextBox txtTypes;
        private TextBox txtEditeur;
        private TextBox numCartes;
        private Panel txtType;
        private Button btnModifierJeux;
        private NumericUpDown nbCartes;
    }
}
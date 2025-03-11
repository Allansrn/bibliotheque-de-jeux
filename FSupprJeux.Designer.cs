namespace BibliothèqueDeJeux
{
    partial class FSupprJeux
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
            label2 = new Label();
            idJeux = new NumericUpDown();
            btnSuppr = new Button();
            ((System.ComponentModel.ISupportInitialize)idJeux).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 39);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 0;
            label1.Text = "Suppr";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 113);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(136, 20);
            label2.TabIndex = 1;
            label2.Text = "Veuillez entrer l'ID :";
            // 
            // idJeux
            // 
            idJeux.Location = new Point(312, 136);
            idJeux.Name = "idJeux";
            idJeux.Size = new Size(150, 27);
            idJeux.TabIndex = 2;
            // 
            // btnSuppr
            // 
            btnSuppr.Location = new Point(505, 134);
            btnSuppr.Name = "btnSuppr";
            btnSuppr.Size = new Size(94, 29);
            btnSuppr.TabIndex = 3;
            btnSuppr.Text = "Supprimer";
            btnSuppr.UseVisualStyleBackColor = true;
            btnSuppr.Click += btnSuppr_Click;
            // 
            // FSupprJeux
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSuppr);
            Controls.Add(idJeux);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FSupprJeux";
            Text = "FSupprJeux";
            Load += FSupprJeux_Load;
            ((System.ComponentModel.ISupportInitialize)idJeux).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown idJeux;
        private Button btnSuppr;
    }
}
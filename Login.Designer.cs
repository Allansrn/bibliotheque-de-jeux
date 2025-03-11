namespace BibliothèqueDeJeux
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            username = new TextBox();
            Valider = new Button();
            password = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(39, 65);
            username.Name = "username";
            username.RightToLeft = RightToLeft.No;
            username.Size = new Size(179, 27);
            username.TabIndex = 0;
            // 
            // Valider
            // 
            Valider.Location = new Point(75, 191);
            Valider.Name = "Valider";
            Valider.Size = new Size(94, 29);
            Valider.TabIndex = 1;
            Valider.Text = "Connecter";
            Valider.UseVisualStyleBackColor = true;
            Valider.Click += button1_Click;
            // 
            // password
            // 
            password.Location = new Point(39, 126);
            password.Name = "password";
            password.Size = new Size(179, 27);
            password.TabIndex = 2;
            password.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Valider);
            panel1.Controls.Add(password);
            panel1.Controls.Add(username);
            panel1.Location = new Point(112, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 259);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 103);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 42);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(177, 78);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 4;
            label3.Text = "Connexion";
            label3.Click += label3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 450);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Se connecter";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private Button Valider;
        private TextBox password;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}

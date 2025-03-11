using MySql.Data.MySqlClient;
using BCrypt.Net;
using System.Drawing;

namespace BibliothèqueDeJeux
{
    public partial class Login : Form
    {
        private string connectionString = "server=localhost;database=bibliotheque_jeux;uid=root;pwd=;";

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT password FROM users WHERE username = @username";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username.Text);


                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        //MessageBox.Show("Résultat non null");
                        string storedHashedPassword = result.ToString();
                        //MessageBox.Show(storedHashedPassword);


                        // Vérifier si le mot de passe saisi correspond au hash stocké
                        if (BCrypt.Net.BCrypt.Verify(password.Text, storedHashedPassword))
                        {
                            string queryRole = "SELECT role FROM users WHERE username = @username";
                            MySqlCommand command = new MySqlCommand(queryRole, conn);
                            command.Parameters.AddWithValue("@username", username.Text);

                            object resultat = command.ExecuteScalar();

                            if(resultat != null)
                            {
                                string role = resultat.ToString();
                                //MessageBox.Show(role);
                                if(role == "admin")
                                {
                                    //MessageBox.Show("Connexion réussie !");
                                    FAdminJeux fAdminJeux = new FAdminJeux();
                                    fAdminJeux.Show();
                                }
                                if (role == "user")
                                {
                                    //MessageBox.Show("Connexion réussie !");
                                    FUserJeux fUserJeux = new FUserJeux();
                                    fUserJeux.Show();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Utilisateur ou mot de passe incorrect.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Utilisateur ou mot de passe incorrect.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

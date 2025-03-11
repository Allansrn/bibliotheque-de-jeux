using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliothèqueDeJeux
{
    public partial class FModifierJeux : Form
    {
        string connectionString = "Server=localhost;Database=bibliotheque_jeux;User Id=root;Password=;";

        public FModifierJeux()
        {
            InitializeComponent();
            numJeux.ValueChanged += NumJeux_ValueChanged;
        }

        private void NumJeux_ValueChanged(object sender, EventArgs e)
        {
            int jeuId = (int)numJeux.Value; // Récupère l'ID entré

            if (jeuId <= 0) // Vérification pour éviter les IDs invalides
            {
                //ClearFields(); // Fonction pour vider les champs
                return;
            }

            // Connexion à la base de données et récupération des infos
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM jeux_de_societe WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", jeuId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Si un jeu avec cet ID est trouvé
                        {
                            txtNom.Text = reader["nom"] != DBNull.Value ? reader["nom"].ToString() : "";
                            txtDescription.Text = reader["description"] != DBNull.Value ? reader["description"].ToString() : "";
                            txtNbJoueurs.Text = reader["nombre_joueurs"] != DBNull.Value ? reader["nombre_joueurs"].ToString() : "";
                            txtTypes.Text = reader["type"] != DBNull.Value ? reader["type"].ToString() : "";
                            txtEditeur.Text = reader["editeur"] != DBNull.Value ? reader["editeur"].ToString() : "";
                            nbCartes.Value = reader["nombre_cartes"] != DBNull.Value ? Convert.ToInt32(reader["nombre_cartes"]) : 0;
                        }
                        else
                        {
                            MessageBox.Show("Aucun jeu trouvé avec cet ID.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ClearFields(); // Vide les champs si l'ID n'existe pas
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération des données : " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            txtNom.Text = "";
            txtDescription.Text = "";
            txtNbJoueurs.Text = "";
            txtTypes.Text = "";
            txtEditeur.Text = "";
            nbCartes.Value = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private bool ModifierJeu()
        {
            int jeuId = (int)numJeux.Value; // Récupère l'ID entré
            string nom = txtNom.Text;
            string description = txtDescription.Text;
            string nbJoueurs = txtNbJoueurs.Text;
            string types = txtTypes.Text;
            string editeur = txtEditeur.Text;
            int nbCartes = 52; // Valeur par défaut

            if (jeuId <= 0) // Vérification pour éviter les IDs invalides
            {
                MessageBox.Show("Sélectionnez un ID de jeu valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string updateQuery = "UPDATE jeux_de_societe SET nom = @nom, description = @description, nombre_joueurs = @nombreJoueurs, " +
                                 "nombre_cartes = @nombreCartes, type = @type, editeur = @editeur WHERE id = @id";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", jeuId);
                        cmd.Parameters.AddWithValue("@nom", nom);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@nombreJoueurs", nbJoueurs);
                        cmd.Parameters.AddWithValue("@nombreCartes", nbCartes);
                        cmd.Parameters.AddWithValue("@type", types);
                        cmd.Parameters.AddWithValue("@editeur", editeur);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Jeu modifié avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("La modification a échoué. Vérifiez que l'ID existe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Événement du bouton Modifier
        private void btnModifierJeux_Click(object sender, EventArgs e)
        {
            if (ModifierJeu()) // Si la modification est réussie
            {
                this.Close(); // Fermer la fenêtre actuelle
                FAdminJeux fadminJeux = new FAdminJeux();
                fadminJeux.Show();
            }
        }

    }
}

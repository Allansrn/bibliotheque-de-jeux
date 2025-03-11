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
    public partial class FAjoutJeux : Form
    {
        string connectionString = "Server=localhost;Database=bibliotheque_jeux;User Id=root;Password=;";

        public FAjoutJeux()
        {
            InitializeComponent();
        }

        private void FAjoutJeux_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs des champs
            string nom = txtNom.Text;
            string description = txtDescription.Text;
            string nombreJoueurs = numJoueurs.Text;
            int nombreCartes = (int)numCartes.Value;
            string type = txtType.Text;
            string editeur = txtEditeur.Text;

            // Vérifier que tous les champs obligatoires sont remplis
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(type) || string.IsNullOrWhiteSpace(editeur))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
                return;
            }

            // Requête SQL pour insérer les données
            string query = "INSERT INTO jeux_de_societe (nom, description, nombre_joueurs, nombre_cartes, type, editeur) " +
                           "VALUES (@nom, @description, @nombreJoueurs, @nombreCartes, @type, @editeur)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Assigner les valeurs aux paramètres
                        cmd.Parameters.AddWithValue("@nom", nom);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@nombreJoueurs", nombreJoueurs);
                        cmd.Parameters.AddWithValue("@nombreCartes", nombreCartes);
                        cmd.Parameters.AddWithValue("@type", type);
                        cmd.Parameters.AddWithValue("@editeur", editeur);

                        // Exécuter la commande
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Jeu ajouté avec succès !");
                            FAdminJeux fAdminJeux = new FAdminJeux();
                            fAdminJeux.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("L'ajout a échoué.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
    
    }
}

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
    public partial class FSupprJeux : Form
    {
        string connectionString = "Server=localhost;Database=bibliotheque_jeux;User Id=root;Password=;";

        public FSupprJeux()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FSupprJeux_Load(object sender, EventArgs e)
        {

        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            int idJeux = 32;

            if (idJeux == 0)
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
                return;
            }

            //Suppression imédiate ou confirmation
            // Requête SQL pour supprimer
            string query = "DELETE FROM jeux_de_societe WHERE id = @id";
                           

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Assigner les valeurs aux paramètres
                        cmd.Parameters.AddWithValue("@id", idJeux);


                        // Exécuter la commande
                        cmd.ExecuteNonQuery();
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

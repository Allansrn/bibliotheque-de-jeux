using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BibliothèqueDeJeux //test
{
    public partial class FUserJeux : Form
    {
        string connectionString = "Server=localhost;Database=bibliotheque_jeux;User Id=root;Password=;";
        public FUserJeux()
        {
            InitializeComponent();
            LoadData();
            txtRecherche.TextChanged += txtRecherche_TextChanged;
            listTrie.SelectedIndexChanged += ListTrie_SelectedIndexChanged;


        }

        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT nom, description, nombre_joueurs, nombre_cartes, type, editeur FROM jeux_de_societe";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    dataGridView1.DataSource = data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            //Fonction de recherche 
            // Ne pas effectuer de recherche si le texte est le placeholder
            //textBox1.Text == "Rechercher un jeu..." || 
            if (string.IsNullOrWhiteSpace(txtRecherche.Text))
            {
                LoadData(); // Recharger toutes les données
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT nom, description, nombre_joueurs, nombre_cartes, type, editeur FROM jeux_de_societe WHERE nom LIKE @searchTerm";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" + txtRecherche.Text + "%");
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    dataGridView1.DataSource = data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void ListTrie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTrie.SelectedItem == null)
                return;

            string selectedValue = listTrie.SelectedItem.ToString(); // Récupère l'élément sélectionné
            string query = "SELECT * FROM jeux_de_societe"; // Requête par défaut

            if (listTrie.Items.Contains(selectedValue)) // Vérifie si l'élément existe bien dans la collection
            {
                switch (selectedValue)
                {
                    case "Tous":
                        query = "SELECT * FROM jeux_de_societe ORDER BY id";
                        break;
                    case "Nom":
                        query = "SELECT nom, description, nombre_joueurs, nombre_cartes, type, editeur FROM jeux_de_societe ORDER BY nom";
                        break;
                    case "Nombre de joueurs":
                        query = "SELECT nom, description, nombre_joueurs, nombre_cartes, type, editeur FROM jeux_de_societe ORDER BY nombre_joueurs";
                        break;
                    case "Nombre de cartes":
                        query = "SELECT nom, description, nombre_joueurs, nombre_cartes, type, editeur FROM jeux_de_societe ORDER BY nombre_cartes";
                        break;
                    case "Editeur":
                        query = "SELECT nom, description, nombre_joueurs, nombre_cartes, type, editeur FROM jeux_de_societe ORDER BY editeur";
                        break;
                }
            }

            // Exécuter la requête SQL et mettre à jour l'affichage
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt; // Mise à jour de l'affichage
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du tri des données : " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FUserJeux_Load(object sender, EventArgs e)
        {

        }
    }
}

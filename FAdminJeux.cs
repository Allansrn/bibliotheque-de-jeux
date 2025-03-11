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
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace BibliothèqueDeJeux
{
    public partial class FAdminJeux : Form
    {
        string connectionString = "Server=localhost;Database=bibliotheque_jeux;User Id=root;Password=;";


        public FAdminJeux()
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
                    string query = "SELECT * FROM jeux_de_societe ORDER BY id";
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
                    string query = "SELECT * FROM jeux_de_societe WHERE nom LIKE @searchTerm";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAjoutJeux_Click(object sender, EventArgs e)
        {
            //Ouverture de la fenêtre d'ajout de jeux
            FAjoutJeux fAjoutJeux = new FAjoutJeux();
            fAjoutJeux.Show();
            this.Close();

        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            //Fonction de supression
            int idJeux = (int)numJeux.Value;
            string numId = idJeux.ToString();
            //MessageBox.Show(numId);

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

                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
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
                        query = "SELECT * FROM jeux_de_societe ORDER BY nom";
                        break;
                    case "Nombre de joueurs":
                        query = "SELECT * FROM jeux_de_societe ORDER BY nombre_joueurs";
                        break;
                    case "Nombre de cartes":
                        query = "SELECT * FROM jeux_de_societe ORDER BY nombre_cartes";
                        break;
                    case "Editeur":
                        query = "SELECT * FROM jeux_de_societe ORDER BY editeur";
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

        private void FAdminJeux_Load(object sender, EventArgs e)
        {

        }

        private void btnModifierJeux_Click(object sender, EventArgs e)
        {
            FModifierJeux fModifierJeux = new FModifierJeux();
            fModifierJeux.Show();
            this.Close();

        }
    }
}

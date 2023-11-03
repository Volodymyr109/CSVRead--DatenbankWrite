using MySqlConnector;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManagement
{
    public partial class formMain : Form
    {
        private DataTable dbDataTable = new DataTable();

        public formMain()
        {
            InitializeComponent();
        }
        //MEINE CONN DATEN!!!
        //_connection = new NpgsqlConnection("Server=;Port=;Database=;User Id=;Password=;");

        private void RetriveDataKunden_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = GetConnectionString();

                using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
                {
                    con.Open();

                    string queryKunde = "SELECT * FROM kunde;";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(queryKunde, con))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable table = new DataTable();
                            table.Load(reader);
                            dataGridViewKunde.DataSource = table;
                            //con.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Verbinden zur Datenbank: " + ex.Message);
            }
        }

        private void RetriveDataArtikel_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = GetConnectionString();

                using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
                {
                    con.Open();

                    string queryKunde = "SELECT * FROM artikel;";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(queryKunde, con))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable table = new DataTable();
                            table.Load(reader);
                            dataGridViewArtikel.DataSource = table;
                            //con.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Verbinden zur Datenbank: " + ex.Message);
            }
        }

        private void RetriveDataRechnung_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = GetConnectionString();

                using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
                {
                    con.Open();

                    string queryKunde = "SELECT * FROM rechnung;";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(queryKunde, con))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable table = new DataTable();
                            table.Load(reader);
                            dataGridViewRechnung.DataSource = table;
                            //con.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Verbinden zur Datenbank: " + ex.Message);
            }
        }

        private string GetConnectionString()
        {
            string server = "";
            string port = "";
            string database = "";
            string user = "";
            string passwort = "";

            string connectionString = $"Host={server};Port={port};Database={database};Username={user};Password={passwort}";

            return connectionString;
        }

        private void dataGridViewArtikeln_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                string searchString = textBox1.Text.Trim(); 

                if (!string.IsNullOrEmpty(searchString))
                {
                    
                    string query = "SELECT * FROM kunde WHERE name LIKE @searchName;";

                    try
                    {
                        string connectionString = GetConnectionString();

                        using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
                        {
                            con.Open();

                            using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@searchName", "%" + searchString + "%"); 
                                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                                {
                                    DataTable table = new DataTable();
                                    table.Load(reader);
                                    dataGridViewKunde.DataSource = table;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fehler beim Verbinden zur Datenbank: " + ex.Message);
                    }
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchString = textBox2.Text.Trim();

                if (!string.IsNullOrEmpty(searchString))
                {

                    string query = "SELECT * FROM artikel WHERE name LIKE @searchName;";

                    try
                    {
                        string connectionString = GetConnectionString();

                        using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
                        {
                            con.Open();

                            using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@searchName", "%" + searchString + "%");
                                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                                {
                                    DataTable table = new DataTable();
                                    table.Load(reader);
                                    dataGridViewArtikel.DataSource = table;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fehler beim Verbinden zur Datenbank: " + ex.Message);
                    }
                }
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(textBox3.Text, out int searchArtikelid))
                {
                    string query = "SELECT * FROM rechnung WHERE rechnungid = @searchRechnungid;";

                    try
                    {
                        string connectionString = GetConnectionString();

                        using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
                        {
                            con.Open();

                            using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@searchRechnungid", searchArtikelid);
                                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                                {
                                    DataTable table = new DataTable();
                                    table.Load(reader);
                                    dataGridViewRechnung.DataSource = table;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fehler beim Verbinden zur Datenbank: " + ex.Message);
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

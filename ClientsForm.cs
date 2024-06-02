using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace course
{
    public partial class ClientsForm : Form
    {
        private MySqlConnection conn;

        public ClientsForm(MySqlConnection connection)
        {
            InitializeComponent();
            conn = connection;
            LoadClients();
        }

        private void LoadClients()
        {
            string query = "SELECT Ім_я, Прізвище, Електронна_пошта FROM Clients";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewClients.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження клієнтів: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

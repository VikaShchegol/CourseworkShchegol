using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace course
{
    public partial class ScheduleForm : Form
    {
        private MySqlConnection conn;

        public ScheduleForm(MySqlConnection connection)
        {
            InitializeComponent();
            conn = connection;
        }
        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Введіть електронну пошту")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "Введіть електронну пошту";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }


        private void buttonLoadSchedule_Click(object sender, EventArgs e)
        {
            string clientEmail = textBoxEmail.Text.Trim();
            if (string.IsNullOrEmpty(clientEmail))
            {
                MessageBox.Show("Будь ласка, введіть електронну пошту.");
                return;
            }

            LoadSchedule(clientEmail);
        }

        private void LoadSchedule(string email)
        {
            string query = "SELECT Дата_та_час_запису, Назва_послуги FROM Schedule WHERE ClientEmail = @Email";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    flowLayoutPanelSchedule.Controls.Clear();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        CreateScheduleCard(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження розкладу: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void CreateScheduleCard(DataRow row)
        {
            Panel panel = new Panel
            {
                Width = 500,
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10)
            };

            Label lblDateTime = new Label
            {
                Text = "Дата і час: " + row["Дата_та_час_запису"].ToString(),
                Font = new Font("Arial", 10),
                Location = new Point(10, 10),
                AutoSize = true
            };

            Label lblServiceName = new Label
            {
                Text = "Назва послуги: " + row["Назва_послуги"].ToString(),
                Font = new Font("Arial", 10),
                Location = new Point(10, lblDateTime.Bottom + 5),
                AutoSize = true
            };

            panel.Controls.Add(lblDateTime);
            panel.Controls.Add(lblServiceName);

            flowLayoutPanelSchedule.Controls.Add(panel);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}

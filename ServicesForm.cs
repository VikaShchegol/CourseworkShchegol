using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace course
{
    public partial class ServicesForm : Form
    {
        private MySqlConnection conn;
        private bool isLoggedIn;

        public ServicesForm(MySqlConnection connection, bool loggedIn)
        {
            InitializeComponent();
            conn = connection;
            isLoggedIn = loggedIn;
            LoadServices();
        }

        private void LoadServices()
        {
            string query = "SELECT ID_service, Назва, Опис, Ціна FROM Services";

            try
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                flowLayoutPanelServices.Controls.Clear();

                foreach (DataRow row in dataTable.Rows)
                {
                    CreateServiceCard(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження даних: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void CreateServiceCard(DataRow row)
        {
            Panel panel = new Panel
            {
                Width = 500,
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10)
            };

            Label lblName = new Label
            {
                Text = row["Назва"].ToString(),
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            Label lblDescription = new Label
            {
                Text = row["Опис"].ToString(),
                Font = new Font("Arial", 10),
                Location = new Point(10, 40),
                Width = 600,
                AutoSize = true,
                MaximumSize = new Size(600, 0)
            };

            Size size = TextRenderer.MeasureText(lblDescription.Text, lblDescription.Font, new Size(lblDescription.Width, int.MaxValue), TextFormatFlags.WordBreak);
            lblDescription.Height = size.Height;

            Label lblPrice = new Label
            {
                Text = $"Ціна: {row["Ціна"]} грн",
                Font = new Font("Arial", 10, FontStyle.Italic),
                Location = new Point(10, lblDescription.Bottom + 10),
                AutoSize = true
            };

            Button btnBook = new Button
            {
                Text = "Записатися",
                Location = new Point(10, lblPrice.Bottom + 10),
                Font = new Font("Arial", 12, FontStyle.Italic),
                AutoSize = true,
                Tag = row["ID_service"]
            };
            btnBook.Click += ButtonBook_Click;

            panel.Controls.Add(lblName);
            panel.Controls.Add(lblDescription);
            panel.Controls.Add(lblPrice);
            panel.Controls.Add(btnBook);

            flowLayoutPanelServices.Controls.Add(panel);
        }

        private void ButtonBook_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int serviceId = Convert.ToInt32(button.Tag); 
            int ClientEmail = Convert.ToInt32(button.Tag);
            BookingForm bookingForm = new BookingForm(conn, serviceId, ClientEmail);
            bookingForm.ShowDialog();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}

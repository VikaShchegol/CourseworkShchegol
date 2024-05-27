using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace course
{
    public partial class BookingForm : Form
    {
        private MySqlConnection conn;
        private int serviceId;
        private int clientEmail;

        public BookingForm(MySqlConnection connection, int serviceId, int clientEmail) 
        {

            InitializeComponent();
            conn = connection;
            this.serviceId = serviceId;
            this.clientEmail = clientEmail; 
            LoadServices(); 
        }
        private void LoadServices()
        {
            string query = "SELECT ID_service, Назва FROM Services";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxService.Items.Add(new ComboBoxItem(reader["Назва"].ToString(), int.Parse(reader["ID_service"].ToString())));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження послуг: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            int selectedServiceId = ((ComboBoxItem)comboBoxService.SelectedItem)?.Value ?? 0;

            if (selectedServiceId == 0)
            {
                MessageBox.Show("Будь ласка, оберіть послугу для запису.");
                return;
            }

            string serviceName = ((ComboBoxItem)comboBoxService.SelectedItem)?.Text;
            DateTime selectedDateTime = dateTimePicker.Value.Date; 
            string time = comboBoxTime.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(time))
            {
                selectedDateTime = selectedDateTime.Add(TimeSpan.Parse(time)); 
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть час для запису.");
                return;
            }

            string clientEmail = textBoxEmail.Text;

            string query = "INSERT INTO Schedule (ID_service, Дата_та_час_запису, Назва_послуги, ClientEmail) VALUES (@ServiceID, @DateTime, @ServiceName, @ClientEmail)";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ServiceID", selectedServiceId);
                cmd.Parameters.AddWithValue("@DateTime", selectedDateTime);
                cmd.Parameters.AddWithValue("@ServiceName", serviceName);
                cmd.Parameters.AddWithValue("@ClientEmail", clientEmail); 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Запис успішно додано!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка запису: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public ComboBoxItem(string text, int value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}

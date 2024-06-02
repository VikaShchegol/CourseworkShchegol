using System;
using System.Data.Common;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace course
{
    public partial class EmployeeForm : Form
    {
        private int userId;
        private string userRole;
        private MySqlConnection conn;

        public EmployeeForm(int userId, string userRole)
        {
            InitializeComponent();
            this.userId = userId;
            this.userRole = userRole;
            conn = DBUtils.GetDBConnection();
        }
        private void buttonAddService_Click(object sender, EventArgs e)
        {
            string serviceName = textBoxServiceName.Text;
            string serviceDescription = textBoxServiceDescription.Text;
            decimal servicePrice;

            if (string.IsNullOrEmpty(serviceName) || string.IsNullOrEmpty(serviceDescription) || !decimal.TryParse(textBoxServicePrice.Text, out servicePrice))
            {
                MessageBox.Show("Все поля повинні бути заповненими, а ціна повинна бути числом.");
                return;
            }

            string sql = "INSERT INTO Services (Назва, Опис, Ціна) VALUES (@Name, @Description, @Price)";

            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Name", serviceName);
                cmd.Parameters.AddWithValue("@Description", serviceDescription);
                cmd.Parameters.AddWithValue("@Price", servicePrice);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Послуга успішно додана.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при додаванні послуги: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void buttonAddTour_Click(object sender, EventArgs e)
        {
            string voucherName = textBoxTourName.Text;
            string voucherDescription = textBoxTourDescription.Text;
            decimal voucherPrice;

            if (string.IsNullOrEmpty(voucherName) || string.IsNullOrEmpty(voucherDescription) || !decimal.TryParse(textBoxTourPrice.Text, out voucherPrice))
            {
                MessageBox.Show("Все поля повинні бути заповненими, а ціна повинна бути числом.");
                return;
            }

            string sql = "INSERT INTO Vouchers (Назва, Опис, Ціна) VALUES (@Name, @Description, @Price)";

            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Name", voucherName);
                cmd.Parameters.AddWithValue("@Description", voucherDescription);
                cmd.Parameters.AddWithValue("@Price", voucherPrice);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Путівка успішно додана.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при додаванні путівки: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

        }
        
        private void переглядToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm(conn);
            clientsForm.Show();
        }
    }
}

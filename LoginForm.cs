using System;
using System.Data.Common;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace course
{
    public partial class LoginForm : Form
    {
        private MySqlConnection conn;
        public int UserId { get; private set; }
        public string UserRole { get; private set; }
        public LoginForm(MySqlConnection connection)
        {
            InitializeComponent();
            conn = connection;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            string role = comboBoxRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Всі поля мають бути заповнені.");
                return;
            }

            string sql = "";
            string idColumn = "";

            switch (role)
            {
                case "Клієнт":
                    sql = "SELECT ID_client FROM Clients WHERE Електронна_пошта = @Email AND Пароль = @Password";
                    idColumn = "ID_client";
                    break;
                case "Співробітник":
                    sql = "SELECT ID_employee FROM Employees WHERE Електронна_пошта = @Email AND Пароль = @Password";
                    idColumn = "ID_employee";
                    break;
                default:
                    MessageBox.Show("Виберіть правильну роль.");
                    return;
            }

            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                try
                {
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            UserId = reader.GetInt32(reader.GetOrdinal(idColumn));
                            UserRole = role;

                            if (role == "Співробітник" && email == "shchegolviktoria@gmail.com" && password == "12345678")
                            {
                                UserRole = "Адмін";
                            }

                            MessageBox.Show($"Вхід успішний. Ваш ID:  {UserId}");

                            if (UserRole == "Адмін" || UserRole != "Співробітник")
                            {
                                this.DialogResult = DialogResult.OK;
                                this.Hide(); 
                            }
                            else
                            {
                                MessageBox.Show("Неверный email или пароль.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при вході: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
    }


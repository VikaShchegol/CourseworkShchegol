using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace course
{
    public partial class VouchersForm : Form
    {
        private MySqlConnection conn;
        private bool isLoggedIn;
        public VouchersForm(MySqlConnection connection, bool loggedIn)
        {
            InitializeComponent();
            conn = connection;
            isLoggedIn = loggedIn;
            LoadVouchers();
        }
        private void LoadVouchers()
        {
            string query = "SELECT Назва, Опис, Ціна FROM Vouchers";

            try
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                flowLayoutPanelVouchers.Controls.Clear();

                foreach (DataRow row in dataTable.Rows)
                {
                    CreateVoucherCard(row);
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

        private void CreateVoucherCard(DataRow row)
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
                Width = 655,
                AutoSize = true,
                MaximumSize = new Size(655, 0), 
              
            };
            Size size = TextRenderer.MeasureText(lblDescription.Text, lblDescription.Font, new Size(lblDescription.Width, int.MaxValue), TextFormatFlags.WordBreak);
            lblDescription.Height = size.Height;

            Label lblPrice = new Label
            {
                Text = $"Ціна: {row["Ціна"]} грн",
                Font = new Font("Arial", 10, FontStyle.Italic),
                Location = new Point(10, 90),
                AutoSize = true
            };

            panel.Controls.Add(lblName);
            panel.Controls.Add(lblDescription);
            panel.Controls.Add(lblPrice);

            flowLayoutPanelVouchers.Controls.Add(panel);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}

using System;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace stockApp
{
    public partial class customerRegister : Form
    {
        public customerRegister()
        {
            InitializeComponent();
        }
        private MySqlConnection GetDatabaseConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
            return new MySqlConnection(connectionString);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            root target = new root();
            target.Show();
            this.Hide();
        }
        private void customerRegister_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = GetDatabaseConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantısı başarısız: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string firstName = textBoxFirstName.Text.Trim();
            string lastName = textBoxLastName.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            string email = textBoxMail.Text.Trim();
            string address = textBoxAdress.Text.Trim();
            string city = textBoxCity.Text.Trim();
            string birthDateText = textBoxBirthDay.Text.Trim();
            string registrationDateText = DateTime.Now.ToString("dd-MM-yyyy");
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
    string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
    string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(email) ||
    string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(city) ||
    string.IsNullOrWhiteSpace(birthDateText))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password.Length < 8)
            {
                MessageBox.Show("Şifre en az 8 karakter olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!DateTime.TryParse(birthDateText, out DateTime birthDate))
            {
                MessageBox.Show("Geçerli bir doğum tarihi girin. (Örn: 30-12-2000)", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (MySqlConnection connection = GetDatabaseConnection())
            {
                try
                {
                    connection.Open();
                    string checkUsernameQuery = "SELECT COUNT(*) FROM customers WHERE username = @username";
                    MySqlCommand checkUsernameCommand = new MySqlCommand(checkUsernameQuery, connection);
                    checkUsernameCommand.Parameters.AddWithValue("@username", username);
                    int usernameExists = Convert.ToInt32(checkUsernameCommand.ExecuteScalar());

                    if (usernameExists > 0)
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten alınmış. Lütfen farklı bir kullanıcı adı deneyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    int userId;
                    Random random = new Random();
                    do
                    {
                        userId = random.Next(100000000, 1000000000);
                        string checkIdQuery = "SELECT COUNT(*) FROM customers WHERE id = @id";
                        MySqlCommand checkIdCommand = new MySqlCommand(checkIdQuery, connection);
                        checkIdCommand.Parameters.AddWithValue("@id", userId);
                        int idExists = Convert.ToInt32(checkIdCommand.ExecuteScalar());
                        if (idExists == 0) break;
                    } while (true);
                    string insertQuery = @"
                INSERT INTO customers 
                (id, username, password, first_name, last_name, phone, email, address, city, birth_date, registration_date)
                VALUES 
                (@id, @username, @password, @first_name, @last_name, @phone, @email, @address, @city, @birth_date, @registration_date)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@id", userId);
                    insertCommand.Parameters.AddWithValue("@username", username);
                    insertCommand.Parameters.AddWithValue("@password", password);
                    insertCommand.Parameters.AddWithValue("@first_name", firstName);
                    insertCommand.Parameters.AddWithValue("@last_name", lastName);
                    insertCommand.Parameters.AddWithValue("@phone", phone);
                    insertCommand.Parameters.AddWithValue("@email", email);
                    insertCommand.Parameters.AddWithValue("@address", address);
                    insertCommand.Parameters.AddWithValue("@city", city);
                    insertCommand.Parameters.AddWithValue("@birth_date", birthDateText);
                    insertCommand.Parameters.AddWithValue("@registration_date", registrationDateText);
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        GlobalVariables.customerID = Convert.ToInt32(userId);
                        MessageBox.Show("Kayıt başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        customerHome target = new customerHome();
                        target.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
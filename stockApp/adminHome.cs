using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace stockApp
{
    public partial class adminHome : Form
    {

        public adminHome()
        {
            InitializeComponent();
        }

        private MySqlConnection GetDatabaseConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
            return new MySqlConnection(connectionString);
        }

        public void GetProducts()
        {
            using (MySqlConnection connection = GetDatabaseConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM products";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    dataGridViewProducts.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void GetProductCount()
        {
            using (MySqlConnection connection = GetDatabaseConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM products";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    int productCount = Convert.ToInt32(command.ExecuteScalar());

                    labelProductCount.Text = productCount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void GetCustomers()
        {
            using (MySqlConnection connection = GetDatabaseConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM customers";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    dataGridViewCustomers.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void GetCustomersCount()
        {
            using (MySqlConnection connection = GetDatabaseConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM customers";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    int customerCount = Convert.ToInt32(command.ExecuteScalar());

                    labelCustomerCount.Text = customerCount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void GetOrders()
        {
            using (MySqlConnection connection = GetDatabaseConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM orders";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    dataGridViewOrders.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void GetOrdersCount()
        {
            using (MySqlConnection connection = GetDatabaseConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM orders";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    int customerCount = Convert.ToInt32(command.ExecuteScalar());

                    labelOrdersCount.Text = customerCount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void adminHome_Load(object sender, EventArgs e)
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

            panelProducts.Visible = true;
            panelOrders.Visible = false;
            panelCustomers.Visible = false;

            buttonProducts.ForeColor = Color.Blue;
            buttonOrders.ForeColor = Color.Black;
            buttonCustomers.ForeColor = Color.Black;


            labelUpdateText.Text = "";
            labelUpdateID.Text = "";

            textBoxUpdateProductName.Enabled = false;
            textBoxUpdateProductPrice.Enabled = false;
            textBoxUpdateProductStock.Enabled = false;

            buttonUpdate.Enabled = false;


            GetProducts();
            GetProductCount();

            GetCustomers();
            GetCustomersCount();

            GetOrders();
            GetOrdersCount();


        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string productName = textBoxInsertProductName.Text.Trim();
            string productPrice = textBoxInsertProductPrice.Text.Trim();
            string productStock = textBoxInsertProductStock.Text.Trim();

            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(productPrice) || string.IsNullOrEmpty(productStock))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection connection = GetDatabaseConnection())
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO products (product_name, product_price, product_stock) VALUES (@name, @price, @stock)";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@name", productName);
                    command.Parameters.AddWithValue("@price", productPrice);
                    command.Parameters.AddWithValue("@stock", productStock);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Ürün başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBoxInsertProductName.Clear();
                        textBoxInsertProductPrice.Clear();
                        textBoxInsertProductStock.Clear();

                        GetProducts();

                        GetProductCount();
                    }
                    else
                    {
                        MessageBox.Show("Ürün eklenemedi. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string productId = textBoxDeleteID.Text.Trim();

            if (string.IsNullOrEmpty(productId))
            {
                MessageBox.Show("Lütfen silinecek ürünün ID'sini girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection connection = GetDatabaseConnection())
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM products WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@id", productId);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Ürün başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBoxDeleteID.Clear();

                        GetProducts();

                        GetProductCount();
                    }
                    else
                    {
                        MessageBox.Show("Ürün silinemedi. Lütfen geçerli bir ID girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string productId = labelUpdateID.Text.Trim();
            string productName = textBoxUpdateProductName.Text.Trim();
            string productPrice = textBoxUpdateProductPrice.Text.Trim();
            string productStock = textBoxUpdateProductStock.Text.Trim();

            if (string.IsNullOrEmpty(productId) || string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(productPrice) || string.IsNullOrEmpty(productStock))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection connection = GetDatabaseConnection())
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE products SET product_name = @name, product_price = @price, product_stock = @stock WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@id", productId);
                    command.Parameters.AddWithValue("@name", productName);
                    command.Parameters.AddWithValue("@price", productPrice);
                    command.Parameters.AddWithValue("@stock", productStock);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Ürün başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBoxUpdateID.Clear();
                        textBoxUpdateProductName.Clear();
                        textBoxUpdateProductPrice.Clear();
                        textBoxUpdateProductStock.Clear();

                        labelUpdateText.Text = "";
                        labelUpdateID.Text = "";

                        textBoxUpdateProductName.Enabled = false;
                        textBoxUpdateProductPrice.Enabled = false;
                        textBoxUpdateProductStock.Enabled = false;

                        buttonUpdate.Enabled = false;

                        GetProducts();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme başarısız. Lütfen geçerli bir ID girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonGetProduct_Click(object sender, EventArgs e)
        {
            string productId = textBoxUpdateID.Text.Trim();

            if (string.IsNullOrEmpty(productId))
            {
                MessageBox.Show("Lütfen ürün ID'sini girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection connection = GetDatabaseConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT product_name, product_price, product_stock FROM products WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", productId);

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        textBoxUpdateProductName.Text = reader["product_name"].ToString();
                        textBoxUpdateProductPrice.Text = reader["product_price"].ToString();
                        textBoxUpdateProductStock.Text = reader["product_stock"].ToString();

                        labelUpdateText.Text = "Seçili ürün:";
                        labelUpdateID.Text = textBoxUpdateID.Text;

                        textBoxUpdateProductName.Enabled = true;
                        textBoxUpdateProductPrice.Enabled = true;
                        textBoxUpdateProductStock.Enabled = true;

                        buttonUpdate.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Bu ID'ye ait bir ürün bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            panelProducts.Visible = true;
            panelOrders.Visible = false;
            panelCustomers.Visible = false;

            buttonProducts.ForeColor = Color.Blue;
            buttonOrders.ForeColor = Color.Black;
            buttonCustomers.ForeColor = Color.Black;
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            panelProducts.Visible = false;
            panelOrders.Visible = true;
            panelCustomers.Visible = false;

            buttonProducts.ForeColor = Color.Black;
            buttonOrders.ForeColor = Color.Blue;
            buttonCustomers.ForeColor = Color.Black;
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            panelProducts.Visible = false;
            panelOrders.Visible = false;
            panelCustomers.Visible = true;

            buttonProducts.ForeColor = Color.Black;
            buttonOrders.ForeColor = Color.Black;
            buttonCustomers.ForeColor = Color.Blue;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            root target = new root();
            target.Show();
            this.Hide();
        }

    }
}

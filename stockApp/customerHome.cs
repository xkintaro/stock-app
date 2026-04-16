using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace stockApp
{
    public partial class customerHome : Form
    {
        public customerHome()
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
        public void GetOrders()
        {
            int currentCustomerID = GlobalVariables.customerID;

            using (MySqlConnection connection = GetDatabaseConnection())
            {
                try
                {
                    connection.Open();


                    string query = @"
                SELECT 
                    id AS 'Sipariş  ID',
                    product_id AS 'Ürün ID',
                    order_adress AS 'Sipariş Adresi',
                    order_date AS 'Sipariş Tarihi',
                    order_number AS 'Sipariş Miktarı'
                FROM orders 
                WHERE customer_id = @customerId";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@customerId", currentCustomerID);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {

                        dataGridViewOrders.DataSource = dataTable;
                    }
                    else
                    {
                        labelorderstext.Text = "Bu kullanıcıya ait herhangi bir sipariş bulunamadı.";
                        dataGridViewOrders.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void fillUserInfo()
        {
            int currentCustomerID = GlobalVariables.customerID;
            labelCustomerID.Text = "ID: " + currentCustomerID.ToString();

            using (MySqlConnection connection = GetDatabaseConnection())
            {
                try
                {
                    connection.Open();

                    string query = @"
                        SELECT 
                            username, password, first_name, last_name, 
                            phone, email, address, city, birth_date, registration_date 
                        FROM customers 
                        WHERE id = @id";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", currentCustomerID);

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        textBoxUsername.Text = reader["username"].ToString();
                        textBoxPassword.Text = reader["password"].ToString();
                        textBoxFirstName.Text = reader["first_name"].ToString();
                        textBoxLastName.Text = reader["last_name"].ToString();
                        textBoxPhone.Text = reader["phone"].ToString();
                        textBoxMail.Text = reader["email"].ToString();
                        textBoxAdress.Text = reader["address"].ToString();
                        textBoxCity.Text = reader["city"].ToString();
                        textBoxBirthDay.Text = Convert.ToDateTime(reader["birth_date"]).ToString("dd-MM-yyyy");
                        labelRegisterDate.Text = "Kayıt Tarihi: " + Convert.ToDateTime(reader["registration_date"]).ToString("dd-MM-yyyy");
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bilgileri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonAccount_Click(object sender, EventArgs e)
        {
            panelAccount.Visible = true;
            panelProducts.Visible = false;
            panelOrders.Visible = false;

            buttonAccount.ForeColor = Color.Blue;
            buttonProducts.ForeColor = Color.Black;
            buttonOrder.ForeColor = Color.Black;
        }
        private void buttonProducts_Click(object sender, EventArgs e)
        {
            panelAccount.Visible = false;
            panelProducts.Visible = true;
            panelOrders.Visible = false;

            buttonAccount.ForeColor = Color.Black;
            buttonProducts.ForeColor = Color.Blue;
            buttonOrder.ForeColor = Color.Black;
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            panelAccount.Visible = false;
            panelProducts.Visible = false;
            panelOrders.Visible = true;

            buttonAccount.ForeColor = Color.Black;
            buttonProducts.ForeColor = Color.Black;
            buttonOrders.ForeColor = Color.Blue;
        }
        private void buttonBackToGetProductID_Click(object sender, EventArgs e)
        {
            GlobalVariables.customerProductID = 0;
            panelGetProductID.Visible = true;
            panelGetOrder.Visible = false;
            panelOrderGetAdress.Visible = false;
        }
        private void buttonBackToOrder_Click(object sender, EventArgs e)
        {
            GlobalVariables.customerOrderProductNumber = 0;
            panelGetProductID.Visible = false;
            panelGetOrder.Visible = true;
            panelOrderGetAdress.Visible = false;
        }
        private void customerHome_Load(object sender, EventArgs e)
        {
            GetProducts();
            fillUserInfo();
            GetAdress();
            GetOrders();

            panelAccount.Visible = true;
            panelProducts.Visible = false;
            panelOrders.Visible = false;

            buttonAccount.ForeColor = Color.Blue;
            buttonProducts.ForeColor = Color.Black;
            buttonOrder.ForeColor = Color.Black;

            panelGetProductID.Visible = true;
            panelGetOrder.Visible = false;
            panelOrderGetAdress.Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            root target = new root();
            target.Show();
            this.Hide();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearch.Text.Trim();

            using (MySqlConnection connection = GetDatabaseConnection())
            {
                try
                {
                    connection.Open();

                    if (string.IsNullOrWhiteSpace(searchQuery))
                    {
                        GetProducts();
                        return;
                    }

                    string query = @"
            SELECT * FROM products WHERE product_name LIKE @search";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@search", "%" + searchQuery + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridViewProducts.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Arama kriterlerine uygun ürün bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewProducts.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        public void GetAdress()
        {
            int currentCustomerID = GlobalVariables.customerID;

            using (MySqlConnection connection = GetDatabaseConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT address FROM customers WHERE id = @customerID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@customerID", currentCustomerID);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string address = result.ToString();
                        textBoxGetAdress.Text = address;
                    }
                    else
                    {
                        MessageBox.Show("Bu ID'ye ait bir adres bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxGetAdress.Text = string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonGetAdress_Click(object sender, EventArgs e)
        {
            GetAdress();
        }
        private void buttonGetProductID_Click(object sender, EventArgs e)
        {
            string productIdText = textBoxGetProductID.Text.Trim();

            if (string.IsNullOrWhiteSpace(productIdText))
            {
                MessageBox.Show("Lütfen bir ürün ID'si girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(productIdText, out int productId))
            {
                MessageBox.Show("Geçerli bir ürün ID'si girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection connection = GetDatabaseConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT product_name, product_price, product_stock FROM products WHERE id = @productId";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@productId", productId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["product_name"].ToString();
                            string productPrice = reader["product_price"].ToString();
                            int productStock = Convert.ToInt32(reader["product_stock"]);
                            if (productStock == 0)
                            {
                                MessageBox.Show("Bu ürünün stoğu tükenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            GlobalVariables.customerProductID = productId;
                            panelGetProductID.Visible = false;
                            panelGetOrder.Visible = true;
                            panelOrderGetAdress.Visible = false;
                            textBoxGetProductID.Text = null;
                            labelShowProductID.Text = "Seçili ID: " + GlobalVariables.customerProductID.ToString();
                            textBoxProductName.Text = productName;
                            textBoxProductPrice.Text = productPrice;
                            textBoxProductStock.Text = productStock.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bu ID'ye ait bir ürün bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            string stockNumberText = textBoxProductStockNumber.Text.Trim();
            if (string.IsNullOrWhiteSpace(stockNumberText))
            {
                MessageBox.Show("Lütfen bir stok miktarı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(stockNumberText, out int stockNumber))
            {
                MessageBox.Show("Geçerli bir stok miktarı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int productId = GlobalVariables.customerProductID;
            using (MySqlConnection connection = GetDatabaseConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT product_stock FROM products WHERE id = @productId";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@productId", productId);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        int productStock = Convert.ToInt32(result);

                        if (stockNumber > productStock)
                        {
                            MessageBox.Show($"Ürün stoğunu aştınız. Max: {productStock}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            GlobalVariables.customerOrderProductNumber = Convert.ToInt32(stockNumber);
                            textBoxProductStockNumber.Text = null;
                            panelGetProductID.Visible = false;
                            panelGetOrder.Visible = false;
                            panelOrderGetAdress.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seçili ID'ye ait bir ürün bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonComplateOrder_Click(object sender, EventArgs e)
        {
            int currentCustomerID = GlobalVariables.customerID;
            int selectedProductID = GlobalVariables.customerProductID;
            int orderQuantity = GlobalVariables.customerOrderProductNumber;
            string orderAddress = textBoxGetAdress.Text.Trim();
            string orderDate = DateTime.Now.ToString("dd-MM-yyyy HH:mm");

            if (string.IsNullOrWhiteSpace(orderAddress))
            {
                MessageBox.Show("Lütfen adres bilgisini doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (MySqlConnection connection = GetDatabaseConnection())
            {
                try
                {
                    connection.Open();
                    string stockQuery = "SELECT product_stock FROM products WHERE id = @productID";
                    MySqlCommand stockCommand = new MySqlCommand(stockQuery, connection);
                    stockCommand.Parameters.AddWithValue("@productID", selectedProductID);
                    object stockResult = stockCommand.ExecuteScalar();
                    if (stockResult != null)
                    {
                        int currentStock = Convert.ToInt32(stockResult);
                        if (orderQuantity > currentStock)
                        {
                            MessageBox.Show($"Ürün stok miktarını aştınız! Maksimum sipariş miktarı: {currentStock}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        int newStock = currentStock - orderQuantity;
                        string updateStockQuery = "UPDATE products SET product_stock = @newStock WHERE id = @productID";
                        MySqlCommand updateStockCommand = new MySqlCommand(updateStockQuery, connection);
                        updateStockCommand.Parameters.AddWithValue("@newStock", newStock);
                        updateStockCommand.Parameters.AddWithValue("@productID", selectedProductID);
                        updateStockCommand.ExecuteNonQuery();
                        GetProducts();
                    }
                    else
                    {
                        MessageBox.Show("Seçili ürün bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string orderQuery = @"
                INSERT INTO orders (customer_id, product_id, order_adress, order_date, order_number) 
                VALUES (@customerID, @productID, @orderAddress, @orderDate, @orderNumber)";
                    MySqlCommand orderCommand = new MySqlCommand(orderQuery, connection);
                    orderCommand.Parameters.AddWithValue("@customerID", currentCustomerID);
                    orderCommand.Parameters.AddWithValue("@productID", selectedProductID);
                    orderCommand.Parameters.AddWithValue("@orderAddress", orderAddress);
                    orderCommand.Parameters.AddWithValue("@orderDate", orderDate);
                    orderCommand.Parameters.AddWithValue("@orderNumber", orderQuantity);
                    orderCommand.ExecuteNonQuery();
                    GetProducts();
                    GetOrders();
                    MessageBox.Show("Siparişiniz başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelAccount.Visible = false;
                    panelProducts.Visible = false;
                    panelOrders.Visible = true;
                    buttonAccount.ForeColor = Color.Black;
                    buttonProducts.ForeColor = Color.Black;
                    buttonOrders.ForeColor = Color.Blue;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sipariş sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

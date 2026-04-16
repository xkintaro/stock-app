namespace stockApp
{
    partial class adminHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.labelProductCount = new System.Windows.Forms.Label();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.panelProductUpdate = new System.Windows.Forms.Panel();
            this.labelUpdateText = new System.Windows.Forms.Label();
            this.labelUpdateID = new System.Windows.Forms.Label();
            this.buttonGetProduct = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxUpdateID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxUpdateProductStock = new System.Windows.Forms.TextBox();
            this.textBoxUpdateProductPrice = new System.Windows.Forms.TextBox();
            this.textBoxUpdateProductName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panelProductDelete = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDeleteID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelProductInsert = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxInsertProductStock = new System.Windows.Forms.TextBox();
            this.textBoxInsertProductPrice = new System.Windows.Forms.TextBox();
            this.textBoxInsertProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.panelCustomers = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label232 = new System.Windows.Forms.Label();
            this.labelCustomerCount = new System.Windows.Forms.Label();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.buttonCustomers = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.labelOrdersCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.panelProductUpdate.SuspendLayout();
            this.panelProductDelete.SuspendLayout();
            this.panelProductInsert.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelProducts.SuspendLayout();
            this.panelOrders.SuspendLayout();
            this.panelCustomers.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOrders
            // 
            this.buttonOrders.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrders.FlatAppearance.BorderSize = 0;
            this.buttonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrders.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOrders.Location = new System.Drawing.Point(156, 25);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(97, 33);
            this.buttonOrders.TabIndex = 0;
            this.buttonOrders.Text = "Siparişler";
            this.buttonOrders.UseVisualStyleBackColor = false;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProducts.FlatAppearance.BorderSize = 0;
            this.buttonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProducts.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonProducts.Location = new System.Drawing.Point(15, 25);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(135, 33);
            this.buttonProducts.TabIndex = 1;
            this.buttonProducts.Text = "Ürün Yönetimi";
            this.buttonProducts.UseVisualStyleBackColor = false;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.IndianRed;
            this.label12.Location = new System.Drawing.Point(8, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(222, 28);
            this.label12.TabIndex = 20;
            this.label12.Text = "Toplam Ürün Sayısı:";
            // 
            // labelProductCount
            // 
            this.labelProductCount.AutoSize = true;
            this.labelProductCount.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProductCount.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelProductCount.Location = new System.Drawing.Point(245, 18);
            this.labelProductCount.Name = "labelProductCount";
            this.labelProductCount.Size = new System.Drawing.Size(28, 28);
            this.labelProductCount.TabIndex = 19;
            this.labelProductCount.Text = "A";
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(9, 16);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(912, 213);
            this.dataGridViewProducts.TabIndex = 18;
            // 
            // panelProductUpdate
            // 
            this.panelProductUpdate.BackColor = System.Drawing.SystemColors.Menu;
            this.panelProductUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProductUpdate.Controls.Add(this.labelUpdateText);
            this.panelProductUpdate.Controls.Add(this.labelUpdateID);
            this.panelProductUpdate.Controls.Add(this.buttonGetProduct);
            this.panelProductUpdate.Controls.Add(this.label11);
            this.panelProductUpdate.Controls.Add(this.textBoxUpdateID);
            this.panelProductUpdate.Controls.Add(this.label5);
            this.panelProductUpdate.Controls.Add(this.label6);
            this.panelProductUpdate.Controls.Add(this.label9);
            this.panelProductUpdate.Controls.Add(this.buttonUpdate);
            this.panelProductUpdate.Controls.Add(this.textBoxUpdateProductStock);
            this.panelProductUpdate.Controls.Add(this.textBoxUpdateProductPrice);
            this.panelProductUpdate.Controls.Add(this.textBoxUpdateProductName);
            this.panelProductUpdate.Controls.Add(this.label10);
            this.panelProductUpdate.Location = new System.Drawing.Point(315, 235);
            this.panelProductUpdate.Name = "panelProductUpdate";
            this.panelProductUpdate.Size = new System.Drawing.Size(300, 400);
            this.panelProductUpdate.TabIndex = 17;
            // 
            // labelUpdateText
            // 
            this.labelUpdateText.AutoSize = true;
            this.labelUpdateText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUpdateText.ForeColor = System.Drawing.Color.IndianRed;
            this.labelUpdateText.Location = new System.Drawing.Point(59, 128);
            this.labelUpdateText.Name = "labelUpdateText";
            this.labelUpdateText.Size = new System.Drawing.Size(82, 19);
            this.labelUpdateText.TabIndex = 12;
            this.labelUpdateText.Text = "Seçili ürün:";
            // 
            // labelUpdateID
            // 
            this.labelUpdateID.AutoSize = true;
            this.labelUpdateID.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUpdateID.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelUpdateID.Location = new System.Drawing.Point(147, 128);
            this.labelUpdateID.Name = "labelUpdateID";
            this.labelUpdateID.Size = new System.Drawing.Size(19, 19);
            this.labelUpdateID.TabIndex = 11;
            this.labelUpdateID.Text = "A";
            // 
            // buttonGetProduct
            // 
            this.buttonGetProduct.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGetProduct.Location = new System.Drawing.Point(182, 91);
            this.buttonGetProduct.Name = "buttonGetProduct";
            this.buttonGetProduct.Size = new System.Drawing.Size(61, 32);
            this.buttonGetProduct.TabIndex = 10;
            this.buttonGetProduct.Text = "Getir";
            this.buttonGetProduct.UseVisualStyleBackColor = true;
            this.buttonGetProduct.Click += new System.EventHandler(this.buttonGetProduct_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(59, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 19);
            this.label11.TabIndex = 9;
            this.label11.Text = "Ürün ID";
            // 
            // textBoxUpdateID
            // 
            this.textBoxUpdateID.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxUpdateID.Location = new System.Drawing.Point(60, 93);
            this.textBoxUpdateID.Name = "textBoxUpdateID";
            this.textBoxUpdateID.Size = new System.Drawing.Size(116, 27);
            this.textBoxUpdateID.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(56, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ürün Adeti";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(59, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ürün Fiyatı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(59, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "Ürün Adı";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUpdate.Location = new System.Drawing.Point(106, 336);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(84, 35);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Güncelle";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxUpdateProductStock
            // 
            this.textBoxUpdateProductStock.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxUpdateProductStock.Location = new System.Drawing.Point(60, 291);
            this.textBoxUpdateProductStock.Name = "textBoxUpdateProductStock";
            this.textBoxUpdateProductStock.Size = new System.Drawing.Size(180, 27);
            this.textBoxUpdateProductStock.TabIndex = 3;
            // 
            // textBoxUpdateProductPrice
            // 
            this.textBoxUpdateProductPrice.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxUpdateProductPrice.Location = new System.Drawing.Point(60, 233);
            this.textBoxUpdateProductPrice.Name = "textBoxUpdateProductPrice";
            this.textBoxUpdateProductPrice.Size = new System.Drawing.Size(180, 27);
            this.textBoxUpdateProductPrice.TabIndex = 2;
            // 
            // textBoxUpdateProductName
            // 
            this.textBoxUpdateProductName.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxUpdateProductName.Location = new System.Drawing.Point(60, 176);
            this.textBoxUpdateProductName.Name = "textBoxUpdateProductName";
            this.textBoxUpdateProductName.Size = new System.Drawing.Size(180, 27);
            this.textBoxUpdateProductName.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(54, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ürün Güncelle";
            // 
            // panelProductDelete
            // 
            this.panelProductDelete.BackColor = System.Drawing.SystemColors.Menu;
            this.panelProductDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProductDelete.Controls.Add(this.label8);
            this.panelProductDelete.Controls.Add(this.textBoxDeleteID);
            this.panelProductDelete.Controls.Add(this.label7);
            this.panelProductDelete.Controls.Add(this.buttonDelete);
            this.panelProductDelete.Location = new System.Drawing.Point(621, 307);
            this.panelProductDelete.Name = "panelProductDelete";
            this.panelProductDelete.Size = new System.Drawing.Size(300, 328);
            this.panelProductDelete.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(94, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 31);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ürün Sil";
            // 
            // textBoxDeleteID
            // 
            this.textBoxDeleteID.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxDeleteID.Location = new System.Drawing.Point(63, 133);
            this.textBoxDeleteID.Name = "textBoxDeleteID";
            this.textBoxDeleteID.Size = new System.Drawing.Size(180, 27);
            this.textBoxDeleteID.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(62, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ürün ID";
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDelete.Location = new System.Drawing.Point(116, 176);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 35);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Sil";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // panelProductInsert
            // 
            this.panelProductInsert.BackColor = System.Drawing.SystemColors.Menu;
            this.panelProductInsert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProductInsert.Controls.Add(this.label4);
            this.panelProductInsert.Controls.Add(this.label3);
            this.panelProductInsert.Controls.Add(this.label2);
            this.panelProductInsert.Controls.Add(this.buttonInsert);
            this.panelProductInsert.Controls.Add(this.textBoxInsertProductStock);
            this.panelProductInsert.Controls.Add(this.textBoxInsertProductPrice);
            this.panelProductInsert.Controls.Add(this.textBoxInsertProductName);
            this.panelProductInsert.Controls.Add(this.label1);
            this.panelProductInsert.Location = new System.Drawing.Point(9, 235);
            this.panelProductInsert.Name = "panelProductInsert";
            this.panelProductInsert.Size = new System.Drawing.Size(300, 400);
            this.panelProductInsert.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(56, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ürün Adeti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(59, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ürün Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(59, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün Adı";
            // 
            // buttonInsert
            // 
            this.buttonInsert.FlatAppearance.BorderSize = 0;
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonInsert.Location = new System.Drawing.Point(112, 266);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(74, 35);
            this.buttonInsert.TabIndex = 4;
            this.buttonInsert.Text = "Ekle";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxInsertProductStock
            // 
            this.textBoxInsertProductStock.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxInsertProductStock.Location = new System.Drawing.Point(60, 222);
            this.textBoxInsertProductStock.Name = "textBoxInsertProductStock";
            this.textBoxInsertProductStock.Size = new System.Drawing.Size(180, 27);
            this.textBoxInsertProductStock.TabIndex = 3;
            // 
            // textBoxInsertProductPrice
            // 
            this.textBoxInsertProductPrice.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxInsertProductPrice.Location = new System.Drawing.Point(60, 158);
            this.textBoxInsertProductPrice.Name = "textBoxInsertProductPrice";
            this.textBoxInsertProductPrice.Size = new System.Drawing.Size(180, 27);
            this.textBoxInsertProductPrice.TabIndex = 2;
            // 
            // textBoxInsertProductName
            // 
            this.textBoxInsertProductName.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxInsertProductName.Location = new System.Drawing.Point(60, 99);
            this.textBoxInsertProductName.Name = "textBoxInsertProductName";
            this.textBoxInsertProductName.Size = new System.Drawing.Size(180, 27);
            this.textBoxInsertProductName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(85, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Ekle";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.labelProductCount);
            this.panel2.Location = new System.Drawing.Point(622, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 65);
            this.panel2.TabIndex = 19;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Image = global::stockApp.Properties.Resources.off;
            this.backButton.Location = new System.Drawing.Point(888, 22);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(36, 36);
            this.backButton.TabIndex = 21;
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panelProducts
            // 
            this.panelProducts.Controls.Add(this.panelProductDelete);
            this.panelProducts.Controls.Add(this.panelProductInsert);
            this.panelProducts.Controls.Add(this.panelProductUpdate);
            this.panelProducts.Controls.Add(this.panel2);
            this.panelProducts.Controls.Add(this.dataGridViewProducts);
            this.panelProducts.Location = new System.Drawing.Point(1, 64);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(1197, 651);
            this.panelProducts.TabIndex = 22;
            // 
            // panelOrders
            // 
            this.panelOrders.Controls.Add(this.panel3);
            this.panelOrders.Controls.Add(this.dataGridViewOrders);
            this.panelOrders.Location = new System.Drawing.Point(1, 64);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Size = new System.Drawing.Size(1197, 651);
            this.panelOrders.TabIndex = 23;
            // 
            // panelCustomers
            // 
            this.panelCustomers.Controls.Add(this.panel1);
            this.panelCustomers.Controls.Add(this.dataGridViewCustomers);
            this.panelCustomers.Location = new System.Drawing.Point(1, 64);
            this.panelCustomers.Name = "panelCustomers";
            this.panelCustomers.Size = new System.Drawing.Size(1197, 651);
            this.panelCustomers.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label232);
            this.panel1.Controls.Add(this.labelCustomerCount);
            this.panel1.Location = new System.Drawing.Point(8, 573);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 65);
            this.panel1.TabIndex = 20;
            // 
            // label232
            // 
            this.label232.AutoSize = true;
            this.label232.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label232.ForeColor = System.Drawing.Color.IndianRed;
            this.label232.Location = new System.Drawing.Point(8, 18);
            this.label232.Name = "label232";
            this.label232.Size = new System.Drawing.Size(251, 28);
            this.label232.TabIndex = 20;
            this.label232.Text = "Toplam Müşteri Sayısı:";
            // 
            // labelCustomerCount
            // 
            this.labelCustomerCount.AutoSize = true;
            this.labelCustomerCount.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCustomerCount.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelCustomerCount.Location = new System.Drawing.Point(284, 20);
            this.labelCustomerCount.Name = "labelCustomerCount";
            this.labelCustomerCount.Size = new System.Drawing.Size(28, 28);
            this.labelCustomerCount.TabIndex = 19;
            this.labelCustomerCount.Text = "A";
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomers.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(9, 6);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.Size = new System.Drawing.Size(912, 561);
            this.dataGridViewCustomers.TabIndex = 19;
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustomers.FlatAppearance.BorderSize = 0;
            this.buttonCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomers.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCustomers.Location = new System.Drawing.Point(259, 25);
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.Size = new System.Drawing.Size(107, 33);
            this.buttonCustomers.TabIndex = 25;
            this.buttonCustomers.Text = "Müşteriler";
            this.buttonCustomers.UseVisualStyleBackColor = false;
            this.buttonCustomers.Click += new System.EventHandler(this.buttonCustomers_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(8, 16);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(912, 552);
            this.dataGridViewOrders.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Menu;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.labelOrdersCount);
            this.panel3.Location = new System.Drawing.Point(9, 574);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(911, 65);
            this.panel3.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.IndianRed;
            this.label13.Location = new System.Drawing.Point(8, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(245, 28);
            this.label13.TabIndex = 20;
            this.label13.Text = "Toplam Siparişi Sayısı:";
            // 
            // labelOrdersCount
            // 
            this.labelOrdersCount.AutoSize = true;
            this.labelOrdersCount.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrdersCount.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelOrdersCount.Location = new System.Drawing.Point(284, 20);
            this.labelOrdersCount.Name = "labelOrdersCount";
            this.labelOrdersCount.Size = new System.Drawing.Size(28, 28);
            this.labelOrdersCount.TabIndex = 19;
            this.labelOrdersCount.Text = "A";
            // 
            // adminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(933, 714);
            this.Controls.Add(this.buttonCustomers);
            this.Controls.Add(this.panelCustomers);
            this.Controls.Add(this.panelOrders);
            this.Controls.Add(this.panelProducts);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.buttonOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "adminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminHome";
            this.Load += new System.EventHandler(this.adminHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.panelProductUpdate.ResumeLayout(false);
            this.panelProductUpdate.PerformLayout();
            this.panelProductDelete.ResumeLayout(false);
            this.panelProductDelete.PerformLayout();
            this.panelProductInsert.ResumeLayout(false);
            this.panelProductInsert.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelProducts.ResumeLayout(false);
            this.panelOrders.ResumeLayout(false);
            this.panelCustomers.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelProductCount;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Panel panelProductUpdate;
        private System.Windows.Forms.Label labelUpdateText;
        private System.Windows.Forms.Label labelUpdateID;
        private System.Windows.Forms.Button buttonGetProduct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxUpdateID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxUpdateProductStock;
        private System.Windows.Forms.TextBox textBoxUpdateProductPrice;
        private System.Windows.Forms.TextBox textBoxUpdateProductName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelProductDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDeleteID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panelProductInsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxInsertProductStock;
        private System.Windows.Forms.TextBox textBoxInsertProductPrice;
        private System.Windows.Forms.TextBox textBoxInsertProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.Panel panelCustomers;
        private System.Windows.Forms.Button buttonCustomers;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label232;
        private System.Windows.Forms.Label labelCustomerCount;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelOrdersCount;
    }
}
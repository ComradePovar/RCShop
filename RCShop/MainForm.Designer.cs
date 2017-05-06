namespace RCShop
{
    partial class MainForm
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
            this.tc = new System.Windows.Forms.TabControl();
            this.tpGoods = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbProductInfo = new System.Windows.Forms.GroupBox();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.btnAddEdit1 = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.lbProductTitle = new System.Windows.Forms.Label();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.tbProductCount = new System.Windows.Forms.TextBox();
            this.tbProductTitle = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.tpOrders = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbOrderInfo = new System.Windows.Forms.GroupBox();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnAddEdit2 = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.lbOrderPrice = new System.Windows.Forms.Label();
            this.lbClientID = new System.Windows.Forms.Label();
            this.lbProductID = new System.Windows.Forms.Label();
            this.tbOrderPrice = new System.Windows.Forms.TextBox();
            this.tbOrderClientID = new System.Windows.Forms.TextBox();
            this.tbOrderProductID = new System.Windows.Forms.TextBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.tpClients = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.gbClientInfo = new System.Windows.Forms.GroupBox();
            this.tbClientAdress = new System.Windows.Forms.TextBox();
            this.lbAdress = new System.Windows.Forms.Label();
            this.btnCancel3 = new System.Windows.Forms.Button();
            this.btnAddEdit3 = new System.Windows.Forms.Button();
            this.btnDelete3 = new System.Windows.Forms.Button();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbClientName = new System.Windows.Forms.Label();
            this.tbClientPhone = new System.Windows.Forms.TextBox();
            this.tbClientDiscount = new System.Windows.Forms.TextBox();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.tpServiceTickets = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.gbServiceTicketInfo = new System.Windows.Forms.GroupBox();
            this.tbTicketClientID = new System.Windows.Forms.TextBox();
            this.lbTicketClientID = new System.Windows.Forms.Label();
            this.btnCancel4 = new System.Windows.Forms.Button();
            this.btnAddEdit4 = new System.Windows.Forms.Button();
            this.btnDelete4 = new System.Windows.Forms.Button();
            this.lbTicketPrice = new System.Windows.Forms.Label();
            this.lbProblem = new System.Windows.Forms.Label();
            this.lbTicketTitle = new System.Windows.Forms.Label();
            this.tbTicketPrice = new System.Windows.Forms.TextBox();
            this.tbProblem = new System.Windows.Forms.TextBox();
            this.tbTicketTitle = new System.Windows.Forms.TextBox();
            this.dgvServiceTickets = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tc.SuspendLayout();
            this.tpGoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tpOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.tpClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.gbClientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.tpServiceTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.gbServiceTicketInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tpGoods);
            this.tc.Controls.Add(this.tpOrders);
            this.tc.Controls.Add(this.tpClients);
            this.tc.Controls.Add(this.tpServiceTickets);
            this.tc.Location = new System.Drawing.Point(0, 0);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(868, 363);
            this.tc.TabIndex = 0;
            this.tc.Selected += new System.Windows.Forms.TabControlEventHandler(this.tc_Selected);
            // 
            // tpGoods
            // 
            this.tpGoods.Controls.Add(this.splitContainer1);
            this.tpGoods.Location = new System.Drawing.Point(4, 22);
            this.tpGoods.Name = "tpGoods";
            this.tpGoods.Padding = new System.Windows.Forms.Padding(3);
            this.tpGoods.Size = new System.Drawing.Size(860, 337);
            this.tpGoods.TabIndex = 0;
            this.tpGoods.Text = "Товары";
            this.tpGoods.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbProductInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvProducts);
            this.splitContainer1.Size = new System.Drawing.Size(854, 331);
            this.splitContainer1.SplitterDistance = 284;
            this.splitContainer1.TabIndex = 1;
            // 
            // gbProductInfo
            // 
            this.gbProductInfo.Controls.Add(this.btnCancel1);
            this.gbProductInfo.Controls.Add(this.btnAddEdit1);
            this.gbProductInfo.Controls.Add(this.btnDelete1);
            this.gbProductInfo.Controls.Add(this.lbPrice);
            this.gbProductInfo.Controls.Add(this.lbCount);
            this.gbProductInfo.Controls.Add(this.lbProductTitle);
            this.gbProductInfo.Controls.Add(this.tbProductPrice);
            this.gbProductInfo.Controls.Add(this.tbProductCount);
            this.gbProductInfo.Controls.Add(this.tbProductTitle);
            this.gbProductInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProductInfo.Location = new System.Drawing.Point(0, 0);
            this.gbProductInfo.Name = "gbProductInfo";
            this.gbProductInfo.Size = new System.Drawing.Size(284, 331);
            this.gbProductInfo.TabIndex = 0;
            this.gbProductInfo.TabStop = false;
            this.gbProductInfo.Text = "Информация о товаре";
            // 
            // btnCancel1
            // 
            this.btnCancel1.Location = new System.Drawing.Point(9, 273);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(75, 23);
            this.btnCancel1.TabIndex = 6;
            this.btnCancel1.Text = "Отмена";
            this.btnCancel1.UseVisualStyleBackColor = true;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // btnAddEdit1
            // 
            this.btnAddEdit1.Location = new System.Drawing.Point(203, 274);
            this.btnAddEdit1.Name = "btnAddEdit1";
            this.btnAddEdit1.Size = new System.Drawing.Size(75, 23);
            this.btnAddEdit1.TabIndex = 3;
            this.btnAddEdit1.UseVisualStyleBackColor = true;
            // 
            // btnDelete1
            // 
            this.btnDelete1.Location = new System.Drawing.Point(122, 274);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(75, 23);
            this.btnDelete1.TabIndex = 4;
            this.btnDelete1.Text = "Удалить";
            this.btnDelete1.UseVisualStyleBackColor = true;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(6, 205);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(36, 13);
            this.lbPrice.TabIndex = 5;
            this.lbPrice.Text = "Цена:";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(6, 129);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(69, 13);
            this.lbCount.TabIndex = 4;
            this.lbCount.Text = "Количество:";
            // 
            // lbProductTitle
            // 
            this.lbProductTitle.AutoSize = true;
            this.lbProductTitle.Location = new System.Drawing.Point(6, 43);
            this.lbProductTitle.Name = "lbProductTitle";
            this.lbProductTitle.Size = new System.Drawing.Size(98, 13);
            this.lbProductTitle.TabIndex = 3;
            this.lbProductTitle.Text = "Название товара:";
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Location = new System.Drawing.Point(110, 202);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(168, 20);
            this.tbProductPrice.TabIndex = 2;
            // 
            // tbProductCount
            // 
            this.tbProductCount.Location = new System.Drawing.Point(110, 126);
            this.tbProductCount.Name = "tbProductCount";
            this.tbProductCount.Size = new System.Drawing.Size(168, 20);
            this.tbProductCount.TabIndex = 1;
            // 
            // tbProductTitle
            // 
            this.tbProductTitle.Location = new System.Drawing.Point(110, 40);
            this.tbProductTitle.Name = "tbProductTitle";
            this.tbProductTitle.Size = new System.Drawing.Size(168, 20);
            this.tbProductTitle.TabIndex = 0;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(566, 331);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // tpOrders
            // 
            this.tpOrders.Controls.Add(this.splitContainer2);
            this.tpOrders.Location = new System.Drawing.Point(4, 22);
            this.tpOrders.Name = "tpOrders";
            this.tpOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrders.Size = new System.Drawing.Size(860, 337);
            this.tpOrders.TabIndex = 1;
            this.tpOrders.Text = "Заказы";
            this.tpOrders.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gbOrderInfo);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvOrders);
            this.splitContainer2.Size = new System.Drawing.Size(854, 331);
            this.splitContainer2.SplitterDistance = 284;
            this.splitContainer2.TabIndex = 2;
            // 
            // gbOrderInfo
            // 
            this.gbOrderInfo.Controls.Add(this.btnCancel2);
            this.gbOrderInfo.Controls.Add(this.btnAddEdit2);
            this.gbOrderInfo.Controls.Add(this.btnDelete2);
            this.gbOrderInfo.Controls.Add(this.lbOrderPrice);
            this.gbOrderInfo.Controls.Add(this.lbClientID);
            this.gbOrderInfo.Controls.Add(this.lbProductID);
            this.gbOrderInfo.Controls.Add(this.tbOrderPrice);
            this.gbOrderInfo.Controls.Add(this.tbOrderClientID);
            this.gbOrderInfo.Controls.Add(this.tbOrderProductID);
            this.gbOrderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOrderInfo.Location = new System.Drawing.Point(0, 0);
            this.gbOrderInfo.Name = "gbOrderInfo";
            this.gbOrderInfo.Size = new System.Drawing.Size(284, 331);
            this.gbOrderInfo.TabIndex = 0;
            this.gbOrderInfo.TabStop = false;
            this.gbOrderInfo.Text = "Информация о заказе";
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(9, 273);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(75, 23);
            this.btnCancel2.TabIndex = 6;
            this.btnCancel2.Text = "Отмена";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnAddEdit2
            // 
            this.btnAddEdit2.Location = new System.Drawing.Point(203, 274);
            this.btnAddEdit2.Name = "btnAddEdit2";
            this.btnAddEdit2.Size = new System.Drawing.Size(75, 23);
            this.btnAddEdit2.TabIndex = 3;
            this.btnAddEdit2.UseVisualStyleBackColor = true;
            // 
            // btnDelete2
            // 
            this.btnDelete2.Location = new System.Drawing.Point(122, 274);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(75, 23);
            this.btnDelete2.TabIndex = 4;
            this.btnDelete2.Text = "Удалить";
            this.btnDelete2.UseVisualStyleBackColor = true;
            // 
            // lbOrderPrice
            // 
            this.lbOrderPrice.AutoSize = true;
            this.lbOrderPrice.Location = new System.Drawing.Point(6, 205);
            this.lbOrderPrice.Name = "lbOrderPrice";
            this.lbOrderPrice.Size = new System.Drawing.Size(75, 13);
            this.lbOrderPrice.TabIndex = 5;
            this.lbOrderPrice.Text = "Цена заказа:";
            // 
            // lbClientID
            // 
            this.lbClientID.AutoSize = true;
            this.lbClientID.Location = new System.Drawing.Point(6, 129);
            this.lbClientID.Name = "lbClientID";
            this.lbClientID.Size = new System.Drawing.Size(65, 13);
            this.lbClientID.TabIndex = 4;
            this.lbClientID.Text = "ID клиента:";
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(6, 43);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(59, 13);
            this.lbProductID.TabIndex = 3;
            this.lbProductID.Text = "ID товара:";
            // 
            // tbOrderPrice
            // 
            this.tbOrderPrice.Location = new System.Drawing.Point(110, 202);
            this.tbOrderPrice.Name = "tbOrderPrice";
            this.tbOrderPrice.Size = new System.Drawing.Size(168, 20);
            this.tbOrderPrice.TabIndex = 2;
            // 
            // tbOrderClientID
            // 
            this.tbOrderClientID.Location = new System.Drawing.Point(110, 126);
            this.tbOrderClientID.Name = "tbOrderClientID";
            this.tbOrderClientID.Size = new System.Drawing.Size(168, 20);
            this.tbOrderClientID.TabIndex = 1;
            // 
            // tbOrderProductID
            // 
            this.tbOrderProductID.Location = new System.Drawing.Point(110, 40);
            this.tbOrderProductID.Name = "tbOrderProductID";
            this.tbOrderProductID.Size = new System.Drawing.Size(168, 20);
            this.tbOrderProductID.TabIndex = 0;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(566, 331);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellClick);
            // 
            // tpClients
            // 
            this.tpClients.Controls.Add(this.splitContainer3);
            this.tpClients.Location = new System.Drawing.Point(4, 22);
            this.tpClients.Name = "tpClients";
            this.tpClients.Padding = new System.Windows.Forms.Padding(3);
            this.tpClients.Size = new System.Drawing.Size(860, 337);
            this.tpClients.TabIndex = 2;
            this.tpClients.Text = "Клиенты";
            this.tpClients.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.gbClientInfo);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dgvClients);
            this.splitContainer3.Size = new System.Drawing.Size(854, 331);
            this.splitContainer3.SplitterDistance = 284;
            this.splitContainer3.TabIndex = 3;
            // 
            // gbClientInfo
            // 
            this.gbClientInfo.Controls.Add(this.tbClientAdress);
            this.gbClientInfo.Controls.Add(this.lbAdress);
            this.gbClientInfo.Controls.Add(this.btnCancel3);
            this.gbClientInfo.Controls.Add(this.btnAddEdit3);
            this.gbClientInfo.Controls.Add(this.btnDelete3);
            this.gbClientInfo.Controls.Add(this.lbPhone);
            this.gbClientInfo.Controls.Add(this.lbDiscount);
            this.gbClientInfo.Controls.Add(this.lbClientName);
            this.gbClientInfo.Controls.Add(this.tbClientPhone);
            this.gbClientInfo.Controls.Add(this.tbClientDiscount);
            this.gbClientInfo.Controls.Add(this.tbClientName);
            this.gbClientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbClientInfo.Location = new System.Drawing.Point(0, 0);
            this.gbClientInfo.Name = "gbClientInfo";
            this.gbClientInfo.Size = new System.Drawing.Size(284, 331);
            this.gbClientInfo.TabIndex = 0;
            this.gbClientInfo.TabStop = false;
            this.gbClientInfo.Text = "Информация о клиенте";
            // 
            // tbClientAdress
            // 
            this.tbClientAdress.Location = new System.Drawing.Point(110, 80);
            this.tbClientAdress.Name = "tbClientAdress";
            this.tbClientAdress.Size = new System.Drawing.Size(168, 20);
            this.tbClientAdress.TabIndex = 8;
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Location = new System.Drawing.Point(9, 83);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(41, 13);
            this.lbAdress.TabIndex = 7;
            this.lbAdress.Text = "Адрес:";
            // 
            // btnCancel3
            // 
            this.btnCancel3.Location = new System.Drawing.Point(9, 273);
            this.btnCancel3.Name = "btnCancel3";
            this.btnCancel3.Size = new System.Drawing.Size(75, 23);
            this.btnCancel3.TabIndex = 6;
            this.btnCancel3.Text = "Отмена";
            this.btnCancel3.UseVisualStyleBackColor = true;
            this.btnCancel3.Click += new System.EventHandler(this.btnCancel3_Click);
            // 
            // btnAddEdit3
            // 
            this.btnAddEdit3.Location = new System.Drawing.Point(203, 274);
            this.btnAddEdit3.Name = "btnAddEdit3";
            this.btnAddEdit3.Size = new System.Drawing.Size(75, 23);
            this.btnAddEdit3.TabIndex = 3;
            this.btnAddEdit3.UseVisualStyleBackColor = true;
            // 
            // btnDelete3
            // 
            this.btnDelete3.Location = new System.Drawing.Point(122, 274);
            this.btnDelete3.Name = "btnDelete3";
            this.btnDelete3.Size = new System.Drawing.Size(75, 23);
            this.btnDelete3.TabIndex = 4;
            this.btnDelete3.Text = "Удалить";
            this.btnDelete3.UseVisualStyleBackColor = true;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(6, 183);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(55, 13);
            this.lbPhone.TabIndex = 5;
            this.lbPhone.Text = "Телефон:";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(6, 133);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(47, 13);
            this.lbDiscount.TabIndex = 4;
            this.lbDiscount.Text = "Скидка:";
            // 
            // lbClientName
            // 
            this.lbClientName.AutoSize = true;
            this.lbClientName.Location = new System.Drawing.Point(6, 33);
            this.lbClientName.Name = "lbClientName";
            this.lbClientName.Size = new System.Drawing.Size(76, 13);
            this.lbClientName.TabIndex = 3;
            this.lbClientName.Text = "Имя клиента:";
            // 
            // tbClientPhone
            // 
            this.tbClientPhone.Location = new System.Drawing.Point(110, 180);
            this.tbClientPhone.Name = "tbClientPhone";
            this.tbClientPhone.Size = new System.Drawing.Size(168, 20);
            this.tbClientPhone.TabIndex = 2;
            // 
            // tbClientDiscount
            // 
            this.tbClientDiscount.Location = new System.Drawing.Point(110, 130);
            this.tbClientDiscount.Name = "tbClientDiscount";
            this.tbClientDiscount.Size = new System.Drawing.Size(168, 20);
            this.tbClientDiscount.TabIndex = 1;
            // 
            // tbClientName
            // 
            this.tbClientName.Location = new System.Drawing.Point(110, 30);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(168, 20);
            this.tbClientName.TabIndex = 0;
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClients.Location = new System.Drawing.Point(0, 0);
            this.dgvClients.MultiSelect = false;
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersVisible = false;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(566, 331);
            this.dgvClients.TabIndex = 0;
            this.dgvClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellClick);
            // 
            // tpServiceTickets
            // 
            this.tpServiceTickets.Controls.Add(this.splitContainer4);
            this.tpServiceTickets.Location = new System.Drawing.Point(4, 22);
            this.tpServiceTickets.Name = "tpServiceTickets";
            this.tpServiceTickets.Padding = new System.Windows.Forms.Padding(3);
            this.tpServiceTickets.Size = new System.Drawing.Size(860, 337);
            this.tpServiceTickets.TabIndex = 3;
            this.tpServiceTickets.Text = "Обращения в сервис-центр";
            this.tpServiceTickets.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.gbServiceTicketInfo);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dgvServiceTickets);
            this.splitContainer4.Size = new System.Drawing.Size(854, 331);
            this.splitContainer4.SplitterDistance = 284;
            this.splitContainer4.TabIndex = 3;
            // 
            // gbServiceTicketInfo
            // 
            this.gbServiceTicketInfo.Controls.Add(this.tbTicketClientID);
            this.gbServiceTicketInfo.Controls.Add(this.lbTicketClientID);
            this.gbServiceTicketInfo.Controls.Add(this.btnCancel4);
            this.gbServiceTicketInfo.Controls.Add(this.btnAddEdit4);
            this.gbServiceTicketInfo.Controls.Add(this.btnDelete4);
            this.gbServiceTicketInfo.Controls.Add(this.lbTicketPrice);
            this.gbServiceTicketInfo.Controls.Add(this.lbProblem);
            this.gbServiceTicketInfo.Controls.Add(this.lbTicketTitle);
            this.gbServiceTicketInfo.Controls.Add(this.tbTicketPrice);
            this.gbServiceTicketInfo.Controls.Add(this.tbProblem);
            this.gbServiceTicketInfo.Controls.Add(this.tbTicketTitle);
            this.gbServiceTicketInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbServiceTicketInfo.Location = new System.Drawing.Point(0, 0);
            this.gbServiceTicketInfo.Name = "gbServiceTicketInfo";
            this.gbServiceTicketInfo.Size = new System.Drawing.Size(284, 331);
            this.gbServiceTicketInfo.TabIndex = 0;
            this.gbServiceTicketInfo.TabStop = false;
            this.gbServiceTicketInfo.Text = "Информация об обращении";
            // 
            // tbTicketClientID
            // 
            this.tbTicketClientID.Location = new System.Drawing.Point(122, 30);
            this.tbTicketClientID.Name = "tbTicketClientID";
            this.tbTicketClientID.Size = new System.Drawing.Size(155, 20);
            this.tbTicketClientID.TabIndex = 8;
            // 
            // lbTicketClientID
            // 
            this.lbTicketClientID.AutoSize = true;
            this.lbTicketClientID.Location = new System.Drawing.Point(9, 33);
            this.lbTicketClientID.Name = "lbTicketClientID";
            this.lbTicketClientID.Size = new System.Drawing.Size(65, 13);
            this.lbTicketClientID.TabIndex = 7;
            this.lbTicketClientID.Text = "ID клиента:";
            // 
            // btnCancel4
            // 
            this.btnCancel4.Location = new System.Drawing.Point(9, 273);
            this.btnCancel4.Name = "btnCancel4";
            this.btnCancel4.Size = new System.Drawing.Size(75, 23);
            this.btnCancel4.TabIndex = 6;
            this.btnCancel4.Text = "Отмена";
            this.btnCancel4.UseVisualStyleBackColor = true;
            this.btnCancel4.Click += new System.EventHandler(this.btnCancel4_Click);
            // 
            // btnAddEdit4
            // 
            this.btnAddEdit4.Location = new System.Drawing.Point(203, 274);
            this.btnAddEdit4.Name = "btnAddEdit4";
            this.btnAddEdit4.Size = new System.Drawing.Size(75, 23);
            this.btnAddEdit4.TabIndex = 3;
            this.btnAddEdit4.UseVisualStyleBackColor = true;
            // 
            // btnDelete4
            // 
            this.btnDelete4.Location = new System.Drawing.Point(122, 274);
            this.btnDelete4.Name = "btnDelete4";
            this.btnDelete4.Size = new System.Drawing.Size(75, 23);
            this.btnDelete4.TabIndex = 4;
            this.btnDelete4.Text = "Удалить";
            this.btnDelete4.UseVisualStyleBackColor = true;
            // 
            // lbTicketPrice
            // 
            this.lbTicketPrice.AutoSize = true;
            this.lbTicketPrice.Location = new System.Drawing.Point(6, 183);
            this.lbTicketPrice.Name = "lbTicketPrice";
            this.lbTicketPrice.Size = new System.Drawing.Size(80, 13);
            this.lbTicketPrice.TabIndex = 5;
            this.lbTicketPrice.Text = "Цена починки:";
            // 
            // lbProblem
            // 
            this.lbProblem.AutoSize = true;
            this.lbProblem.Location = new System.Drawing.Point(6, 133);
            this.lbProblem.Name = "lbProblem";
            this.lbProblem.Size = new System.Drawing.Size(115, 13);
            this.lbProblem.TabIndex = 4;
            this.lbProblem.Text = "Описание проблемы:";
            // 
            // lbTicketTitle
            // 
            this.lbTicketTitle.AutoSize = true;
            this.lbTicketTitle.Location = new System.Drawing.Point(5, 83);
            this.lbTicketTitle.Name = "lbTicketTitle";
            this.lbTicketTitle.Size = new System.Drawing.Size(60, 13);
            this.lbTicketTitle.TabIndex = 3;
            this.lbTicketTitle.Text = "Название:";
            // 
            // tbTicketPrice
            // 
            this.tbTicketPrice.Location = new System.Drawing.Point(122, 180);
            this.tbTicketPrice.Name = "tbTicketPrice";
            this.tbTicketPrice.Size = new System.Drawing.Size(156, 20);
            this.tbTicketPrice.TabIndex = 2;
            // 
            // tbProblem
            // 
            this.tbProblem.Location = new System.Drawing.Point(122, 130);
            this.tbProblem.Name = "tbProblem";
            this.tbProblem.Size = new System.Drawing.Size(156, 20);
            this.tbProblem.TabIndex = 1;
            // 
            // tbTicketTitle
            // 
            this.tbTicketTitle.Location = new System.Drawing.Point(122, 80);
            this.tbTicketTitle.Name = "tbTicketTitle";
            this.tbTicketTitle.Size = new System.Drawing.Size(156, 20);
            this.tbTicketTitle.TabIndex = 0;
            // 
            // dgvServiceTickets
            // 
            this.dgvServiceTickets.AllowUserToAddRows = false;
            this.dgvServiceTickets.AllowUserToDeleteRows = false;
            this.dgvServiceTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServiceTickets.Location = new System.Drawing.Point(0, 0);
            this.dgvServiceTickets.MultiSelect = false;
            this.dgvServiceTickets.Name = "dgvServiceTickets";
            this.dgvServiceTickets.ReadOnly = true;
            this.dgvServiceTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServiceTickets.Size = new System.Drawing.Size(566, 331);
            this.dgvServiceTickets.TabIndex = 0;
            this.dgvServiceTickets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceTickets_CellClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(12, 369);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(148, 20);
            this.tbSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(166, 366);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 398);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.tc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "RCShop";
            this.Load += new System.EventHandler(this.RCShop_Load);
            this.tc.ResumeLayout(false);
            this.tpGoods.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbProductInfo.ResumeLayout(false);
            this.gbProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tpOrders.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbOrderInfo.ResumeLayout(false);
            this.gbOrderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.tpClients.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.gbClientInfo.ResumeLayout(false);
            this.gbClientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.tpServiceTickets.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.gbServiceTicketInfo.ResumeLayout(false);
            this.gbServiceTicketInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tpGoods;
        private System.Windows.Forms.TabPage tpOrders;
        private System.Windows.Forms.TabPage tpClients;
        private System.Windows.Forms.TabPage tpServiceTickets;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddEdit1;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbProductInfo;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label lbProductTitle;
        private System.Windows.Forms.TextBox tbProductPrice;
        private System.Windows.Forms.TextBox tbProductCount;
        private System.Windows.Forms.TextBox tbProductTitle;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox gbOrderInfo;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnAddEdit2;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Label lbOrderPrice;
        private System.Windows.Forms.Label lbClientID;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.TextBox tbOrderPrice;
        private System.Windows.Forms.TextBox tbOrderClientID;
        private System.Windows.Forms.TextBox tbOrderProductID;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox gbClientInfo;
        private System.Windows.Forms.Button btnCancel3;
        private System.Windows.Forms.Button btnAddEdit3;
        private System.Windows.Forms.Button btnDelete3;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbClientName;
        private System.Windows.Forms.TextBox tbClientPhone;
        private System.Windows.Forms.TextBox tbClientDiscount;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.TextBox tbClientAdress;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox gbServiceTicketInfo;
        private System.Windows.Forms.Button btnCancel4;
        private System.Windows.Forms.Button btnAddEdit4;
        private System.Windows.Forms.Button btnDelete4;
        private System.Windows.Forms.Label lbTicketPrice;
        private System.Windows.Forms.Label lbProblem;
        private System.Windows.Forms.Label lbTicketTitle;
        private System.Windows.Forms.TextBox tbTicketPrice;
        private System.Windows.Forms.TextBox tbProblem;
        private System.Windows.Forms.TextBox tbTicketTitle;
        private System.Windows.Forms.DataGridView dgvServiceTickets;
        private System.Windows.Forms.TextBox tbTicketClientID;
        private System.Windows.Forms.Label lbTicketClientID;
    }
}


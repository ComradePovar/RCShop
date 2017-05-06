using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using RCShop.DB.Entities;
using LiteDB;

namespace RCShop
{
    public partial class MainForm : Form
    {
        enum DataGridViewTab { Products, Orders, Clients, ServiceCenter };
        private Service service;

        private Client currentClientInfo;
        private Order currentOrderInfo;
        private Product currentProductInfo;
        private ServiceTicket currentServiceTicketInfo;

        public MainForm()
        {
            InitializeComponent();
            service = Service.GetInstance();
            service.ClientRepository.Add(new Client()
            {
                Name = "abcdef",
                Adress = "123",
                Phone = "1234567",
                Discount = 10
            });
            //service.OrderRepository.Add(new Order()
            //{
            //    ClientID = 1,
            //    Price = 200,
            //    ProductID = 1
            //});
            //service.ProductRepository.Add(new Product()
            //{
            //    Title = "abc",
            //    Count = 5,
            //    Price = 100
            //});
            //service.ServiceCenterOrderRepository.Add(new ServiceTicket()
            //{
            //    ClientID = 1,
            //    Price = 200,
            //    Problem = "debil",
            //    Title = "abc",
            //});
            RefreshDataGridView(DataGridViewTab.Clients);
            RefreshDataGridView(DataGridViewTab.Orders);
            RefreshDataGridView(DataGridViewTab.Products);
            RefreshDataGridView(DataGridViewTab.ServiceCenter);
        }

        private void RCShop_Load(object sender, EventArgs e)
        {
        }

        private void tc_Selected(object sender, TabControlEventArgs e)
        {
            switch ((DataGridViewTab)e.TabPageIndex)
            {
                case DataGridViewTab.Products:
                    break;
                case DataGridViewTab.Orders:
                    break;
                case DataGridViewTab.Clients:
                    break;
                case DataGridViewTab.ServiceCenter:
                    break;
            }
        }

        private void RefreshDataGridView(DataGridViewTab tab)
        {
            switch (tab)
            {
                case DataGridViewTab.Products:
                    var products = new BindingList<Product>(service.ProductRepository.GetAll());
                    dgvProducts.DataSource = new BindingSource(products, null);
                    break;
                case DataGridViewTab.Clients:
                    var clients = new BindingList<Client>(service.ClientRepository.GetAll());
                    dgvClients.DataSource = new BindingSource(clients, null);
                    break;
                case DataGridViewTab.Orders:
                    var orders = new BindingList<Order>(service.OrderRepository.GetAll());
                    dgvOrders.DataSource = new BindingSource(orders, null);
                    break;
                case DataGridViewTab.ServiceCenter:
                    var serviceCenterOrders = new BindingList<ServiceTicket>(service.ServiceCenterOrderRepository.GetAll());
                    dgvServiceTickets.DataSource = new BindingSource(serviceCenterOrders, null);
                    break;
            }
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            tbProductTitle.Text = currentProductInfo.Title;
            tbProductCount.Text = currentProductInfo.Count.ToString();
            tbProductPrice.Text = Math.Round(currentProductInfo.Price, 2).ToString();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            tbOrderProductID.Text = currentOrderInfo.ProductID.ToString();
            tbOrderClientID.Text = currentOrderInfo.ClientID.ToString();
            tbOrderPrice.Text = Math.Round(currentOrderInfo.Price, 2).ToString();
        }

        private void btnCancel3_Click(object sender, EventArgs e)
        {
            tbClientName.Text = currentClientInfo.Name;
            tbClientAdress.Text = currentClientInfo.Adress;
            tbClientDiscount.Text = Math.Round(currentClientInfo.Discount, 2).ToString();
            tbClientPhone.Text = currentClientInfo.Phone;
        }

        private void btnCancel4_Click(object sender, EventArgs e)
        {
            tbTicketClientID.Text = currentServiceTicketInfo.ClientID.ToString();
            tbTicketTitle.Text = currentServiceTicketInfo.Title;
            tbProblem.Text = currentServiceTicketInfo.Problem;
            tbTicketPrice.Text = Math.Round(currentServiceTicketInfo.Price, 2).ToString();
        }
        
        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((sender as DataGridView).SelectedRows[0].Cells[0].Value.ToString() == currentClientInfo?.ID.ToString())
            {
                currentClientInfo = new Client()
                {
                    ID = default(int),
                    Name = default(string),
                    Adress = default(string),
                    Discount = default(decimal)
                };
                btnAddEdit3.Text = "Добавить";
                dgvClients.ClearSelection();
            }
            else
            {
                var row = (sender as DataGridView).SelectedRows[0];
                currentClientInfo = new Client()
                {
                    ID = int.Parse(row.Cells[0].Value.ToString()),
                    Name = row.Cells[1].Value.ToString(),
                    Adress = row.Cells[2].Value.ToString(),
                    Phone = row.Cells[3].Value.ToString(),
                    Discount = decimal.Parse(row.Cells[4].Value.ToString())
                };
                btnAddEdit3.Text = "Обновить";
            }

            tbClientName.Text = currentClientInfo.Name;
            tbClientAdress.Text = currentClientInfo.Adress;
            tbClientPhone.Text = currentClientInfo.Phone;
            tbClientDiscount.Text = currentClientInfo.Discount.ToString();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((sender as DataGridView).SelectedRows[0].Cells[0].Value.ToString() == currentProductInfo?.ID.ToString())
            {
                currentProductInfo = new Product()
                {
                    ID = default(int),
                    Title = default(string),
                    Count = default(int),
                    Price = default(decimal)
                };
                btnAddEdit1.Text = "Добавить";
                dgvProducts.ClearSelection();
            }
            else
            {
                var row = (sender as DataGridView).SelectedRows[0];
                currentProductInfo = new Product()
                {
                    ID = int.Parse(row.Cells[0].Value.ToString()),
                    Title = row.Cells[1].Value.ToString(),
                    Count = int.Parse(row.Cells[2].Value.ToString()),
                    Price = decimal.Parse(row.Cells[3].Value.ToString())
                };
                btnAddEdit1.Text = "Обновить";
            }

            tbProductTitle.Text = currentProductInfo.Title;
            tbProductCount.Text = currentProductInfo.Count.ToString();
            tbProductPrice.Text = Math.Round(currentProductInfo.Price, 2).ToString();
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((sender as DataGridView).SelectedRows[0].Cells[0].Value.ToString() == currentOrderInfo?.ID.ToString())
            {
                currentOrderInfo = new Order()
                {
                    ID = default(int),
                    ProductID = default(int),
                    ClientID = default(int),
                    Price = default(decimal)
                };
                btnAddEdit2.Text = "Добавить";
                dgvOrders.ClearSelection();
            }
            else
            {
                var row = (sender as DataGridView).SelectedRows[0];
                currentOrderInfo = new Order()
                {
                    ID = int.Parse(row.Cells[0].Value.ToString()),
                    ProductID = int.Parse(row.Cells[1].Value.ToString()),
                    ClientID = int.Parse(row.Cells[2].Value.ToString()),
                    Price = decimal.Parse(row.Cells[3].Value.ToString())
                };
                btnAddEdit2.Text = "Обновить";
            }

            tbOrderProductID.Text = currentOrderInfo.ProductID.ToString();
            tbOrderClientID.Text = currentOrderInfo.ClientID.ToString();
            tbOrderPrice.Text = Math.Round(currentOrderInfo.Price, 2).ToString();
        }

        private void dgvServiceTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((sender as DataGridView).SelectedRows[0].Cells[0].Value.ToString() == currentServiceTicketInfo?.ID.ToString())
            {
                currentServiceTicketInfo = new ServiceTicket()
                {
                    ID = default(int),
                    ClientID = default(int),
                    Title = default(string),
                    Problem = default(string),
                    Price = default(decimal)
                };
                btnAddEdit4.Text = "Добавить";
                dgvServiceTickets.ClearSelection();
            }
            else
            {
                var row = (sender as DataGridView).SelectedRows[0];
                currentServiceTicketInfo = new ServiceTicket()
                {
                    ID = int.Parse(row.Cells[0].Value.ToString()),
                    ClientID = int.Parse(row.Cells[1].Value.ToString()),
                    Title = row.Cells[2].Value.ToString(),
                    Problem = row.Cells[3].Value.ToString(),
                    Price = decimal.Parse(row.Cells[4].Value.ToString())
                };
                btnAddEdit4.Text = "Обновить";
            }

            tbTicketClientID.Text = currentServiceTicketInfo.ClientID.ToString();
            tbTicketTitle.Text = currentServiceTicketInfo.Title;
            tbProblem.Text = currentServiceTicketInfo.Problem;
            tbTicketPrice.Text = Math.Round(currentServiceTicketInfo.Price, 2).ToString();
        }
    }
}

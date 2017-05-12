using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using RCShop.DB.Entities;
using LiteDB;

namespace RCShop
{
    public partial class MainForm : Form
    {
        enum DataGridViewTab { Products, Orders, Clients, ServiceTicket };
        private Service service;

        private Regex moneyFormat = new Regex(@"^\d+(.\d{1,2})?$");
        private Regex idFormat = new Regex(@"^\d+$");
        private Client currentClientInfo;
        private Order currentOrderInfo;
        private Product currentProductInfo;
        private ServiceTicket currentServiceTicketInfo;

        public MainForm()
        {
            InitializeComponent();
            service = Service.GetInstance();

        }

        private void RCShop_Load(object sender, EventArgs e)
        {
            btnDelete1.Visible = false;
            btnDelete2.Visible = false;
            btnDelete3.Visible = false;
            btnDelete4.Visible = false;

            btnAddEdit1.Text = "Добавить";
            btnAddEdit2.Text = "Добавить";
            btnAddEdit3.Text = "Добавить";
            btnAddEdit4.Text = "Добавить";

            currentProductInfo = new Product();
            currentOrderInfo = new Order();
            currentClientInfo = new Client();
            currentServiceTicketInfo = new ServiceTicket();

            RefreshDataGridView(DataGridViewTab.Clients);
            RefreshDataGridView(DataGridViewTab.Orders);
            RefreshDataGridView(DataGridViewTab.Products);
            RefreshDataGridView(DataGridViewTab.ServiceTicket);

        }

        private void RefreshDataGridView(DataGridViewTab tab)
        {
            switch (tab)
            {
                case DataGridViewTab.Products:
                    var products = new BindingList<Product>(service.ProductRepository.Search(tbSearch.Text));
                    dgvProducts.DataSource = new BindingSource(products, null);
                    break;
                case DataGridViewTab.Clients:
                    var clients = new BindingList<Client>(service.ClientRepository.Search(tbSearch.Text));
                    dgvClients.DataSource = new BindingSource(clients, null);
                    break;
                case DataGridViewTab.Orders:
                    var orders = new BindingList<Order>(service.OrderRepository.Search(tbSearch.Text));
                    dgvOrders.DataSource = new BindingSource(orders, null);
                    break;
                case DataGridViewTab.ServiceTicket:
                    var serviceTickets = new BindingList<ServiceTicket>(service.ServiceTicketRepository.Search(tbSearch.Text));
                    dgvServiceTickets.DataSource = new BindingSource(serviceTickets, null);
                    break;
            }
            ClearSelection(tab);
            SetEntityInformation(true);
            SetRowHeadersSettings(tab);
        }

        private void SetRowHeadersSettings(DataGridViewTab tab)
        {
            switch (tab)
            {
                case DataGridViewTab.Products:
                    dgvProducts.Columns[0].HeaderCell.Value = "ID";
                    dgvProducts.Columns[1].HeaderCell.Value = "Название товара";
                    dgvProducts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvProducts.Columns[2].HeaderCell.Value = "Количество";
                    dgvProducts.Columns[3].HeaderCell.Value = "Цена";
                    break;
                case DataGridViewTab.Orders:
                    dgvOrders.Columns[0].HeaderCell.Value = "ID";
                    dgvOrders.Columns[1].HeaderCell.Value = "ID товара";
                    dgvOrders.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvOrders.Columns[2].HeaderCell.Value = "ID клиента";
                    dgvOrders.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvOrders.Columns[3].HeaderCell.Value = "Цена заказа";
                    break;
                case DataGridViewTab.Clients:
                    dgvClients.Columns[0].HeaderCell.Value = "ID";
                    dgvClients.Columns[1].HeaderCell.Value = "Имя клиента";
                    dgvClients.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvClients.Columns[2].HeaderCell.Value = "Адрес";
                    dgvClients.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvClients.Columns[3].HeaderCell.Value = "Телефон";
                    dgvClients.Columns[4].HeaderCell.Value = "Скидка";
                    break;
                case DataGridViewTab.ServiceTicket:
                    dgvServiceTickets.Columns[0].HeaderCell.Value = "ID";
                    dgvServiceTickets.Columns[1].HeaderCell.Value = "ID клиента";
                    dgvServiceTickets.Columns[2].HeaderCell.Value = "Название";
                    dgvServiceTickets.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvServiceTickets.Columns[3].HeaderCell.Value = "Описание проблемы";
                    dgvServiceTickets.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvServiceTickets.Columns[4].HeaderCell.Value = "Цена починки";
                    break;
            }
        }

        private void ClearSelection(DataGridViewTab tab)
        {
            switch (tab)
            {
                case DataGridViewTab.Products:
                    dgvProducts.ClearSelection();
                    currentProductInfo = new Product();
                    break;
                case DataGridViewTab.Orders:
                    dgvOrders.ClearSelection();
                    currentOrderInfo = new Order();
                    break;
                case DataGridViewTab.Clients:
                    dgvClients.ClearSelection();
                    currentClientInfo = new Client();
                    break;
                case DataGridViewTab.ServiceTicket:
                    dgvServiceTickets.ClearSelection();
                    currentServiceTicketInfo = new ServiceTicket();
                    break;
            }
        }

        private void SetEntityInformation(bool isAdd)
        {
            switch ((DataGridViewTab)tc.SelectedIndex)
            {
                case DataGridViewTab.Products:
                    btnAddEdit1.Text = isAdd ? "Добавить" : "Обновить";
                    btnDelete1.Visible = isAdd ? false : true;
                    tbProductTitle.Text = currentProductInfo.Title;
                    tbProductCount.Text = currentProductInfo.Count.ToString();
                    tbProductPrice.Text = Math.Round(currentProductInfo.Price, 2).ToString();
                    break;
                case DataGridViewTab.Orders:
                    btnAddEdit2.Text = isAdd ? "Добавить" : "Обновить";
                    btnDelete2.Visible = isAdd ? false : true;
                    lbOrderShippingPrice.Text = isAdd ? "Цена доставки:" : "Цена заказа:";
                    tbOrderProductID.Text = currentOrderInfo.ProductID.ToString();
                    tbOrderClientID.Text = currentOrderInfo.ClientID.ToString();
                    tbOrderShippingPrice.Text = Math.Round(currentOrderInfo.Price, 2).ToString();
                    break;
                case DataGridViewTab.Clients:
                    btnAddEdit3.Text = isAdd ? "Добавить" : "Обновить";
                    btnDelete3.Visible = isAdd ? false : true;
                    tbClientName.Text = currentClientInfo.Name;
                    tbClientAdress.Text = currentClientInfo.Adress;
                    mtbClientPhone.Text = currentClientInfo.Phone;
                    tbClientDiscount.Text = currentClientInfo.Discount.ToString();
                    break;
                case DataGridViewTab.ServiceTicket:
                    btnAddEdit4.Text = isAdd ? "Добавить" : "Обновить";
                    btnDelete4.Visible = isAdd ? false : true;
                    tbTicketClientID.Text = currentServiceTicketInfo.ClientID.ToString();
                    tbTicketTitle.Text = currentServiceTicketInfo.Title;
                    tbProblem.Text = currentServiceTicketInfo.Problem;
                    tbTicketPrice.Text = Math.Round(currentServiceTicketInfo.Price, 2).ToString();
                    break;
            }
        }

        /*
         * Button Cancel Click
         * */

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
            tbOrderShippingPrice.Text = Math.Round(currentOrderInfo.Price, 2).ToString();
        }

        private void btnCancel3_Click(object sender, EventArgs e)
        {
            tbClientName.Text = currentClientInfo.Name;
            tbClientAdress.Text = currentClientInfo.Adress;
            tbClientDiscount.Text = Math.Round(currentClientInfo.Discount, 2).ToString();
            mtbClientPhone.Text = currentClientInfo.Phone;
        }

        private void btnCancel4_Click(object sender, EventArgs e)
        {
            tbTicketClientID.Text = currentServiceTicketInfo.ClientID.ToString();
            tbTicketTitle.Text = currentServiceTicketInfo.Title;
            tbProblem.Text = currentServiceTicketInfo.Problem;
            tbTicketPrice.Text = Math.Round(currentServiceTicketInfo.Price, 2).ToString();
        }

        /*
         * DataGridView Cell Click
         * */

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((sender as DataGridView).SelectedRows[0].Cells[0].Value.ToString() == currentProductInfo?.ID.ToString())
            {
                ClearSelection(DataGridViewTab.Products);
                SetEntityInformation(true);
            }
            else
            {
                var row = (sender as DataGridView).SelectedRows[0];
                currentProductInfo = new Product()
                {
                    ID = int.Parse(row.Cells[0].Value.ToString()),
                    Title = row.Cells[1].Value.ToString(),
                    Count = int.Parse(row.Cells[2].Value.ToString()),
                    Price = double.Parse(row.Cells[3].Value.ToString())
                };
                SetEntityInformation(false);
            }
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((sender as DataGridView).SelectedRows[0].Cells[0].Value.ToString() == currentOrderInfo?.ID.ToString())
            {
                ClearSelection(DataGridViewTab.Orders);
                SetEntityInformation(true);
            }
            else
            {
                var row = (sender as DataGridView).SelectedRows[0];
                currentOrderInfo = new Order()
                {
                    ID = int.Parse(row.Cells[0].Value.ToString()),
                    ProductID = int.Parse(row.Cells[1].Value.ToString()),
                    ClientID = int.Parse(row.Cells[2].Value.ToString()),
                    Price = double.Parse(row.Cells[3].Value.ToString())
                };
                SetEntityInformation(false);
            }
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((sender as DataGridView).SelectedRows[0].Cells[0].Value.ToString() == currentClientInfo?.ID.ToString())
            {
                ClearSelection(DataGridViewTab.Clients);
                SetEntityInformation(true);
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
                    Discount = double.Parse(row.Cells[4].Value.ToString())
                };
                SetEntityInformation(false);
            }
        }

        private void dgvServiceTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((sender as DataGridView).SelectedRows[0].Cells[0].Value.ToString() == currentServiceTicketInfo?.ID.ToString())
            {
                ClearSelection(DataGridViewTab.ServiceTicket);
                SetEntityInformation(true);
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
                    Price = double.Parse(row.Cells[4].Value.ToString())
                };
                SetEntityInformation(false);
            }
        }

        /*
         * Button Delete Click
         * */

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvProducts.SelectedRows[0].Cells[0].Value.ToString());
            service.ProductRepository.Delete(id);
            RefreshDataGridView(DataGridViewTab.Products);
            ClearSelection(DataGridViewTab.Products);
            SetEntityInformation(true);
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvOrders.SelectedRows[0].Cells[0].Value.ToString());
            service.OrderRepository.Delete(id);
            RefreshDataGridView(DataGridViewTab.Orders);
            ClearSelection(DataGridViewTab.Orders);
            SetEntityInformation(true);
        }

        private void btnDelete3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvClients.SelectedRows[0].Cells[0].Value.ToString());
            service.ClientRepository.Delete(id);
            RefreshDataGridView(DataGridViewTab.Clients);
            ClearSelection(DataGridViewTab.Clients);
            SetEntityInformation(true);
        }

        private void btnDelete4_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvServiceTickets.SelectedRows[0].Cells[0].Value.ToString());
            service.ServiceTicketRepository.Delete(id);
            RefreshDataGridView(DataGridViewTab.ServiceTicket);
            ClearSelection(DataGridViewTab.ServiceTicket);
            SetEntityInformation(true);
        }

        /*
         * Button AddEdit Click
         * */

        private void btnAddEdit1_Click(object sender, EventArgs e)
        {
            currentProductInfo = new Product()
            {
                Title = tbProductTitle.Text,
                Count = int.Parse(tbProductCount.Text),
                Price = double.Parse(tbProductPrice.Text)
            };

            if (btnAddEdit1.Text == "Добавить")
            {
                service.ProductRepository.Add(currentProductInfo);
            }
            else
            {
                currentProductInfo.ID = int.Parse(dgvProducts.SelectedRows[0].Cells[0].Value.ToString());
                service.ProductRepository.Update(currentProductInfo);
            }
            RefreshDataGridView(DataGridViewTab.Products);
            ClearSelection(DataGridViewTab.Products);
            SetEntityInformation(true);
        }

        private void btnAddEdit2_Click(object sender, EventArgs e)
        {
            currentOrderInfo = new Order()
            {
                ProductID = int.Parse(tbOrderProductID.Text),
                ClientID = int.Parse(tbOrderClientID.Text)
            };

            if (btnAddEdit2.Text == "Добавить")
            {
                var product = service.ProductRepository.Get(currentOrderInfo.ProductID);
                var client = service.ClientRepository.Get(currentOrderInfo.ClientID);
                if (client == null)
                {
                    MessageBox.Show("Клиента с таким ID не существует.");
                    return;
                }
                if (product == null)
                {
                    MessageBox.Show("Товара с таким ID не существует.");
                    return;
                }
                if (product.Count > 0)
                {
                    product.Count--;

                    currentOrderInfo.Price = Math.Round(double.Parse(tbOrderShippingPrice.Text) +
                                                product.Price * (100.0 - client.Discount) / 100, 2);
                    service.OrderRepository.Add(currentOrderInfo);
                    service.ProductRepository.Update(product);
                    RefreshDataGridView(DataGridViewTab.Products);
                }
                else
                {
                    MessageBox.Show("Товар отсутствует.");
                    return;
                }
            }
            else
            {
                currentOrderInfo.ID = int.Parse(dgvOrders.SelectedRows[0].Cells[0].Value.ToString());
                currentOrderInfo.Price = double.Parse(tbOrderShippingPrice.Text);
                service.OrderRepository.Update(currentOrderInfo);
            }
            RefreshDataGridView(DataGridViewTab.Orders);
            ClearSelection(DataGridViewTab.Orders);
            SetEntityInformation(true);
        }

        private void btnAddEdit3_Click(object sender, EventArgs e)
        {
            currentClientInfo = new Client()
            {
                Name = tbClientName.Text,
                Adress = tbClientAdress.Text,
                Phone = mtbClientPhone.Text,
                Discount = double.Parse(tbClientDiscount.Text)
            };

            if (btnAddEdit3.Text == "Добавить")
            {
                service.ClientRepository.Add(currentClientInfo);
            }
            else
            {
                currentClientInfo.ID = int.Parse(dgvClients.SelectedRows[0].Cells[0].Value.ToString());
                service.ClientRepository.Update(currentClientInfo);
            }
            RefreshDataGridView(DataGridViewTab.Clients);
            ClearSelection(DataGridViewTab.Clients);
            SetEntityInformation(true);
        }

        private void btnAddEdit4_Click(object sender, EventArgs e)
        {
            currentServiceTicketInfo = new ServiceTicket()
            {
                ClientID = int.Parse(tbTicketClientID.Text),
                Title = tbTicketTitle.Text,
                Problem = tbProblem.Text
            };

            if (btnAddEdit4.Text == "Добавить")
            {
                var client = service.ClientRepository.Get(currentServiceTicketInfo.ClientID);
                if (client == null)
                {
                    MessageBox.Show("Клиента с таким ID не существует.");
                    return;
                }
                currentServiceTicketInfo.Price = Math.Round(double.Parse(tbTicketPrice.Text) * (100.0 - client.Discount) / 100, 2);

                service.ServiceTicketRepository.Add(currentServiceTicketInfo);
            }
            else
            {
                currentServiceTicketInfo.ID = int.Parse(dgvServiceTickets.SelectedRows[0].Cells[0].Value.ToString());
                currentServiceTicketInfo.Price = double.Parse(tbTicketPrice.Text);
                service.ServiceTicketRepository.Update(currentServiceTicketInfo);
            }
            RefreshDataGridView(DataGridViewTab.ServiceTicket);
            ClearSelection(DataGridViewTab.ServiceTicket);
            SetEntityInformation(true);
        }

        /*
         * Search
         * */

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshDataGridView((DataGridViewTab)tc.SelectedIndex);
        }

        /*
         * Validation
         * */

        private void tbProductPrice_TextChanged(object sender, EventArgs e)
        {
            if (!moneyFormat.IsMatch(tbProductPrice.Text) && tbProductPrice.Text != "")
            {
                btnAddEdit1.Enabled = false;
                MessageBox.Show("Некорректное значение цены товара.");
            }
            else
            {
                btnAddEdit1.Enabled = true;
            }
        }


        private void tbOrderProductID_TextChanged(object sender, EventArgs e)
        {
            if (!idFormat.IsMatch(tbOrderProductID.Text) && tbOrderProductID.Text != "")
            {
                btnAddEdit2.Enabled = false;
            }
            else
            {
                btnAddEdit2.Enabled = true;
            }
        }

        private void tbOrderClientID_TextChanged(object sender, EventArgs e)
        {
            if (!idFormat.IsMatch(tbOrderClientID.Text) && tbOrderClientID.Text != "")
            {
                btnAddEdit2.Enabled = false;
            }
            else
            {
                btnAddEdit2.Enabled = true;
            }
        }

        private void tbOrderShippingPrice_TextChanged(object sender, EventArgs e)
        {
            if (!moneyFormat.IsMatch(tbOrderShippingPrice.Text) && tbOrderShippingPrice.Text != "")
            {
                btnAddEdit2.Enabled = false;
            }
            else
            {
                btnAddEdit2.Enabled = true;
            }
        }

        private void tbClientDiscount_TextChanged(object sender, EventArgs e)
        {
            if (!moneyFormat.IsMatch(tbClientDiscount.Text) && tbClientDiscount.Text != "")
            {
                btnAddEdit3.Enabled = false;
            }
            else
            {
                btnAddEdit3.Enabled = true;
            }
        }

        private void tbTicketClientID_TextChanged(object sender, EventArgs e)
        {
            if (!idFormat.IsMatch(tbTicketClientID.Text) && tbTicketClientID.Text != "")
            {
                btnAddEdit4.Enabled = false;
            }
            else
            {
                btnAddEdit4.Enabled = true;
            }
        }

        private void tbTicketPrice_TextChanged(object sender, EventArgs e)
        {
            if (!moneyFormat.IsMatch(tbTicketPrice.Text) && tbTicketPrice.Text != "")
            {
                btnAddEdit4.Enabled = false;
            }
            else
            {
                btnAddEdit4.Enabled = true;
            }
        }
    }
}

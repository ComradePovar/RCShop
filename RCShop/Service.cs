using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.ComponentModel;
using RCShop.DB.Repositories;
using RCShop.Interfaces;
using RCShop.DB.Entities;


namespace RCShop
{
    class Service
    {
        private static readonly Service instance = new Service();

        public IRepository<Client> ClientRepository { get; }
        public IRepository<Order> OrderRepository { get; }
        public IRepository<Product> ProductRepository { get; }
        public IRepository<ServiceTicket> ServiceCenterOrderRepository { get; }

        private Service()
        {
            ClientRepository = new ClientRepository(ConfigurationManager.AppSettings["dbPath"]);
            OrderRepository = new OrderRepository(ConfigurationManager.AppSettings["dbPath"]);
            ProductRepository = new ProductRepository(ConfigurationManager.AppSettings["dbPath"]);
            ServiceCenterOrderRepository = new ServiceTicketRepository(ConfigurationManager.AppSettings["dbPath"]);
        }

        public static Service GetInstance()
        {
            return instance;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCShop.DB.Entities;
using RCShop.Interfaces;
using LiteDB;

namespace RCShop.DB.Repositories
{
    public class ServiceTicketRepository : IRepository<ServiceTicket>
    {
        private string dbPath;

        public ServiceTicketRepository(string dbPath)
        {
            this.dbPath = dbPath;
        }

        public void EnsureIndex(LiteCollection<ServiceTicket> collection)
        {
            collection.EnsureIndex(x => x.ID);
            collection.EnsureIndex(x => x.ClientID);
            collection.EnsureIndex(x => x.Title);
            collection.EnsureIndex(x => x.Problem);
            collection.EnsureIndex(x => x.Price);
        }

        public void Add(ServiceTicket item)
        {
            using (var db = new LiteDatabase(dbPath))
            {
                var serviceCenterOrders = db.GetCollection<ServiceTicket>("ServiceCenterTickets");
                serviceCenterOrders.Insert(item);

                EnsureIndex(serviceCenterOrders);
            }
        }

        public void Delete(int id)
        {
            using (var db = new LiteDatabase(dbPath))
            {
                var serviceCenterOrders = db.GetCollection<ServiceTicket>("ServiceCenterTickets");
                serviceCenterOrders.Delete(id);
            }
        }

        public void Update(ServiceTicket item)
        {
            using (var db = new LiteDatabase(dbPath))
            {
                var serviceCenterOrders = db.GetCollection<ServiceTicket>("ServiceCenterTickets");
                serviceCenterOrders.Update(item);
            }
        }

        public IList<ServiceTicket> GetAll()
        {
            var serviceCenterOrders = new List<ServiceTicket>();
            using (var db = new LiteDatabase(dbPath))
            {
                serviceCenterOrders.AddRange(db.GetCollection<ServiceTicket>("ServiceCenterTickets").FindAll());
            }
            return serviceCenterOrders;
        }

        public IList<ServiceTicket> Search(string query)
        {
            return GetAll()
                .Where(x =>
                    x.ID.ToString().Contains(query) ||
                    x.ClientID.ToString().Contains(query) ||
                    x.Title.Contains(query) ||
                    x.Problem.Contains(query) ||
                    x.Price.ToString().Contains(query))
                .OrderBy(x => x.ID)
                .ToList();
        }

        public ServiceTicket Get(int id)
        {
            using (var db = new LiteDatabase(dbPath))
            {
                return db.GetCollection<ServiceTicket>("ServiceCenterTickets").FindById(id);
            }
        }
    }
}

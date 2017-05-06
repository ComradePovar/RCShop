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
        }

        public void Add(ServiceTicket item)
        {
            using (var db = new LiteDatabase(dbPath))
            {
                var serviceCenterOrders = db.GetCollection<ServiceTicket>("ServiceCenterOrders");
                serviceCenterOrders.Insert(item);

                EnsureIndex(serviceCenterOrders);
            }
        }

        public void Delete(int id)
        {
            using (var db = new LiteDatabase(dbPath))
            {
                var serviceCenterOrders = db.GetCollection<ServiceTicket>("ServiceCenterOrders");
                serviceCenterOrders.Delete(id);
            }
        }

        public void Update(ServiceTicket item)
        {
            using (var db = new LiteDatabase(dbPath))
            {
                var serviceCenterOrders = db.GetCollection<ServiceTicket>("ServiceCenterOrders");
                serviceCenterOrders.Update(item);
            }
        }

        public IList<ServiceTicket> GetAll()
        {
            var serviceCenterOrders = new List<ServiceTicket>();
            using (var db = new LiteDatabase(dbPath))
            {
                serviceCenterOrders.AddRange(db.GetCollection<ServiceTicket>("ServiceCenterOrders").FindAll());
            }
            return serviceCenterOrders;
        }
    }
}

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
    public class OrderRepository : IRepository<Order>
    {
        private string dbPath;

        public OrderRepository(string dbPath)
        {
            this.dbPath = dbPath;
        }

        public void EnsureIndex(LiteCollection<Order> collection)
        {
            collection.EnsureIndex(x => x.ID);
        }

        public void Add(Order item)
        {
            using (var db = new LiteDatabase(dbPath))
            {
                var orders = db.GetCollection<Order>("Orders");
                orders.Insert(item);

                EnsureIndex(orders);
            }
        }

        public void Delete(int id)
        {
            using (var db = new LiteDatabase(dbPath))
            {
                var orders = db.GetCollection<Order>("Orders");
                orders.Delete(id);
            }
        }

        public void Update(Order item)
        {
            using (var db = new LiteDatabase(dbPath))
            {
                var orders = db.GetCollection<Order>("Orders");
                orders.Update(item);
            }
        }

        public IList<Order> GetAll()
        {
            var orders = new List<Order>();
            using (var db = new LiteDatabase(dbPath))
            {
                orders.AddRange(db.GetCollection<Order>("Orders").FindAll());
            }
            return orders;
        }
    }
}

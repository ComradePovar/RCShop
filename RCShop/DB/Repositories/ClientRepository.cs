using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCShop.Interfaces;
using RCShop.DB.Entities;
using LiteDB;

namespace RCShop.DB.Repositories
{
    public class ClientRepository : IRepository<Client>
    {
        private string dbPath;

        public ClientRepository(string dbPath)
        {
            this.dbPath = dbPath;
        }

        public void EnsureIndex(LiteCollection<Client> collection)
        {
            collection.EnsureIndex(x => x.ID);
            collection.EnsureIndex(x => x.Name);
            collection.EnsureIndex(x => x.Adress);
            collection.EnsureIndex(x => x.Phone);
            collection.EnsureIndex(x => x.Discount);
        }

        public IList<Client> Search(string query)
        {
            return GetAll()
                .Where(x =>
                    x.ID.ToString().Contains(query) ||
                    x.Name.Contains(query) ||
                    x.Adress.Contains(query) ||
                    x.Phone.Contains(query) ||
                    x.Discount.ToString().Contains(query))
                .OrderBy(x => x.ID)
                .ToList();
        }

        public void Add(Client item)
        {
            using (var db = new LiteDatabase(dbPath))
            {
                var clients = db.GetCollection<Client>("Clients");
                clients.Insert(item);

                EnsureIndex(clients);
            }
        }

        public void Delete(int id)
        {
            using (var db = new LiteDatabase(dbPath))
            {
                var clients = db.GetCollection<Client>("Clients");
                clients.Delete(id);
            }
        }

        public void Update(Client item)
        {
            using (var db = new LiteDatabase(dbPath))
            {
                var clients = db.GetCollection<Client>("Clients");
                clients.Update(item);
            }
        }

        public IList<Client> GetAll()
        {
            var clients = new List<Client>();
            using (var db = new LiteDatabase(dbPath))
            {
                clients.AddRange(db.GetCollection<Client>("Clients").FindAll());
            }
            return clients;
        }

        public Client Get(int id)
        {
            using (var db = new LiteDatabase(dbPath))
            {
                return db.GetCollection<Client>("Clients").FindById(id);
            }
        }
    }
}

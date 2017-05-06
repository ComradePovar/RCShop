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
    }
}

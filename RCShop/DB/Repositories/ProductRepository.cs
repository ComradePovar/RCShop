using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using RCShop.DB.Entities;
using RCShop.Interfaces;

namespace RCShop.DB.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private string dbPath;

        public ProductRepository(string dbPath)
        {
            this.dbPath = dbPath;
        }

        public void EnsureIndex(LiteCollection<Product> collection)
        {
            collection.EnsureIndex(x => x.ID);
            collection.EnsureIndex(x => x.Title);
            collection.EnsureIndex(x => x.Count);
            collection.EnsureIndex(x => x.Price);
        }

        public void Add(Product item)
        {
            using (var db = new LiteDatabase(dbPath))
            {
                var products = db.GetCollection<Product>("Products");
                products.Insert(item);

                EnsureIndex(products);
            }
        }

        public void Delete(int id)
        {
            using (var db = new LiteDatabase(dbPath))
            {
                var products = db.GetCollection<Product>("Products");
                products.Delete(id);
            }
        }

        public void Update(Product item)
        {
            using (var db = new LiteDatabase(dbPath))
            {
                var products = db.GetCollection<Product>("Products");
                products.Update(item);
            }
        }

        public IList<Product> GetAll()
        {
            var products = new List<Product>();
            using (var db = new LiteDatabase(dbPath))
            {
                products.AddRange(db.GetCollection<Product>("Products").FindAll());
            }
            return products;
        }

        public IList<Product> Search(string query)
        {
            return GetAll()
                .Where(x =>
                    x.ID.ToString().Contains(query) ||
                    x.Title.Contains(query) ||
                    x.Count.ToString().Contains(query) ||
                    x.Price.ToString().Contains(query))
                .OrderBy(x => x.ID)
                .ToList();
        }

        public Product Get(int id)
        {
            using (var db = new LiteDatabase(dbPath))
            {
                return db.GetCollection<Product>("Products").FindById(id);
            }
        }
    }
}

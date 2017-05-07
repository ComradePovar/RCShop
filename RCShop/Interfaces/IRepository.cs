using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace RCShop.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Update(T item);
        void Delete(int id);
        T Get(int id);
        IList<T> GetAll();
        IList<T> Search(string query);
        void EnsureIndex(LiteCollection<T> collection);
    }
}

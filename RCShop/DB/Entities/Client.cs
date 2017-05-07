using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCShop.DB.Entities
{
    public class Client
    {
        [LiteDB.BsonId]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public double Discount { get; set; }
    }
}

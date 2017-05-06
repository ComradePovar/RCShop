using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCShop.DB.Entities
{
    public class Order
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int ClientID { get; set; }
        public decimal Price { get; set; }
    }
}

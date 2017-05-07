using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCShop.DB.Entities
{
    public class ServiceTicket
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public string Title { get; set; }
        public string Problem { get; set; }
        public double Price { get; set; }
    }
}

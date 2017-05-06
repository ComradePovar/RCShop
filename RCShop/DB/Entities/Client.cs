﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCShop.DB.Entities
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public decimal Discount { get; set; }
    }
}

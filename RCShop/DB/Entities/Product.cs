﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCShop.DB.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
    }
}

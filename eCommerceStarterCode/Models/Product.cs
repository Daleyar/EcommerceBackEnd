﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Product
    {
        public int ProductID {get; set;}
        public string ProductName{ get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
        public int ReviewID { get; set; }
        public int AvgRating { get; set; }

    }
}
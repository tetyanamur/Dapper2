using System;
using System.Collections.Generic;
using System.Text;

namespace DapperInClass
{
    public class Product
    {
        //property
        public int ProductID { get; set; }
        public string Name { get; set; }
        // price categoryID
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public int OnSale { get; set; }
        public string StockLevel { get; set; }
    }
}

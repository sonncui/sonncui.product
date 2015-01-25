using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace product.resource
{
    public class Product
    {
        public long id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }

        public Product(long id, string name, decimal price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
    }
}
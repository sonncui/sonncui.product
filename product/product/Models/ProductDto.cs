using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace product.Models
{
    public class ProductDto
    {
        public long id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
    }
}
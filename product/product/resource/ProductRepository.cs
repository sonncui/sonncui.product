using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace product.resource
{
    public class ProductRepository
    {
        List<Product> products = new List<Product>()
                {
                    new Product(1, "Narcissus", 18),
                    new Product(2, "little Bamboo", 17),
                    new Product(3, "Orchid", 56) 
                };

        public List<Product> GetAll()
        {
            return products;
        }

        public Product GetById(long id)
        {
            return products.FirstOrDefault(p => p.id == id);
        }
    }
}
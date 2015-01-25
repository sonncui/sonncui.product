using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using product.Models;
using product.resource;

namespace product.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly ProductRepository productRep;

        public ProductsController()
        {
            this.productRep = new ProductRepository();
        }

        [HttpGet]
        public List<ProductDto> GetAllProducts()
        {
            return productRep.GetAll().Select(p => p.ToDto()).ToList();
        }

        [HttpGet]
        public ProductDto GetProduct(long id)
        {
            return productRep.GetById(id).ToDto();
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using NHibernate;

namespace product.resource
{
    public class ProductRepository
    {
        private static IList<Product> products;

        public IList<Product> GetAll()
        {
            using (ISession session = NhibernateHelper.OpenSession())
            {
                products = session.QueryOver<Product>().List();
                session.Close();
            }
            return products;
        }

        public Product GetById(long id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }
    }
}
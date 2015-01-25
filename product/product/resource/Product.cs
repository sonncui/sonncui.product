using FluentNHibernate.Mapping;

namespace product.resource
{
    public class Product
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal Price { get; set; }
    }

    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Table("product");
            Id(p => p.Id).Column("id");
            Map(p => p.Name).Column("name");
            Map(p => p.Price).Column("price");
        }
    }
}
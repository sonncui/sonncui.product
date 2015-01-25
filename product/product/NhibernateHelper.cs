using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using product.resource;

namespace product
{
    public class NhibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        private static ISessionFactory sessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    InitializeSessionFactory();
                }
                return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                                      .Database(MsSqlConfiguration.MsSql2008.ConnectionString(@"Data Source=localhost;Initial Catalog=product;Integrated Security=True;Connect Timeout=1200"))
                                      .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Product>())
                                      .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(false, false))
                                      .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return sessionFactory.OpenSession();
        }
    }
}
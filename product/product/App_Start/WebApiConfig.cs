using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace product
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
               name:"GetAll",
               routeTemplate:"api/{controller}",
               defaults: new { controller = "Products" });
            config.Routes.MapHttpRoute(
                name:"GetProduct", 
                routeTemplate:"api/{controller}/{id}", 
                defaults:new { controller = "Products", action = "GetProduct" ,id = RouteParameter.Optional});
        
        }
    }
}

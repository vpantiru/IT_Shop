using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IT_Shop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Products",
                url: "{CategoryName}/{SubcategoryName}/{ProductName}",
                defaults: new {controller = "Product", action = "ViewProductDetails",}
            );

            routes.MapRoute(
               name: "CreateProducts",
               url: "Product/Create/",
               defaults: new { controller = "Product", action = "Create", }
           );

            routes.MapRoute(
              name: "Manufacturers",
              url: "Producatori/{action}",
              defaults: new { controller = "Manufacturer", action = "ViewManufacturers" }
          );

            routes.MapRoute(
               name: "Components",
               url: "{CategoryName}/{SubcategoryName}",
               defaults: new { controller = "Category", action = "ViewProducts"}
           );        

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

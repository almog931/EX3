﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ex3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                 "display",
                 "{action}/{ip}/{port}/{rate}",
                 defaults: new { controller = "Main", action = "display", ip = "file1", port = 4, rate = UrlParameter.Optional }
             );

            routes.MapRoute(
                "save",
                "{action}/{ip}/{port}/{rate}/{recordTime}/{fileName}",
                 defaults: new { controller = "Main", action = "save", ip = "127.0.0.1", port = 5400, rate = 4,
                     recordTime = 7, fileName = "file1" }
            );
                                
        }
    }
}

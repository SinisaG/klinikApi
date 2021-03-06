﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;

namespace Klinik.Api
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "WEB",
                url: "{versionno}/web/{controller}/{action}/{id}",
                defaults: new
            { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

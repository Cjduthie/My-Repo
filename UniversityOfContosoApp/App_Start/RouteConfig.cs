using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UniversityofContoso 
    // The Above ^ specifies the project name, that declares and organize the classes that use it. //
{
    public class RouteConfig
        // The above ^ creates a public class "RouteConfig" which can be acessed by code, or assemblys that reference it. //
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute(
                 name: "Default",
                  url: "{controller}/{action}/{id}",
            defaults: new
            {
                controller = "ChatRoom",
                action = "SignalRChat",
                id = UrlParameter.Optional
            }
        );
        }
    }
}
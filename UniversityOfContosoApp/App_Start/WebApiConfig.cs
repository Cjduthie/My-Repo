using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace UniversityofContoso //Specifies the app and the namespace to use for classes. //
{

    public static class WebApiConfig // Used to specify & or create the object "WebApiConfig". //
    {
        public static void Register(HttpConfiguration config) // Used to specify & or register the object "HttpConfiguration". //
        {
            // Web API configuration and services
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional } // This is designed to enable "cors" which also introduces several headers into this config file. //
                // While also adding changes to the web.config file, "cors" allows for a "cross-orgin" request and requires no java code to use. //
                // "*" specifed in the cors attribute defines that any orgin/ or location is allowed to connect between orgins. //
            );
        }
    }
}


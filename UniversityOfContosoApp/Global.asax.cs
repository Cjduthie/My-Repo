using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using UniversityofContoso;

namespace UniversityofContoso
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
// Could not work out how to add RouteTable.Routes.MapHubs();  which is needed to intizlize the chat session. //

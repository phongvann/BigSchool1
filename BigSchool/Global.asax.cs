using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
<<<<<<< HEAD
using System.Web.Http;
=======
>>>>>>> 8a9d73b6c75c6e75f29e46ac5688e461e4185ebf
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace BigSchool
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
<<<<<<< HEAD

            GlobalConfiguration.Configure(WebApiConfig.Register);
=======
>>>>>>> 8a9d73b6c75c6e75f29e46ac5688e461e4185ebf
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}

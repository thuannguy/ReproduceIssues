using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Note: add System.IdentityModel.LocalAppContextSwitches.DisableCngCertificates to the watch window to debug
            //AppContext.SetSwitch("TestSwitch.LocalAppContext.DisableCaching", true);
            AppContext.TryGetSwitch("Switch.System.ServiceModel.DisableCngCertificates", out bool isEnabled);
            //AppContext.SetSwitch("Switch.System.ServiceModel.DisableCngCertificates", true);
            AppContext.TryGetSwitch("Switch.System.ServiceModel.DisableCngCertificates", out isEnabled);
            System.IdentityModel.CookieTransform ct = new System.IdentityModel.DeflateCookieTransform();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AppContext.TryGetSwitch("Switch.System.ServiceModel.DisableCngCertificates", out bool isEnabled);
            System.Runtime.CompilerServices.Unsafe.Equals(null, null);
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://github.com");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
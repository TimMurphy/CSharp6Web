using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharp6Web.Controllers
{
    public class HomeController : Controller
    {
        public string Name { get; } = "value";

        public ActionResult Index()
        {
            string str = null;
            var length = str?.Substring(5)?.ToUpper();
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
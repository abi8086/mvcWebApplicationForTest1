using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1_Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            ViewBag.testMessage = "I am being tested";

            string xyz = ConfigurationManager.ConnectionStrings["DefaultDevConn"].ConnectionString;

            xyz = xyz.Substring(xyz.IndexOf('=')+1, xyz.IndexOf(';')-1);
            xyz = xyz.Replace("v;", "");

            xyz = "Web.Config Transform At: " + xyz;

            ViewBag.connString = xyz;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
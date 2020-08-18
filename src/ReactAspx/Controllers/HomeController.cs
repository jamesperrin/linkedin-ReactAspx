using ReactAspx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReactAspx.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //AppDbContext c = new AppDbContext();            
            // Use if Database already exists and you need to build the tables
            //c.Database.Initialize(true);
            //c.Database.CreateIfNotExists();
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Mail()
        {
            return View();
        }

        public ActionResult Stats()
        {
            return View();
        }

        public ActionResult News()
        {
            return View();
        }

        public ActionResult Videos()
        {
            return View();
        }

        public ActionResult Written()
        {
            return View();
        }
    }
}
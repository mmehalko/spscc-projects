using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HappierHarvest.Controllers
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

            return View();
        }

        public ActionResult CornMaze()
        {
            return View();
        }
        public ActionResult History()
        {
            return View();
        }
        public ActionResult Hours()
        {
            return View();
        }
        public ActionResult Location()
        {
            return View();
        }
        public ActionResult PettingZoo()
        {
            return View();
        }
        public ActionResult PumpkinPatch()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}
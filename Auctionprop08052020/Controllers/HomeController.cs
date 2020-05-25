using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Auctionprop08052020.Controllers
{
    public class Homecontroller : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Properties()
        {
            return View();
        }

        public ActionResult Buyers()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Sellers()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult FAQ()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Add()
        {
            ViewBag.Message = "Add property";

            return View();
        }
        public ActionResult Error()
        {
            ViewBag.Message = "404 Error Page";

            return View();
        }
    }
}

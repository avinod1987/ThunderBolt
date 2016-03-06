using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Thunderbolt.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Name = "Vinod";
            return View();
        }
        public ActionResult Daily()
        {
            return PartialView();
        }
        public ActionResult Charts()
        {
            return PartialView();
        }
        public ActionResult TimeLine()
        {
            return PartialView();
        }
    }
}

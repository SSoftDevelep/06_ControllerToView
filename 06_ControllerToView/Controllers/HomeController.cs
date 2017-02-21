using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _06_ControllerToView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Homepage()
        {
            //ViewData["text1"] = "Lionel Messi";
            //ViewData["check1"] = true;
            //ViewBag.text1 = "Lionel Messi";
            //ViewBag.check1 = true;
            TempData["text1"] = "Lionel Messi";
            TempData["check1"] = true;

            return View();

        }

        public ActionResult About()
        {
            ViewBag.text2 = "Cristiano Ronaldo";
            ViewBag.check2 = true;
            ViewBag.list1 = new SelectListItem[]
            {
                new SelectListItem {Text ="Cr7" },
                new SelectListItem {Text="Leo10" }
            };

            TempData["t1"] = ViewBag.text2;
            TempData["c2"] = ViewBag.check2;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.text2 = TempData["t1"];
            ViewBag.check2 = TempData["c2"];

            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.text2 = TempData["t1"];
            ViewBag.check2 = TempData["c2"];
            return View();
        }
    }
}
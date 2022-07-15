using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OktaAspNetExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            if (Request.IsAuthenticated)
            {
                ViewBag.Message = "You are authenticated";
            }
            else
            {
                ViewBag.Message = "You are not authenticated!";
            }
         

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
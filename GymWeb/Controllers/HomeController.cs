﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GymWeb.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult feature()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult classes() {
            ViewBag.Message = "Your contact page.";

            return View();
    }
         public ActionResult Blog() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Single()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "More About Myself";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Me";
            return View();
        }
    }
}
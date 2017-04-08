﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Data()
        {
            ViewBag.Title = "Hotel Details";
            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Title = "Gallery";
            return View();
        }

    }
}
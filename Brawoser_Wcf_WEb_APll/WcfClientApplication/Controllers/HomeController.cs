﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WcfClientApplication.Controllers
{
    public class HomeController : Controller
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        public ActionResult Index()
        {
            ViewBag.hello = client.hello();
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
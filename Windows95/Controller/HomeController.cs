﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Windows95.Controller
{
    public class HomeController : System.Web.Mvc.Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC2.Controllers
{
    public class TestController:Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
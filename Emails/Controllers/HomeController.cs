﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emails.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult SendEmailView()
        {
            //call SendEmailView view to invoke webmail  
            return View();
        }  
    }
}
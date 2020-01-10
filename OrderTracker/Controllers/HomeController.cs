using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using OrderTracker.Models;

namespace  OrderTracker.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
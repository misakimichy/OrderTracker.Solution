using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
    public class ClassNameController : Controller
    {
        [HttpGet("/className")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
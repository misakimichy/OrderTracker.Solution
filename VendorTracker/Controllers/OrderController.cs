using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
        public ActionResult Show(int vendorId, int orderId)
        {
            Vendor vendor = Vendor.Find(vendorId);
            Order order = Order.Find(orderId);
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("order", order);
            dict.Add("vendor", vendor);
            return View(dict);
        }

        [HttpGet("/vendors/{vendorId}/orders/new")]
        public ActionResult New(int vendorId)
        {
            Vendor vendor = Vendor.Find(vendorId);
            return View(vendor);
        }
    }
}
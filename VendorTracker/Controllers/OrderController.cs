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
            Vendor selectedVendor = Vendor.Find(vendorId);
            Order order = Order.Find(orderId);
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("order", order);
            dict.Add("vendor", selectedVendor);
            return View(dict);
        }

        [HttpGet("/vendors/{vendorId}/orders/new")]
        public ActionResult New(int vendorId)
        {
            Vendor vendor = Vendor.Find(vendorId);
            return View(vendor);
        }

        [HttpGet("/vendors/{vendorId}/orders/{orderId}/delete")]
        public ActionResult Delete(int vendorId, int orderId)
        {
            Vendor selectedVendor = Vendor.Find(vendorId);
            Order order = Order.Find(orderId);
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("order", order);
            dict.Add("vendor", selectedVendor);
            return View(dict);
        }

        [HttpPost("/vendors/{vendorId}/orders/{orderId}/delete")]
        public ActionResult Create(int vendorId, int orderId)
        {
            Vendor selectedVendor = Vendor.Find(vendorId);
            Order order = Order.Find(orderId);
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("order", order);
            dict.Add("vendor", selectedVendor);
            Order.DeleteItem(orderId);
            // Redirect to /vendor/{vendirId} page, which locates in VendorController
            return RedirectToAction("Show", "Vendor");
        }
    }
}
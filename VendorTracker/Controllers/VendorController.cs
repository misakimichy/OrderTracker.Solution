using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
    public class VendorController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> allVendors = Vendor.GetAll();
            return View(allVendors);
        }

        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpGet("/vendors/{vendorId}")]
        public ActionResult Show(int vendorId)
        {
            // This dictionary has a vendor name and a order object
            Dictionary<string, object> dict = new Dictionary<string, object>();
            Vendor selectedVendor = Vendor.Find(vendorId);
            List<Order> vendorOrder = selectedVendor.Orders;
            dict.Add("vendor", selectedVendor);
            dict.Add("orders", vendorOrder);
            return View(dict);
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string name, string description)
        {
            Vendor myVendor = new Vendor(name, description);
            return RedirectToAction("Index");
        }

        [HttpPost("/vendors/{vendorId}/orders")]
        public ActionResult Create(int vendorId, string orderTitle, string orderDescription, int orderPrice, DateTime orderDate)
        {
            Vendor selectedVendor = Vendor.Find(vendorId);
            Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
            selectedVendor.AddOrder(newOrder);
            List<Order> vendorOrders = selectedVendor.Orders;
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("orders", vendorOrders);
            dict.Add("vendor", selectedVendor);
            return View("Show", dict);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("/vendors/{id}")]
        public ActionResult Show(int id)
        {
            // This dictionary has a vendor name and a order object
            Dictionary<string, object> dict = new Dictionary<string, object>();
            Vendor selectedVendor = Vendor.Find(id);
            List<Order> vendorOrder = selectedVendor.Orders;
            dict.Add("Vendor", selectedVendor);
            dict.Add("Orders", vendorOrder);
            return View(dict);
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string name, string description)
        {
            Vendor myVendor = new Vendor(name, description);
            return RedirectToAction("Index");
        }
    }
}
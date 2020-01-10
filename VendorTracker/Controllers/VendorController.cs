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
            Vendor selectedVendor = Vendor.Find(id);
            List<Order> vendorOrder = selectedVendor.Orders;
            // This dictionary has a vendor name and a order object
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("vendor", selectedVendor);
            dict.Add("orders", vendorOrder);
            return View(dict);
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string name, string description)
        {
            if(name == null)
            {
                return RedirectToAction("Index");
            }
            Vendor myVendor = new Vendor(name, description);
            return RedirectToAction("Index");
        }
    }
}
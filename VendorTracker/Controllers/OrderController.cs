// using Microsoft.AspNetCore.Mvc;
// using System;
// using System.Collections.Generic;
// using VendorTracker.Models;

// namespace VendorTracker.Controllers
// {
//     public class OrderController : Controller
//     {
//         [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
//         public ActionResult Show(int vendorId, int orderId)
//         {
//             Vendor vendor = Vendor.Find(vendorId);
//             Order order = Order.Find(orderId);
//             Dictionary<string, object> dict = new Dictionary<string, object>();
//             dict.Add("order", order);
//             dict.Add("vendor", vendor);
//             return View(dict);
//         }

//         [HttpPost("/vendors/{vendorId/orders")]
//         public ActionResult Create(int vendorId, string orderTitle, string orderDescription, int orderPrice, DateTime orderDate)
//         {
//             Vendor selectedVendor = Vendor.Find(vendorId);
//             Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
//             selectedVendor.AddOrder(newOrder);
//             List<Order> vendorOrder = selectedVendor.Orders;
//             Dictionary<string, object> dict = new Dictionary<string, object>();
//             dict.Add("orders", vendorOrder);
//             dict.Add("vendor", selectedVendor);
//             return View("Show", dict);
//         }
//     }
// }
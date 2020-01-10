using System.Collections.Generic;
using System;

namespace VendorTracker.Models
{
    public class Order
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime Date;
        private static List<Order> _instances = new List<Order> {};

        public Order (string title, string description, double price, DateTime date)
        {
            Title = title;
            Description = description;
            Price = price;
            Date = date;
            _instances.Add(this);
        }

        public static List<Order> GetAll()
        {
            return _instances;
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}
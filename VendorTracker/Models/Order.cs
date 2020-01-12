using System.Collections.Generic;
using System;

namespace VendorTracker.Models
{
    public class Order
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        private DateTime _date;
        private static List<Order> _instances = new List<Order>{};
        public int Id { get; set ;}

        public Order (string title, string description, double price, DateTime date)
        {
            Title = title;
            Description = description;
            Price = price;
            _date = date;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Order> GetAll()
        {
            return _instances;
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Order Find(int searchId)
        {
            return _instances[searchId - 1];
        }

        public string GetDate()
        {
            return _date.ToString("MMMM dd yyyy");
        }

        public void SetDate(DateTime new_date)
        {
            _date = new_date;
        }

        public static void DeleteItem(int id)
        {
            _instances.RemoveAt(id - 1);
            FixIndex();
        }

        public static void FixIndex()
        {
            for(int i = 0; i < _instances.Count; i++)
            {
                _instances[i].Id = i + 1;
            }
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderTracker.Models;

namespace OrderTracker.Tests
{
    [TestClass]
    public class VendorTest
    {
        [TestMethod]
        public void VendorConstructor_CreateInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("bakery", "We are bakery");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }
 
    }
}
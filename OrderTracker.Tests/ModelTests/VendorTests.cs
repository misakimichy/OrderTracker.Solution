using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using OrderTracker.Models;

namespace OrderTracker.Tests
{
    [TestClass]
    public class VendorTest : IDisposable
    {

        public void Dispose()
        {
            Vendor.ClearAll();
        }

        [TestMethod]
        public void VendorConstructor_CreateInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("bakery", "We locates in Seattle.");

            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetName_ReturnVendorName_String()
        {
            string name = "Jerry's Bakery";
            string description = "We locates in Seattle.";
            Vendor newVendor = new Vendor(name, description);
            string result = newVendor.Name;

            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void SetName_SetName_String()
        {
            string name = "Jerry's Bakery";
            string description = "We locates in Seattle.";
            Vendor newVendor = new Vendor(name, description);
            string updatedName = "Tony's Bakery";
            newVendor.Name = updatedName;
            string result = newVendor.Name;

            Assert.AreEqual(updatedName, result);
        }

        [TestMethod]
        public void GetDescription_ReturnVendorDescription_String()
        {
            string name = "Jerry's Bakery";
            string description = "We locates in Seattle.";
            Vendor newVendor = new Vendor(name, description);
            string result = newVendor.Description;

            Assert.AreEqual(description, result);
        }

        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
            string name = "Jerry's Bakery";
            string description = "We locates in Seattle.";
            Vendor newVendor = new Vendor(name, description);
            string updatedDescription = "We locates in Bellevue";
            newVendor.Description = updatedDescription;
            string result = newVendor.Description;

            Assert.AreEqual(updatedDescription, result);
        }

        [TestMethod]
        public void GetAll_ReturnsVendors_VendorList()
        {
            string name1 = "Jerry's Bakery";
            string name2 = "Tony's Bakery";
            string description1 = "We locates in Seattle.";
            string description2 = "We locates in Bellevue";
            Vendor newVendor1 = new Vendor(name1, description1);
            Vendor newVendor2 = new Vendor(name2, description2);
            List<Vendor> newList = new List<Vendor> {newVendor1, newVendor2};
            List<Vendor> result = Vendor.GetAll();

            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void GetId_VendorInstantiateWithanId_Int()
        {
            string name = "Jerry's Bakery";
            string description = "We locates in Seattle.";
            Vendor newVendor = new Vendor(name, description);
            int result = newVendor.Id;

            Assert.AreEqual(1, result);
        }
    }
}
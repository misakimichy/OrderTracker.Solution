using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Tests
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
            Vendor newVendor = new Vendor(name, "We locates in Seattle.");
            string result = newVendor.Name;

            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void SetName_SetName_String()
        {
            Vendor newVendor = new Vendor("Jerry's Bakery", "We locates in Seattle.");
            string updatedName = "Tony's Bakery";
            newVendor.Name = updatedName;
            string result = newVendor.Name;

            Assert.AreEqual(updatedName, result);
        }

        [TestMethod]
        public void GetDescription_ReturnVendorDescription_String()
        {
            string description = "We locates in Seattle.";
            Vendor newVendor = new Vendor("Jerry's Bakery", description);
            string result = newVendor.Description;

            Assert.AreEqual(description, result);
        }

        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
            Vendor newVendor = new Vendor("Jerry's Bakery", "We locates in Seattle.");
            string updatedDescription = "We locates in Bellevue";
            newVendor.Description = updatedDescription;
            string result = newVendor.Description;

            Assert.AreEqual(updatedDescription, result);
        }

        [TestMethod]
        public void GetAll_ReturnsVendors_VendorList()
        {
            Vendor newVendor1 = new Vendor("Jerry's Bakery", "We locates in Seattle.");
            Vendor newVendor2 = new Vendor("Tony's Bakery", "We locates in Bellevue");
            List<Vendor> newList = new List<Vendor> {newVendor1, newVendor2};
            List<Vendor> result = Vendor.GetAll();

            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void GetId_VendorInstantiateWithanId_Int()
        {
            Vendor newVendor = new Vendor("Jerry's Bakery", "We locates in Seattle.");
            int result = newVendor.Id;

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectVendor_Vendor()
        {
            Vendor newVendor1 = new Vendor("Jerry's Bakery", "We locates in Seattle.");
            Vendor newVendor2 = new Vendor("Tony's Bakery", "We locates in Bellevue");
            Vendor result = Vendor.Find(2);

            Assert.AreEqual(newVendor2, result);
        }
    }
}
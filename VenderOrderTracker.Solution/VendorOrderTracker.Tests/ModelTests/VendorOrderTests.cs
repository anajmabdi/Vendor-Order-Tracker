using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VendorOrder.Models;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      string test1 = "test";
      string test2 = "test";
      Vendor newVendor = new Vendor(test1, test2);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetNameAndDescription_SavesDescriptionAndNameOfVendor_Vendor()
    {
      string name = "Suzie's Cafe";
      string description = "Coffee Shop";
      Vendor newVendor = new Vendor(name, description);

      string nameCheck = newVendor.Name;
      string descriptionCheck = newVendor.Description;

      Assert.AreEqual(name, nameCheck);
      Assert.AreEqual(description, descriptionCheck);
    }
  }

  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void
    OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      string title = "Tea Party";
      string description = "too many pastries";
      int price = 350;

      Order newOrder = new Order(title, description, price);

      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }


    [TestMethod]
    public void
    SetProperties_DefinesPropertiesForObjectInstances_Order()
    {
      string title = "Tea Party";
      string description = "too many pastries";
      int price = 350;
      Order newOrder = new Order(title, description, price);

      string titleCheck = newOrder.Title;
      string descriptionCheck = newOrder.Description;
      int priceCheck = newOrder.Price;

      Assert.AreEqual(title, titleCheck);
      Assert.AreEqual(description, descriptionCheck);
      Assert.AreEqual(price, priceCheck);
    }
    [TestMethod]
    public void GetDate_AccessDateTimeClass_Order() 
    {
      DateTime date = DateTime.Today;

      Order newOrder = new Order("title", "description", 5);

      DateTime result = newOrder.Today;
      
      Assert.AreEqual(date, result);
    }
  }
}


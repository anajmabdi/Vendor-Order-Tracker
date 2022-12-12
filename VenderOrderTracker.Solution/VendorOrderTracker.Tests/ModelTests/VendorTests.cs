using Microsoft.VisualStudio.TestTools.UnitTesting;
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

      string result = newVendor.Name;
      string result2 = newVendor.Description;

      Assert.AreEqual(name, result);
      Assert.AreEqual(description, result2);
    }
  }
}

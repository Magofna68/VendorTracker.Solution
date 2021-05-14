using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorTracker.Tests //Change to match Title
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Pierre", "Baker");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void DescriptionField_ReturnsDescription_String()
    {
      string description = "Pastry Baker";

      Vendor newVendor = new Vendor("Pierre", description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_UpdatesDescription_String()
    {
      //Arrange
      string description = "Pastry Baker";
      Vendor newVendor = new Vendor("Pierre", description);

      //Act
      string updatedDescription = "Pastry Chef";
      newVendor.Description = updatedDescription;
      string result = newVendor.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      List<Vendor> newList = new List<Vendor> { };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendors_Vendors()
    {
      string vName = "Pierre";
      string vDes = "baker";
      string vName2 = "Margret";
      string vDes2 = "chef";

      Vendor newVendor = new Vendor(vName, vDes);
      Vendor newVendor2 = new Vendor(vName2, vDes2);
      List<Vendor> newList = new List<Vendor> { newVendor, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsAccurateVendor_Vendor()
    {
      string vName = "Pierre";
      string vDes = "baker";
      string vName2 = "Margret";
      string vDes2 = "chef";

      Vendor newVendor = new Vendor(vName, vDes);
      Vendor newVendor2 = new Vendor(vName2, vDes2);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }
  }
}
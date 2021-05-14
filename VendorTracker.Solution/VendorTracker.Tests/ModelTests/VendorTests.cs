using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorTracker.Tests //Change to match Title
{
  [TestClass]
  public class OrderTests //: IDisposable
  {
    // public void Dispose()
    // {
    //   record.ClearAll();
    // }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Pierre");
      Assert.AreEqual(typeof(Vendor), newVendor);
    }
  }
}
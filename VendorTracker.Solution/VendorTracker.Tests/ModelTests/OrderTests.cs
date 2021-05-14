using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;


namespace VendorTrackerTests //Change to match Title
{
  [TestClass]
  public class OrderTests //: IDisposable
  {
    // public void Dispose()
    // {
    //   record.ClearAll();
    // }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Pierre");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}


// [TestMethod]
// public void GetAllByOrder
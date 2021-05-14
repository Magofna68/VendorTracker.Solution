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
      Order newOrder = new Order("Pierre", 0, 0, "");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfAllProperties_Order()
    {
      string title = "Chocolate Chip Cookies";
      int quantity = 24;
      int price = 10;
      string date = "June 10th";
      Order newOrder = new Order(title, quantity, price, date);

      Assert.AreEqual(date, newOrder.Date);
    }

    [TestMethod]
    public void OrderConstructor_SetProperties_Price()
    {
      string title = "Chocolate Chip Cookies";
      int quantity = 24;
      int price = 10;
      string date = "June 10th";
      Order newOrder = new Order(title, quantity, price, date);

      int newPrice = price - 4;
      newOrder.Price = newPrice;
      Assert.AreEqual(6, newOrder.Price);
    }
  }
}


// [TestMethod]
// public void GetAllByOrder
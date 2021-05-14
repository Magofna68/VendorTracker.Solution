using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;


namespace VendorTrackerTests //Change to match Title
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

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

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string title = "Chocolate Chip Cookies";
      string title2 = "Chocolate Cookies";
      int quantity = 24;
      int quantity2 = 14;
      int price = 10;
      int price2 = 13;
      string date = "June 10th";
      string date2 = "June 11th";

      Order newOrder = new Order(title, quantity, price, date);
      Order newOrder2 = new Order(title2, quantity2, price2, date2);
      List<Order> totalO = new List<Order> { newOrder, newOrder2 };

      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(totalO, result);
    }

    [TestMethod]
    public void GetId_IdentifyInstancesViaId_int()
    {
      string title = "Chocolate Chip Cookies";
      int quantity = 24;
      int price = 10;
      string date = "June 10th";
      Order newOrder = new Order(title, quantity, price, date);

      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }
  }
}


// [TestMethod]
// public void GetAllByOrder
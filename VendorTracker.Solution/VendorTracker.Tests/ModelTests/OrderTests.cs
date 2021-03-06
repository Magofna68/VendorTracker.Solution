using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;


namespace VendorTrackerTests
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
      Order newOrder = new Order("Pierre", "0", 0, "");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfAllProperties_Order()
    {
      string title = "Chocolate Chip Cookies";
      string origin = "Pierre's";
      int quantity = 24;
      string date = "June 10th";
      Order newOrder = new Order(title, origin, quantity, date);

      Assert.AreEqual(date, newOrder.Date);
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
      string origin = "Pierre's";
      string origin2 = "Dierre's";
      int quantity = 24;
      int quantity2 = 14;
      string date = "June 10th";
      string date2 = "June 11th";

      Order newOrder = new Order(title, origin, quantity, date);
      Order newOrder2 = new Order(title2, origin2, quantity2, date2);
      List<Order> totalO = new List<Order> { newOrder, newOrder2 };

      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(totalO, result);
    }

    [TestMethod]
    public void GetId_IdentifyInstancesViaId_int()
    {
      string title = "Chocolate Chip Cookies";
      string origin = "Pierre's";
      int quantity = 24;
      string date = "June 10th";
      Order newOrder = new Order(title, origin, quantity, date);

      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsAccurateOrder_Order()
    {
      string title = "Chocolate Chip Cookies";
      string title2 = "Chocolate Cookies";
      string origin = "Pierre's";
      string origin2 = "Dierre's";
      int quantity = 24;
      int quantity2 = 14;
      string date = "June 10th";
      string date2 = "June 11th";

      Order newOrder = new Order(title, origin, quantity, date);
      Order newOrder2 = new Order(title2, origin2, quantity2, date2);
      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }
  }
}

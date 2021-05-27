using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Origin { get; set; }
    public int Quantity { get; set; }
    // public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _orderList = new List<Order> { };
    // private static List<Order> allOrders = new List<Order> { };

    public Order(string oTitle, string oOrigin, int oQuantity, string oDate)
    {
      Title = oTitle;
      Origin = oOrigin;
      Quantity = oQuantity;
      Date = oDate;
      _orderList.Add(this);
      Id = _orderList.Count;
    }
    public static void ClearAll()
    {
      _orderList.Clear();
    }

    public static List<Order> GetAll()
    {
      return _orderList;
    }

    public static Order Find(int searchId)
    {
      return _orderList[searchId - 1];
    }
  }
}
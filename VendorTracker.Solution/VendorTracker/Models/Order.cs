using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Origin { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }

    public static void ClearAll()
    {
      _orderList.Clear();
    }

    private static List<Order> _orderList = new List<Order> { };

    public Order(string oTitle, string oOrigin, int oQuantity, int oPrice, string oDate)
    {
      Title = oTitle;
      Origin = oOrigin;
      Quantity = oQuantity;
      Price = oPrice;
      Date = oDate;
      _orderList.Add(this);
      Id = _orderList.Count;
    }

    public static List<Order> GetAll()
    {
      return _orderList;
    }

    public static Order Find(int searchId)
    {
      return _orderList[searchId - 1];
    }

    public static List<Order> GetAllOrders(string vendor)
    {
      List<Order> allOrders = new List<Order> { };
      foreach (Order order in _orderList)
      {
        if (Order.Origin == oOrigin)
        {
          allOrders.Add(Order);
        }
      }
      return allOrders;
    }
  }
}
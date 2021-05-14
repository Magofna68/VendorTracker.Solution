using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    // public int Id { get; }

    private static List<Order> _instances = new List<Order> { };

    public Order(string oTitle, int oQuantity, int oPrice, string oDate)
    {
      Title = oTitle;
      Quantity = oQuantity;
      Price = oPrice;
      Date = oDate;
      // _instances.Add(this);
      // Id = _instances.Count;
    }
  }
}
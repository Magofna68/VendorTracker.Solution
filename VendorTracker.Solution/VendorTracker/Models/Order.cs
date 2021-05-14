using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }

    public static void ClearAll()
    {
      _orderList.Clear();
    }

    private static List<Order> _orderList = new List<Order> { };

    public Order(string oTitle, int oQuantity, int oPrice, string oDate)
    {
      Title = oTitle;
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

    // public static List<string> GetAllOrders(string vendor)
    // {
    //       // List<string> allArtists = new List<string> { };
    // foreach (Record record in __recordsList)
    // {
    //   string nameOfArtist = record.Artist;
    //   if (!allArtists.Contains(nameOfArtist))
    //   {
    //     allArtists.Add(nameOfArtist);
    //   }
    // }
    // return allArtists;
    // return _orderList;
    // }
  }
}
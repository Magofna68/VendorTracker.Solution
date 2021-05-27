using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendorList = new List<Vendor> { };
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
    public Vendor(string vName, string vDescription)
    {
      Name = vName;
      Description = vDescription;
      _vendorList.Add(this);
      Id = _vendorList.Count;
      Orders = new List<Order> { };
    }

    public static void ClearAll()
    {
      _vendorList.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _vendorList;
    }

    public static Vendor Find(int searchId)
    {
      return _vendorList[searchId - 1];
    }

    public void AddOrder(Order Order)
    {
      Orders.Add(Order);
    }
  }
}
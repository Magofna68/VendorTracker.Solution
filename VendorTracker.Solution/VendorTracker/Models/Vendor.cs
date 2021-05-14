using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    public string Vendors { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public static List<Vendor> _vendorList = new List<Vendor> { };
    public Vendor(string vName, string vDescription)
    {
      Vendors = vName;
      Description = vDescription;
      _vendorList.Add(this);
      Id = _vendorList.Count;
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
  }
}

//This class should include properties for the vendor's name, a description of the vendor, a List of Orders belonging to the vendor, and any other properties you would like to include.
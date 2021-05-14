using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    public string Vendors { get; set; }
    // public string Description { get; set; }
    public static List<Vendor> _vendorList = new List<Vendor> { };
    public Vendor(string vendorName)
    {
      Vendors = vendorName;
      // Description = vDescription;
      // _vendorList.Add(this);
    }


  }
}

//This class should include properties for the vendor's name, a description of the vendor, a List of Orders belonging to the vendor, and any other properties you would like to include.
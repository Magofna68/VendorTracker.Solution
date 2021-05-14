using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vName, string vDescription)
    {
      Vendor firstVendor = new Vendor(vName, vDescription);
      return RedirectToAction("Index");
    }

    // [HttpGet("/vendors/{}")]
    // public ActionResult Show(string vendor)
    // {
    //   List<Order> ordersByVendor = Order.GetAllOrders(vendor);
    //   return View(ordersByVendor);
    // }
  }
}
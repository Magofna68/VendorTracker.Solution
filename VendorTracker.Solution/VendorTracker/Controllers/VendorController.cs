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
      Vendor newVendor = new Vendor(vName, vDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{Id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> ordersByVendor = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", ordersByVendor);
      return View(model);
    }

    [HttpGet("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string oTitle, string oOrigin, string oDate, int oQuantity)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(oTitle, oOrigin, oQuantity, oDate);
      foundVendor.AddOrder(newOrder);
      List<Order> ordersByVendor = foundVendor.Orders;
      model.Add("orders", ordersByVendor);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }
  }
}
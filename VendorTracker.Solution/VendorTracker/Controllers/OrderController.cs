using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendors/{Id}/orders/new")]
    public ActionResult Show(string vendor)
    {
      List<Order> ordersByVendor = Order.GetAllOrders(vendor);
      return View(ordersByVendor);
    }
  }
}
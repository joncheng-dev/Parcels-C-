using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/cart")]
    public ActionResult Index()
    {
      
      List<Item> allPackages = Item.GetAll();
      return View(allPackages);
    }

    [HttpGet("/cart/additem")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/cart")]
    public ActionResult Create(double weight, double length, double width, double height)
    {
      Item anItem = new Item(weight, length, width, height);
      return RedirectToAction("Index");
    }

  }
}
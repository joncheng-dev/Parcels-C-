using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {
    // [HttpGet("/inventory")]
    // public ActionResult Index()
    // {
    //   List<Entry> allEntries = Entry.GetAll();
    //   return View(allEntries);
    // }

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
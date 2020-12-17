using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;

namespace PackerTracker.Controllers
{
  public class KitsController : Controller
  {
    [HttpGet("/kits")]
    public ActionResult Index()
    {
      List<Kit> allKits = Kit.GetAll();
      
      return View(allKits);
    }
    [HttpGet("/kits/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/kits")]
    public ActionResult Create(string name, int price, int weight, bool purchased, bool packed)
    {
      Kit myKit = new Kit(name, price, weight, purchased, packed);

      return RedirectToAction("Index");
    }

    [HttpPost("/kits/delete")]
    public ActionResult DeleteAll()
    {
      Kit.ClearAll();
      return View();
    }

    [HttpGet("/kits/{id}")]
    public ActionResult Show(int id)
    {
      Kit foundKit = Kit.Find(id);
      return View(foundKit);
    }
  }
}
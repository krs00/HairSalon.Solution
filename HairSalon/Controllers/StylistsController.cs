using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    { 
      List<Stylist> model = _db.Stylist.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylist.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Stylist currentStylist = _db.Stylist
                                  .Include(stylist => stylist.Clients)
                                  .FirstOrDefault(stylist => stylist.StylistId == id);
      return View(currentStylist);
    }

    public ActionResult Edit(int id)
    {
      Stylist currentStylist = _db.Stylist.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(currentStylist);
    }

    [HttpPost]
    public ActionResult Edit(Stylist stylist)
    {
      _db.Stylist.Update(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Stylist currentStylist = _db.Stylist.FirstOrDefault(category => category.StylistId == id);
      return View(currentStylist);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Stylist currentStylist = _db.Stylist.FirstOrDefault(category => category.StylistId == id);
      _db.Stylist.Remove(currentStylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }


  }
}
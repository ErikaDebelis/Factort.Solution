using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Linq;
using System;

namespace Factory.Controllers
{
  public class EngineerController : Controller
  {
    private readonly FactoryContext _db;

    public EngineerController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Engineer> model = _db.Engineers.ToList();
      return View(model);
    }
  }
}
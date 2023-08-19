
using StajProjesi.Areas.Data;
using Microsoft.AspNetCore.Mvc;

public class ClassesController : Controller
{
    private readonly ClassesDbContext _db;

    
    public ClassesController(ClassesDbContext db)
  { 
    _db = db;
  }
    
  public IActionResult Index()
  {
    var obj = _db.FirstT.ToList();

    return View(obj);
  }

}


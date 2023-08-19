using Microsoft.AspNetCore.Mvc;
using StajProjesi.Areas.Data;

namespace StajProjesi.Controllers;

public class StudentInfoController : Controller
{
    private readonly ApplicationDbContext _db;

    public StudentInfoController(ApplicationDbContext db)
    {
        _db = db;
    }
    // GET
    public IActionResult Index()
    {
       
        var obj = _db.StudentInfos.ToList();
        return View(obj);
    }

   
}
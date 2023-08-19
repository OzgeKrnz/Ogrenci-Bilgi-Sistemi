using StajProjesi.Areas.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajProjesi.Models;

public class Classes1Controller : Controller
{
    private readonly Classes1DbContext _db;
    
    public Classes1Controller(Classes1DbContext db)
    { 
        _db = db;
    }


    public IActionResult Index()
    {
        var obj = _db.Secondt.ToList();

        return View(obj);
    }
}
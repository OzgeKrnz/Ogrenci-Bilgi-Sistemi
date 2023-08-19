using Microsoft.AspNetCore.Mvc;

namespace StajProjesi.Controllers;

public class AcademicCalendarController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
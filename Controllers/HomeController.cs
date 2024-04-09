using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Intex1_10.Models;

namespace Intex1_10.Controllers;

public class HomeController : Controller
{
    private IIntexRepository _repo;
    public HomeController(IIntexRepository temp)
    {
        _repo = temp;
    }

    [HttpGet]
    public IActionResult Index()
    {
        // This query will be executed at the database when called
        var test = _repo.Customers.FirstOrDefault(x => x.FirstName == "William");

        // Ensure that 'test' is not null before using it
        if (test == null)
        {
            // Handle the case when no customer is found
            // Maybe redirect to another view or display a message
        }

        return View(test);
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Intex1_10.Models;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;

namespace Intex1_10.Controllers;

public class HomeController : Controller
{
    private IIntexRepository _repo;
    public HomeController(IIntexRepository temp)
    {
        _repo = temp;
    }

    public IActionResult Index()
    {
       var productData = _repo.Product
           .OrderBy(x => x.Name)
           .Take(6);
           

        // Pass the collection of products to the view
        return View(productData);
       
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
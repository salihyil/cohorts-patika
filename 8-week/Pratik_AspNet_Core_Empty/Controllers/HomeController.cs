using Microsoft.AspNetCore.Mvc;
using Pratik_AspNet_Core_Empty.Models;

namespace Pratik_AspNet_Core_Empty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            TestViewModel testViewModel = new TestViewModel("Salih", "Yılmaz", 29);

            return View(testViewModel);
        }
    }
}
using _200584677.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _200584677.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Student student = new Student();
            student.FirstName = "Carlos";
            student.LastName = "Bonilla";
            student.StudentId = 200584677;
            student.EmailAddress = "bonillacarlos.1511@gmail.com";
            return View(student);
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
}

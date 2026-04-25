using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestTask_EmployeeImport.Models;

namespace TestTask_EmployeeImport.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public IActionResult UploadCSV(IFormFile file)
        {
            if(file == null || file.Length == 0)
                return BadRequest("No file uploaded.");



			return Ok();
        }
        
        
        
        public IActionResult Index()
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

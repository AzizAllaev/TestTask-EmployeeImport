using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestTask_EmployeeImport.Models;
using TestTask_EmployeeImport.Services;

namespace TestTask_EmployeeImport.Controllers
{
    public class HomeController : Controller
    {

		public HomeController(AppDbContext context, DataImportService dataImportService)
		{
			_context = context;
			_dataImportService = dataImportService;
		}

		private readonly AppDbContext _context;
		private readonly DataImportService _dataImportService;


		[HttpPost]
		public async Task<IActionResult> UploadCSV(IFormFile file)
		{
			if (file == null || file.Length == 0)
				return BadRequest("No file uploaded.");

			var employees = new List<Employee>();

			await _dataImportService.FillEmployeeListAsync(file, employees);

			if (employees.Count > 0)
			{
				_context.Employees.AddRange(employees);
				await _context.SaveChangesAsync();
			}

			return RedirectToAction("Index");
		}

		public IActionResult Index()
        {
			var employees = _context.Employees.ToList();
			return View(employees);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

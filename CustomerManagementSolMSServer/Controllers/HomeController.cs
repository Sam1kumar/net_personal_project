using CustomerManagementSolMSServer.Data;
using CustomerManagementSolMSServer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CustomerManagementSolMSServer.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly UserDbContext _db;

		public HomeController(ILogger<HomeController> logger, UserDbContext db)
		{
			_logger = logger;
			_db = db;
		}

		public IActionResult Index()
		{
			var userList = _db.Users.ToList();
			return View(userList);
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
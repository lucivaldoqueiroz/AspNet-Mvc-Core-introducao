using Microsoft.AspNetCore.Mvc;

namespace lnpqdev.iu.AppModelo.Controllers
{
	public class HomeController: Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

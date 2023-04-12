using Microsoft.AspNetCore.Mvc;

namespace MVCSallesWeb.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

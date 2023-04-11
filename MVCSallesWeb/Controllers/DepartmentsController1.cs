using Microsoft.AspNetCore.Mvc;
using MVCSallesWeb.Models;

namespace MVCSallesWeb.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronics" });
            list.Add(new Department { Id = 2, Name = "Fashion" });
            list.Add(new Department { Id = 3, Name = "Sports" });
            list.Add(new Department { Id = 4, Name = "Music" });

            return View(list);
        }
    }
}

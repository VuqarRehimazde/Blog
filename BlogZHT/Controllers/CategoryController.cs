using Microsoft.AspNetCore.Mvc;

namespace BlogZHT.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

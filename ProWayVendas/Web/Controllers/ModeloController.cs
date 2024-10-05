using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ModeloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

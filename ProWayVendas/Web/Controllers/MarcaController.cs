using Microsoft.AspNetCore.Mvc;
using Web.ViewModels.Forms;

namespace Web.Controllers
{
    [Route("/marca")]
    public class MarcaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("cadastrar")]
        public IActionResult Cadastrar()
        {
            var form = new MarcaCadastrarViewModel();
            return View(form);
        }
    }
}

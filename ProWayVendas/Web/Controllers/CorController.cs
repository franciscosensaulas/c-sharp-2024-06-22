using Microsoft.AspNetCore.Mvc;
using Web.ViewModels;
using Web.ViewModels.Forms;

namespace Web.Controllers
{
    [Route("/cor")]
    public class CorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var cores = new List<CorViewModel>();
            
            return View(cores);
        }

        [HttpGet]
        [Route("cadastrar")]
        public IActionResult Cadastrar()
        {
            var form = new CorCadastrarViewModel();
            return View(form);
        }
    }
}

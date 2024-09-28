using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/calculadora/somar")]
        public IActionResult Somar(int numero1, int numero2)
        {
            var soma = numero1 + numero2;

            // Passar a variável soma para o cshtml(html)
            ViewBag.ResultadoSoma = soma;

            return View();
        }
    }
}

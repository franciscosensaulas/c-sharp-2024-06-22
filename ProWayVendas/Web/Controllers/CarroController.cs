using Microsoft.AspNetCore.Mvc;
using Web.ViewModels;


namespace Web.Controllers
{
    public class CarroController : Controller
    {
        List<string> Marcas = new List<string>
        {
            "Chevrolet",
            "Fiat",
            "Ford",
            "Volkswagen",
        };

        static int ProximoCodigo = 0;
        static List<Carro> Carros = new List<Carro>
        {
            new Carro
            {
                Id = ++ProximoCodigo,
                Marca = "Chevrolet",
                Modelo = "Astra",
                Ano = 2008,
                Descricao = "Modelo v8"
            },
            new Carro
            {
                Id = ++ProximoCodigo,
                Marca = "Fiat",
                Modelo = "Uno",
                Ano = 1996,
                Descricao = "Com escada"
            },
            new Carro
            {
                Id = ++ProximoCodigo,
                Marca = "Ford",
                Modelo = "Belina",
                Ano = 1980,
                Descricao = "Branca com Bege"
            },
        };
        public IActionResult Index()
        {
            // Passar para o html a lista de carros para poder listar os carros para o usuário
            ViewBag.Carros = Carros;
            return View();
        }

        [HttpGet]
        [Route("/carro/cadastrar")]
        public IActionResult Cadastrar(string marca, string modelo, int ano, string? descricao)
        {
            // Instancinaod um objeto da classe Carro, definindo valor
            // para as propriedades do Carro
            var carro = new Carro
            {
                Id = ++ProximoCodigo,
                Marca = marca,
                Modelo = modelo,
                Ano = ano,
                Descricao = descricao
            };
            // Adicionar o carro na lista de carros
            CarroController.Carros.Add(carro);

            // Redirecionamento para a lista a action que lista os carros
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("/carro/apagar")]
        public IActionResult Apagar(int id)
        {
            // Percorrer cada um dos carros para buscar o carro que contém
            // o id que o usuário deseja apagar
            foreach (var carro in Carros.ToList())
            {
                // Verificar se o carro percorrido contém o mesmo id para apagar
                if (carro.Id == id)
                    // Remover o carro da lista de carros
                    Carros.Remove(carro);
            }

            // Redirecionamento para a lista a action que lista os carros
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("/carro/editar")]
        public IActionResult Editar(int id)
        {
            foreach(Carro carro in Carros)
            {
                if (carro.Id == id)
                {
                    ViewBag.Marcas = Marcas;
                    ViewBag.Carro = carro;
                    return View();
                }
            }

            return NotFound();
        }

        [HttpPost]
        [Route("/carro/editar")]
        public IActionResult Editar(
            int id, string marca, string modelo, int ano, string? descricao)
        {
            foreach (Carro carro in Carros)
            {
                if (carro.Id == id)
                {
                    carro.Marca = marca;
                    carro.Modelo = modelo;
                    carro.Ano = ano;
                    carro.Descricao = descricao;
                    return RedirectToAction("Index");
                }
            }

            return NotFound();
        }
    }
}

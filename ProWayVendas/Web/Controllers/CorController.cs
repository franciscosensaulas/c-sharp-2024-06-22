using Microsoft.AspNetCore.Mvc;
using Web.BancoDados;
using Web.Entidades;
using Web.ViewModels;
using Web.ViewModels.Forms;

namespace Web.Controllers
{
    [Route("/cor")]
    public class CorController : Controller
    {
        private readonly VendasContexto _contexto;

        public CorController(VendasContexto contexto)
        {
            _contexto = contexto;    
        }

        [HttpGet]
        public IActionResult Index()
        {
            // Consultar todas as cores
            // SELECT * FROM cores
            var cores = _contexto.Cores.ToList();

            // Criar a lista de cores que será utilizado na tela
            var coresViewModel = new List<CorViewModel>();
            // Percorrer cada uma das cores que foram consultadas na tabela de cores
            foreach(var cor in cores)
            {
                //var corViewModel = new CorViewModel();
                //corViewModel.Id = cor.Id;
                //corViewModel.Nome = cor.Nome;

                // Inicialização rápida de objeto
                var corViewModel = new CorViewModel
                {
                    Id = cor.Id,
                    Nome = cor.Nome
                };
                // Adicionado o view Model na lista de view models
                coresViewModel.Add(corViewModel);
            }
            // Chamando a view passando a lista de view models
            return View(coresViewModel);
        }

        [HttpGet]
        [Route("cadastrar")]
        public IActionResult Cadastrar()
        {
            var form = new CorCadastrarViewModel();
            return View(form);
        }

        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar(string nome)
        {
            // Instanciando um objeto da classe Cor
            var cor = new Cor();
            // Atribuindo valor para a propriedado, este valor veio do form que o usuário preencheu
            cor.Nome = nome;

            // Adicionando na tabela de cores a cor que foi instanciada
            _contexto.Cores.Add(cor);
            // Concretizando o insert na base de dados
            // INSERT INTO cores (nome) VALUES ('Cinza');  Comando de exemplo
            _contexto.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("apagar")]
        public IActionResult Apagar(int id)
        {
            // Consultando a cor filtrando por id
            var cor = _contexto.Cores.Find(id);
            // Caso não encontrar a cor retornar 404 (not found)
            if (cor is null)
                return NotFound("Cor não encontrada");

            // Remover a cor da lista de cores
            _contexto.Cores.Remove(cor);
            // Concretizar o delete na tabela de cores
            // DELETE FROM cores WHERE id = 1;  Comando de exemplo
            _contexto.SaveChanges();

            // Redirecionar para a lista de cores
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("editar")]
        public IActionResult Editar(int id)
        {
            // Consultar a cor filtrando por id da tabela de cores
            var cor = _contexto.Cores.Find(id);
            if(cor is null)
                return NotFound("Cor não encontrada");

            var viewModel = new CorEditarViewModel();
            viewModel.Id = cor.Id;
            viewModel.Nome = cor.Nome;

            return View(viewModel);
        }

        [HttpPost]
        [Route("editar")]
        public IActionResult Editar(int id, string nome)
        {
            // Consultar a cor filtrando por id da tabela de cores
            var cor = _contexto.Cores.Find(id);
            if (cor is null)
                return NotFound("Cor não encontrada");

            // Definindo o nome do objeto da cor que foi consultada na tabela de cores
            cor.Nome = nome;
            // Concretizando o atualização dos dados da cor
            // UPDATE cores SET nome = 'Cinza' WHERE id = 1; Comando de exemplo
            _contexto.SaveChanges();

            // Redirecionar para listagem de cores
            return RedirectToAction("Index");
        }
    }
}

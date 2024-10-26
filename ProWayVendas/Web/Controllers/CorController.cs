using Microsoft.AspNetCore.Mvc;
using Servicos.Dtos.Cor;
using Servicos.Interfaces;
using Web.ViewModels;
using Web.ViewModels.Forms;

namespace Web.Controllers
{
    [Route("/cor")]
    public class CorController : Controller
    {
        private readonly ICorServico _servico;

        public CorController(ICorServico servico)
        {
            _servico = servico;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var dtos = _servico.ObterTodos();

            // Criar a lista de cores que será utilizado na tela
            var coresViewModel = new List<CorViewModel>();
            // Percorrer cada uma das cores que foram consultadas na tabela de cores
            foreach (var corDto in dtos)
            {
                // Inicialização rápida de objeto
                var corViewModel = new CorViewModel
                {
                    Id = corDto.Id,
                    Nome = corDto.Nome
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
        public IActionResult Cadastrar(CorCadastrarViewModel viewModel)
        {
            var dto = new CorCadastrarDto
            {
                Nome = viewModel.Nome!
            };
            _servico.Cadastrar(dto);

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("apagar")]
        public IActionResult Apagar(int id)
        {
            try
            {
                _servico.Apagar(id);
                // Redirecionar para a lista de cores
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Route("editar")]
        public IActionResult Editar(int id)
        {
            try
            {
                // Consultar a cor filtrando por id da tabela de cores
                var dto = _servico.ObterPorId(id);

                var viewModel = new CorEditarViewModel
                {
                    Id = dto.Id,
                    Nome = dto.Nome
                };

                return View(viewModel);
            }
            catch (Exception ex)
            {
                return NotFound("Cor não encontrada");
            }
        }

        [HttpPost]
        [Route("editar")]
        public IActionResult Editar(CorEditarViewModel viewModel)
        {
            var dto = new CorEditarDto
            {
                Id = viewModel.Id,
                Nome = viewModel.Nome
            };
            _servico.Editar(dto);

            // Redirecionar para listagem de cores
            return RedirectToAction("Index");
        }
    }
}

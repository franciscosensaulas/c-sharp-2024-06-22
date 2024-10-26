using Microsoft.AspNetCore.Mvc;
using Repositorios.Entidades;
using Repositorios.Interfaces;
using Servicos.Dtos.Marca;
using Servicos.Interfaces;
using Web.ViewModels;
using Web.ViewModels.Forms;

namespace Web.Controllers
{
    [Route("/marca")]
    public class MarcaController : Controller
    {
        private readonly IMarcaServico _servico;

        public MarcaController(IMarcaServico servico)
        {
            _servico = servico;
        }

        [HttpGet]
        public IActionResult Index([FromQuery] string? nome, [FromQuery] string? cnpj)
        {
            var dtos = _servico.ObterTodos(nome, cnpj);

            var viewModels = new List<MarcaViewModel>();

            foreach (var dto in dtos)
            {
                var viewModel = new MarcaViewModel
                {
                    Id = dto.Id,
                    Nome = dto.Nome,
                    Cnpj = dto.Cnpj,
                };
                viewModels.Add(viewModel);
            }

            ViewBag.PesquisaNome = nome ?? string.Empty;
            ViewBag.PesquisaCnpj = cnpj ?? string.Empty;

            return View(viewModels);
        }

        [HttpGet]
        [Route("cadastrar")]
        public IActionResult Cadastrar()
        {
            var form = new MarcaCadastrarViewModel();
            return View(form);
        }

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar(MarcaCadastrarViewModel viewModel)
        {
            if (ModelState.IsValid == false)
            {
                return View(viewModel);
            }

            var dto = new MarcaCadastrarDto
            {
                Nome = viewModel.Nome!,
                Cnpj = viewModel.Cnpj!,
                Descricao = viewModel.Descricao
            };
            _servico.Cadastrar(dto);

            return RedirectToAction("Index");
        }

        [HttpGet("apagar")]
        public IActionResult Apagar(int id)
        {
            try
            {
                _servico.Apagar(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpGet("editar")]
        public IActionResult Editar(int id)
        {
            try
            {

                var marca = _servico.ObterPorId(id);

                var viewModel = new MarcaEditarViewModel
                {
                    Id = marca.Id,
                    Nome = marca.Nome,
                    Cnpj = marca.Cnpj,
                    Descricao = marca.Descricao
                };

                return View(viewModel);
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        [HttpPost("editar")]
        public IActionResult Editar([FromForm] MarcaEditarViewModel viewModel, [FromQuery] int id)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    viewModel.Id = id;
                    return View(viewModel);
                }

                var dto = new MarcaEditarDto
                {
                    Id = id,
                    Nome = viewModel.Nome!,
                    Descricao = viewModel.Descricao,
                    Cnpj = viewModel.Cnpj!
                };

                _servico.Editar(dto);

                return RedirectToAction("Index");
            }
            catch
            {
                return NotFound();
            }
        }
    }
}

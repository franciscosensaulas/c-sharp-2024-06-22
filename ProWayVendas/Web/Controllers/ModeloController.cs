using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repositorios.Enums;
using Servicos.Dtos.Modelo;
using Servicos.Interfaces;
using Web.Extensions;
using Web.ViewModels;
using Web.ViewModels.Forms;

namespace Web.Controllers
{
    [Route("/modelo")]
    public class ModeloController : Controller
    {
        private readonly IModeloServico _servico;
        private readonly IMarcaServico _marcaServico;

        public ModeloController(IModeloServico servico, IMarcaServico marcaServico)
        {
            _servico = servico;
            _marcaServico = marcaServico;
        }
        
        public IActionResult Index([FromQuery]string? nome, [FromQuery]int? marcaId)
        {
            var modeloDtos = _servico.ObterTodos(nome, marcaId);
            var modeloViewModel = modeloDtos.Select(x => new ModeloViewModel
            {
                Nome = x.Nome,
                Id = x.Id,
                Classificacao = x.Classificacao,
                Marca = x.Marca
            }).ToList();   
            
            return View(modeloViewModel);
        }

        [HttpGet("cadastrar")]
        public IActionResult Cadastrar()
        {
            var marcaDtos = _marcaServico.ObterTodos(string.Empty, string.Empty);

            var viewModel = new ModeloTelaCadastroViewModel
            {
                Form = new ModeloCadastrarViewModel(),
                Marcas = marcaDtos.Select(x => new SelectListItem(x.Nome, x.Id.ToString())).ToList(),
                Classificacoes = Enum.GetValues(typeof(ModeloClassificacao))
                    .Cast<ModeloClassificacao>().Select(x => new SelectListItem(x.ObterDescricao(), ((int)x).ToString())).ToList()
            };
            return View(viewModel);
        }

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar([FromForm] ModeloTelaCadastroViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                var marcaDtos = _marcaServico.ObterTodos(string.Empty, string.Empty);
                viewModel.Marcas = marcaDtos.Select(x => new SelectListItem(x.Nome, x.Id.ToString())).ToList();
                viewModel.Classificacoes = Enum.GetValues(typeof(ModeloClassificacao))
                    .Cast<ModeloClassificacao>()
                    .Select(x => new SelectListItem(x.ObterDescricao(), ((int)x).ToString())).ToList();
                return View(viewModel);
            }

            var modeloCadastrarDto = new ModeloCadastrarDto
            {
                Nome = viewModel.Form.Nome!,
                Classificacao = (ModeloClassificacao)viewModel.Form.Classificacao!,
                MarcaId = viewModel.Form.MarcaId.GetValueOrDefault()
            };
            _servico.Cadastrar(modeloCadastrarDto);
            return RedirectToAction("Index");
        }
        
    }
}

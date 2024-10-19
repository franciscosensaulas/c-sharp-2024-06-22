using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Reflection;
using Web.BancoDados;
using Web.Entidades;
using Web.Migrations;
using Web.ViewModels;
using Web.ViewModels.Forms;

namespace Web.Controllers
{
    [Route("/marca")]
    public class MarcaController : Controller
    {
        private readonly VendasContexto _contexto;

        public MarcaController(VendasContexto contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]
        public IActionResult Index([FromQuery] string? nome, [FromQuery] string? cnpj)
        {
            var query = _contexto.Marcas.Where(x => x.RegistroAtivo == true).AsQueryable();

            if(!string.IsNullOrEmpty(nome))
            {
                query = query.Where(x => x.Nome.ToLower().Contains(nome.ToLower()));
            }

            if (!string.IsNullOrEmpty(cnpj))
            {
                query = query.Where(x => x.Cnpj.Contains(cnpj));
            }

            query = query.OrderBy(x => x.Nome);

            var marcas = query.ToList();

            var viewModels = new List<MarcaViewModel>();

            foreach (var marca in marcas)
            {
                var viewModel = new MarcaViewModel
                {
                    Id = marca.Id,
                    Nome = marca.Nome,
                    Cnpj = marca.Cnpj,
                };
                viewModels.Add(viewModel);
            }

            ViewBag.PesquisaNome = nome ?? "";
            ViewBag.PesquisaCnpj = cnpj ?? "";

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
            if(ModelState.IsValid == false)
            {
                return View(viewModel);
            }

            var marca = new Marca
            {
                Nome = viewModel.Nome,
                Cnpj = viewModel.Cnpj,
                Descricao = viewModel.Descricao
            };
            _contexto.Marcas.Add(marca);
            _contexto.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet("apagar")]
        public IActionResult Apagar(int id)
        {
            var marca = _contexto.Marcas.Find(id);

            if (marca is null)
                return NotFound();

            marca.RegistroAtivo = false;
            _contexto.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("editar")]
        public IActionResult Editar(int id)
        {
            var marca = _contexto.Marcas.Find(id);

            if (marca is null)
                return NotFound();

            var viewModel = new MarcaEditarViewModel
            {
                Id = marca.Id,
                Nome = marca.Nome,
                Cnpj = marca.Cnpj,
                Descricao = marca.Descricao
            };

            return View(viewModel);
        }

        [HttpPost("editar")]
        public IActionResult Editar([FromForm]MarcaEditarViewModel viewModel, [FromQuery] int id)
        {
            var marca = _contexto.Marcas.Find(id);
            if (marca is null)
                return NotFound();

            if (ModelState.IsValid == false)
            {
                viewModel.Id = id;
                return View(viewModel);
            }

            marca.Nome = viewModel.Nome;
            marca.Descricao = viewModel.Descricao;
            marca.Cnpj = viewModel.Cnpj;
            _contexto.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}

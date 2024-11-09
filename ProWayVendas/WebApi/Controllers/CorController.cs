using Microsoft.AspNetCore.Mvc;
using Servicos.Dtos.Cor;
using Servicos.Interfaces;
using WebApi.Models.Cor;

namespace WebApi.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class CorController : Controller
{
    private readonly ICorServico _corServico;

    public CorController(ICorServico corServico)
    {
        _corServico = corServico;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var dtos = _corServico.ObterTodos();

        return Ok(dtos);
    }

    [HttpPost]
    public IActionResult Create([FromBody] CorCadastrarModel model)
    {
        var dto = new CorCadastrarDto
        {
            Nome = model.Nome!,
        };

        var id = _corServico.Cadastrar(dto);

        return CreatedAtAction(nameof(GetById), new { id = id }, dto);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        try
        {
            var dto = _corServico.ObterPorId(id);
            return Ok(dto);
        }
        catch (Exception ex)
        {
            return NotFound();
        }
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        try
        {
            _corServico.Apagar(id);
            return Ok();
        }
        catch (Exception ex)
        {
            return NotFound();
        }
    }

    [HttpPut("{id:int}")]
    public IActionResult Update(int id, [FromBody] CorEditarModel model)
    {
        try
        {
            var dto = new CorEditarDto
            {
                Id = id,
                Nome = model.Nome!
            };
            _corServico.Editar(dto);
            return Ok();
        }
        catch (Exception e)
        {
            return NotFound();
        }
    }

}
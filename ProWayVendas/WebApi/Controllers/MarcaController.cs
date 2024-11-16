using Microsoft.AspNetCore.Mvc;
using Servicos.Dtos.Marca;
using Servicos.Interfaces;
using WebApi.Models.Marca;
using Swashbuckle.AspNetCore.Annotations;

namespace WebApi.Controllers
{
    /// <summary>
    /// API Controller for managing 'Marca' (Brand) entities.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : Controller
    {
        private readonly IMarcaServico _marcaServico;

        public MarcaController(IMarcaServico marcaServico)
        {
            _marcaServico = marcaServico;
        }

        /// <summary>
        /// Get all 'Marca' entities.
        /// </summary>
        /// <returns>A list of all 'Marca' entities.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<MarcaDto>), 200)]
        [SwaggerOperation(Summary = "Get all brands", Description = "Retrieve a list of all brands.")]
        public async Task<IActionResult> GetAll() =>
            Ok(await _marcaServico.ObterTodos());

        /// <summary>
        /// Get a specific 'Marca' entity by ID.
        /// </summary>
        /// <param name="id">The ID of the 'Marca' to retrieve.</param>
        /// <returns>A 'Marca' entity.</returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(MarcaDto), 200)]
        [ProducesResponseType(404)]
        [SwaggerOperation(Summary = "Get a brand by ID", Description = "Retrieve a specific brand by its ID.")]
        public async Task<IActionResult> GetById(int id) =>
            Ok(await _marcaServico.ObterPorId(id));

        /// <summary>
        /// Create a new 'Marca' entity.
        /// </summary>
        /// <param name="dto">The 'Marca' details to create.</param>
        /// <returns>The created 'Marca' entity.</returns>
        [HttpPost]
        [ProducesResponseType(typeof(MarcaCadastrarDto), 201)]
        [SwaggerOperation(Summary = "Create a new brand", Description = "Create a new brand by providing necessary details.")]
        public async Task<IActionResult> Post([FromBody] MarcaCadastrarDto dto)
        {
            var marcaId = await _marcaServico.Cadastrar(dto);
            return CreatedAtAction(nameof(GetById), new { id = marcaId }, dto);
        }

        /// <summary>
        /// Update an existing 'Marca' entity.
        /// </summary>
        /// <param name="id">The ID of the 'Marca' to update.</param>
        /// <param name="model">The updated details of the 'Marca' entity.</param>
        /// <returns>No content if successful.</returns>
        [HttpPut("{id:int}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [SwaggerOperation(Summary = "Update an existing brand", Description = "Update the details of an existing brand by providing the new values.")]
        public async Task<IActionResult> Put(int id, [FromBody] MarcaEditarModel model)
        {
            var dto = new MarcaEditarDto()
            {
                Id = id,
                Nome = model.Nome!,
                Descricao = model.Descricao,
                Cnpj = model.Cnpj!
            };
            await _marcaServico.Editar(dto);
            return NoContent();
        }

        /// <summary>
        /// Delete an existing 'Marca' entity.
        /// </summary>
        /// <param name="id">The ID of the 'Marca' to delete.</param>
        /// <returns>No content if successful.</returns>
        [HttpDelete("{id:int}")]
        [ProducesResponseType(204)]
        [SwaggerOperation(Summary = "Delete a brand by ID", Description = "Delete a brand by its ID.")]
        public async Task<IActionResult> Delete(int id)
        {
            await _marcaServico.Apagar(id);
            return NoContent();
        }
    }
}

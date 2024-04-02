using EjemploOracle.DataAccess.Models;
using EjemploOracle.Services;
using Microsoft.AspNetCore.Mvc;

namespace EjemploOracle.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _service;
        public CategoriaController(ICategoriaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllCategorias()
        {
            var categorias = await _service.GetAllCategorias();
            return Ok(categorias);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Categorium>> GetCategoriaById(decimal id)
        {
            var categoria = await _service.GetCategoriaById(id);

            if (categoria != null)
            {

                return Ok(categoria);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<ActionResult<Categorium>> CreateCategoria(Categorium newCategoria)
        {
            var createdEntries = await _service.CreateCategoria(newCategoria);

            if (createdEntries > 0)
            {
                return Created("", newCategoria);

            }
            else
            {
                return BadRequest();
            }

        }

        [HttpPut]
        public async Task<ActionResult> UpdateCategoria(Categorium categoria)
        {
            var updatedEntries = await _service.UpdateCategoria(categoria);

            if (updatedEntries > 0)
            {
                return Ok(categoria);
            }
            else
            {
                return BadRequest();
            }


        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCategoria(decimal id)
        {
            var deletedEntries = await _service.DeleteCategoria(id);

            if (deletedEntries > 0)
            {
                return Ok(deletedEntries);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}

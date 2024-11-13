using Aplicacion.Feature.Inventario.Categorias.Commands.CreateCategoria;
using Aplicacion.Feature.Inventario.Categorias.Queries.GetAllCategoria;
using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    public class CategoriasController : BaseApiController
    {
        //POST api/<controller>
        [HttpPost]
        // [Authorize]
        public async Task<IActionResult> Post(CreateCategoriaCommand comando)
        {
            return Ok(await Mediator.Send(comando));
        }

        // [HttpPut("{id}")]
        // [Authorize]
        // public async Task<IActionResult> Put(string id, UpdateCategoriaCommand comando)
        // {
        //     if (id != comando.Id)
        //     {
        //         return BadRequest();
        //     }
        //     return Ok(await Mediator.Send(comando));
        // }

        // [HttpDelete("{id}")]
        // [Authorize(Roles = "Admin")]
        // public async Task<IActionResult> Delete(string id)
        // {
        //     return Ok(await Mediator.Send(new DeleteClienteCommand { Id = id }));
        // }

        // [HttpGet("{id}")]
        // public async Task<IActionResult> Get(string id)
        // {
        //     return Ok(await Mediator.Send(new GetClienteByIdQuery { Id = id }));
        // }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllCategoriasParameters filter)
        {
            return Ok(await Mediator.Send(new GetAllCategoriaQuery
            {
                PageNumber = filter.PageNumer,
                PageSize = filter.PageSize,
                Nombre = filter.Nombre,
                Descripcion = filter.Descripcion
            }));
        }
    }
}
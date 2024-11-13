
using Aplicacion.Wrappers;
using MediatR;

namespace Aplicacion.Feature.Inventario.Categorias.Commands.CreateCategoria
{
    public class CreateCategoriaCommand : IRequest<Response<string>>
    {
        public required string Nombre { get; set; }
        public string? Descripcion { get; set; }
    }
}
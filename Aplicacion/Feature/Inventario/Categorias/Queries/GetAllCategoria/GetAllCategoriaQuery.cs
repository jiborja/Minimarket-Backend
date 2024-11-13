using Aplicacion.DTOs;
using Aplicacion.Wrappers;
using MediatR;

namespace Aplicacion.Feature.Inventario.Categorias.Queries.GetAllCategoria
{
    public class GetAllCategoriaQuery : IRequest<PagedResponse<List<CategoriaDto>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
    }
}
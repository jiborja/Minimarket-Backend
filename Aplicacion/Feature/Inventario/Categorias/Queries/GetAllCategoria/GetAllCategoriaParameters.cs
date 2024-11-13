
using Aplicacion.Parameters;

namespace Aplicacion.Feature.Inventario.Categorias.Queries.GetAllCategoria
{
    public class GetAllCategoriasParameters : RequestParameter
    {
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
    }
}
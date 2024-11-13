using Ardalis.Specification;
using Dominio.Inventario;

namespace Aplicacion.Specifications
{
    public class PagedCategoriaSpecification : Specification<Categoria>
    {
        public PagedCategoriaSpecification(int pageSize, int pageNumber, string nombre, string? descripcion)
        {
          
            if (!string.IsNullOrEmpty(nombre))
            {
                Query.Search(x => x.Nombre, "%" + nombre + "%");
            }

            if (!string.IsNullOrEmpty(descripcion))
            {
                Query.Search(x => x.Descripcion, "%" + descripcion + "%");
            }

            Query.Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);

        }
    }
}
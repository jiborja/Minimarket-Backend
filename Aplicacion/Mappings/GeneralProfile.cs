using Aplicacion.DTOs;
using Aplicacion.Feature.Inventario.Categorias.Commands.CreateCategoria;
using AutoMapper;
using Dominio.Inventario;

namespace Aplicacion.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            #region Commands
            CreateMap<CreateCategoriaCommand, Categoria>();                
            #endregion

            #region  DTOs
            CreateMap<Categoria,CategoriaDto>();
            #endregion
        }
    }
}
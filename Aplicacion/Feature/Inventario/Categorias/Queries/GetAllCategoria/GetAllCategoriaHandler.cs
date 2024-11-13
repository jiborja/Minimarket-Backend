using System.Text;
using System.Text.Json;
using Aplicacion.DTOs;
using Aplicacion.Specifications;
using Aplicacion.Wrappers;
using AutoMapper;
using Dominio.Inventario;
using MediatR;
using Microsoft.Extensions.Caching.Distributed;
using Persistencia.Interfaces;

namespace Aplicacion.Feature.Inventario.Categorias.Queries.GetAllCategoria
{
    public class GetAllCategoriaHandler : IRequestHandler<GetAllCategoriaQuery, PagedResponse<List<CategoriaDto>>>
    {
        private readonly IRepositoryAsync<Categoria> _repositoryAsync;
        // private readonly IDistributedCache _distributedCache;
        private readonly IMapper _mapper;

        public GetAllCategoriaHandler(IRepositoryAsync<Categoria> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
            // _distributedCache = distributedCache;
        }

        public async Task<PagedResponse<List<CategoriaDto>>> Handle(GetAllCategoriaQuery request, CancellationToken cancellationToken)
        {
            var cacheKey = $"ListadoCategorias_{request.PageNumber}_{request.PageSize}_{request.Nombre}_{request.Descripcion}";
            string serializedListadoCategorias = string.Empty;
            var listadoCategorias = new List<Categoria>();
            // var redisListadoCategorias = await _distributedCache.GetAsync(cacheKey);

            // if (redisListadoCategorias != null)
            // {
            //     serializedListadoCategorias = Encoding.UTF8.GetString(redisListadoCategorias);
            //     listadoCategorias =  JsonSerializer.Deserialize<List<Categoria>>(serializedListadoCategorias);
            // }
            // else
            // {
                listadoCategorias = await _repositoryAsync.ListAsync(new PagedCategoriaSpecification(request.PageSize, request.PageNumber, request.Nombre, request.Descripcion));
                serializedListadoCategorias = JsonSerializer.Serialize(listadoCategorias);
                // redisListadoCategorias = Encoding.UTF8.GetBytes(serializedListadoCategorias);

                var options = new DistributedCacheEntryOptions().SetAbsoluteExpiration(DateTime.Now.AddMinutes(10))
                .SetSlidingExpiration(TimeSpan.FromMinutes(2));

                // await _distributedCache.SetAsync(cacheKey,redisListadoCategorias,options);
            // }

            var categoriaDtos = _mapper.Map<List<CategoriaDto>>(listadoCategorias);

            return new PagedResponse<List<CategoriaDto>>(categoriaDtos, request.PageNumber, request.PageSize);
        }
    }
}
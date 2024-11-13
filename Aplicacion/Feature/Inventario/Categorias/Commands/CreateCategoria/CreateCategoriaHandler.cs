using Persistencia.Interfaces;
using AutoMapper;
using Dominio.Inventario;
using MediatR;
using Aplicacion.Wrappers;

namespace Aplicacion.Feature.Inventario.Categorias.Commands.CreateCategoria
{
    public class CreateCategoriaHandler : IRequestHandler<CreateCategoriaCommand, Response<string>>
    {
        private readonly IRepositoryAsync<Categoria> _repositoryAsync;
        private readonly IMapper _mapper;

        public CreateCategoriaHandler(IRepositoryAsync<Categoria> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<string>> Handle(CreateCategoriaCommand request, CancellationToken cancellationToken)
        {
            var nuevoRegistro = _mapper.Map<Categoria>(request);
            var data = await _repositoryAsync.AddAsync(nuevoRegistro);

            return new Response<string>(data.Id);
        }
    }
}
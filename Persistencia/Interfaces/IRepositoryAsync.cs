using Ardalis.Specification;

namespace Persistencia.Interfaces
{
    public interface IRepositoryAsync<T> : IRepositoryBase<T> where T : class
    {
         
    }
    public interface IReadRespositoryAsync<T> : IReadRepositoryBase<T> where T : class
    {}
}
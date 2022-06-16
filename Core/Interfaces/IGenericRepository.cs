using Core.Specifications;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<IReadOnlyList<T>> GetAll();
        Task<T> GetSpec(ISpecification<T> spec);
        Task<IReadOnlyList<T>> GetAll(ISpecification<T> spec);
    }
}

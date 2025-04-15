namespace CurriculoDigital.Domain.IRepository
{
    public interface IRepositoryGeneric<T> where T : class
    {
        Task<T> Get();
        Task<T> Post(T entidade);
        Task<T> GetById(long id);
        Task<T> Put(T entidade);
        Task<T> Delete(long id);
    }
}
using CurriculoDigital.Domain.IRepository;

namespace CurriculoDigital.Domain.Services.Base
{
    public class ServiceGeneric<T> where T : class
    {
        private readonly IRepositoryGeneric<T> _repository;

        public ServiceGeneric(IRepositoryGeneric<T> repository)
        {
            _repository = repository;
        }

        public virtual async Task<T> GetAsync()
        {
            return await _repository.Get();
        }

        public virtual async Task<T> GetByIdAsync(long id)
        {
            return await _repository.GetById(id);
        }

        public virtual async Task<T> PostAsync(T entity)
        {
            return await _repository.Post(entity);
        }

        public virtual async Task<T> PutAsync(T entity)
        {
            return await _repository.Put(entity);
        }

        public virtual async Task<T> DeleteAsync(long id)
        {
            return await _repository.Delete(id);
        }
    }
}
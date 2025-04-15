using CurriculoDigital.Domain.IRepository;
using Microsoft.EntityFrameworkCore;

namespace CurriculoDigital.Infra.Base
{
    public class RepositoryGeneric<T> : IRepositoryGeneric<T> where T : class
    {
        protected readonly DatabaseContext _context;
        protected readonly DbSet<T> _dbSet;

        public RepositoryGeneric(DatabaseContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<T> Get()
        {
            return await _dbSet.FirstOrDefaultAsync();
        }

        public async Task<T> GetById(long id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T> Post(T entidade)
        {
            await _dbSet.AddAsync(entidade);
            await _context.SaveChangesAsync();
            return entidade;
        }

        public async Task<T> Put(T entidade)
        {
            _dbSet.Update(entidade);
            await _context.SaveChangesAsync();
            return entidade;
        }

        public async Task<T> Delete(long id)
        {
            var entidade = await _dbSet.FindAsync(id);
            if (entidade != null)
            {
                _dbSet.Remove(entidade);
                await _context.SaveChangesAsync();
            }
            return entidade;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YolArkadasim.Shared.Data.Abstract;
using YolArkadasim.Shared.Entities.Abstract;

namespace YolArkadasim.Shared.Data.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
    {
        protected readonly DbContext _context;

        public EfEntityRepositoryBase(DbContext context)
        {
            _context = context;
        }
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity); // await _context.Set<TEntity>(): TEntity'e subscribe oluyoruz. 
            return entity;
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            return await (predicate == null ? _context.Set<TEntity>().CountAsync() : _context.Set<TEntity>().CountAsync(predicate));
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Remove(entity); }); //Task.Run(() : Remove asyn olmadığı için böyle bir yöntem izledik.
        }

        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, 
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
            // Kodlarımızı predicate'in null olma durumunu da sorgulayarak yazıyoruz.

            IQueryable<TEntity> query = _context.Set<TEntity>();//includeProperties için
            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (includeProperties.Any())//dizinin içerisinde herhangi bir değer varsa..
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }

            return await query.ToListAsync(); //kullanıcıya liste döndür.
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        { 
            // Kodlarımızı predicate'in null olma durumunu da sorgulayarak yazıyoruz.

            IQueryable<TEntity> query = _context.Set<TEntity>(); //includeProperties için
            query = query.Where(predicate);

            if (includeProperties.Any()) //dizinin içerisinde herhangi bir değer varsa..
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }

            return await query.SingleOrDefaultAsync(); //kullanıcıya nesneyi döndür.
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Update(entity); });
            return entity;
        }
    }
}

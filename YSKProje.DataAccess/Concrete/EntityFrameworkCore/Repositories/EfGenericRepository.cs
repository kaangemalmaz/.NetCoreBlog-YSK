using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using YSKProje.DataAccess.Concrete.EntityFrameworkCore.Context;
using YSKProje.DataAccess.Interfaces;
using ITable = YSKProje.Entities.Interfaces.ITable;

namespace YSKProje.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericRepository<TEntity> : IGenericDal<TEntity>
        where TEntity : class, ITable, new()
    {

        public async Task AddAsync(TEntity entity)
        {
            using var context = new UdemyBlogContext();
            await context.Set<TEntity>().AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task<TEntity> FindByIdAsync(int id)
        {
            using var context = new UdemyBlogContext();
            return await context.Set<TEntity>().FindAsync(id);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            using var context = new UdemyBlogContext();
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression)
        {
            using var context = new UdemyBlogContext();
            return await context.Set<TEntity>().Where(expression).ToListAsync();

        }
        public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, TKey>> keySelector)
        {
            using var context = new UdemyBlogContext();
            return await context.Set<TEntity>().Where(expression).OrderByDescending(keySelector).ToListAsync();
        }

        public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, TKey>> keySelector)
        {
            using var context = new UdemyBlogContext();
            return await context.Set<TEntity>().OrderByDescending(keySelector).ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
        {
            using var context = new UdemyBlogContext();
            return await context.Set<TEntity>().Where(expression).FirstOrDefaultAsync();
        }

        public async Task RemoveAsync(TEntity entity)
        {
            using var context = new UdemyBlogContext();
            context.Set<TEntity>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            using var context = new UdemyBlogContext();
            context.Set<TEntity>().Update(entity);
            await context.SaveChangesAsync();
        }
    }
}

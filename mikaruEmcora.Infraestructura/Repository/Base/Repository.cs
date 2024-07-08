using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MikaruEmcora.Core;
using MikaruEmcora.Core.Entities;
using MikaruEmcora.Core.Entities.Base;
using MikaruEmcora.Core.Repositories.Base;
using MikaruEmcora.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MikaruEmcora.Infraestructure.Repository.Base {
    public class Repository<T> : IRepository<T> where T : BaseEntity {
        protected readonly MikaruEmcoraContext dbContext;
        public Repository(MikaruEmcoraContext dbContext) { this.dbContext = dbContext; }

        public async Task<T> AddAsync(T entity) {
            dbContext.Set<T>().Add(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity) {
            dbContext.Set<T>().Remove(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync() {
            return await dbContext.Set<T>().ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate) {
            return await dbContext.Set<T>().Where(predicate).ToListAsync();
        }
        public async Task<T> GetByIdAsync(int id) {
            return await dbContext.Set<T>().FindAsync(id);
        }
        public async Task UpdateAsync(T entity) {
            dbContext.Entry(entity).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
        }

    }
}

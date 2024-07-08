using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MikaruEmcora.Core.Entities.Base;

namespace MikaruEmcora.Core.Repositories.Base {
    public interface IRepository<T> where T: BaseEntity {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate);
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        //es mala practica meter aqui un metodo que devuelva datos por nombre
    }
}

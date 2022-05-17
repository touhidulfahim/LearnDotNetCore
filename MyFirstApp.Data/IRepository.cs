using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyFirstApp.Data
{
    public interface IRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
    {
        void Add(TEntity item);
        void Update(TEntity item);
        void Remove(TKey id); 
        void Remove(TEntity entityToDelete);
        void Remove(Expression<Func<TEntity, bool>> filter);
        IList<TEntity> GetAll();
        TEntity GetById(TKey id);
        void Edit(TEntity entityToUpdate);
    }
}

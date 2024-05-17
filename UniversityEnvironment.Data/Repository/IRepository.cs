using UniversityEnvironment.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Linq.Expressions;


namespace UniversityEnvironment.Data.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> filter = null);
        TEntity? FindById(Guid id);
        TEntity? FindByFilter(Expression<Func<TEntity, bool>> filter);
        void Create(TEntity obj);
        int Create(IEnumerable<TEntity> objects);
        TEntity? Update(TEntity obj);
        void Remove(TEntity obj);
        int Remove(IEnumerable<TEntity> objects);
    }
}

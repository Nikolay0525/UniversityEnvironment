using UniversityEnvironment.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Reflection;
using UniversityEnvironment.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using UniversityEnvironment.Data.Model.Tables;

namespace UniversityEnvironment.Data.Repository
{
    public class RepoImplementation<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private UniversityEnvironmentContext _context;
        private static RepoImplementation<TEntity>? _instance;
        private DbSet<TEntity> _objects;

        private RepoImplementation(UniversityEnvironmentContext context)
        {
            _context = context;
            _objects = context.Set<TEntity>();
        }

        public static RepoImplementation<TEntity> GetRepository(UniversityEnvironmentContext context)
        {
            return _instance ?? new RepoImplementation<TEntity>(context);
        }
        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> query = _objects;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return [.. query]; 
        }
        public TEntity? FindByFilter(Expression<Func<TEntity, bool>> filter)
        {
            return _objects.FirstOrDefault(filter);
        }

        public TEntity? FindById(Guid id)
        {
            return _objects.Find(id);
        }

        public void Create(TEntity obj)
        {
            _objects.Add(obj);
            _context.SaveChanges();
        }

        public void Create(IEnumerable<TEntity> objects)
        {
            foreach (var obj in objects)
            {
                if (_objects.Any(o => o == obj)) { continue; }
                _objects.Add(obj);
            }

            _context.SaveChanges();
        }

        public TEntity? Update(TEntity obj)
        {
        _objects.Entry(obj).State = EntityState.Modified;
        _context.SaveChanges();
        return obj;
        }

        public void Remove(TEntity obj)
        {
            if (_context.Entry(obj).State == EntityState.Detached)
            {
                _objects.Attach(obj);
            }

            _objects.Remove(obj);
            _context.SaveChanges();
        }
        public void Remove(IEnumerable<TEntity> objects)
        {
            foreach (var obj in objects)
            {
                if (_context.Entry(obj).State == EntityState.Detached)
                {
                    _objects.Attach(obj);
                }

                _objects.Remove(obj);
            }

            _context.SaveChanges();
        }
    }
}

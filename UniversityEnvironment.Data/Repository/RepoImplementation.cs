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
    public class RepoImplementation<T> : IRepository<T> where T : class
    {
        private UniversityEnvironmentContext _context;
        private DbSet<T> _objects;

        private RepoImplementation(UniversityEnvironmentContext context)
        {
            _context = context;
            _objects = context.Set<T>();
        }

        public static RepoImplementation<T> GetRepository(UniversityEnvironmentContext context)
        {
            return new RepoImplementation<T>(context);
        }
        public IEnumerable<T> FindAll(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = _objects;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return [.. query]; 
        }
        public T? FindByFilter(Expression<Func<T, bool>> filter)
        {
            return _objects.FirstOrDefault(filter);
        }

        public T? FindById(Guid id)
        {
            return _objects.Find(id);
        }

        public void Create(T obj)
        {
            if (!_objects.Any(o => o == obj)) _objects.Add(obj);
            _context.SaveChanges();
        }

        public int Create(IEnumerable<T> objects)
        {
            int count = 0;
            foreach (var obj in objects)
            {
                if (_objects.Any(o => o == obj)) { continue; }
                _objects.Add(obj);
                count++;
            }

            _context.SaveChanges();
            return count;
        }

        public T? Update(T obj)
        {
            _objects.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
            return obj;
        }

        public void Remove(T obj)
        {
            if (_context.Entry(obj).State == EntityState.Detached)
            {
                _objects.Attach(obj);
            }

            if (_objects.Any(o => o == obj)) _objects.Remove(obj);
            _context.SaveChanges();
        }
        public int Remove(IEnumerable<T> objects)
        {
            int count = 0;
            foreach (var obj in objects)
            {
                if (_context.Entry(obj).State == EntityState.Detached) _objects.Attach(obj);
                if (!_objects.Any(o => o == obj)) { continue; }
                _objects.Remove(obj);
                count++;
            }

            _context.SaveChanges();
            return count;
        }
    }
}

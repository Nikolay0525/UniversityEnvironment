using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Data.Model.Tables;


namespace UniversityEnvironment.Data.Service
{
    public static class MySqlService
    {
        public static IEnumerable<T> FindAll<T>(Expression<Func<T, bool>> filter = null) where T : class
        {
            using UniversityEnvironmentContext context = new();
            IQueryable<T> query = context.Set<T>();

            if (filter != null)
            {
                query = query.AsNoTracking().Where(filter);
            }

            return [.. query];
        }
        public static T? FindByFilter<T>(Expression<Func<T, bool>> filter) where T : class
        {
            using UniversityEnvironmentContext context = new();
            return context.Set<T>().AsNoTracking().FirstOrDefault(filter);
        }

        public static void Create<T>(T obj) where T : class
        {
            using UniversityEnvironmentContext context = new();
            if (context.Set<T>().Any(o => o == obj)) return;
            context.Add(obj);
            context.SaveChanges();
        }

        public static int Create<T>(IEnumerable<T> objects) where T : class
        {
            using UniversityEnvironmentContext context = new();
            int count = 0;
            foreach (var obj in objects)
            {
                if (context.Set<T>().Any(o => o == obj)) { continue; }
                context.Add(obj);
                count++;
            }

            context.SaveChanges();
            return count;
        }

        public static T? Update<T>(T obj) where T : class
        {
            using UniversityEnvironmentContext context = new();
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
            return obj;
        }

        public static void Remove<T>(T obj) where T : class
        {
            using UniversityEnvironmentContext context = new();
            if (!context.Set<T>().Any(o => o == obj)) { return; }
            context.Remove(obj);
            context.SaveChanges();
        }
        public static int Remove<T>(IEnumerable<T> objects) where T : class
        {
            using UniversityEnvironmentContext context = new();
            int count = 0;
            foreach (var obj in objects)
            {
                if (!context.Set<T>().Any(o => o == obj)) { continue; }
                context.Remove(obj);
                count++;
            }

            context.SaveChanges();
            return count;
        }
    }
}

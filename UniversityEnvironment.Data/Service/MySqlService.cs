using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using UniversityEnvironment.Data.Model.MtoMTables;

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

        public static int Create<T>(T? obj = null,IEnumerable<T>? objects = null) where T : class
        {
            using UniversityEnvironmentContext context = new();
            int count = 0;
            if (obj != null)
            {
                if (context.Set<T>().Any(o => o == obj)) return count;
                context.Add(obj);
                count++;
            }
            else if (objects != null)
            {

                foreach (var objj in objects)
                {
                    if (context.Set<T>().Any(o => o == objj)) { continue; }
                    context.Add(objj);
                    count++;
                }
            }
            context.SaveChanges();
            return count;
        }

        public static T? Update<T>(T? obj = null, IEnumerable<T>? objects = null) where T : class
        {
            using UniversityEnvironmentContext context = new();
            if(obj != null)
            {
                context.Entry(obj).State = EntityState.Modified;
                return obj;
            }
            else if(objects != null)
            {
                foreach (var objj in objects) { context.Entry(objj).State = EntityState.Modified; }
            }
            context.SaveChanges();
            return null;
        }

        public static int Remove<T>(T? obj = null,IEnumerable<T>? objects = null) where T : class
        {
            using UniversityEnvironmentContext context = new();
            int count = 0;
            if (obj != null)
            {
                if (!context.Set<T>().Any(o => o == obj)) return count;
                context.Remove(obj);
                count++;
            }
            else if(objects != null)
            {
                foreach (var objj in objects)
                {
                    if (!context.Set<T>().Any(o => o == objj)) { continue; }
                    context.Remove(objj);
                    count++;
                }
            }
            context.SaveChanges();
            return count;
        }
    }
}

using UniversityEnvironment.Data.Model;
using UniversityEnvironment.Data.Repository;

namespace UniversityEnvironment.Data.Repositories
{
    public static class RepositoryManager
    {
        public static IRepository<TEntity> GetRepo<TEntity>() where TEntity : class
        {
            var context = new UniversityEnvironmentContext();
            var repo = RepoImplementation<TEntity>.GetRepo(context);
            return repo;
        }
    }
}
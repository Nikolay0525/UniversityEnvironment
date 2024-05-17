using UniversityEnvironment.Data.Model;
using UniversityEnvironment.Data.Repository;

namespace UniversityEnvironment.Data.Repositories
{
    public static class RepositoryManager
    {
        public static IRepository<TEntity> GetRepo<TEntity>(UniversityEnvironmentContext context) where TEntity : class
        {
            var contextFake = new UniversityEnvironmentContext();
            var repo = RepoImplementation<TEntity>.GetRepository(contextFake);
            return repo;
        }
    }
}
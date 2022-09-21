using Microsoft.Extensions.DependencyInjection;
using Students.DataAccess.Repositories;
using Students.DataAccess.Repositories.Contract;
using Students.Domain.Students;

namespace Students.DataAccess.DependecyInjection
{
    public static class RepositoriesCollectionConfiguration
    {
        public static void AddRepositoriesCollections(this IServiceCollection service)
        {
            service.AddScoped<IBaseRepository<Student>, StudentRepository>();
        }
    }
}

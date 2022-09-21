using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using Students.DataAccess.DBContexts;

namespace Students.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddContextInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<StudentsContext>(options => options.UseSqlServer(configuration.GetValue<string>("connectionString:StudentsConnection")));
        }
    }
}

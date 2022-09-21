using Microsoft.Extensions.DependencyInjection;
using Students.Application.DTOs;
using Students.Application.Services;
using Students.Application.Services.Base.Contract;
using Students.Application.Services.Contract;
using Students.Domain.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Students.Application.DependencyInjection
{
    public static class ServicesConfiguration
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IServicesBase<Student>, StudentService>();
            services.AddScoped<IStudentService, StudentService>();
        }
    }
}

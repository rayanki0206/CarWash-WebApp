using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShineNDrive_DAL.DataContext;
using ShineNDrive_DAL.Repositories;
using ShineNDrive_DAL.Repositories.IRepositories;
using ShineNDrive_DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShineNDrive_DAL
{
    public static class DependencyInjection
    {
        public static void RegisterDALDependencies(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<ApplicationContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("MyConnection"), options => options.MigrationsAssembly("ShineNDrive"));
            });

            services.AddScoped<ICRUD, CRUD>();
            services.AddScoped<IServicesInfo, ServicesInfoRepo>();
            services.AddScoped<IBookingInfoRepository, BookingInfoRepository>();

        }
    }
}

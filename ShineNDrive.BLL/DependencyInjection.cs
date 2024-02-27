using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShineNDrive_DAL.DataContext;
using ShineNDrive_DAL.Repositories.IRepositories;
using ShineNDrive_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShineNDrive_BLL.Services.Iservices;
using ShineNDrive_BLL.Services;

namespace ShineNDrive_BLL
{
    public static  class DependencyInjection
    {

        public static void RegisterBLLDependencies(this IServiceCollection services, IConfiguration Configuration)
        {
            //services.AddDbContext<ApplicationContext>(options =>
            //{
            //    options.UseSqlServer(Configuration.GetConnectionString("MyConnection"), options => options.MigrationsAssembly("ShineNDrive"));
            //});


            services.AddScoped<ICRUDService, CRUDService>();
            services.AddScoped<IServiceInfo, ServicesInfo>();
            services.AddScoped<IBookingInfoService, BookingInfoService>();


        }

    }
}

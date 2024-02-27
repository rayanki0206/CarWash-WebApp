using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ShineNDrive_DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShineNDrive_DAL.DataContext
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<BookingInfo> BookingInfos { get; set; }
        public DbSet<Service> Services { get; set; }
       

    }
}

using Microsoft.EntityFrameworkCore;
using ShineNDrive_DAL.DataContext;
using ShineNDrive_DAL.Repositories.IRepositories;
using ShineNDrive_DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShineNDrive_DAL.Repositories
{
    public class CRUD : ICRUD
    {

        private readonly ApplicationContext _ApplicationContext;

        public CRUD(ApplicationContext ApplicationContext)
        {
            _ApplicationContext = ApplicationContext;
        }

        public async Task<Admin> AddAdmin(Admin admin)
        {
            _ApplicationContext.Admins.Add(admin);
            await _ApplicationContext.SaveChangesAsync();
            return admin;
        }

        public async Task<IEnumerable<Admin>> GetAllAdmins()
        {
            var admins=await _ApplicationContext.Admins.ToListAsync();
            return admins;
        }
    }
}

using ShineNDrive_BLL.Services.Iservices;
using ShineNDrive_DAL.DataContext;
using ShineNDrive_DAL.Repositories;
using ShineNDrive_DAL.Repositories.IRepositories;
using ShineNDrive_DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShineNDrive_BLL.Services
{
    public class CRUDService : ICRUDService
    {
        private readonly ICRUD _ICRUD;

        public CRUDService(ICRUD Icrud)
        {
            _ICRUD = Icrud;
        }

        public async Task<Admin> AddAdmin(Admin admin)
        {
            return await _ICRUD.AddAdmin(admin);
        }

        public async Task<IEnumerable<Admin>> GetAllAdmins()
        {
            return await _ICRUD.GetAllAdmins();
        }
    }
}

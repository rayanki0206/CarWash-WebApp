using ShineNDrive_DTO.Entities;
using ShineNDrive_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShineNDrive_BLL.Services.Iservices
{
    public interface ICRUDService
    {
        public Task<Admin> AddAdmin(Admin admin);
        public Task<IEnumerable<Admin>> GetAllAdmins();

    }
}

using ShineNDrive_DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShineNDrive_DAL.Repositories.IRepositories
{
    public interface ICRUD
    {
        Task<Admin> AddAdmin(Admin admin);
        Task<IEnumerable<Admin>> GetAllAdmins();

    }
}

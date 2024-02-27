using ShineNDrive_BLL.Services.Iservices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShineNDrive_DAL.Repositories.IRepositories;
using ShineNDrive_DTO.Entities;

namespace ShineNDrive_BLL.Services
{
    public class ServicesInfo : IServiceInfo
    {
        public readonly IServicesInfo _IService;
        public ServicesInfo(IServicesInfo service)
        {
            _IService = service;
        }

        public async Task<Service> AddNewService(Service service)
        {
            return await _IService.AddNewService(service);
        }

        public async Task<Service> DeleteService(int serviceID)
        {
            return await _IService.DeleteService(serviceID);
        }

        public async Task<IEnumerable<Service>> GetAllServices()
        {
            return await _IService.GetAllServices();
        }

        public async Task<Service> UpdateService(int serviceID, Service updatedService)
        {
            return await _IService.UpdateService(serviceID, updatedService);
        }

    }
}

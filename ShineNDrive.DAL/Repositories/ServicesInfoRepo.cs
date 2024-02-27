using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShineNDrive_DAL.DataContext;
using ShineNDrive_DAL.Repositories.IRepositories;
using ShineNDrive_DTO.Entities;

namespace ShineNDrive_DAL.Repositories
{
    public class ServicesInfoRepo : IServicesInfo
    {
        private readonly ApplicationContext _ApplicationContext;

        public ServicesInfoRepo(ApplicationContext ApplicationContext)
        {
            _ApplicationContext = ApplicationContext;
        }

        public async Task<Service?> AddNewService(Service service)
        {
            _ApplicationContext.Services.Add(service);
            await _ApplicationContext.SaveChangesAsync();
            return service;
        }

        public async Task<IEnumerable<Service?>> GetAllServices()
        {
            var services = await _ApplicationContext.Services.ToListAsync();
            return services;
        }

        public async Task<Service?> DeleteService(int serviceID)
        {
            var deleteService = await _ApplicationContext.Services.FindAsync(serviceID);

            if (deleteService != null)
            {
                _ApplicationContext.Services.Remove(deleteService);
                await _ApplicationContext.SaveChangesAsync();
            }

            return deleteService;
        }




        public async Task<Service?> UpdateService(int serviceID, Service updatedService)
        {
            if (serviceID != updatedService.ServiceId)
            {
                throw new ArgumentException("The serviceID does not match the ServiceId of the updatedService.");
            }

            _ApplicationContext.Entry(updatedService).State = EntityState.Modified;
            await _ApplicationContext.SaveChangesAsync();
            return updatedService;
        }

    }
}

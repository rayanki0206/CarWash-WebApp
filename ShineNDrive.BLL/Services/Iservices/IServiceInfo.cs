﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShineNDrive_DTO.Entities;
namespace ShineNDrive_BLL.Services.Iservices
{
    public interface IServiceInfo
    {
        Task<Service> AddNewService(Service service);

        Task<IEnumerable<Service>> GetAllServices();

        Task<Service> DeleteService(int serviceID);

        Task<Service> UpdateService(int serviceID, Service updatedService);
    }
}

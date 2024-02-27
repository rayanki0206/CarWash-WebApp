using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShineNDrive_DTO.Entities;
using ShineNDrive_BLL.Services.Iservices;

namespace ShineNDrive.Controllers
{
    [Route("api/service/")]
    public class ServiceController : Controller
    {
        private readonly IServiceInfo _IService;
        public ServiceController(IServiceInfo iService)
        {
            _IService = iService;
        }

        [HttpGet("ServicesInfo")]
        public async Task<ActionResult<IEnumerable<Service>>> GetAllServices()
        {
            var ServicesInfo = await _IService.GetAllServices();

            if (ServicesInfo == null || !ServicesInfo.Any())
            {
                return NotFound();
            }

            return Ok(ServicesInfo);
        }
        [HttpPost("newService")]
        public async Task<ActionResult<Service>> AddNewService(Service serviceInfo)
        {
            try
            {
                await _IService.AddNewService(serviceInfo);
                return Ok();
            }
            catch (DbUpdateException)
            {

                return BadRequest("Error occurred while saving the user. Please check your input and try again.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{ServiceId}")]
        public async Task<ActionResult> DeleteService(int ServiceId)
        {
            try
            {
                var DeleteServiceInfo = await _IService.DeleteService(ServiceId);

                if (DeleteServiceInfo == null)
                {
                    return NotFound();
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500, "Internal Server Error");
            }
        }


        [HttpPut("{ServiceId}")]
        public async Task<ActionResult> UpdateService(int ServiceId, Service updatedService)

        { 
            try
            {
                var UpdateServiceinfo = await _IService.UpdateService(ServiceId, updatedService);
                if (UpdateServiceinfo == null)
                {
                    return BadRequest();
                }
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}

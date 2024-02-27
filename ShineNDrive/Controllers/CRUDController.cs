using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShineNDrive_BLL.Services;
using ShineNDrive_BLL.Services.Iservices;
using ShineNDrive_DTO.Entities;

namespace ShineNDrive.Controllers
{
    public class CRUDController : Controller
    {
        private readonly ICRUDService _icrudService;
        public CRUDController(ICRUDService crudService)
        {
            _icrudService = crudService;
        }



        [HttpPost("newAdmin")]
        public async Task<ActionResult<Admin>> AddNewAdmin(Admin admin)
        {
            try
            {
                await _icrudService.AddAdmin(admin);


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

        [HttpGet("GetAllAdmins")]
        public async Task<ActionResult<IEnumerable<Admin>>> GetAllAdmins()
        {
            var admins = await _icrudService.GetAllAdmins();

            if (admins == null || !admins.Any())
            {
                return NotFound();
            }

            return Ok(admins);
        }

    }
}

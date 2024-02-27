using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShineNDrive_BLL.Services;
using ShineNDrive_BLL.Services.Iservices;
using ShineNDrive_DTO.Entities;

namespace ShineNDrive.Controllers
{
    [Route("api/booking/")]
    public class BookingInfoController : Controller
    {
        private readonly IBookingInfoService _bookingInfoService;

        public BookingInfoController(IBookingInfoService bookingInfoService)
        {
            _bookingInfoService = bookingInfoService;
        }

        [HttpGet("BookingsInfo")]
        public async Task<ActionResult<IEnumerable<BookingInfo>>> GetAllBookingInfos()
        {
            var bookingsInfo = await _bookingInfoService.GetAllBookingInfos();

            if (bookingsInfo == null || !bookingsInfo.Any())
            {
                return NotFound();
            }

            return Ok(bookingsInfo);
        }

        [HttpPost("newBookingInfo")]
        public async Task<ActionResult<BookingInfo>> AddNewBookingInfo(BookingInfo bookingInfo)
        {
            try
            {
                await _bookingInfoService.AddNewBookingInfo(bookingInfo);
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

        [HttpPut("{updateBookingId}")]
        public async Task<ActionResult> UpdateBookingInfo(int bookingId, BookingInfo updateBookingInfo)

        {
            try
            {
                var UpdateBookingInfo = await _bookingInfoService.UpdateBookingInfo(bookingId, updateBookingInfo);
                if (UpdateBookingInfo == null)
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

        [HttpDelete("{bookingId}")]
        public async Task<ActionResult> DeleteBookingInfo(int bookingId)
        {
            try
            {
                var Deletebooking = await _bookingInfoService.DeleteBookingInfo(bookingId);

                if (Deletebooking == null)
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
    }
}

using ShineNDrive_DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShineNDrive_BLL.Services.Iservices
{
    public interface IBookingInfoService
    {
        Task<BookingInfo> AddNewBookingInfo(BookingInfo bookingInfo);

        Task<IEnumerable<BookingInfo>> GetAllBookingInfos();

        Task<BookingInfo> DeleteBookingInfo(int bookingId);

        Task<BookingInfo> UpdateBookingInfo(int bookingId, BookingInfo updateBookingInfo);
    }
}

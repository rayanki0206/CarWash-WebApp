using ShineNDrive_DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShineNDrive_DAL.Repositories.IRepositories
{
    public interface IBookingInfoRepository
    {
        Task<BookingInfo> AddNewBookingInfo(BookingInfo bookingInfo);

        Task<IEnumerable<BookingInfo>> GetAllBookings();

        Task<BookingInfo?> DeleteBookingInfo(int bookingId);
        Task<BookingInfo> UpdateBookingInfo(int bookingId, BookingInfo updateBookinginfo);
    }
}

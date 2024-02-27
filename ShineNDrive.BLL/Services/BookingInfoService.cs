using ShineNDrive_BLL.Services.Iservices;
using ShineNDrive_DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShineNDrive_DAL.Repositories.IRepositories;
using ShineNDrive_DAL.Repositories;

namespace ShineNDrive_BLL.Services
{
    public class BookingInfoService : IBookingInfoService
    {
        private readonly IBookingInfoRepository _bookingInfoRepository;
        public BookingInfoService(IBookingInfoRepository bookingInfoRepository)
        {
            _bookingInfoRepository = bookingInfoRepository;
        }

        public async Task<BookingInfo> AddNewBookingInfo(BookingInfo bookingInfo)
        {
            return await _bookingInfoRepository.AddNewBookingInfo(bookingInfo);
        }

        public async Task<BookingInfo> DeleteBookingInfo(int bookingId)
        {
            return await _bookingInfoRepository.DeleteBookingInfo(bookingId);
        }

        public async Task<IEnumerable<BookingInfo>> GetAllBookingInfos()
        {
            return await _bookingInfoRepository.GetAllBookings();
        }

        public async Task<BookingInfo> UpdateBookingInfo(int bookingId, BookingInfo updateBookingInfo)
        {
            return await _bookingInfoRepository.UpdateBookingInfo(bookingId, updateBookingInfo);
        }
    }
}

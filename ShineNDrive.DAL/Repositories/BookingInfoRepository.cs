using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;
using ShineNDrive_DAL.DataContext;
using ShineNDrive_DAL.Repositories.IRepositories;
using ShineNDrive_DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShineNDrive_DAL.Repositories
{
    public class BookingInfoRepository : IBookingInfoRepository
    {
        private readonly ApplicationContext _ApplicationContext;

        public BookingInfoRepository(ApplicationContext ApplicationContext)
        {
            _ApplicationContext = ApplicationContext;
        }

        public async Task<BookingInfo> AddNewBookingInfo(BookingInfo bookingInfo)
        {
            _ApplicationContext.BookingInfos.Add(bookingInfo);
            await _ApplicationContext.SaveChangesAsync();
            return bookingInfo;
        }

        public async Task<BookingInfo?> DeleteBookingInfo(int bookingId)
        {
            var deletebookingInfo = await _ApplicationContext.BookingInfos.FindAsync(bookingId);

            if (deletebookingInfo != null)
            {
                _ApplicationContext.BookingInfos.Remove(deletebookingInfo);
                await _ApplicationContext.SaveChangesAsync();
            }

            return deletebookingInfo ?? throw new InvalidOperationException("Booking info not found.");
        }


        public async Task<IEnumerable<BookingInfo>> GetAllBookings()
        {
            var bookingInfos= await _ApplicationContext.BookingInfos.ToListAsync();
            return bookingInfos;
        }

        public async Task<BookingInfo> UpdateBookingInfo(int bookingId, BookingInfo updateBookinginfo)
        {
            if (bookingId != updateBookinginfo.BookingId)
            {
                throw new ArgumentException("The bookingId does not match the BookingId of the updateBookinginfo.");
            }
            _ApplicationContext.Entry(updateBookinginfo).State = EntityState.Modified;
            await _ApplicationContext.SaveChangesAsync();
            return updateBookinginfo;
        }
    }
}

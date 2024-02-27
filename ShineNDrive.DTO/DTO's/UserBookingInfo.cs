using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShineNDrive_DTO.DTO_s
{
    internal class UserBookingInfo
    {
        public int BookingId { get; set; }
        public required DateTime DateTime { get; set; }
        public required string VehicleType { get; set; }
        public string ServiceName { get; set; }
        public required string Timing { get; set; }
        public required int Cost { get; set; }



    }
}

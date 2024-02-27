using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShineNDrive_DTO.Entities
{
    public class BookingInfo
    {
        [Key]
        public int BookingId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string VehicleType { get; set; }
        public string ServiceName { get; set; }
        public string ModelName { get; set; }
        public string Timing { get; set; }
        public string Address { get; set; } 
        public int Cost { get; set; }
        public DateTime DateTime { get; set; }
        public string Status { get; set; }
    }
}
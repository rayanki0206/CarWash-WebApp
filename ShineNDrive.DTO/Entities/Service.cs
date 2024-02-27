using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShineNDrive_DTO.Entities
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }
        public string ServiceType { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public string ImageUrl { get; set; }
        public int Cost { get; set; }
    }
}

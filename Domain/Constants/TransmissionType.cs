using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Constants
{
    public class TransmissionType
    {
        public int TransmissionTypeId { get; set; }
        public string? TransmissionName { get; set; }
        public ICollection<CarAd>? CarAds { get; set; }
    }
}

using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Constants
{
    public class FuelType
    {
        public int FuelTypeId { get; set; }
        public string? FuelName { get; set;}
        public ICollection<CarAd>? CarAds { get; set; }
    }
}

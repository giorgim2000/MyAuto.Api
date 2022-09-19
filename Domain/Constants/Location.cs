using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Constants
{
    public class Location
    {
        public int LocationId { get; set; }
        public string? LocationName { get; set; }
        public ICollection<CarAd>? CarAds { get; set; }
    }
}

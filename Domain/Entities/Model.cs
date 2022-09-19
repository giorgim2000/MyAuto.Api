using Domain.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Model
    {
        public int ModelId { get; set; }
        [Required]
        public string? ModelName { get; set; }
        [Required]
        public int ManufacturerId { get; set; }
        public Manufacturer? Manufacturer { get; set; }
        [Required]
        public int CarTypeId { get; set; }
        public CarType? CarType { get; set; }
        public ICollection<CarAd>? CarAds { get; set; }
    }
}

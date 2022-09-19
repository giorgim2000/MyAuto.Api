using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }
        public string? ManufacturerName { get; set;}
        public ICollection<Model>? Models { get; set; }
    }
}

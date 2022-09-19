using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Constants
{
    public class CarType
    {
        public int CarTypeId { get; set; }
        public string? Name { get; set; }
        public ICollection<Model>? Models { get; set; }
    }
}

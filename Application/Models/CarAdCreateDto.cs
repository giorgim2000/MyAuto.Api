using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class CarAdCreateDto
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public int ModelId { get; set; }
        public DateTimeOffset AdCreationTime { get; set; } = DateTimeOffset.Now;
        [Required]
        public int Year { get; set; }
        [Required]
        public decimal Price { get; set; }
        public double? EngineCapacity { get; set; } = null;
        public int? TransmissionTypeId { get; set; } = null;
        public int? FuelTypeId { get; set; } = null;
        public bool CustomsDuty { get; set; }
        public bool? RightHandWheel { get; set; } = null;
        public int? LocationId { get; set; } = null;
        public string Mileage { get; set; } = null;
        public bool? TechnicalInspection { get; set; } = null;
        public string VinCode { get; set; } = null;
        public bool? ParkingControl { get; set; } = null;
        public bool? ClimateControl { get; set; } = null;
        public bool? Auction { get; set; } = null;
        public bool? Camera { get; set; } = null;
        public bool? SeatHeating { get; set; } = null;
        public bool? Navigation { get; set; } = null;
        public bool? ElectricWindows { get; set; } = null;
    }
}

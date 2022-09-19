using Domain.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CarAd
    {
        public int CarAdId { get; set; }
        [Required]
        public int UserId { get; set; }
        public User? User { get; set; }
        [Required]
        public int ModelId { get; set; }
        public Model? Model { get; set; }
        [Required]
        public DateTimeOffset AdCreationTime { get; set; }
        [Required]
        public int Year { get; set; }
        public decimal Price { get; set; }
        public double? EngineCapacity { get; set; }
        public int? TransmissionTypeId { get; set; }
        public TransmissionType? TransmissionType { get; set; }
        public int? FuelTypeId { get; set; }
        public FuelType? FuelType { get; set; }
        public bool? CustomsDuty { get; set; }
        public bool? RightHandWheel { get; set; }
        public int? LocationId { get; set; }
        public Location? Location { get; set; }
        public string? Mileage { get; set; }
        public bool? TechnicalInspection { get; set; }
        public string? VinCode { get; set; }
        public bool? ParkingControl { get; set; }
        public bool? ClimateControl { get; set; }
        public bool? Auction { get; set; }
        public bool? Camera { get; set; }
        public bool? SeatHeating { get; set; }
        public bool? Navigation { get; set; }
        public bool? ElectricWindows { get; set; }
    }
}

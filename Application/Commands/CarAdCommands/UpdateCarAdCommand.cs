using Domain.Constants;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.CarAdCommands
{
    public class UpdateCarAdCommand : IRequest<bool>
    {
        public int CarAdId { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public DateTimeOffset AdCreationTime { get; } = DateTimeOffset.Now;
        public int? Year { get; set; }
        public decimal? Price { get; set; }
        public double? EngineCapacity { get; set; }
        public string TransmissionType { get; set; }
        public string FuelType { get; set; }
        public bool? CustomsDuty { get; set; }
        public bool? RightHandWheel { get; set; }
        public string Location { get; set; }
        public string Mileage { get; set; }
        public bool? TechnicalInspection { get; set; }
        public string VinCode { get; set; }
        public bool? ParkingControl { get; set; }
        public bool? ClimateControl { get; set; }
        public bool? Auction { get; set; }
        public bool? Camera { get; set; }
        public bool? SeatHeating { get; set; }
        public bool? Navigation { get; set; }
        public bool? ElectricWindows { get; set; }

    }
}

using Domain.Entities;
using Infrastructure.Repository.Abstraction;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.CarAdCommands
{
    public class CreateCarAdCommandHandler : IRequestHandler<CreateCarAdCommand, bool>
    {
        private readonly ICarAdRepository _carAdRepository;
        public CreateCarAdCommandHandler(ICarAdRepository carAdRepository)
        {
            _carAdRepository = carAdRepository;
        }
        public async Task<bool> Handle(CreateCarAdCommand input, CancellationToken cancellationToken)
        {
            await _carAdRepository.Create(new CarAd()
            {
                UserId = input.UserId,
                ModelId = input.ModelId,
                AdCreationTime = input.AdCreationTime,
                Year = input.Year,
                Price = input.Price,
                EngineCapacity = input.EngineCapacity,
                TransmissionTypeId = input.TransmissionTypeId == 0 ? null : input.TransmissionTypeId,
                FuelTypeId = input.FuelTypeId == 0 ? null : input.FuelTypeId,
                CustomsDuty = input.CustomsDuty,
                RightHandWheel = input.RightHandWheel,
                LocationId = input.LocationId == 0 ? null : input.LocationId,
                Mileage = input.Mileage,
                TechnicalInspection = input.TechnicalInspection,
                VinCode = input.VinCode,
                ParkingControl = input.ParkingControl,
                ClimateControl = input.ClimateControl,
                Auction = input.Auction,
                Camera = input.Camera,
                SeatHeating = input.SeatHeating,
                Navigation = input.Navigation,
                ElectricWindows = input.ElectricWindows
            });
            return await _carAdRepository.SaveChangesAsync();
        }
    }
}

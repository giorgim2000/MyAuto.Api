using Infrastructure.Repository.Abstraction;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.CarAdCommands
{
    public class UpdateCarAdCommandHandler : IRequestHandler<UpdateCarAdCommand, bool>
    {
        private readonly ICarAdRepository _carAdRepository;
        private readonly ITransmissionTypeRepository _transmissionRepo;
        public UpdateCarAdCommandHandler(ICarAdRepository carAdRepository, ITransmissionTypeRepository transmissionRepo)
        {
            _carAdRepository = carAdRepository;
            _transmissionRepo = transmissionRepo;
        }
        public async Task<bool> Handle(UpdateCarAdCommand request, CancellationToken cancellationToken)
        {
            var targetCarAd = await _carAdRepository.GetQuery(i => i.CarAdId == request.CarAdId)
                                                    .Include(i=>i.Model)
                                                    .ThenInclude(i=>i.Manufacturer)
                                                    .Include(i=>i.Location)
                                                    .Include(i=>i.FuelType)
                                                    .Include(i=>i.Model)
                                                    .ThenInclude(i=>i.CarType)
                                                    .SingleOrDefaultAsync();
            
            var trans = await _transmissionRepo.GetQuery(i => i.TransmissionName == request.TransmissionType).SingleOrDefaultAsync();
            
            if (targetCarAd != null)
            {
                if (request.Model != null)
                    targetCarAd.Model.ModelName = request.Model;
                if (request.Year != null)
                    targetCarAd.Year = request.Year.Value;
                if (request.FuelType != null)
                    targetCarAd.FuelType.FuelName = request.FuelType;
                if (request.Mileage != null)
                    targetCarAd.Mileage = request.Mileage;
                if (request.Navigation != null)
                    targetCarAd.Navigation = request.Navigation;
                if (request.Camera != null)
                    targetCarAd.Camera = request.Camera;
                if (request.ClimateControl != null)
                    targetCarAd.ClimateControl = request.ClimateControl;
                if (request.EngineCapacity != null)
                    targetCarAd.EngineCapacity = request.EngineCapacity;
                if (request.CustomsDuty != null)
                    targetCarAd.CustomsDuty = request.CustomsDuty;
                if (request.ElectricWindows != null)
                    targetCarAd.ElectricWindows = request.ElectricWindows;
                if (request.VinCode != null)
                    targetCarAd.VinCode = request.VinCode;
                if (request.Auction != null)
                    targetCarAd.Auction = request.Auction;
                if (request.Location != null)
                    targetCarAd.Location.LocationName = request.Location;
                if (trans != null)
                    targetCarAd.TransmissionTypeId = trans.TransmissionTypeId;
                if (request.Price != null)
                    targetCarAd.Price = request.Price.Value;
                

                _carAdRepository.Update(targetCarAd);

                return await _carAdRepository.SaveChangesAsync();
            }
            else
                return false;
        }
    }
}

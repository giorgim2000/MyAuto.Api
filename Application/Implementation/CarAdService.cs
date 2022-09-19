using Application.Abstraction;
using Application.Models;
using Domain.Entities;
using Infrastructure.DataContext;
using Infrastructure.Repository.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Implementation
{
    public class CarAdService : ICarAdService
    {
        private readonly ApplicationDbContext _context;
        private readonly ICarAdRepository _carAdRepository;
        public CarAdService(ApplicationDbContext context, ICarAdRepository carAdRepository)
        {
            _context = context;
            _carAdRepository = carAdRepository;
        }

        public async Task<List<CarAdDto>> GetAllCarAds()
        {
            var cars = _context.CarAds == null ? null :
                    await _context.CarAds.AsNoTracking()
                    .Include(i => i.User)
                    .Include(i => i.Model)
                        .ThenInclude(i => i != null ? i.Manufacturer : null)
                    .Include(i => i.Location)
                    .Include(i => i.FuelType)
                    .Include(i => i.TransmissionType)
                    .ToListAsync();

            return cars != null ? cars.Select(car => new CarAdDto()
            {
                UserName = car.User != null ? car.User.UserName : null,
                Model = car.Model != null ? car.Model.ModelName : null,
                Manufacturer = (car.Model != null) && (car.Model.Manufacturer != null) ? car.Model.Manufacturer.ManufacturerName : null,
                AdCreationTime = car.AdCreationTime,
                Year = car.Year,
                Price = car.Price,
                EngineCapacity = car.EngineCapacity,
                Location = car.Location != null ? car.Location.LocationName : null,
                FuelType = car.FuelType != null ? car.FuelType.FuelName : null,
                Transmission = car.TransmissionType != null ? car.TransmissionType.TransmissionName : null,
                Auction = car.Auction,
                Camera = car.Camera,
                ClimateControl = car.ClimateControl,
                CustomsDuty = car.CustomsDuty,
                ElectricWindows = car.ElectricWindows,
                Mileage = car.Mileage,
                Navigation = car.Navigation,
                ParkingControl = car.ParkingControl,
                RightHandWheel = car.RightHandWheel,
                SeatHeating = car.SeatHeating,
                TechnicalInspection = car.TechnicalInspection,
                VinCode = car.VinCode
            }).ToList() : new List<CarAdDto>();
        }

        public async Task<CarAdDto> GetCarAdById(int id)
        {
            var car = await _context.CarAds.AsNoTracking()
                        .Include(i => i.User)
                        .Include(i => i.Model)
                             .ThenInclude(i => i != null ? i.Manufacturer : null)
                        .Include(i => i.Location)
                        .Include(i => i.FuelType)
                        .Include(i => i.TransmissionType)
                        .SingleOrDefaultAsync(i => i.CarAdId == id);

            if (car != null)
                return new CarAdDto()
                {
                    UserName = car.User.UserName,
                    Model = car.Model.ModelName,
                    Manufacturer = car.Model.Manufacturer.ManufacturerName,
                    AdCreationTime = car.AdCreationTime,
                    Year = car.Year,
                    Price = car.Price,
                    EngineCapacity = car.EngineCapacity,
                    Location = car.Location != null ? car.Location.LocationName : null,
                    FuelType = car.FuelType != null ? car.FuelType.FuelName : null,
                    Transmission = car.TransmissionType != null ? car.TransmissionType.TransmissionName : null,
                    Auction = car.Auction,
                    Camera = car.Camera,
                    ClimateControl = car.ClimateControl,
                    CustomsDuty = car.CustomsDuty,
                    ElectricWindows = car.ElectricWindows,
                    Mileage = car.Mileage,
                    Navigation = car.Navigation,
                    ParkingControl = car.ParkingControl,
                    RightHandWheel = car.RightHandWheel,
                    SeatHeating = car.SeatHeating,
                    TechnicalInspection = car.TechnicalInspection,
                    VinCode = car.VinCode
                };
            else
                return null;
        }

        public async Task<List<CarAdDto>> GetCarAdByUserId(int id)
        {
            var carAD = _carAdRepository.GetQuery(i => i.UserId == id)
                                              .Include(i => i.User)
                                              .Include(i => i.Model)
                                              .ThenInclude(i => i.Manufacturer)
                                              .Include(i => i.Location)
                                              .Include(i => i.FuelType)
                                              .Include(i => i.TransmissionType)
                                              .AsNoTracking();

            if (carAD.Count() != 0)
                return await carAD.Select(i => new CarAdDto()
                {
                    UserName = i.User.UserName,
                    Model = i.Model.ModelName,
                    Manufacturer = i.Model.Manufacturer.ManufacturerName,
                    AdCreationTime = i.AdCreationTime,
                    Year = i.Year,
                    Price = i.Price,
                    EngineCapacity = i.EngineCapacity,
                    Location = i.Location.LocationName,
                    FuelType = i.FuelType.FuelName,
                    Transmission = i.TransmissionType.TransmissionName,
                    Auction = i.Auction,
                    Camera = i.Camera,
                    ClimateControl = i.ClimateControl,
                    CustomsDuty = i.CustomsDuty,
                    ElectricWindows = i.ElectricWindows,
                    Mileage = i.Mileage,
                    Navigation = i.Navigation,
                    ParkingControl = i.ParkingControl,
                    RightHandWheel = i.RightHandWheel,
                    SeatHeating = i.SeatHeating,
                    TechnicalInspection = i.TechnicalInspection,
                    VinCode = i.VinCode
                }).ToListAsync();
            else
                return null;
        }

        public async Task<List<CarAdDto>> GetCarAdByUserName(string userName)
        {
            var carAD = _carAdRepository.GetQuery(i => i.User.UserName == userName)
                                              .Include(i => i.User)
                                              .Include(i => i.Model)
                                              .ThenInclude(i => i.Manufacturer)
                                              .Include(i => i.Location)
                                              .Include(i => i.FuelType)
                                              .Include(i => i.TransmissionType)
                                              .AsNoTracking();

            if (carAD.Count() != 0)
                return await carAD.Select(i => new CarAdDto()
                {
                    UserName = i.User.UserName,
                    Model = i.Model.ModelName,
                    Manufacturer = i.Model.Manufacturer.ManufacturerName,
                    AdCreationTime = i.AdCreationTime,
                    Year = i.Year,
                    Price = i.Price,
                    EngineCapacity = i.EngineCapacity,
                    Location = i.Location.LocationName,
                    FuelType = i.FuelType.FuelName,
                    Transmission = i.TransmissionType.TransmissionName,
                    Auction = i.Auction,
                    Camera = i.Camera,
                    ClimateControl = i.ClimateControl,
                    CustomsDuty = i.CustomsDuty,
                    ElectricWindows = i.ElectricWindows,
                    Mileage = i.Mileage,
                    Navigation = i.Navigation,
                    ParkingControl = i.ParkingControl,
                    RightHandWheel = i.RightHandWheel,
                    SeatHeating = i.SeatHeating,
                    TechnicalInspection = i.TechnicalInspection,
                    VinCode = i.VinCode
                }).ToListAsync();
            else
                return null;
        }

        //public async Task<List<CarAdDto>> FilterCarAds()
        //{

        //}
    }
}

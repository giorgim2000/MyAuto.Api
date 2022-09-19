using Domain.Entities;
using Infrastructure.DataContext;
using Infrastructure.Repository.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Implementation
{
    public class CarAdRepository : Repository<CarAd>, ICarAdRepository
    {
        public CarAdRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<CarAd>> FilterCarAd(CarAd carAd)
        {
            var carAds = await _context.CarAds
                                       .Where(i => (carAd.CustomsDuty == true ? (i.CustomsDuty == true) : (i.CustomsDuty == false || i.CustomsDuty == null || i.CustomsDuty == true))
                                       && (carAd.Camera == true ? (i.Camera == true) : (i.Camera == false || i.Camera == null || i.Camera == true))
                                       && (carAd.ClimateControl == true ? (i.ClimateControl == true) : (i.ClimateControl == false || i.ClimateControl == null || i.ClimateControl == true))
                                       && (carAd.TechnicalInspection == true ? (i.TechnicalInspection == true) : (i.TechnicalInspection == false || i.TechnicalInspection == null || i.TechnicalInspection == true)))
                                       .ToListAsync();
            
            return carAds;
        } 
    }
}

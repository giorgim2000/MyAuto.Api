using Application.Models;
using Domain.Entities;
using Infrastructure.Repository.Abstraction;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries
{
    public class FilterCarAdQueryHandler : IRequestHandler<FilterCarAdQuery, List<CarAd>>
    {
        private readonly ICarAdRepository _carAdRepository;
        public FilterCarAdQueryHandler(ICarAdRepository carAdRepository)
        {
            _carAdRepository = carAdRepository;
        }

        public async Task<List<CarAd>> Handle(FilterCarAdQuery request, CancellationToken cancellationToken)
        {
            var adList = await _carAdRepository.FilterCarAd(new Domain.Entities.CarAd()
            {
                CustomsDuty = request.CustomsDuty,
                ClimateControl = request.ClimateControl,
                Camera = request.Camera,
                TechnicalInspection = request.TechInspection
            });

            return adList;
        }
    }
}

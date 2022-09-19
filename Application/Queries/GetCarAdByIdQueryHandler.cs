using Application.Models;
using Domain.Entities;
using Infrastructure.Repository.Abstraction;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries
{
    public class GetCarAdByIdQueryHandler : IRequestHandler<GetCarAdByIdQuery, CarAd>
    {
        private readonly ICarAdRepository _carAdRepository;
        public GetCarAdByIdQueryHandler(ICarAdRepository carAdRepository)
        {
            _carAdRepository = carAdRepository;
        }

        public async Task<CarAd> Handle(GetCarAdByIdQuery request, CancellationToken cancellationToken)
        {
            var carAd = await _carAdRepository.GetQuery(i => i.CarAdId == request.Id).SingleOrDefaultAsync();
            return carAd;
        }
    }
}

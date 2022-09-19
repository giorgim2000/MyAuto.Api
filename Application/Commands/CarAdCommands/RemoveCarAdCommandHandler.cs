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
    public class RemoveCarAdCommandHandler : IRequestHandler<RemoveCarAdCommand, bool>
    {
        private readonly ICarAdRepository _carAdRepository;
        public RemoveCarAdCommandHandler(ICarAdRepository carAdRepository)
        {
            _carAdRepository = carAdRepository;
        }
        public async Task<bool> Handle(RemoveCarAdCommand request, CancellationToken cancellationToken)
        {
            _carAdRepository.Delete(new CarAd() { CarAdId = request.CarAdId });

            return await _carAdRepository.SaveChangesAsync();
        }
    }
}

using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Abstraction
{
    public interface ICarAdRepository : IRepository<CarAd>
    {
        Task<List<CarAd>> FilterCarAd(CarAd carAd);
    }
}

using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction
{
    public interface ICarAdService
    {
        Task<List<CarAdDto>> GetAllCarAds();
        Task<CarAdDto> GetCarAdById(int id);
        Task<List<CarAdDto>> GetCarAdByUserId(int id);
        Task<List<CarAdDto>> GetCarAdByUserName(string userName);
    }
}

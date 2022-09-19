using Application.Models;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries
{
    public class GetCarAdByIdQuery : IRequest<CarAd>
    {
        public int Id { get; set; }
    }
}

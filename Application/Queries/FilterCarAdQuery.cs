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
    public class FilterCarAdQuery : IRequest<List<CarAd>>
    {
        public bool? CustomsDuty { get; set; }
        public bool? Camera { get; set; }
        public bool? TechInspection { get; set; }
        public bool? ClimateControl { get; set; }
    }
}

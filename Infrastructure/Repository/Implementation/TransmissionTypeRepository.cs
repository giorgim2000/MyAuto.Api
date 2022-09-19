using Domain.Constants;
using Infrastructure.DataContext;
using Infrastructure.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Implementation
{
    public class TransmissionTypeRepository : Repository<TransmissionType>, ITransmissionTypeRepository
    {
        public TransmissionTypeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}

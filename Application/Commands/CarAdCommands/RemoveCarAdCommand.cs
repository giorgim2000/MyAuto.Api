using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.CarAdCommands
{
    public class RemoveCarAdCommand : IRequest<bool>
    {
        public int CarAdId { get; set; }
    }
}

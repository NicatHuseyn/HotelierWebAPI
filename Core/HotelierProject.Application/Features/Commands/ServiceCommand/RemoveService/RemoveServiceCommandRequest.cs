using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Commands.ServiceCommand.RemoveService
{
    public class RemoveServiceCommandRequest:IRequest<RemoveServiceCommandResponse>
    {
        public int Id { get; set; }
    }
}

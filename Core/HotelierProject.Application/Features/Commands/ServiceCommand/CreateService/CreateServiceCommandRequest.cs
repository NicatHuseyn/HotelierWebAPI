using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Commands.ServiceCommand.CreateService
{
    public class CreateServiceCommandRequest:IRequest<CreateServiceCommandResponse>
    {
        public string IconUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}

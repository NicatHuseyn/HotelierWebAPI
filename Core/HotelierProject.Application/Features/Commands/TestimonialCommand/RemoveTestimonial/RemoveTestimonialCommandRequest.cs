using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Commands.TestimonialCommand.RemoveCommand
{
    public class RemoveTestimonialCommandRequest:IRequest<RemoveTestimonialCommandResponse>
    {
        public int Id { get; set; }
    }
}

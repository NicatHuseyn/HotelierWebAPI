using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Commands.TestimonialCommand.CreateTestimonial
{
    public class CreateTestimonialCommandRequest:IRequest<CreateTestimonialCommandResponse>
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}

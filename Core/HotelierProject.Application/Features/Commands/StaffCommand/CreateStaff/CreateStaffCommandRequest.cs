using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Commands.StaffCommand.CreateStaff
{
    public class CreateStaffCommandRequest:IRequest<CreateStaffCommandResponse>
    {
        public string Name { get; set; }
        public string Profeesion { get; set; }
        public string FaceBookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Commands.StaffCommand.RemoveStaff
{
    public class RemoveStaffCommandRequest:IRequest<RemoveStaffCommandResponse>
    {
        public int Id { get; set; }
    }
}

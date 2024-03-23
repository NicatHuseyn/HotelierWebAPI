using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Queries.StaffQuery.GetByIdStaff
{
    public class GetByIdStaffQueryRequest:IRequest<GetByIdStaffQueryResponse>
    {
        public int Id { get; set; }
    }
}

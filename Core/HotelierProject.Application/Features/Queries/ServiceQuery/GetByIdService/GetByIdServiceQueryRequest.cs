using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Queries.ServiceQuery.GetByIdService
{
    public class GetByIdServiceQueryRequest:IRequest<GetByIdServiceQueryResponse>
    {
        public int Id { get; set; }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Queries.TestimonialQuery.GetAllTestimonial
{
    public class GetAllTestimonialQueryRequest:IRequest<List<GetAllTestimonialQueryResponse>>
    {
    }
}

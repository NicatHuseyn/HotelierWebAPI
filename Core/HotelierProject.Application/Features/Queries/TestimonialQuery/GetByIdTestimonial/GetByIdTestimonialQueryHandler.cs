using HotelierProject.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Queries.TestimonialQuery.GetByIdTestimonial
{
    public class GetByIdTestimonialQueryHandler : IRequestHandler<GetByIdTestimonialQueryRequest, GetByIdTestimonialQueryResponse>
    {
        private readonly ITestimonialReadRepository _repository;

        public GetByIdTestimonialQueryHandler(ITestimonialReadRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetByIdTestimonialQueryResponse> Handle(GetByIdTestimonialQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetByIdTestimonialQueryResponse
            {
                Id = value.Id,
                Name = value.Name,
                Description = value.Description,
                ImageUrl = value.ImageUrl,
                Profession = value.Profession
            };
        }
    }
}

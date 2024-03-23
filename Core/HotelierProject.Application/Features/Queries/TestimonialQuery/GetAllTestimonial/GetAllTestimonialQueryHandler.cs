using HotelierProject.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Queries.TestimonialQuery.GetAllTestimonial
{
    public class GetAllTestimonialQueryHandler : IRequestHandler<GetAllTestimonialQueryRequest, List<GetAllTestimonialQueryResponse>>
    {
        private readonly ITestimonialReadRepository _repository;

        public GetAllTestimonialQueryHandler(ITestimonialReadRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAllTestimonialQueryResponse>> Handle(GetAllTestimonialQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=> new GetAllTestimonialQueryResponse
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                Profession = x.Profession
            }).ToList();
        }
    }
}

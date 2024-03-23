using HotelierProject.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Queries.ServiceQuery.GetAllService
{
    public class GetAllServiceQueryHandler : IRequestHandler<GetAllServiceQueryRequest, List<GetAllServiceQueryResponse>>
    {
        private readonly IServiceReadRepository _repository;

        public GetAllServiceQueryHandler(IServiceReadRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAllServiceQueryResponse>> Handle(GetAllServiceQueryRequest request, CancellationToken cancellationToken)
        {
            var services = await _repository.GetAllAsync();
            return services.Select(x=> new GetAllServiceQueryResponse
            {
                Id = x.Id,
                Description = x.Description,
                IconUrl = x.IconUrl,
                Title = x.Title
            }).ToList();
        }
    }
}

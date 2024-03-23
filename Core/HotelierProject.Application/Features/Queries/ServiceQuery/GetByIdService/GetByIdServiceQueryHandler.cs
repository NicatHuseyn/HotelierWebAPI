using HotelierProject.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Queries.ServiceQuery.GetByIdService
{
    public class GetByIdServiceQueryHandler : IRequestHandler<GetByIdServiceQueryRequest, GetByIdServiceQueryResponse>
    {
        private readonly IServiceReadRepository _repository;

        public GetByIdServiceQueryHandler(IServiceReadRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetByIdServiceQueryResponse> Handle(GetByIdServiceQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            return new()
            {
                Id  = value.Id,
                Description = value.Description,
                IconUrl = value.IconUrl,
                Title = value.Title
            };
        }
    }
}

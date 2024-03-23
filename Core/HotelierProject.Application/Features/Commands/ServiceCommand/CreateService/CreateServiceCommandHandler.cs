using HotelierProject.Application.Repositories;
using HotelierProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Commands.ServiceCommand.CreateService
{
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommandRequest, CreateServiceCommandResponse>
    {
        private readonly IServiceWriteRepository _repository;

        public CreateServiceCommandHandler(IServiceWriteRepository repository)
        {
            _repository = repository;
        }

        public async Task<CreateServiceCommandResponse> Handle(CreateServiceCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(new Service
            {
                Description = request.Description,
                IconUrl = request.IconUrl,
                Title = request.Title
            });

            await _repository.SaveAsync();

            return new();
        }
    }
}

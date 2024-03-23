using HotelierProject.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Commands.ServiceCommand.UpdateService
{
    public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommandRequest, UpdateServiceCommandResponse>
    {
        private readonly IServiceReadRepository _serviceReadRepository;
        private readonly IServiceWriteRepository _serviceWriteRepository;

        public UpdateServiceCommandHandler(IServiceReadRepository serviceReadRepository, IServiceWriteRepository serviceWriteRepository)
        {
            _serviceReadRepository = serviceReadRepository;
            _serviceWriteRepository = serviceWriteRepository;
        }

        public async Task<UpdateServiceCommandResponse> Handle(UpdateServiceCommandRequest request, CancellationToken cancellationToken)
        {
            var service = await _serviceReadRepository.GetByIdAsync(request.Id);
            service.Id = request.Id;
            service.Description = request.Description;
            service.Title = request.Title;
            service.IconUrl = request.IconUrl;

            _serviceWriteRepository.Update(service);
            await _serviceWriteRepository.SaveAsync();

            return new();
        }
    }
}

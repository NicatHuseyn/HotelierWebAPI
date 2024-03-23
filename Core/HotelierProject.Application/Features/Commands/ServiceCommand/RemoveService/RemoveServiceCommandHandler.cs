using HotelierProject.Application.Repositories;
using HotelierProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Commands.ServiceCommand.RemoveService
{
    public class RemoveServiceCommandHandler : IRequestHandler<RemoveServiceCommandRequest, RemoveServiceCommandResponse>
    {
        private readonly IServiceWriteRepository _writeRepository;
        private readonly IServiceReadRepository _readRepository;

        public RemoveServiceCommandHandler(IServiceWriteRepository writeRepository, IServiceReadRepository readRepository)
        {
            _writeRepository = writeRepository;
            _readRepository = readRepository;
        }

        public async Task<RemoveServiceCommandResponse> Handle(RemoveServiceCommandRequest request, CancellationToken cancellationToken)
        {
            Service service = await _readRepository.GetByIdAsync(request.Id);
            _writeRepository.Remove(service);
            await _writeRepository.SaveAsync();
            return new();
        }
    }
}

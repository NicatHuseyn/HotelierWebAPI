using HotelierProject.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Commands.StaffCommand.RemoveStaff
{
    public class RemoveStaffCommandHandler : IRequestHandler<RemoveStaffCommandRequest, RemoveStaffCommandResponse>
    {
        private readonly IStaffReadRepository _staffReadRepository;
        private readonly IStaffWriteRepository _staffWriteRepository;
        public RemoveStaffCommandHandler(IStaffReadRepository staffReadRepository, IStaffWriteRepository staffWriteRepository)
        {
            _staffReadRepository = staffReadRepository;
            _staffWriteRepository = staffWriteRepository;
        }


        public async Task<RemoveStaffCommandResponse> Handle(RemoveStaffCommandRequest request, CancellationToken cancellationToken)
        {
            var value = await _staffReadRepository.GetByIdAsync(request.Id);
            _staffWriteRepository.Remove(value);
            await _staffWriteRepository.SaveAsync();
            return new();
        }
    }
}

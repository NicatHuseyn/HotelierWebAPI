using HotelierProject.Application.Repositories;
using HotelierProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Commands.StaffCommand.CreateStaff
{
    public class CreateStaffCommandHandler : IRequestHandler<CreateStaffCommandRequest, CreateStaffCommandResponse>
    {

        private readonly IStaffWriteRepository _staffWriteRepository;

        public CreateStaffCommandHandler(IStaffWriteRepository staffWriteRepository)
        {
            _staffWriteRepository = staffWriteRepository;
        }

        public async Task<CreateStaffCommandResponse> Handle(CreateStaffCommandRequest request, CancellationToken cancellationToken)
        {
            await _staffWriteRepository.AddAsync(new Staff
            {
                Name = request.Name,
                FaceBookUrl = request.FaceBookUrl,
                InstagramUrl = request.InstagramUrl,
                TwitterUrl = request.TwitterUrl,
                Profeesion = request.Profeesion
            });

            await _staffWriteRepository.SaveAsync();

            return new();
        }
    }
}

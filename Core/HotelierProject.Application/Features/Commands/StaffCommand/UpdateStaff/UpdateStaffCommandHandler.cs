using HotelierProject.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Commands.StaffCommand.UpdateStaff
{
    public class UpdateStaffCommandHandler : IRequestHandler<UpdateStaffCommandRequest, UpdateStaffCommandResponse>
    {
        private readonly IStaffReadRepository _staffReadRepository;
        private readonly IStaffWriteRepository _staffWriteRepository;

        public UpdateStaffCommandHandler(IStaffReadRepository staffReadRepository, IStaffWriteRepository staffWriteRepository)
        {
            _staffReadRepository = staffReadRepository;
            _staffWriteRepository = staffWriteRepository;
        }

        public async Task<UpdateStaffCommandResponse> Handle(UpdateStaffCommandRequest request, CancellationToken cancellationToken)
        {
            var value = await _staffReadRepository.GetByIdAsync(request.Id);
            value.Id = request.Id;
            value.Name = request.Name;
            value.Profeesion = request.Profeesion;
            value.TwitterUrl = request.TwitterUrl;
            value.InstagramUrl = request.InstagramUrl;
            value.FaceBookUrl = request.FaceBookUrl;


            _staffWriteRepository.Update(value);
            await _staffWriteRepository.SaveAsync();

            return new();
        }
    }
}

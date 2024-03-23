using HotelierProject.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Commands.TestimonialCommand.UpdateTestimonial
{
    public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommandRequest, UpdateTestimonialCommandResponse>
    {
        private readonly ITestimonialReadRepository _readRepository;
        private readonly ITestimonialWriteRepository _writeRepository;

        public UpdateTestimonialCommandHandler(ITestimonialReadRepository readRepository, ITestimonialWriteRepository writeRepository)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
        }

        public async Task<UpdateTestimonialCommandResponse> Handle(UpdateTestimonialCommandRequest request, CancellationToken cancellationToken)
        {
            var value = await _readRepository.GetByIdAsync(request.Id);
            value.Id = request.Id;
            value.Name = request.Name;
            value.Description = request.Description;
            value.Profession = request.Profession;
            value.ImageUrl = request.ImageUrl;

            _writeRepository.Update(value);
            await _writeRepository.SaveAsync();
            return new();
        }
    }
}

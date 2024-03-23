using HotelierProject.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Commands.TestimonialCommand.RemoveCommand
{
    public class RemoveTestimonialCommandHandler : IRequestHandler<RemoveTestimonialCommandRequest, RemoveTestimonialCommandResponse>
    {
        private readonly ITestimonialReadRepository _repository;
        private readonly ITestimonialWriteRepository _writeRepository;
        public RemoveTestimonialCommandHandler(ITestimonialReadRepository repository, ITestimonialWriteRepository writeRepository)
        {
            _repository = repository;
            _writeRepository = writeRepository;
        }

        public async Task<RemoveTestimonialCommandResponse> Handle(RemoveTestimonialCommandRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            _writeRepository.Remove(value);

            await _writeRepository.SaveAsync();
            return new();
        }
    }
}

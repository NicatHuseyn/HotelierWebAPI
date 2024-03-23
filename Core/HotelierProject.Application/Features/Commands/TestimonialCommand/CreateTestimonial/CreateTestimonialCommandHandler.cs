using HotelierProject.Application.Repositories;
using HotelierProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Commands.TestimonialCommand.CreateTestimonial
{
    public class CreateTestimonialCommandHandler : IRequestHandler<CreateTestimonialCommandRequest, CreateTestimonialCommandResponse>
    {
        private readonly ITestimonialWriteRepository _repository;

        public CreateTestimonialCommandHandler(ITestimonialWriteRepository repository)
        {
            _repository = repository;
        }

        public async Task<CreateTestimonialCommandResponse> Handle(CreateTestimonialCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(new Testimonial
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                Profession = request.Profession
            });
            await _repository.SaveAsync();

            return new();
        }
    }
}

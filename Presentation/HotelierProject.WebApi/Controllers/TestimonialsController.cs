using HotelierProject.Application.Features.Commands.TestimonialCommand.CreateTestimonial;
using HotelierProject.Application.Features.Commands.TestimonialCommand.RemoveCommand;
using HotelierProject.Application.Features.Commands.TestimonialCommand.UpdateTestimonial;
using HotelierProject.Application.Features.Queries.TestimonialQuery.GetAllTestimonial;
using HotelierProject.Application.Features.Queries.TestimonialQuery.GetByIdTestimonial;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TestimonialsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery]GetAllTestimonialQueryRequest getAllTestimonialQueryRequest)
        {
            var response = await _mediator.Send(getAllTestimonialQueryRequest);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonial([FromQuery]GetByIdTestimonialQueryRequest getByIdTestimonialQueryRequest)
        {
            var response = await _mediator.Send(getByIdTestimonialQueryRequest);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialCommandRequest createTestimonialCommandRequest)
        {
            await _mediator.Send(createTestimonialCommandRequest);
            return Ok("Created Testimonial");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialCommandRequest updateTestimonialCommandRequest)
        {
            await _mediator.Send(updateTestimonialCommandRequest);
            return Ok("Update Testimonial");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveTestimonial([FromQuery]RemoveTestimonialCommandRequest removeTestimonialCommandRequest)
        {
            await _mediator.Send(removeTestimonialCommandRequest);
            return Ok("Remove Testimonial");
        }

    }
}

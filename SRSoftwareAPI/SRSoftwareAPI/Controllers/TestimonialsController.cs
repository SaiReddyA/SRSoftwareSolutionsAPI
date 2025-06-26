using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SRSoftwareAPI.DTOs;

namespace SRSoftwareAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialRepository _repository;

        public TestimonialsController(ITestimonialRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TestimonialReadDto>>> GetAll()
        {
            var testimonials = await _repository.GetAllAsync();
            return Ok(testimonials);
        }

        [HttpPost]
        public async Task<ActionResult<TestimonialReadDto>> Create(Testimonial dto)
        {
            var result = await _repository.CreateAsync(dto);
            return CreatedAtAction("", new { id = result.Id }, result);
        }

       
    }
}

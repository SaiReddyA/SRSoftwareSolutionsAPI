

namespace SRSoftwareAPI.Repository
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly Supabase.Client _client;

        public TestimonialRepository(Supabase.Client client)
        {
            _client = client;
        }

        public Task<Testimonial> CreateAsync(Testimonial testimonial)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Testimonial>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        //public async Task<IEnumerable<Testimonial>> GetAllAsync()
        //{
        //    var result = await _client.From<Testimonial>().Get();
        //    return result.Models;
        //}

        //public async Task<Testimonial> CreateAsync(Testimonial testimonial)
        //{
        //    var inserted = await _client.From<Testimonial>().Insert(testimonial);
        //    return inserted.Models.FirstOrDefault();
        //}
    }


}

namespace SRSoftwareAPI.Interface
{
    public interface ICoursesRepo
    {
    }
    public interface ITestimonialRepository
    {
        Task<IEnumerable<Testimonial>> GetAllAsync();
        Task<Testimonial> CreateAsync(Testimonial testimonial);
    }
}

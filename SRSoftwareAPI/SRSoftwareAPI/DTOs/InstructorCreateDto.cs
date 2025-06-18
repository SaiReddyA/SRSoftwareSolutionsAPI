namespace SRSoftwareAPI.DTOs
{
    public class InstructorCreateDto
    {
        public string Name { get; set; }
        public string ProfileImage { get; set; }
        public string Bio { get; set; }
    }

    public class InstructorReadDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ProfileImage { get; set; }
        public string Bio { get; set; }
    }
    public class CourseCreateDto
    {
        public string Title { get; set; }
        public string Type { get; set; }
        public string ImageUrl { get; set; }
        public string Level { get; set; }
        public string Duration { get; set; }
        public decimal Rating { get; set; }
        public string Learners { get; set; }
        public decimal Price { get; set; }
        public bool IsPaid { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public Guid? InstructorId { get; set; }
        public int Lectures { get; set; }
        public string Enrolled { get; set; }
        public string Language { get; set; }
        public string Deadline { get; set; }
        public bool Certificate { get; set; }
        public string Url { get; set; }
    }
    public class CourseReadDto : CourseCreateDto
    {
        public Guid Id { get; set; }
    }
    public class CourseTopicDto
    {
        public int Id { get; set; }
        public Guid CourseId { get; set; }
        public string Topic { get; set; }
    }

    public class CourseSkillDto
    {
        public int Id { get; set; }
        public Guid CourseId { get; set; }
        public string Skill { get; set; }
    }

    public class CourseSyllabusDto
    {
        public int Id { get; set; }
        public Guid CourseId { get; set; }
        public string Title { get; set; }
        public int OrderIndex { get; set; }
    }
    public class UserRegisterDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class UserLoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class UserReadDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegisteredAt { get; set; }
    }
    public class EnrollmentCreateDto
    {
        public Guid UserId { get; set; }
        public Guid CourseId { get; set; }
    }

    public class EnrollmentReadDto
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public Guid CourseId { get; set; }
        public DateTime EnrolledAt { get; set; }
    }

}

namespace SRSoftwareAPI.Models
{
    public class Course
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Type { get; set; }
        public string ImageUrl { get; set; }
        public string Level { get; set; }
        public string Duration { get; set; }
        public decimal Rating { get; set; }
        public string Learners { get; set; }
        public decimal Price { get; set; }
        public bool IsPaid { get; set; } = true;
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public Guid? InstructorId { get; set; }
        public int Lectures { get; set; }
        public string Enrolled { get; set; }
        public string Language { get; set; }
        public string Deadline { get; set; }
        public bool Certificate { get; set; } = false;
        public string Url { get; set; }
    }

    public class CourseTopic
    {
        public int Id { get; set; }
        public Guid CourseId { get; set; }
        public string Topic { get; set; }
    }

    public class CourseSkill
    {
        public int Id { get; set; }
        public Guid CourseId { get; set; }
        public string Skill { get; set; }
    }
    public class CourseSyllabus
    {
        public int Id { get; set; }
        public Guid CourseId { get; set; }
        public string Title { get; set; }
        public int OrderIndex { get; set; }
    }

    public class Instructor
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string ProfileImage { get; set; }
        public string Bio { get; set; }
    }
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // Hashed
        public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;
    }
    public class Enrollment
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public Guid CourseId { get; set; }
        public DateTime EnrolledAt { get; set; } = DateTime.UtcNow;
    }
    public class Testimonial
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
    }


}

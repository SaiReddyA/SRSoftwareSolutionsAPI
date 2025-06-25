using SRSoftwareAPI.Models;

namespace SRSoftwareAPI.DBContext
{
    public class AppDbContext: DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseTopic> CourseTopics { get; set; }
        public DbSet<CourseSkill> CourseSkills { get; set; }
        public DbSet<CourseSyllabus> CourseSyllabi { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .Property(c => c.Rating)
                .HasColumnType("numeric(2,1)");

            modelBuilder.Entity<Course>()
                .Property(c => c.Price)
                .HasColumnType("numeric");

            modelBuilder.Entity<Course>()
                .HasOne<Instructor>()
                .WithMany()
                .HasForeignKey(c => c.InstructorId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}

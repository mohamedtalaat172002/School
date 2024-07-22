using Microsoft.EntityFrameworkCore;
using School.Data.Entities;

namespace School.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions option) : base(option)
        {

        }
        public DbSet<ClassRoom> classRooms { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Grade> Grads { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<Teacher> teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define the many-to-many relationship
            modelBuilder.Entity<ClassRoom>()
                .HasMany(cr => cr.Teachers)
                .WithMany(t => t.rooms)
                .UsingEntity<Dictionary<string, object>>(
                    "ClassRoomTeacher",
                    j => j
                        .HasOne<Teacher>()
                        .WithMany()
                        .HasForeignKey("Teachersid")
                        .OnDelete(DeleteBehavior.Cascade),
                    j => j
                        .HasOne<ClassRoom>()
                        .WithMany()
                        .HasForeignKey("roomsId")
                        .OnDelete(DeleteBehavior.Cascade)
                );

            // Additional configurations if needed
        }
    }
}

using Microsoft.EntityFrameworkCore;
using SMS.Server.Data.Models;

namespace SMS.Server.Data
{
    public class SMSDbContext(DbContextOptions<SMSDbContext> options) : DbContext(options)
    {
        public DbSet<Class> Classes { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<AttendanceLog> AttendanceLogs { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<ClassSchedule> ClassSchedules { get; set; }
        public DbSet<StudentMark> StudentMarks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>().ToTable("Class");
            modelBuilder.Entity<Section>().ToTable("Section");
            modelBuilder.Entity<Subject>().ToTable("Subject");
            modelBuilder.Entity<AttendanceLog>().ToTable("AttendanceLog");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Teacher>().ToTable("Teacher");
            modelBuilder.Entity<ClassSchedule>().ToTable("ClassSchedule");
            modelBuilder.Entity<StudentMark>().ToTable("StudentMark");
        }
    }
}

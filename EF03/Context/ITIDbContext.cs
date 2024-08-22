using EFC01.ITI_DB_Schema;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF03.Context
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-M4KTLBQ; Database = ITI_Db03; Trusted_Connection = True; Encrypt = false; ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //composite PK
            modelBuilder.Entity<Course_Inst>()
                        .HasKey(CI => new { CI.CourseId, CI.InstructorId });
            modelBuilder.Entity<Student_Course>()
                        .HasKey(SC => new {SC.StudentId, SC.CourseId });

            modelBuilder.Entity<Instructor>()
                        .HasOne(I => I.Department)
                        .WithMany(D => D.Instructors)
                        .HasForeignKey("DeptID");

            modelBuilder.Entity<Department>()
                        .HasOne(D => D.HeadInstructor)
                        .WithOne()
                        .HasForeignKey("InsID");                

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Student_Course> StudCourses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course_Inst> course_Insts { get; set; }
    }
}

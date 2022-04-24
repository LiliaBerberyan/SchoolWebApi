using Microsoft.EntityFrameworkCore;
using SchoolWebAPi.Data.Models;
using SchoolWebAPi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolWebAPi
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student_Subject>()
                .HasOne(s => s.Student)
                .WithMany(sa => sa.Student_Subjects)
                .HasForeignKey(st => st.StudentId);

            modelBuilder.Entity<Student_Subject>()
               .HasOne(s => s.Subject)
               .WithMany(sa => sa.Student_Subjects)
               .HasForeignKey(st => st.SubjectId);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Student_Subject> Student_Subject { get; set; }
    }
}

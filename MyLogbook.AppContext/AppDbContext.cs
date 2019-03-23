using Microsoft.EntityFrameworkCore;
using MyLogbook.Entities;
using System;
using System.Collections.Generic;

namespace MyLogbook.AppContext
{
    public class AppDbContext: DbContext
    {
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base (options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //base.OnModelCreating(builder);

            Guid faculty_une = Guid.NewGuid();
            Guid faculty_deux = Guid.NewGuid();
            Guid faculty_trois = Guid.NewGuid();
            Guid faculty_quatre = Guid.NewGuid();

            Guid group_une = Guid.NewGuid();
            Guid group_deux = Guid.NewGuid();
            Guid group_trois = Guid.NewGuid();
            Guid group_quatre = Guid.NewGuid();

            Guid department_une = Guid.NewGuid();
            Guid department_deux = Guid.NewGuid();
            Guid department_trois = Guid.NewGuid();
            Guid department_quatre = Guid.NewGuid();

            builder.Entity<Faculty>()
                .HasMany(f => f.Groups)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Faculty>()
                .HasMany(d => d.Departments)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Group>()
                .HasOne(g => g.Faculty)
                .WithMany(item => item.Groups)
                .HasForeignKey(g => g.FacultyId);

            builder.Entity<Department>()
                .HasOne(g => g.Faculty)
                .WithMany(item => item.Departments)
                .HasForeignKey(g => g.FacultyId);


            /*
             * First data for faculties 
             */
            builder.Entity<Faculty>().HasData(
                new Faculty { Id = faculty_une, Title = "Programming" },
                new Faculty { Id = faculty_deux, Title = "System administration and security" },
                new Faculty { Id = faculty_trois, Title = "Disign" },
                new Faculty { Id = faculty_quatre, Title = "Base" }
                );

            /*
            * First data for groups 
            */
            builder.Entity<Group>().HasData(
                new Group {Id = group_une, Title = "PR-01-1", FacultyId = faculty_une },
                new Group {Id = group_deux, Title = "PR-01-2", FacultyId = faculty_une },
                new Group {Id = group_trois, Title = "SAS-01-1", FacultyId = faculty_deux },
                new Group {Id = group_quatre, Title = "DN-01-1", FacultyId = faculty_trois }
                );

            /*
            * First data for departments 
            */
            builder.Entity<Department>().HasData(
                new Department { Id = department_une, Title = "Department NET", FacultyId = faculty_une },
                new Department { Id = department_deux, Title = "Department WEB", FacultyId = faculty_une },
                new Department { Id = department_trois, Title = "Department Drow", FacultyId = faculty_trois },
                new Department { Id = department_quatre, Title = "Department Network", FacultyId = faculty_deux }
                );
        }
    }
}

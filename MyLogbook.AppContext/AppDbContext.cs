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
        public DbSet<Student> Students { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base (options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            Guid faculty_une = Guid.NewGuid();
            Guid faculty_deux = Guid.NewGuid();
            Guid faculty_trois = Guid.NewGuid();
            Guid faculty_quatre = Guid.NewGuid();

            Guid group_une = Guid.NewGuid();
            Guid group_deux = Guid.NewGuid();
            Guid group_trois = Guid.NewGuid();
            Guid group_quatre = Guid.NewGuid();

            builder.Entity<Faculty>()
                .HasOne(f => f.Groups)
                .WithOne();

            builder.Entity<Group>()
                .HasOne(g => g.Faculty)
                .WithMany(f => f.Groups)
                .HasForeignKey(g => g.FacultyId);


            /*
             * First data for faculties 
             */
            builder.Entity<Faculty>().HasData(
                new Faculty
                {
                    Id = faculty_une,
                    Title = "Programming",
                },
                new Faculty
                {
                    Id = faculty_deux,
                    Title = "System administration and security",
                },
                new Faculty
                {
                    Id = faculty_trois,
                    Title = "Disign",
                },
                new Faculty
                {
                    Id = faculty_quatre,
                    Title = "Base",
                });

            /*
            * First data for groups 
            */
            builder.Entity<Group>().HasData(
                new Group
                {
                    Id = group_une,
                    Title = "PR-01-1",
                    FacultyId = faculty_une
                },
                new Group
                {
                    Id = group_deux,
                    Title = "PR-01-2",
                    FacultyId = faculty_une,
                },
                new Group
                {
                    Id = group_trois,
                    FacultyId = faculty_deux,
                    Title = "SAS-01-1",

                },
                new Group
                {
                    Id = group_quatre,
                    Title = "DN-01-1",
                    FacultyId = faculty_trois,
                });
        }
    }
}

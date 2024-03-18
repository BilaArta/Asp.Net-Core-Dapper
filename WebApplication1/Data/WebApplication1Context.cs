using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class WebApplication1Context : DbContext
    {
        public WebApplication1Context (DbContextOptions<WebApplication1Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new DbInitializer(modelBuilder).Seed();
        }
       

        public DbSet<Movie> Movie { get; set; } = default!;
        public DbSet<Person> Person { get; set; } = default!;
        public DbSet<Address> Addresses { get; set; } = default!;
        public DbSet<Email> Emails { get; set; } = default!;
        public DbSet<Employee> Employees { get; set; } = default!;
        public DbSet<Company> Companies { get; set; } = default!;
    }

    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie() { Id = 1, Genre = "Drama", Price = 25000, ReleaseDate = DateTime.Today, Title = "Movie A" },
                new Movie() { Id = 2, Genre = "Drama", Price = 25000, ReleaseDate = DateTime.Today, Title = "Movie B" },
                new Movie() { Id = 3, Genre = "Drama", Price = 25000, ReleaseDate = DateTime.Today, Title = "Movie C" },
                new Movie() { Id = 4, Genre = "Drama", Price = 25000, ReleaseDate = DateTime.Today, Title = "Movie D" },
                new Movie() { Id = 5, Genre = "Drama", Price = 25000, ReleaseDate = DateTime.Today, Title = "Movie E" }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Id = 1, Name = "Andi Jaya", Age = 22, CompanyId = 1, Position = "Software Developer" },
                new Employee() { Id = 2, Name = "Hantoro Sudibyo", Age = 28, CompanyId = 1, Position = "HRD" },
                new Employee() { Id = 3, Name = "Sinarmas", Age = 30, CompanyId = 1, Position = "CEO" },
                new Employee() { Id = 4, Name = "Kukuh Atmaja", Age = 27, CompanyId = 1, Position = "UI/UX" }
            );

            modelBuilder.Entity<Company>().HasData(
                new Company() { Id = 1, Address= "Jl. raya tes 123", Country= "Surabaya", Name= "Company Usaha aja dulu" }
            );
        }
    }
}

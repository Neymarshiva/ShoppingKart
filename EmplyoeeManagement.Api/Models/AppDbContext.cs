using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmplyoeeManagementModels;
using Core.Entities;

namespace EmplyoeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Emplyoee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Products> Products { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<ProductBrand> ProductBrand { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Code to seed data
            if(Database.ProviderName == "Microsoft.EntityFrameworkCore.Sqlite")
            {
                ///SqlLIte database decimal converison does't support using orderby time so that using this method
                foreach(var entityType in modelBuilder.Model.GetEntityTypes())
                {
                    //In this line it will give the all the table decimal column and converting double
                    var properties = entityType.ClrType.GetProperties().Where(p => p.PropertyType == typeof(decimal));

                    foreach(var property in properties)
                    {
                        modelBuilder.Entity(entityType.Name).Property(property.Name).HasConversion<double>();
                    }
                }
            }



            modelBuilder.Entity<Department>().HasData(
             new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 4, DepartmentName = "Admin" });

            // Seed Employee Table
            modelBuilder.Entity<Emplyoee>().HasData(new Emplyoee
            {
                EmplyoeeId = 1,
                FirstName = "John",
                LastName = "Hastings",
                Email = "David@pragimtech.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/MenImages.jpg"
            });

            modelBuilder.Entity<Emplyoee>().HasData(new Emplyoee
            {
                EmplyoeeId = 2,
                FirstName = "Sam",
                LastName = "Galloway",
                Email = "Sam@pragimtech.com",
                DateOfBirth = new DateTime(1981, 12, 22),
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "images/MenImages.jpg"
            });

            modelBuilder.Entity<Emplyoee>().HasData(new Emplyoee
            {
                EmplyoeeId = 3,
                FirstName = "Mary",
                LastName = "Smith",
                Email = "mary@pragimtech.com",
                DateOfBirth = new DateTime(1979, 11, 11),
                Gender = Gender.Female,
                DepartmentId = 1,
                PhotoPath = "images/MenImages.jpg"
            });

            modelBuilder.Entity<Emplyoee>().HasData(new Emplyoee
            {
                EmplyoeeId = 4,
                FirstName = "Sara",
                LastName = "Longway",
                Email = "sara@pragimtech.com",
                DateOfBirth = new DateTime(1982, 9, 23),
                Gender = Gender.Female,
                DepartmentId = 3,
                PhotoPath = "images/MenImages.jpg"
            });
        }
    }
}

using Domain.Constants;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)   
        {
            
        }
        public DbSet<CarAd> CarAds { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<TransmissionType> TransmissionTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(i => i.CarAds)
                .WithOne(i => i.User)
                .HasForeignKey(i => i.UserId);

            modelBuilder.Entity<Manufacturer>()
                .HasMany(i => i.Models)
                .WithOne(i => i.Manufacturer)
                .HasForeignKey(i => i.ManufacturerId);


            modelBuilder.Entity<Model>()
                .HasMany(i => i.CarAds)
                .WithOne(i => i.Model)
                .HasForeignKey(i => i.ModelId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CarType>()
                .HasMany(i => i.Models)
                .WithOne(i => i.CarType)
                .HasForeignKey(i => i.CarTypeId);

            modelBuilder.Entity<FuelType>()
                .HasMany(i => i.CarAds)
                .WithOne(i => i.FuelType)
                .HasForeignKey(i => i.FuelTypeId);

            modelBuilder.Entity<Location>()
                .HasMany(i => i.CarAds)
                .WithOne(i => i.Location)
                .HasForeignKey(i => i.LocationId);


            modelBuilder.Entity<TransmissionType>()
                .HasMany(i => i.CarAds)
                .WithOne(i => i.TransmissionType)
                .HasForeignKey(i => i.TransmissionTypeId);


            modelBuilder.Entity<TransmissionType>().HasData(
                new TransmissionType { TransmissionTypeId = 1, TransmissionName = "Manual" },
                new TransmissionType { TransmissionTypeId = 2, TransmissionName = "Automatic" },
                new TransmissionType { TransmissionTypeId = 3, TransmissionName = "Semi-Automatic" }
                );

            modelBuilder.Entity<CarType>().HasKey(i => i.CarTypeId);

            modelBuilder.Entity<CarType>().HasData(
                new CarType { CarTypeId=1, Name = "Sedan" },
                new CarType { CarTypeId = 2, Name = "Coupe" },
                new CarType { CarTypeId = 3, Name = "SUV" },
                new CarType { CarTypeId = 4, Name = "Minivan" },
                new CarType { CarTypeId = 5, Name = "Cabriolet" },
                new CarType { CarTypeId = 6, Name = "Small Car" },
                new CarType { CarTypeId = 7, Name = "Limousine" }
                );

            modelBuilder.Entity<Location>().HasData(
                new Location { LocationId = 1, LocationName = "Tbilisi" },
                new Location { LocationId = 2, LocationName = "Batumi" },
                new Location { LocationId = 3, LocationName = "Kutaisi" },
                new Location { LocationId = 4, LocationName = "Rustavi" },
                new Location { LocationId = 5, LocationName = "Telavi" },
                new Location { LocationId = 6, LocationName = "Zestafoni" },
                new Location { LocationId = 7, LocationName = "Gori" },
                new Location { LocationId = 8, LocationName = "Khashuri" },
                new Location { LocationId = 9, LocationName = "Poti" },
                new Location { LocationId = 10, LocationName = "Qobuleti" }
                );

            modelBuilder.Entity<FuelType>().HasData(
                new FuelType { FuelTypeId=1, FuelName = "Petrol" },
                new FuelType { FuelTypeId = 2, FuelName = "Diesel" },
                new FuelType { FuelTypeId = 3, FuelName = "Hybrid" },
                new FuelType { FuelTypeId = 4, FuelName = "Electric" },
                new FuelType { FuelTypeId = 5, FuelName = "Gas" }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer("Server=MSI; Database=MyAuto.Api; Trusted_Connection=True;");
            return new ApplicationDbContext(options.Options);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using PharmacyClassLib.Model;
using System;

namespace PharmacyClassLib
{
    public class MyDbContext : DbContext
    {
        public DbSet<RegistratedHospital> RegistratedHospitals { get; set; }
        public DbSet<Pharmacy> Pharmacies { get; set; }

        public MyDbContext()
        {

        }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            String connectionString = "Server=localhost; Port =5432; Database =Integration; User Id = postgres; Password =root;";
            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pharmacy>().HasData(
                new Pharmacy(1, "Jankovic", "Novi Sad", "Rumenačka", "15"),
                new Pharmacy(2, "Jankovic", "Novi Sad", "Bulevar oslobođenja", "135"),
                new Pharmacy(3, "Jankovic", "Beograd", "Olge Jovanović", "18a")
                );
        }
    }
}

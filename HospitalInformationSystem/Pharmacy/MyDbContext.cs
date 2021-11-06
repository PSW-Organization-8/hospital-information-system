using Microsoft.EntityFrameworkCore;
using PharmacyClassLib.Model;
using PharmacyClassLib.Model.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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
            String connectionString = "Server=localhost; Port=5432; Database=Pharmacy; User Id=postgres; Password=2331;";
            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pharmacy>().HasData(
                new Pharmacy(1, "Jankovic", "Novi Sad", "Rumenačka", "15"),
                new Pharmacy(2, "Benu Pharmacy", "Novi Sad", "Bulevar oslobođenja", "135"),
                new Pharmacy(3, "Galen Pharm", "Beograd", "Olge Jovanović", "18a")
                );

            modelBuilder.Entity<MedicationIngredient>().HasData(
                new MedicationIngredient(1, "Vitamin C"),
                new MedicationIngredient(2, "Fosfor"),
                new MedicationIngredient(3, "Kalcijum")
                );

            modelBuilder.Entity<Medication>().HasData(
                new Medication(1, "Paracetamol", MedicineApprovalStatus.Accepted, 150, null),
                new Medication(2, "Analgin", MedicineApprovalStatus.Accepted, 50, null)
                );
        }
    }
}

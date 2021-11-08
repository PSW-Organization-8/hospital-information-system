using Microsoft.EntityFrameworkCore;
using PharmacyClassLib.Model;
using PharmacyClassLib.Model.Enums;
using System;
using System.Collections.Generic;

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
            String connectionString = "Server=localhost; Port =5432; Database =Pharmacy; User Id = postgres; Password =2331;";
            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pharmacy>().HasData(
                new Pharmacy(1, "Jankovic", "Novi Sad", "Rumenačka", "15"),
                new Pharmacy(2, "Jankovic", "Novi Sad", "Bulevar oslobođenja", "135"),
                new Pharmacy(3, "Jankovic", "Beograd", "Olge Jovanović", "18a")
                );

            modelBuilder.Entity<Objection>().HasData(
                new Objection(1, 0, "Bolnica1", "Ne valja nista")
                );

            modelBuilder.Entity<Response>().HasData(
                new Response(1, 0, "Bolnica1", "Kleveta")
                );
            modelBuilder.Entity<RegistratedHospital>().HasData(
                new RegistratedHospital("Bolnica1", "http:localhost:7313", "fds15d4fs6")
                );

            MedicationIngredient ingredient1 = new MedicationIngredient(1, "Vitamin C");
            MedicationIngredient ingredient2 = new MedicationIngredient(2, "Fosfor");
            MedicationIngredient ingredient3 = new MedicationIngredient(3, "Kalcijum");

            IngredientQuantity quantity1 = new IngredientQuantity(1, 35.4, 1);
            IngredientQuantity quantity2 = new IngredientQuantity(2, 48.7, 2);

            List<IngredientQuantity> ingredientList = new List<IngredientQuantity>();

            ingredientList.Add(quantity1);
            ingredientList.Add(quantity2);

            modelBuilder.Entity<MedicationIngredient>().HasData(
                ingredient1,
                ingredient2,
                ingredient3
                );

            modelBuilder.Entity<IngredientQuantity>().HasData(
                quantity1,
                quantity2
                );

            modelBuilder.Entity<Medication>().HasData(
                new Medication(1, "Paracetamol", MedicineApprovalStatus.Accepted, 150),
                new Medication(2, "Analgin", MedicineApprovalStatus.Accepted, 50)
                );

        }

        private List<IngredientQuantity> IngredientsQuantity()
        {
            IngredientQuantity quantity1 = new IngredientQuantity(1, 35.4, 1);
            IngredientQuantity quantity2 = new IngredientQuantity(2, 48.7, 2);

            List<IngredientQuantity> ingredientList = new List<IngredientQuantity>();

            ingredientList.Add(quantity1);
            ingredientList.Add(quantity2);

            return ingredientList;
        }
    }
}

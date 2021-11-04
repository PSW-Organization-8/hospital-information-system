using IntegrationClassLib.Parthership.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace IntegrationClassLib
{
    public class MyDbContext : DbContext
    {
        public DbSet<Pharmacy.Model.Pharmacy> Pharmacies { get; set; }
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
            modelBuilder.Entity<Pharmacy.Model.Pharmacy>().HasData(
                new Pharmacy.Model.Pharmacy { Id = 1, Name = "Apoteka1", ApiKey="asd123easd", Url="asdsad", Port="1234"}
            );
            modelBuilder.Entity<Objection>().HasData(
                new Objection { Id = 1, PharmacyName = "Apoteka1", TextObjection = "Lose usluge" }
            );
            modelBuilder.Entity<Response>().HasData(
               new Response { Id = 1, PharmacyName = "Apoteka1", TextResponse = "Nije tacno" }
           );
        }
    }
}

﻿// <auto-generated />
using System;
using HospitalClassLib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HospitalAPI.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("HospitalClassLib.Feedbacks.Model.Feedback", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsAnonymous")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPublishable")
                        .HasColumnType("boolean");

                    b.Property<string>("PatientId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Feedbacks");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Content = "Tekst neki",
                            Date = new DateTime(2021, 11, 3, 23, 39, 20, 454, DateTimeKind.Local).AddTicks(1777),
                            IsAnonymous = false,
                            IsApproved = true,
                            IsPublishable = true,
                            PatientId = "1"
                        },
                        new
                        {
                            Id = "2",
                            Content = "Drugi neki",
                            Date = new DateTime(2021, 11, 3, 23, 39, 20, 458, DateTimeKind.Local).AddTicks(8590),
                            IsAnonymous = false,
                            IsApproved = false,
                            IsPublishable = true,
                            PatientId = "2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

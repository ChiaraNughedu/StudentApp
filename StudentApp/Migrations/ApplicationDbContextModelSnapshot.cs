﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentApp.Data;

#nullable disable

namespace StudentApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentApp.Models.Studente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cognome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DataDiNascita")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Studenti");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cognome = "Nughedu",
                            DataDiNascita = new DateTime(1997, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "chiara.nughedu@example.com",
                            Nome = "Chiara"
                        },
                        new
                        {
                            Id = 2,
                            Cognome = "Palmeri",
                            DataDiNascita = new DateTime(1995, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "fra.palmeri@example.com",
                            Nome = "Francesca"
                        },
                        new
                        {
                            Id = 3,
                            Cognome = "Ciammella",
                            DataDiNascita = new DateTime(1998, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ettore.ciammella@example.com",
                            Nome = "Ettore"
                        },
                        new
                        {
                            Id = 4,
                            Cognome = "Bodescu",
                            DataDiNascita = new DateTime(1999, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "fla.bodescu@example.com",
                            Nome = "Flavius"
                        },
                        new
                        {
                            Id = 5,
                            Cognome = "Rossi",
                            DataDiNascita = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mario.rossi@example.com",
                            Nome = "Mario"
                        },
                        new
                        {
                            Id = 6,
                            Cognome = "Bianchi",
                            DataDiNascita = new DateTime(1992, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "luca.bianchi@example.com",
                            Nome = "Luca"
                        },
                        new
                        {
                            Id = 7,
                            Cognome = "Verdi",
                            DataDiNascita = new DateTime(1995, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "giulia.verdi@example.com",
                            Nome = "Giulia"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

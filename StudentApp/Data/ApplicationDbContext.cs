using Microsoft.EntityFrameworkCore;
using StudentApp.Models;
using System;

namespace StudentApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Studente> Studenti { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Studente>().HasData(
                 new Studente
                 {
                     Id = 1,
                     Nome = "Chiara",
                     Cognome = "Nughedu",
                     DataDiNascita = new DateTime(1997, 03, 10),
                     Email = "chiara.nughedu@example.com"
                 },
                new Studente
                {
                    Id = 2,
                    Nome = "Francesca",
                    Cognome = "Palmeri",
                    DataDiNascita = new DateTime(1995, 09, 20),
                    Email = "fra.palmeri@example.com"
                },
                  new Studente
                  {
                      Id = 3,
                      Nome = "Ettore",
                      Cognome = "Ciammella",
                      DataDiNascita = new DateTime(1998, 05, 10),
                      Email = "ettore.ciammella@example.com"
                  },
                   new Studente
                   {
                       Id = 4,
                       Nome = "Flavius",
                       Cognome = "Bodescu",
                       DataDiNascita = new DateTime(1999, 10, 20),
                       Email = "fla.bodescu@example.com"
                   },
                new Studente
                {
                    Id = 5,
                    Nome = "Mario",
                    Cognome = "Rossi",
                    DataDiNascita = new DateTime(1990, 1, 1),
                    Email = "mario.rossi@example.com"
                },
                new Studente
                {
                    Id = 6,
                    Nome = "Luca",
                    Cognome = "Bianchi",
                    DataDiNascita = new DateTime(1992, 5, 15),
                    Email = "luca.bianchi@example.com"
                },
                new Studente
                {
                    Id = 7,
                    Nome = "Giulia",
                    Cognome = "Verdi",
                    DataDiNascita = new DateTime(1995, 10, 20),
                    Email = "giulia.verdi@example.com"
                }
                 
            );
        }
    }
}

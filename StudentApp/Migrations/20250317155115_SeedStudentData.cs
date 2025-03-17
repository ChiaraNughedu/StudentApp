using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedStudentData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Studenti",
                columns: new[] { "Id", "Cognome", "DataDiNascita", "Email", "Nome" },
                values: new object[,]
                {
                    { 1, "Nughedu", new DateTime(1997, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "chiara.nughedu@example.com", "Chiara" },
                    { 2, "Palmeri", new DateTime(1995, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "fra.palmeri@example.com", "Francesca" },
                    { 3, "Ciammella", new DateTime(1998, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ettore.ciammella@example.com", "Ettore" },
                    { 4, "Bodescu", new DateTime(1999, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "fla.bodescu@example.com", "Flavius" },
                    { 5, "Rossi", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mario.rossi@example.com", "Mario" },
                    { 6, "Bianchi", new DateTime(1992, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "luca.bianchi@example.com", "Luca" },
                    { 7, "Verdi", new DateTime(1995, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "giulia.verdi@example.com", "Giulia" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}

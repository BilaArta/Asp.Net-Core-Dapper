using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Genre", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "Drama", 25000m, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), "Movie A" },
                    { 2, "Drama", 25000m, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), "Movie B" },
                    { 3, "Drama", 25000m, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), "Movie C" },
                    { 4, "Drama", 25000m, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), "Movie D" },
                    { 5, "Drama", 25000m, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), "Movie E" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}

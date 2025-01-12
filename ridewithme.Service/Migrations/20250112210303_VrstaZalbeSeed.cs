using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class VrstaZalbeSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 12, 22, 3, 3, 407, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 12, 22, 3, 3, 407, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.InsertData(
                table: "VrstaZalbe",
                columns: new[] { "Id", "DatumIzmjene", "KorisnikId", "Naziv" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 12, 22, 3, 3, 412, DateTimeKind.Local).AddTicks(8794), 1, "Na vožnju" },
                    { 2, new DateTime(2025, 1, 12, 22, 3, 3, 412, DateTimeKind.Local).AddTicks(8809), 1, "Na vozača" },
                    { 3, new DateTime(2025, 1, 12, 22, 3, 3, 412, DateTimeKind.Local).AddTicks(8811), 1, "Ostalo" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 12, 22, 2, 16, 508, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 12, 22, 2, 16, 509, DateTimeKind.Local).AddTicks(208));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class KuponiSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 12, 22, 24, 45, 337, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 12, 22, 24, 45, 337, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.InsertData(
                table: "Kuponi",
                columns: new[] { "Id", "BrojIskoristivosti", "DatumIzmjene", "DatumPocetka", "Kod", "KorisnikId", "Naziv", "Popust", "StateMachine" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2025, 1, 12, 22, 24, 45, 341, DateTimeKind.Local).AddTicks(3769), new DateTime(2025, 1, 12, 22, 24, 45, 341, DateTimeKind.Local).AddTicks(3772), "TESTNI-KOD", 1, "Testni kod", 0.10000000000000001, "draft" },
                    { 2, 10, new DateTime(2025, 1, 12, 22, 24, 45, 341, DateTimeKind.Local).AddTicks(3774), new DateTime(2025, 1, 12, 22, 24, 45, 341, DateTimeKind.Local).AddTicks(3775), "WELCOME", 1, "Popust dobrodošlice", 0.5, "active" }
                });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 12, 22, 24, 45, 341, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 12, 22, 24, 45, 341, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 12, 22, 24, 45, 341, DateTimeKind.Local).AddTicks(3735));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2);

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

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 12, 22, 3, 3, 412, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 12, 22, 3, 3, 412, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 12, 22, 3, 3, 412, DateTimeKind.Local).AddTicks(8811));
        }
    }
}

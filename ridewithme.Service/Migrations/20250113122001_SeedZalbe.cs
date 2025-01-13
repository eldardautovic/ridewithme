using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class SeedZalbe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 13, 13, 19, 59, 972, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 13, 13, 19, 59, 973, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(4038), new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(4050), new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "Naziv" },
                values: new object[] { new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(3927), "Na aplikaciju" });

            migrationBuilder.InsertData(
                table: "VrstaZalbe",
                columns: new[] { "Id", "DatumIzmjene", "KorisnikId", "Naziv" },
                values: new object[] { 4, new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(3931), 1, "Ostalo" });

            migrationBuilder.InsertData(
                table: "Zalbe",
                columns: new[] { "Id", "AdministratorId", "DatumIzmjene", "DatumKreiranja", "DatumPreuzimanja", "KorisnikId", "Naslov", "OdgovorNaZalbu", "Sadrzaj", "StateMachine", "VrstaZalbeId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(4116), new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(4121), null, 1, "Problem prilikom prijave", null, "Prilikom pokušaja prijave na aplikaciju, ne mogu da se prijavim iako unosim ispravne podatke.", "active", 3 },
                    { 2, null, new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(4127), new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(4131), null, 1, "Vozač ne uzvraća poruke", null, "Potrebno je da dogovorim lokaciju polaska sa vozačem vožnje ID: 2 ali ne mogu da dobijem povratnu informaciju od vozača.", "active", 2 },
                    { 3, null, new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(4135), new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(4138), null, 1, "Vožnja nije bila do navedene lokacije", null, "Vožnja je naznačena da je do Sarajeva, a vozili smo se do Kaknja, molim za povrat novca.", "active", 1 },
                    { 4, null, new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(4142), new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(4145), null, 1, "Neiskoristiv kupon", null, "Naznačeno je da koristimo kupon 'WELCOME', ali on ne radi.", "active", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 13, 10, 45, 40, 213, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 13, 10, 45, 40, 213, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 13, 10, 45, 40, 215, DateTimeKind.Local).AddTicks(99), new DateTime(2025, 1, 13, 10, 45, 40, 215, DateTimeKind.Local).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 13, 10, 45, 40, 215, DateTimeKind.Local).AddTicks(108), new DateTime(2025, 1, 13, 10, 45, 40, 215, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 13, 10, 45, 40, 215, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 13, 10, 45, 40, 215, DateTimeKind.Local).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "Naziv" },
                values: new object[] { new DateTime(2025, 1, 13, 10, 45, 40, 215, DateTimeKind.Local).AddTicks(38), "Ostalo" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class AdminSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 14, 13, 55, 29, 423, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.InsertData(
                table: "Korisnici",
                columns: new[] { "Id", "DatumKreiranja", "Email", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime" },
                values: new object[] { 2, new DateTime(2025, 1, 14, 13, 55, 29, 423, DateTimeKind.Local).AddTicks(9820), "admin@gmail.com", "Admin", "admin", "KaiUaS4zfaZiZnbuv7TN0r5OfeM=", "AglQFeC8HyIM/UV2yFOa0w==", "Korisnik" });

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 14, 13, 55, 29, 424, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(6941), new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(6951) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(6962), new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(7037), new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(7051), new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(7060), new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(7064) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(7070), new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.InsertData(
                table: "KorisniciUloge",
                columns: new[] { "Id", "DatumIzmjene", "KorisnikId", "UlogaId" },
                values: new object[] { 2, new DateTime(2025, 1, 14, 13, 55, 29, 424, DateTimeKind.Local).AddTicks(8748), 2, 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 14, 13, 53, 45, 396, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 14, 13, 53, 45, 397, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 53, 45, 399, DateTimeKind.Local).AddTicks(2886), new DateTime(2025, 1, 14, 13, 53, 45, 399, DateTimeKind.Local).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 53, 45, 399, DateTimeKind.Local).AddTicks(2905), new DateTime(2025, 1, 14, 13, 53, 45, 399, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 14, 13, 53, 45, 399, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 14, 13, 53, 45, 399, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 14, 13, 53, 45, 399, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 14, 13, 53, 45, 399, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 53, 45, 399, DateTimeKind.Local).AddTicks(2978), new DateTime(2025, 1, 14, 13, 53, 45, 399, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 53, 45, 399, DateTimeKind.Local).AddTicks(2993), new DateTime(2025, 1, 14, 13, 53, 45, 399, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 53, 45, 399, DateTimeKind.Local).AddTicks(3005), new DateTime(2025, 1, 14, 13, 53, 45, 399, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 53, 45, 399, DateTimeKind.Local).AddTicks(3017), new DateTime(2025, 1, 14, 13, 53, 45, 399, DateTimeKind.Local).AddTicks(3022) });
        }
    }
}

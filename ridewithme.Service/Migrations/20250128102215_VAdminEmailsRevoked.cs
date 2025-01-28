using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class VAdminEmailsRevoked : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 28, 11, 22, 14, 630, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 28, 11, 22, 14, 630, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 28, 11, 22, 14, 630, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 28, 11, 22, 14, 630, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9895), new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9905), new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 22, 14, 632, DateTimeKind.Local).AddTicks(9), new DateTime(2025, 1, 28, 11, 22, 14, 632, DateTimeKind.Local).AddTicks(13), new DateTime(2025, 1, 30, 11, 22, 14, 632, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 22, 14, 632, DateTimeKind.Local).AddTicks(25), new DateTime(2025, 1, 28, 11, 22, 14, 632, DateTimeKind.Local).AddTicks(27), new DateTime(2025, 1, 28, 13, 22, 14, 632, DateTimeKind.Local).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 22, 14, 632, DateTimeKind.Local).AddTicks(33), new DateTime(2025, 1, 28, 11, 22, 14, 632, DateTimeKind.Local).AddTicks(35), new DateTime(2025, 1, 28, 16, 22, 14, 632, DateTimeKind.Local).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9947), new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9956), new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9962), new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9967), new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9970) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 28, 11, 11, 16, 291, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 28, 11, 11, 16, 291, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 28, 11, 11, 16, 291, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 28, 11, 11, 16, 291, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 11, 16, 292, DateTimeKind.Local).AddTicks(1867), new DateTime(2025, 1, 28, 11, 11, 16, 292, DateTimeKind.Local).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 11, 16, 292, DateTimeKind.Local).AddTicks(1872), new DateTime(2025, 1, 28, 11, 11, 16, 292, DateTimeKind.Local).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 11, 16, 292, DateTimeKind.Local).AddTicks(1945), new DateTime(2025, 1, 28, 11, 11, 16, 292, DateTimeKind.Local).AddTicks(1947), new DateTime(2025, 1, 30, 11, 11, 16, 292, DateTimeKind.Local).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 11, 16, 292, DateTimeKind.Local).AddTicks(1953), new DateTime(2025, 1, 28, 11, 11, 16, 292, DateTimeKind.Local).AddTicks(1954), new DateTime(2025, 1, 28, 13, 11, 16, 292, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 11, 16, 292, DateTimeKind.Local).AddTicks(1959), new DateTime(2025, 1, 28, 11, 11, 16, 292, DateTimeKind.Local).AddTicks(1960), new DateTime(2025, 1, 28, 16, 11, 16, 292, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 28, 11, 11, 16, 292, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 28, 11, 11, 16, 292, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 28, 11, 11, 16, 292, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 28, 11, 11, 16, 292, DateTimeKind.Local).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 11, 16, 292, DateTimeKind.Local).AddTicks(1900), new DateTime(2025, 1, 28, 11, 11, 16, 292, DateTimeKind.Local).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 11, 16, 292, DateTimeKind.Local).AddTicks(1904), new DateTime(2025, 1, 28, 11, 11, 16, 292, DateTimeKind.Local).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 11, 16, 292, DateTimeKind.Local).AddTicks(1908), new DateTime(2025, 1, 28, 11, 11, 16, 292, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 11, 16, 292, DateTimeKind.Local).AddTicks(1912), new DateTime(2025, 1, 28, 11, 11, 16, 292, DateTimeKind.Local).AddTicks(1913) });
        }
    }
}

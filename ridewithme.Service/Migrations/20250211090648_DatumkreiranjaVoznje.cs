using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class DatumkreiranjaVoznje : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DatumKreiranja",
                table: "Voznje",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 11, 10, 6, 46, 867, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 11, 10, 6, 46, 867, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "KorisniciDostignuca",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 11, 10, 6, 46, 868, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 11, 10, 6, 46, 868, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 11, 10, 6, 46, 868, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 6, 46, 870, DateTimeKind.Local).AddTicks(1851), new DateTime(2025, 2, 11, 10, 6, 46, 870, DateTimeKind.Local).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 6, 46, 870, DateTimeKind.Local).AddTicks(1862), new DateTime(2025, 2, 11, 10, 6, 46, 870, DateTimeKind.Local).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 6, 46, 870, DateTimeKind.Local).AddTicks(2016), new DateTime(2025, 2, 11, 10, 6, 46, 870, DateTimeKind.Local).AddTicks(2022), new DateTime(2025, 2, 13, 10, 6, 46, 870, DateTimeKind.Local).AddTicks(2026) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 6, 46, 870, DateTimeKind.Local).AddTicks(2036), new DateTime(2025, 2, 11, 10, 6, 46, 870, DateTimeKind.Local).AddTicks(2039), new DateTime(2025, 2, 11, 12, 6, 46, 870, DateTimeKind.Local).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 6, 46, 870, DateTimeKind.Local).AddTicks(2047), new DateTime(2025, 2, 11, 10, 6, 46, 870, DateTimeKind.Local).AddTicks(2051), new DateTime(2025, 2, 11, 15, 6, 46, 870, DateTimeKind.Local).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 11, 10, 6, 46, 870, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 11, 10, 6, 46, 870, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 11, 10, 6, 46, 870, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 11, 10, 6, 46, 870, DateTimeKind.Local).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 6, 46, 870, DateTimeKind.Local).AddTicks(1922), new DateTime(2025, 2, 11, 10, 6, 46, 870, DateTimeKind.Local).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 6, 46, 870, DateTimeKind.Local).AddTicks(1934), new DateTime(2025, 2, 11, 10, 6, 46, 870, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 6, 46, 870, DateTimeKind.Local).AddTicks(1942), new DateTime(2025, 2, 11, 10, 6, 46, 870, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 6, 46, 870, DateTimeKind.Local).AddTicks(1950), new DateTime(2025, 2, 11, 10, 6, 46, 870, DateTimeKind.Local).AddTicks(1952) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatumKreiranja",
                table: "Voznje");

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 10, 21, 34, 35, 924, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 10, 21, 34, 35, 924, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "KorisniciDostignuca",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 10, 21, 34, 35, 925, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 10, 21, 34, 35, 925, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 10, 21, 34, 35, 925, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 10, 21, 34, 35, 926, DateTimeKind.Local).AddTicks(1272), new DateTime(2025, 2, 10, 21, 34, 35, 926, DateTimeKind.Local).AddTicks(1274) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 10, 21, 34, 35, 926, DateTimeKind.Local).AddTicks(1278), new DateTime(2025, 2, 10, 21, 34, 35, 926, DateTimeKind.Local).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 10, 21, 34, 35, 926, DateTimeKind.Local).AddTicks(1359), new DateTime(2025, 2, 10, 21, 34, 35, 926, DateTimeKind.Local).AddTicks(1361), new DateTime(2025, 2, 12, 21, 34, 35, 926, DateTimeKind.Local).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 10, 21, 34, 35, 926, DateTimeKind.Local).AddTicks(1367), new DateTime(2025, 2, 10, 21, 34, 35, 926, DateTimeKind.Local).AddTicks(1368), new DateTime(2025, 2, 10, 23, 34, 35, 926, DateTimeKind.Local).AddTicks(1369) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 10, 21, 34, 35, 926, DateTimeKind.Local).AddTicks(1372), new DateTime(2025, 2, 10, 21, 34, 35, 926, DateTimeKind.Local).AddTicks(1373), new DateTime(2025, 2, 11, 2, 34, 35, 926, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 10, 21, 34, 35, 926, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 10, 21, 34, 35, 926, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 10, 21, 34, 35, 926, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 10, 21, 34, 35, 926, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 10, 21, 34, 35, 926, DateTimeKind.Local).AddTicks(1306), new DateTime(2025, 2, 10, 21, 34, 35, 926, DateTimeKind.Local).AddTicks(1308) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 10, 21, 34, 35, 926, DateTimeKind.Local).AddTicks(1311), new DateTime(2025, 2, 10, 21, 34, 35, 926, DateTimeKind.Local).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 10, 21, 34, 35, 926, DateTimeKind.Local).AddTicks(1314), new DateTime(2025, 2, 10, 21, 34, 35, 926, DateTimeKind.Local).AddTicks(1316) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 10, 21, 34, 35, 926, DateTimeKind.Local).AddTicks(1317), new DateTime(2025, 2, 10, 21, 34, 35, 926, DateTimeKind.Local).AddTicks(1319) });
        }
    }
}

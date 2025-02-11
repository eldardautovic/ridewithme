using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class DatumkreiranjaUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DatumKreiranja",
                table: "Korisnici",
                type: "datetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 11, 10, 12, 35, 910, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 11, 10, 12, 35, 910, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "KorisniciDostignuca",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 11, 10, 12, 35, 911, DateTimeKind.Local).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 11, 10, 12, 35, 910, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 11, 10, 12, 35, 910, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 12, 35, 913, DateTimeKind.Local).AddTicks(2687), new DateTime(2025, 2, 11, 10, 12, 35, 913, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 12, 35, 913, DateTimeKind.Local).AddTicks(2699), new DateTime(2025, 2, 11, 10, 12, 35, 913, DateTimeKind.Local).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 12, 35, 913, DateTimeKind.Local).AddTicks(2880), new DateTime(2025, 2, 11, 10, 12, 35, 913, DateTimeKind.Local).AddTicks(2890), new DateTime(2025, 2, 13, 10, 12, 35, 913, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 12, 35, 913, DateTimeKind.Local).AddTicks(2920), new DateTime(2025, 2, 11, 10, 12, 35, 913, DateTimeKind.Local).AddTicks(2924), new DateTime(2025, 2, 11, 12, 12, 35, 913, DateTimeKind.Local).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 12, 35, 913, DateTimeKind.Local).AddTicks(2938), new DateTime(2025, 2, 11, 10, 12, 35, 913, DateTimeKind.Local).AddTicks(2942), new DateTime(2025, 2, 11, 15, 12, 35, 913, DateTimeKind.Local).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 11, 10, 12, 35, 913, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 11, 10, 12, 35, 913, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 11, 10, 12, 35, 913, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 11, 10, 12, 35, 913, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 12, 35, 913, DateTimeKind.Local).AddTicks(2771), new DateTime(2025, 2, 11, 10, 12, 35, 913, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 12, 35, 913, DateTimeKind.Local).AddTicks(2785), new DateTime(2025, 2, 11, 10, 12, 35, 913, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 12, 35, 913, DateTimeKind.Local).AddTicks(2794), new DateTime(2025, 2, 11, 10, 12, 35, 913, DateTimeKind.Local).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 11, 10, 12, 35, 913, DateTimeKind.Local).AddTicks(2802), new DateTime(2025, 2, 11, 10, 12, 35, 913, DateTimeKind.Local).AddTicks(2806) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DatumKreiranja",
                table: "Korisnici",
                type: "datetime",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "(getdate())");

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
    }
}

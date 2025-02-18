using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class KorisniciSlika : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Slika",
                table: "Korisnici",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumKreiranja", "Slika" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 20, 43, 789, DateTimeKind.Local).AddTicks(3454), null });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumKreiranja", "Slika" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 20, 43, 789, DateTimeKind.Local).AddTicks(3565), null });

            migrationBuilder.UpdateData(
                table: "KorisniciDostignuca",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 18, 11, 20, 43, 790, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 18, 11, 20, 43, 789, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 18, 11, 20, 43, 789, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(284), new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(287) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(294), new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(448), new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(451), new DateTime(2025, 2, 20, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(465), new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(468), new DateTime(2025, 2, 18, 13, 20, 43, 792, DateTimeKind.Local).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(475), new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(478), new DateTime(2025, 2, 18, 16, 20, 43, 792, DateTimeKind.Local).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(350), new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(360), new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(367), new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(375), new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(377) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slika",
                table: "Korisnici");

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
    }
}

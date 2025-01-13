using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class OdgovorNaZalbu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OdgovorNaZalbu",
                table: "Zalbe",
                type: "nvarchar(max)",
                nullable: true);

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
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 13, 10, 45, 40, 215, DateTimeKind.Local).AddTicks(38));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OdgovorNaZalbu",
                table: "Zalbe");

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 13, 7, 53, 57, 145, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 13, 7, 53, 57, 146, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 13, 7, 53, 57, 157, DateTimeKind.Local).AddTicks(14), new DateTime(2025, 1, 13, 7, 53, 57, 157, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 13, 7, 53, 57, 157, DateTimeKind.Local).AddTicks(25), new DateTime(2025, 1, 13, 7, 53, 57, 157, DateTimeKind.Local).AddTicks(28) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 13, 7, 53, 57, 156, DateTimeKind.Local).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 13, 7, 53, 57, 156, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 13, 7, 53, 57, 156, DateTimeKind.Local).AddTicks(9920));
        }
    }
}

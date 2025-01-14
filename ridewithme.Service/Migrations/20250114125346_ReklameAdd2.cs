using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class ReklameAdd2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Slika",
                table: "Reklame",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Slika",
                table: "Reklame",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 14, 13, 26, 36, 878, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 14, 13, 26, 36, 879, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 26, 36, 881, DateTimeKind.Local).AddTicks(307), new DateTime(2025, 1, 14, 13, 26, 36, 881, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 26, 36, 881, DateTimeKind.Local).AddTicks(320), new DateTime(2025, 1, 14, 13, 26, 36, 881, DateTimeKind.Local).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 14, 13, 26, 36, 881, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 14, 13, 26, 36, 881, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 14, 13, 26, 36, 881, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 14, 13, 26, 36, 881, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 26, 36, 881, DateTimeKind.Local).AddTicks(382), new DateTime(2025, 1, 14, 13, 26, 36, 881, DateTimeKind.Local).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 26, 36, 881, DateTimeKind.Local).AddTicks(399), new DateTime(2025, 1, 14, 13, 26, 36, 881, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 26, 36, 881, DateTimeKind.Local).AddTicks(407), new DateTime(2025, 1, 14, 13, 26, 36, 881, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 26, 36, 881, DateTimeKind.Local).AddTicks(415), new DateTime(2025, 1, 14, 13, 26, 36, 881, DateTimeKind.Local).AddTicks(417) });
        }
    }
}

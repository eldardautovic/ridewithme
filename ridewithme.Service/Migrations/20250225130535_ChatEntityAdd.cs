using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class ChatEntityAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DatumKreiranja",
                table: "ChatMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 185, DateTimeKind.Local).AddTicks(9252), new DateTime(2025, 2, 25, 14, 5, 32, 185, DateTimeKind.Local).AddTicks(9283) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 185, DateTimeKind.Local).AddTicks(9296), new DateTime(2025, 2, 25, 14, 5, 32, 185, DateTimeKind.Local).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 185, DateTimeKind.Local).AddTicks(9331), new DateTime(2025, 2, 25, 14, 5, 32, 185, DateTimeKind.Local).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 185, DateTimeKind.Local).AddTicks(9360), new DateTime(2025, 2, 25, 14, 5, 32, 185, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 185, DateTimeKind.Local).AddTicks(9379), new DateTime(2025, 2, 25, 14, 5, 32, 185, DateTimeKind.Local).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 25, 14, 5, 32, 177, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 25, 14, 5, 32, 177, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "KorisniciDostignuca",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 25, 14, 5, 32, 185, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 14, 5, 32, 180, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 14, 5, 32, 180, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7185), new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7211), new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7655), new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7664), new DateTime(2025, 2, 27, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7693), new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7701), new DateTime(2025, 2, 25, 16, 5, 32, 192, DateTimeKind.Local).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7722), new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7730), new DateTime(2025, 2, 25, 19, 5, 32, 192, DateTimeKind.Local).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7343), new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7367), new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7386), new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7429), new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7527) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatumKreiranja",
                table: "ChatMessages");

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 13, 54, 16, 265, DateTimeKind.Local).AddTicks(1500), new DateTime(2025, 2, 25, 13, 54, 16, 265, DateTimeKind.Local).AddTicks(1504) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 13, 54, 16, 265, DateTimeKind.Local).AddTicks(1511), new DateTime(2025, 2, 25, 13, 54, 16, 265, DateTimeKind.Local).AddTicks(1515) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 13, 54, 16, 265, DateTimeKind.Local).AddTicks(1520), new DateTime(2025, 2, 25, 13, 54, 16, 265, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 13, 54, 16, 265, DateTimeKind.Local).AddTicks(1529), new DateTime(2025, 2, 25, 13, 54, 16, 265, DateTimeKind.Local).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 13, 54, 16, 265, DateTimeKind.Local).AddTicks(1537), new DateTime(2025, 2, 25, 13, 54, 16, 265, DateTimeKind.Local).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 25, 13, 54, 16, 263, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 25, 13, 54, 16, 263, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "KorisniciDostignuca",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 25, 13, 54, 16, 265, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 13, 54, 16, 264, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 13, 54, 16, 264, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 25, 13, 54, 16, 282, DateTimeKind.Local).AddTicks(1284), new DateTime(2025, 2, 25, 13, 54, 16, 282, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 25, 13, 54, 16, 282, DateTimeKind.Local).AddTicks(1322), new DateTime(2025, 2, 25, 13, 54, 16, 282, DateTimeKind.Local).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 25, 13, 54, 16, 282, DateTimeKind.Local).AddTicks(1733), new DateTime(2025, 2, 25, 13, 54, 16, 282, DateTimeKind.Local).AddTicks(1740), new DateTime(2025, 2, 27, 13, 54, 16, 282, DateTimeKind.Local).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 25, 13, 54, 16, 282, DateTimeKind.Local).AddTicks(1762), new DateTime(2025, 2, 25, 13, 54, 16, 282, DateTimeKind.Local).AddTicks(1766), new DateTime(2025, 2, 25, 15, 54, 16, 282, DateTimeKind.Local).AddTicks(1769) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 25, 13, 54, 16, 282, DateTimeKind.Local).AddTicks(1777), new DateTime(2025, 2, 25, 13, 54, 16, 282, DateTimeKind.Local).AddTicks(1781), new DateTime(2025, 2, 25, 18, 54, 16, 282, DateTimeKind.Local).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 13, 54, 16, 282, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 13, 54, 16, 282, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 13, 54, 16, 282, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 13, 54, 16, 282, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 13, 54, 16, 282, DateTimeKind.Local).AddTicks(1459), new DateTime(2025, 2, 25, 13, 54, 16, 282, DateTimeKind.Local).AddTicks(1468) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 13, 54, 16, 282, DateTimeKind.Local).AddTicks(1496), new DateTime(2025, 2, 25, 13, 54, 16, 282, DateTimeKind.Local).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 13, 54, 16, 282, DateTimeKind.Local).AddTicks(1514), new DateTime(2025, 2, 25, 13, 54, 16, 282, DateTimeKind.Local).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 13, 54, 16, 282, DateTimeKind.Local).AddTicks(1532), new DateTime(2025, 2, 25, 13, 54, 16, 282, DateTimeKind.Local).AddTicks(1573) });
        }
    }
}

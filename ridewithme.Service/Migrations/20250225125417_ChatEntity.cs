using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class ChatEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChatMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    RecieverId = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatMessages_Korisnici_RecieverId",
                        column: x => x.RecieverId,
                        principalTable: "Korisnici",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChatMessages_Korisnici_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Korisnici",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessages_RecieverId",
                table: "ChatMessages",
                column: "RecieverId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessages_SenderId",
                table: "ChatMessages",
                column: "SenderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChatMessages");

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 639, DateTimeKind.Local).AddTicks(1745), new DateTime(2025, 2, 25, 9, 26, 4, 639, DateTimeKind.Local).AddTicks(1749) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 639, DateTimeKind.Local).AddTicks(1755), new DateTime(2025, 2, 25, 9, 26, 4, 639, DateTimeKind.Local).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 639, DateTimeKind.Local).AddTicks(1760), new DateTime(2025, 2, 25, 9, 26, 4, 639, DateTimeKind.Local).AddTicks(1762) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 639, DateTimeKind.Local).AddTicks(1766), new DateTime(2025, 2, 25, 9, 26, 4, 639, DateTimeKind.Local).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 639, DateTimeKind.Local).AddTicks(1771), new DateTime(2025, 2, 25, 9, 26, 4, 639, DateTimeKind.Local).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 25, 9, 26, 4, 638, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 25, 9, 26, 4, 638, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "KorisniciDostignuca",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 25, 9, 26, 4, 639, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 9, 26, 4, 638, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 9, 26, 4, 638, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4046), new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4055), new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4178), new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4180), new DateTime(2025, 2, 27, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4195), new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4197), new DateTime(2025, 2, 25, 11, 26, 4, 640, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4204), new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4206), new DateTime(2025, 2, 25, 14, 26, 4, 640, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4101), new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4109), new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4115), new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4121), new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4122) });
        }
    }
}

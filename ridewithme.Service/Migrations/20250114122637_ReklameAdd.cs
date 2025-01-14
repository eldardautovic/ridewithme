using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class ReklameAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reklame",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivKlijenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NazivKampanje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SadrzajKampanje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slika = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    KorisnikId = table.Column<int>(type: "int", nullable: false),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reklame", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reklame_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Reklame_KorisnikId",
                table: "Reklame",
                column: "KorisnikId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reklame");

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
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(4116), new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(4127), new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(4131) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(4135), new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(4142), new DateTime(2025, 1, 13, 13, 19, 59, 975, DateTimeKind.Local).AddTicks(4145) });
        }
    }
}

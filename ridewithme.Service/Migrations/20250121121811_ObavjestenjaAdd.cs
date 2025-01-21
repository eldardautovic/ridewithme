using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class ObavjestenjaAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Obavjestenja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateMachine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Naslov = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Podnaslov = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumZavrsetka = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KorisnikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obavjestenja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Obavjestenja_Korisnici_KorisnikId",
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
                value: new DateTime(2025, 1, 21, 13, 18, 10, 430, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 21, 13, 18, 10, 430, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 21, 13, 18, 10, 431, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 21, 13, 18, 10, 431, DateTimeKind.Local).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 21, 13, 18, 10, 432, DateTimeKind.Local).AddTicks(2788), new DateTime(2025, 1, 21, 13, 18, 10, 432, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 21, 13, 18, 10, 432, DateTimeKind.Local).AddTicks(2797), new DateTime(2025, 1, 21, 13, 18, 10, 432, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 21, 13, 18, 10, 432, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 21, 13, 18, 10, 432, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 21, 13, 18, 10, 432, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 21, 13, 18, 10, 432, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 21, 13, 18, 10, 432, DateTimeKind.Local).AddTicks(2851), new DateTime(2025, 1, 21, 13, 18, 10, 432, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 21, 13, 18, 10, 432, DateTimeKind.Local).AddTicks(2860), new DateTime(2025, 1, 21, 13, 18, 10, 432, DateTimeKind.Local).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 21, 13, 18, 10, 432, DateTimeKind.Local).AddTicks(2867), new DateTime(2025, 1, 21, 13, 18, 10, 432, DateTimeKind.Local).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 21, 13, 18, 10, 432, DateTimeKind.Local).AddTicks(2873), new DateTime(2025, 1, 21, 13, 18, 10, 432, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.CreateIndex(
                name: "IX_Obavjestenja_KorisnikId",
                table: "Obavjestenja",
                column: "KorisnikId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Obavjestenja");

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 20, 9, 46, 54, 817, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 20, 9, 46, 54, 817, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 20, 9, 46, 54, 818, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 20, 9, 46, 54, 818, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 20, 9, 46, 54, 822, DateTimeKind.Local).AddTicks(4111), new DateTime(2025, 1, 20, 9, 46, 54, 822, DateTimeKind.Local).AddTicks(4125) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 20, 9, 46, 54, 822, DateTimeKind.Local).AddTicks(4140), new DateTime(2025, 1, 20, 9, 46, 54, 822, DateTimeKind.Local).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 20, 9, 46, 54, 822, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 20, 9, 46, 54, 822, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 20, 9, 46, 54, 822, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 20, 9, 46, 54, 822, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 20, 9, 46, 54, 822, DateTimeKind.Local).AddTicks(6124), new DateTime(2025, 1, 20, 9, 46, 54, 822, DateTimeKind.Local).AddTicks(6156) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 20, 9, 46, 54, 822, DateTimeKind.Local).AddTicks(6178), new DateTime(2025, 1, 20, 9, 46, 54, 822, DateTimeKind.Local).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 20, 9, 46, 54, 822, DateTimeKind.Local).AddTicks(6198), new DateTime(2025, 1, 20, 9, 46, 54, 822, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 20, 9, 46, 54, 822, DateTimeKind.Local).AddTicks(6218), new DateTime(2025, 1, 20, 9, 46, 54, 822, DateTimeKind.Local).AddTicks(6226) });
        }
    }
}

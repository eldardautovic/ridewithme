using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class DogadjajiModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dogadjaji",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumPocetka = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumZavrsetka = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogadjaji", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 20, 9, 14, 55, 764, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 20, 9, 14, 55, 764, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 20, 9, 14, 55, 765, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 20, 9, 14, 55, 765, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 20, 9, 14, 55, 767, DateTimeKind.Local).AddTicks(6739), new DateTime(2025, 1, 20, 9, 14, 55, 767, DateTimeKind.Local).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 20, 9, 14, 55, 767, DateTimeKind.Local).AddTicks(6751), new DateTime(2025, 1, 20, 9, 14, 55, 767, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 20, 9, 14, 55, 767, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 20, 9, 14, 55, 767, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 20, 9, 14, 55, 767, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 20, 9, 14, 55, 767, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 20, 9, 14, 55, 767, DateTimeKind.Local).AddTicks(6820), new DateTime(2025, 1, 20, 9, 14, 55, 767, DateTimeKind.Local).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 20, 9, 14, 55, 767, DateTimeKind.Local).AddTicks(6832), new DateTime(2025, 1, 20, 9, 14, 55, 767, DateTimeKind.Local).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 20, 9, 14, 55, 767, DateTimeKind.Local).AddTicks(6841), new DateTime(2025, 1, 20, 9, 14, 55, 767, DateTimeKind.Local).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 20, 9, 14, 55, 767, DateTimeKind.Local).AddTicks(6849), new DateTime(2025, 1, 20, 9, 14, 55, 767, DateTimeKind.Local).AddTicks(6851) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dogadjaji");

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 14, 13, 55, 29, 423, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 14, 13, 55, 29, 423, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 14, 13, 55, 29, 424, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 14, 13, 55, 29, 424, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(6941), new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(6951) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(6962), new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(7037), new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(7051), new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(7060), new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(7064) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(7070), new DateTime(2025, 1, 14, 13, 55, 29, 426, DateTimeKind.Local).AddTicks(7074) });
        }
    }
}

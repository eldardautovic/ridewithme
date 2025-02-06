using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class DostignucaAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dostignuca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slika = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dostignuca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KorisniciDostignuca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikId = table.Column<int>(type: "int", nullable: false),
                    DostignuceId = table.Column<int>(type: "int", nullable: false),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisniciDostignuca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KorisniciDostignuca_Dostignuca",
                        column: x => x.DostignuceId,
                        principalTable: "Dostignuca",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KorisniciDostignuca_Korisnici",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 6, 14, 30, 30, 512, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 6, 14, 30, 30, 512, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 6, 14, 30, 30, 512, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 6, 14, 30, 30, 512, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 6, 14, 30, 30, 514, DateTimeKind.Local).AddTicks(1802), new DateTime(2025, 2, 6, 14, 30, 30, 514, DateTimeKind.Local).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 6, 14, 30, 30, 514, DateTimeKind.Local).AddTicks(1811), new DateTime(2025, 2, 6, 14, 30, 30, 514, DateTimeKind.Local).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 6, 14, 30, 30, 514, DateTimeKind.Local).AddTicks(1934), new DateTime(2025, 2, 6, 14, 30, 30, 514, DateTimeKind.Local).AddTicks(1937), new DateTime(2025, 2, 8, 14, 30, 30, 514, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 6, 14, 30, 30, 514, DateTimeKind.Local).AddTicks(1950), new DateTime(2025, 2, 6, 14, 30, 30, 514, DateTimeKind.Local).AddTicks(1953), new DateTime(2025, 2, 6, 16, 30, 30, 514, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 6, 14, 30, 30, 514, DateTimeKind.Local).AddTicks(1960), new DateTime(2025, 2, 6, 14, 30, 30, 514, DateTimeKind.Local).AddTicks(1963), new DateTime(2025, 2, 6, 19, 30, 30, 514, DateTimeKind.Local).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 6, 14, 30, 30, 514, DateTimeKind.Local).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 6, 14, 30, 30, 514, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 6, 14, 30, 30, 514, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 6, 14, 30, 30, 514, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 6, 14, 30, 30, 514, DateTimeKind.Local).AddTicks(1857), new DateTime(2025, 2, 6, 14, 30, 30, 514, DateTimeKind.Local).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 6, 14, 30, 30, 514, DateTimeKind.Local).AddTicks(1869), new DateTime(2025, 2, 6, 14, 30, 30, 514, DateTimeKind.Local).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 6, 14, 30, 30, 514, DateTimeKind.Local).AddTicks(1876), new DateTime(2025, 2, 6, 14, 30, 30, 514, DateTimeKind.Local).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 6, 14, 30, 30, 514, DateTimeKind.Local).AddTicks(1883), new DateTime(2025, 2, 6, 14, 30, 30, 514, DateTimeKind.Local).AddTicks(1885) });

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciDostignuca_DostignuceId",
                table: "KorisniciDostignuca",
                column: "DostignuceId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciDostignuca_KorisnikId",
                table: "KorisniciDostignuca",
                column: "KorisnikId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KorisniciDostignuca");

            migrationBuilder.DropTable(
                name: "Dostignuca");

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 5, 13, 31, 3, 477, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 5, 13, 31, 3, 477, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 5, 13, 31, 3, 478, DateTimeKind.Local).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 5, 13, 31, 3, 478, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 5, 13, 31, 3, 479, DateTimeKind.Local).AddTicks(4826), new DateTime(2025, 2, 5, 13, 31, 3, 479, DateTimeKind.Local).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 5, 13, 31, 3, 479, DateTimeKind.Local).AddTicks(4836), new DateTime(2025, 2, 5, 13, 31, 3, 479, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 5, 13, 31, 3, 479, DateTimeKind.Local).AddTicks(4956), new DateTime(2025, 2, 5, 13, 31, 3, 479, DateTimeKind.Local).AddTicks(4959), new DateTime(2025, 2, 7, 13, 31, 3, 479, DateTimeKind.Local).AddTicks(4961) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 5, 13, 31, 3, 479, DateTimeKind.Local).AddTicks(4970), new DateTime(2025, 2, 5, 13, 31, 3, 479, DateTimeKind.Local).AddTicks(4972), new DateTime(2025, 2, 5, 15, 31, 3, 479, DateTimeKind.Local).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 5, 13, 31, 3, 479, DateTimeKind.Local).AddTicks(4980), new DateTime(2025, 2, 5, 13, 31, 3, 479, DateTimeKind.Local).AddTicks(4982), new DateTime(2025, 2, 5, 18, 31, 3, 479, DateTimeKind.Local).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 5, 13, 31, 3, 479, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 5, 13, 31, 3, 479, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 5, 13, 31, 3, 479, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 5, 13, 31, 3, 479, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 5, 13, 31, 3, 479, DateTimeKind.Local).AddTicks(4883), new DateTime(2025, 2, 5, 13, 31, 3, 479, DateTimeKind.Local).AddTicks(4886) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 5, 13, 31, 3, 479, DateTimeKind.Local).AddTicks(4892), new DateTime(2025, 2, 5, 13, 31, 3, 479, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 5, 13, 31, 3, 479, DateTimeKind.Local).AddTicks(4899), new DateTime(2025, 2, 5, 13, 31, 3, 479, DateTimeKind.Local).AddTicks(4902) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 5, 13, 31, 3, 479, DateTimeKind.Local).AddTicks(4906), new DateTime(2025, 2, 5, 13, 31, 3, 479, DateTimeKind.Local).AddTicks(4908) });
        }
    }
}

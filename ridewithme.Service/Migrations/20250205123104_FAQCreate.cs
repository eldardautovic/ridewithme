using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class FAQCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FAQs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pitanje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Odgovor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KorisnikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FAQs_Korisnici_KorisnikId",
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

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_KorisnikId",
                table: "FAQs",
                column: "KorisnikId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FAQs");

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 28, 11, 22, 14, 630, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 28, 11, 22, 14, 630, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 28, 11, 22, 14, 630, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 28, 11, 22, 14, 630, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9895), new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9905), new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 22, 14, 632, DateTimeKind.Local).AddTicks(9), new DateTime(2025, 1, 28, 11, 22, 14, 632, DateTimeKind.Local).AddTicks(13), new DateTime(2025, 1, 30, 11, 22, 14, 632, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 22, 14, 632, DateTimeKind.Local).AddTicks(25), new DateTime(2025, 1, 28, 11, 22, 14, 632, DateTimeKind.Local).AddTicks(27), new DateTime(2025, 1, 28, 13, 22, 14, 632, DateTimeKind.Local).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 22, 14, 632, DateTimeKind.Local).AddTicks(33), new DateTime(2025, 1, 28, 11, 22, 14, 632, DateTimeKind.Local).AddTicks(35), new DateTime(2025, 1, 28, 16, 22, 14, 632, DateTimeKind.Local).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9947), new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9956), new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9962), new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9967), new DateTime(2025, 1, 28, 11, 22, 14, 631, DateTimeKind.Local).AddTicks(9970) });
        }
    }
}

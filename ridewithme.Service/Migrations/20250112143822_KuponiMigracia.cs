using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class KuponiMigracia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KuponId",
                table: "Voznje",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Kuponi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumPocetka = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BrojIskoristivosti = table.Column<int>(type: "int", nullable: false),
                    StateMachine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Popust = table.Column<double>(type: "float", nullable: false),
                    KorisnikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kuponi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kuponi_Korisnici_KorisnikId",
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
                value: new DateTime(2025, 1, 12, 15, 38, 21, 726, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 12, 15, 38, 21, 727, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.CreateIndex(
                name: "IX_Voznje_KuponId",
                table: "Voznje",
                column: "KuponId");

            migrationBuilder.CreateIndex(
                name: "IX_Kuponi_KorisnikId",
                table: "Kuponi",
                column: "KorisnikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Voznje_Kuponi_KuponId",
                table: "Voznje",
                column: "KuponId",
                principalTable: "Kuponi",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voznje_Kuponi_KuponId",
                table: "Voznje");

            migrationBuilder.DropTable(
                name: "Kuponi");

            migrationBuilder.DropIndex(
                name: "IX_Voznje_KuponId",
                table: "Voznje");

            migrationBuilder.DropColumn(
                name: "KuponId",
                table: "Voznje");

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 12, 15, 3, 24, 427, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 12, 15, 3, 24, 427, DateTimeKind.Local).AddTicks(8091));
        }
    }
}

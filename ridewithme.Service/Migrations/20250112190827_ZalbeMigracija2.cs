using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class ZalbeMigracija2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VrstaZalbe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KorisnikId = table.Column<int>(type: "int", nullable: false),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaZalbe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VrstaZalbe_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zalbe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naslov = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sadrzaj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumPreuzimanja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StateMachine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VrstaZalbeId = table.Column<int>(type: "int", nullable: false),
                    AdministratorId = table.Column<int>(type: "int", nullable: true),
                    KorisnikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zalbe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zalbe_Korisnici_AdministratorId",
                        column: x => x.AdministratorId,
                        principalTable: "Korisnici",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Zalbe_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Zalbe_VrstaZalbe_VrstaZalbeId",
                        column: x => x.VrstaZalbeId,
                        principalTable: "VrstaZalbe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 12, 20, 8, 27, 325, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 12, 20, 8, 27, 326, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.CreateIndex(
                name: "IX_VrstaZalbe_KorisnikId",
                table: "VrstaZalbe",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Zalbe_AdministratorId",
                table: "Zalbe",
                column: "AdministratorId");

            migrationBuilder.CreateIndex(
                name: "IX_Zalbe_KorisnikId",
                table: "Zalbe",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Zalbe_VrstaZalbeId",
                table: "Zalbe",
                column: "VrstaZalbeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zalbe");

            migrationBuilder.DropTable(
                name: "VrstaZalbe");

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 12, 20, 6, 58, 752, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 12, 20, 6, 58, 752, DateTimeKind.Local).AddTicks(9536));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class DataSync : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gradovi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradovi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Prezime = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    KorisnickoIme = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(320)", unicode: false, maxLength: 320, nullable: false),
                    LozinkaHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LozinkaSalt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Voznje",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateMachine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumVrijemePocetka = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DatumVrijemeZavrsetka = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Napomena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ocjena = table.Column<int>(type: "int", nullable: true),
                    Cijena = table.Column<double>(type: "float", nullable: false),
                    GradOdId = table.Column<int>(type: "int", nullable: false),
                    GradDoId = table.Column<int>(type: "int", nullable: false),
                    VozacId = table.Column<int>(type: "int", nullable: false),
                    KlijentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voznje", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Voznje_Gradovi_GradDoId",
                        column: x => x.GradDoId,
                        principalTable: "Gradovi",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Voznje_Gradovi_GradOdId",
                        column: x => x.GradOdId,
                        principalTable: "Gradovi",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Voznje_Korisnici_KlijentId",
                        column: x => x.KlijentId,
                        principalTable: "Korisnici",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Voznje_Korisnici_VozacId",
                        column: x => x.VozacId,
                        principalTable: "Korisnici",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KorisniciUloge",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikId = table.Column<int>(type: "int", nullable: false),
                    UlogaId = table.Column<int>(type: "int", nullable: false),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisniciUloge", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Korisnici",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Uloge",
                        column: x => x.UlogaId,
                        principalTable: "Uloge",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Gradovi",
                columns: new[] { "Id", "Latitude", "Longitude", "Naziv" },
                values: new object[,]
                {
                    { 1, 44.226100000000002, 17.665800000000001, "Travnik" },
                    { 2, 43.848599999999998, 18.356400000000001, "Sarajevo" },
                    { 3, 44.537300000000002, 18.676600000000001, "Tuzla" },
                    { 4, 43.343800000000002, 17.8078, "Mostar" },
                    { 5, 44.773499999999999, 17.1937, "Banja Luka" },
                    { 6, 44.206400000000002, 17.6708, "Bugojno" },
                    { 7, 44.117800000000003, 17.6111, "Jajce" },
                    { 8, 43.612499999999997, 18.9725, "Foča" },
                    { 9, 44.440600000000003, 17.221800000000002, "Prijedor" },
                    { 10, 44.981099999999998, 15.7471, "Bihać" },
                    { 11, 44.160800000000002, 19.1021, "Zvornik" },
                    { 12, 43.200899999999997, 17.684699999999999, "Široki Brijeg" },
                    { 13, 44.360799999999998, 18.805299999999999, "Lukavac" },
                    { 14, 44.541200000000003, 17.365400000000001, "Gradiška" },
                    { 15, 43.337800000000001, 17.8139, "Stolac" },
                    { 16, 44.4664, 19.1736, "Bijeljina" },
                    { 17, 43.828400000000002, 17.404299999999999, "Livno" },
                    { 18, 43.769799999999996, 18.0578, "Konjic" },
                    { 19, 44.124899999999997, 18.123200000000001, "Visoko" },
                    { 20, 44.775199999999998, 17.192399999999999, "Doboj" }
                });

            migrationBuilder.InsertData(
                table: "Korisnici",
                columns: new[] { "Id", "DatumKreiranja", "Email", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime" },
                values: new object[] { 1, new DateTime(2025, 1, 12, 15, 3, 24, 427, DateTimeKind.Local).AddTicks(5531), "test@gmail.com", "Test", "test", "KaiUaS4zfaZiZnbuv7TN0r5OfeM=", "AglQFeC8HyIM/UV2yFOa0w==", "Korisnik" });

            migrationBuilder.InsertData(
                table: "Uloge",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 1, "Korisnik" },
                    { 2, "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "KorisniciUloge",
                columns: new[] { "Id", "DatumIzmjene", "KorisnikId", "UlogaId" },
                values: new object[] { 1, new DateTime(2025, 1, 12, 15, 3, 24, 427, DateTimeKind.Local).AddTicks(8091), 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_KorisnikId",
                table: "KorisniciUloge",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_UlogaId",
                table: "KorisniciUloge",
                column: "UlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_Voznje_GradDoId",
                table: "Voznje",
                column: "GradDoId");

            migrationBuilder.CreateIndex(
                name: "IX_Voznje_GradOdId",
                table: "Voznje",
                column: "GradOdId");

            migrationBuilder.CreateIndex(
                name: "IX_Voznje_KlijentId",
                table: "Voznje",
                column: "KlijentId");

            migrationBuilder.CreateIndex(
                name: "IX_Voznje_VozacId",
                table: "Voznje",
                column: "VozacId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KorisniciUloge");

            migrationBuilder.DropTable(
                name: "Voznje");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "Gradovi");

            migrationBuilder.DropTable(
                name: "Korisnici");
        }
    }
}

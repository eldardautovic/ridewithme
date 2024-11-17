using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class KorisniciUlogeAdd2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KorisniciUloges_Korisnici_KorisnikId",
                table: "KorisniciUloges");

            migrationBuilder.DropForeignKey(
                name: "FK_Voznje_Korisnici_KorisniciId",
                table: "Voznje");

            migrationBuilder.DropIndex(
                name: "IX_Voznje_KorisniciId",
                table: "Voznje");

            migrationBuilder.DropIndex(
                name: "IX_KorisniciUloges_KorisnikId",
                table: "KorisniciUloges");

            migrationBuilder.DropColumn(
                name: "KorisniciId",
                table: "Voznje");

            migrationBuilder.AddColumn<int>(
                name: "KorisniciId",
                table: "KorisniciUloges",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloges_KorisniciId",
                table: "KorisniciUloges",
                column: "KorisniciId");

            migrationBuilder.AddForeignKey(
                name: "FK_KorisniciUloges_Korisnici_KorisniciId",
                table: "KorisniciUloges",
                column: "KorisniciId",
                principalTable: "Korisnici",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KorisniciUloges_Korisnici_KorisniciId",
                table: "KorisniciUloges");

            migrationBuilder.DropIndex(
                name: "IX_KorisniciUloges_KorisniciId",
                table: "KorisniciUloges");

            migrationBuilder.DropColumn(
                name: "KorisniciId",
                table: "KorisniciUloges");

            migrationBuilder.AddColumn<int>(
                name: "KorisniciId",
                table: "Voznje",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Voznje_KorisniciId",
                table: "Voznje",
                column: "KorisniciId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloges_KorisnikId",
                table: "KorisniciUloges",
                column: "KorisnikId");

            migrationBuilder.AddForeignKey(
                name: "FK_KorisniciUloges_Korisnici_KorisnikId",
                table: "KorisniciUloges",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Voznje_Korisnici_KorisniciId",
                table: "Voznje",
                column: "KorisniciId",
                principalTable: "Korisnici",
                principalColumn: "Id");
        }
    }
}

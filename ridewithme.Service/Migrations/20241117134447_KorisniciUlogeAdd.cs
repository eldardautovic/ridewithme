using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class KorisniciUlogeAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korisnici_Uloge",
                table: "Korisnici");

            migrationBuilder.DropIndex(
                name: "IX_Korisnici_UlogaId",
                table: "Korisnici");

            migrationBuilder.AddColumn<int>(
                name: "KorisniciId",
                table: "Voznje",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UlogeId",
                table: "Korisnici",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Voznje_KorisniciId",
                table: "Voznje",
                column: "KorisniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnici_UlogeId",
                table: "Korisnici",
                column: "UlogeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Korisnici_Uloge_UlogeId",
                table: "Korisnici",
                column: "UlogeId",
                principalTable: "Uloge",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Voznje_Korisnici_KorisniciId",
                table: "Voznje",
                column: "KorisniciId",
                principalTable: "Korisnici",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korisnici_Uloge_UlogeId",
                table: "Korisnici");

            migrationBuilder.DropForeignKey(
                name: "FK_Voznje_Korisnici_KorisniciId",
                table: "Voznje");

            migrationBuilder.DropIndex(
                name: "IX_Voznje_KorisniciId",
                table: "Voznje");

            migrationBuilder.DropIndex(
                name: "IX_Korisnici_UlogeId",
                table: "Korisnici");

            migrationBuilder.DropColumn(
                name: "KorisniciId",
                table: "Voznje");

            migrationBuilder.DropColumn(
                name: "UlogeId",
                table: "Korisnici");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnici_UlogaId",
                table: "Korisnici",
                column: "UlogaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Korisnici_Uloge",
                table: "Korisnici",
                column: "UlogaId",
                principalTable: "Uloge",
                principalColumn: "Id");
        }
    }
}

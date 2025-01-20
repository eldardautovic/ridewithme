using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class DogadjajiVoznjeForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DogadjajId",
                table: "Voznje",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Voznje_DogadjajId",
                table: "Voznje",
                column: "DogadjajId");

            migrationBuilder.AddForeignKey(
                name: "FK_Voznje_Dogadjaji_DogadjajId",
                table: "Voznje",
                column: "DogadjajId",
                principalTable: "Dogadjaji",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voznje_Dogadjaji_DogadjajId",
                table: "Voznje");

            migrationBuilder.DropIndex(
                name: "IX_Voznje_DogadjajId",
                table: "Voznje");

            migrationBuilder.DropColumn(
                name: "DogadjajId",
                table: "Voznje");

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
    }
}

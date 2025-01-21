using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class ObavjestenjaAddSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 21, 14, 17, 2, 261, DateTimeKind.Local).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2025, 1, 21, 14, 17, 2, 261, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 21, 14, 17, 2, 261, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 21, 14, 17, 2, 261, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 21, 14, 17, 2, 263, DateTimeKind.Local).AddTicks(3758), new DateTime(2025, 1, 21, 14, 17, 2, 263, DateTimeKind.Local).AddTicks(3762) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 1, 21, 14, 17, 2, 263, DateTimeKind.Local).AddTicks(3767), new DateTime(2025, 1, 21, 14, 17, 2, 263, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.InsertData(
                table: "Obavjestenja",
                columns: new[] { "Id", "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka", "KorisnikId", "Naslov", "Opis", "Podnaslov", "StateMachine" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 21, 14, 17, 2, 263, DateTimeKind.Local).AddTicks(3898), new DateTime(2025, 1, 21, 14, 17, 2, 263, DateTimeKind.Local).AddTicks(3900), new DateTime(2025, 1, 23, 14, 17, 2, 263, DateTimeKind.Local).AddTicks(3903), 2, "Ažuriranje pravila privatnosti", "Ažurirali smo naša pravila privatnosti kako bi ti pružili veću transparentnost i kontrolu nad tvojim podacima. Pregledaj nove postavke privatnosti u aplikaciji i prilagodi ih svojim potrebama.", "Više kontrole nad tvojim podacima", "active" },
                    { 2, new DateTime(2025, 1, 21, 14, 17, 2, 263, DateTimeKind.Local).AddTicks(3913), new DateTime(2025, 1, 21, 14, 17, 2, 263, DateTimeKind.Local).AddTicks(3915), new DateTime(2025, 1, 21, 16, 17, 2, 263, DateTimeKind.Local).AddTicks(3918), 2, "Stigli su novi alati za bolje iskustvo!", "RideWithMe je bogatiji za nove funkcionalnosti! Sada možeš lakše planirati putovanja, pratiti svoje vožnje i komunicirati s vozačima direktno iz aplikacije. Ažuriraj aplikaciju i isprobaj nove mogućnosti!", "Otkrij nove funkcije aplikacije", "active" },
                    { 3, new DateTime(2025, 1, 21, 14, 17, 2, 263, DateTimeKind.Local).AddTicks(3923), new DateTime(2025, 1, 21, 14, 17, 2, 263, DateTimeKind.Local).AddTicks(3925), new DateTime(2025, 1, 21, 19, 17, 2, 263, DateTimeKind.Local).AddTicks(3927), 2, "Poboljšana korisnička podrška", "Uveli smo nove opcije podrške u aplikaciji, uključujući chat uživo i detaljniji centar za pomoć. Kontaktiraj nas jednostavno putem aplikacije za bilo kakva pitanja ili sugestije!", "Brže rješenje tvojih upita", "active" }
                });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 21, 14, 17, 2, 263, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 21, 14, 17, 2, 263, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 21, 14, 17, 2, 263, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 1, 21, 14, 17, 2, 263, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 21, 14, 17, 2, 263, DateTimeKind.Local).AddTicks(3825), new DateTime(2025, 1, 21, 14, 17, 2, 263, DateTimeKind.Local).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 21, 14, 17, 2, 263, DateTimeKind.Local).AddTicks(3837), new DateTime(2025, 1, 21, 14, 17, 2, 263, DateTimeKind.Local).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 21, 14, 17, 2, 263, DateTimeKind.Local).AddTicks(3844), new DateTime(2025, 1, 21, 14, 17, 2, 263, DateTimeKind.Local).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 1, 21, 14, 17, 2, 263, DateTimeKind.Local).AddTicks(3850), new DateTime(2025, 1, 21, 14, 17, 2, 263, DateTimeKind.Local).AddTicks(3853) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 3);

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
        }
    }
}

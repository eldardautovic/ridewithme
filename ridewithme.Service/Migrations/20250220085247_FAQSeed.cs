using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class FAQSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FAQs",
                columns: new[] { "Id", "DatumIzmjene", "DatumKreiranja", "KorisnikId", "Odgovor", "Pitanje" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 20, 9, 52, 46, 304, DateTimeKind.Local).AddTicks(8417), new DateTime(2025, 2, 20, 9, 52, 46, 304, DateTimeKind.Local).AddTicks(8420), 1, "Lozinku možete promijeniti u postavkama profila pod opcijom 'Uredi profil'.", "Kako mogu promijeniti svoju lozinku?" },
                    { 3, new DateTime(2025, 2, 20, 9, 52, 46, 304, DateTimeKind.Local).AddTicks(8427), new DateTime(2025, 2, 20, 9, 52, 46, 304, DateTimeKind.Local).AddTicks(8430), 1, "Nakon završene vožnje, možete ostaviti ocjenu i komentar u sekciji 'Vožnje u kojima ste (bili) putnici'.", "Kako mogu ocijeniti vozača ili saputnika?" },
                    { 4, new DateTime(2025, 2, 20, 9, 52, 46, 304, DateTimeKind.Local).AddTicks(8434), new DateTime(2025, 2, 20, 9, 52, 46, 304, DateTimeKind.Local).AddTicks(8437), 1, "Kliknite na (+) ikonicu, 'Dodaj vožnju', unesite detalje i objavite vožnju.", "Kako mogu dodati novu vožnju?" },
                    { 5, new DateTime(2025, 2, 20, 9, 52, 46, 304, DateTimeKind.Local).AddTicks(8441), new DateTime(2025, 2, 20, 9, 52, 46, 304, DateTimeKind.Local).AddTicks(8443), 1, "Da, možete poslati poruku vozaču putem chat opcije na platformi.", "Da li mogu kontaktirati vozača prije vožnje?" },
                    { 6, new DateTime(2025, 2, 20, 9, 52, 46, 304, DateTimeKind.Local).AddTicks(8447), new DateTime(2025, 2, 20, 9, 52, 46, 304, DateTimeKind.Local).AddTicks(8449), 1, "Možete prijaviti problem putem opcije 'Žalbe' u sekciji profila .", "Šta ako vozač ne dođe na dogovorenu lokaciju?" }
                });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 20, 9, 52, 46, 303, DateTimeKind.Local).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 20, 9, 52, 46, 303, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "KorisniciDostignuca",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 20, 9, 52, 46, 304, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 20, 9, 52, 46, 304, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 20, 9, 52, 46, 304, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 20, 9, 52, 46, 306, DateTimeKind.Local).AddTicks(2276), new DateTime(2025, 2, 20, 9, 52, 46, 306, DateTimeKind.Local).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 20, 9, 52, 46, 306, DateTimeKind.Local).AddTicks(2286), new DateTime(2025, 2, 20, 9, 52, 46, 306, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 20, 9, 52, 46, 306, DateTimeKind.Local).AddTicks(2421), new DateTime(2025, 2, 20, 9, 52, 46, 306, DateTimeKind.Local).AddTicks(2425), new DateTime(2025, 2, 22, 9, 52, 46, 306, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 20, 9, 52, 46, 306, DateTimeKind.Local).AddTicks(2441), new DateTime(2025, 2, 20, 9, 52, 46, 306, DateTimeKind.Local).AddTicks(2443), new DateTime(2025, 2, 20, 11, 52, 46, 306, DateTimeKind.Local).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 20, 9, 52, 46, 306, DateTimeKind.Local).AddTicks(2451), new DateTime(2025, 2, 20, 9, 52, 46, 306, DateTimeKind.Local).AddTicks(2454), new DateTime(2025, 2, 20, 14, 52, 46, 306, DateTimeKind.Local).AddTicks(2457) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 20, 9, 52, 46, 306, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 20, 9, 52, 46, 306, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 20, 9, 52, 46, 306, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 20, 9, 52, 46, 306, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 20, 9, 52, 46, 306, DateTimeKind.Local).AddTicks(2338), new DateTime(2025, 2, 20, 9, 52, 46, 306, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 20, 9, 52, 46, 306, DateTimeKind.Local).AddTicks(2348), new DateTime(2025, 2, 20, 9, 52, 46, 306, DateTimeKind.Local).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 20, 9, 52, 46, 306, DateTimeKind.Local).AddTicks(2356), new DateTime(2025, 2, 20, 9, 52, 46, 306, DateTimeKind.Local).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 20, 9, 52, 46, 306, DateTimeKind.Local).AddTicks(2363), new DateTime(2025, 2, 20, 9, 52, 46, 306, DateTimeKind.Local).AddTicks(2366) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 18, 11, 20, 43, 789, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 18, 11, 20, 43, 789, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "KorisniciDostignuca",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 18, 11, 20, 43, 790, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 18, 11, 20, 43, 789, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 18, 11, 20, 43, 789, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(284), new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(287) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(294), new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(448), new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(451), new DateTime(2025, 2, 20, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(465), new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(468), new DateTime(2025, 2, 18, 13, 20, 43, 792, DateTimeKind.Local).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(475), new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(478), new DateTime(2025, 2, 18, 16, 20, 43, 792, DateTimeKind.Local).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(350), new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(360), new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(367), new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(375), new DateTime(2025, 2, 18, 11, 20, 43, 792, DateTimeKind.Local).AddTicks(377) });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class SeedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dostignuca",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dostignuca",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Dostignuca",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Dostignuca",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Dostignuca",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "Dostignuca",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Naziv", "Opis" },
                values: new object[] { "Pustolov na putu", "Vozio si se u 10 različitih gradova! Avantura te zove!" });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 639, DateTimeKind.Local).AddTicks(1745), new DateTime(2025, 2, 25, 9, 26, 4, 639, DateTimeKind.Local).AddTicks(1749) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 639, DateTimeKind.Local).AddTicks(1755), new DateTime(2025, 2, 25, 9, 26, 4, 639, DateTimeKind.Local).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 639, DateTimeKind.Local).AddTicks(1760), new DateTime(2025, 2, 25, 9, 26, 4, 639, DateTimeKind.Local).AddTicks(1762) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 639, DateTimeKind.Local).AddTicks(1766), new DateTime(2025, 2, 25, 9, 26, 4, 639, DateTimeKind.Local).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 639, DateTimeKind.Local).AddTicks(1771), new DateTime(2025, 2, 25, 9, 26, 4, 639, DateTimeKind.Local).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 25, 9, 26, 4, 638, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 25, 9, 26, 4, 638, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "KorisniciDostignuca",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 25, 9, 26, 4, 639, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 9, 26, 4, 638, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 9, 26, 4, 638, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4046), new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4055), new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4178), new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4180), new DateTime(2025, 2, 27, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4195), new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4197), new DateTime(2025, 2, 25, 11, 26, 4, 640, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4204), new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4206), new DateTime(2025, 2, 25, 14, 26, 4, 640, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4101), new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4109), new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4115), new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4121), new DateTime(2025, 2, 25, 9, 26, 4, 640, DateTimeKind.Local).AddTicks(4122) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dostignuca",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Naziv", "Opis" },
                values: new object[] { "Noćna ptica", "Vozio si se najmanje 10 puta između ponoći i 5 ujutro!" });

            migrationBuilder.InsertData(
                table: "Dostignuca",
                columns: new[] { "Id", "Naziv", "Opis" },
                values: new object[,]
                {
                    { 9, "Pustolov na putu", "Vozio si se u 10 različitih gradova! Avantura te zove!" },
                    { 10, "ridewithme beba", "Godinu dana na platformi! Početak sjajne priče!" },
                    { 11, "ridewithme pro", "5 godina vožnji! Pravi si veteran zajednice!" },
                    { 12, "Nestali saputnik", "Otkazao si vožnju u zadnji čas! Sljedeći put dolaziš?" },
                    { 13, "BlaBla influencer", "Tvoj profil je pregledan preko 1000 puta! Ljudi žele putovati s tobom!" }
                });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 20, 9, 52, 46, 304, DateTimeKind.Local).AddTicks(8417), new DateTime(2025, 2, 20, 9, 52, 46, 304, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 20, 9, 52, 46, 304, DateTimeKind.Local).AddTicks(8427), new DateTime(2025, 2, 20, 9, 52, 46, 304, DateTimeKind.Local).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 20, 9, 52, 46, 304, DateTimeKind.Local).AddTicks(8434), new DateTime(2025, 2, 20, 9, 52, 46, 304, DateTimeKind.Local).AddTicks(8437) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 20, 9, 52, 46, 304, DateTimeKind.Local).AddTicks(8441), new DateTime(2025, 2, 20, 9, 52, 46, 304, DateTimeKind.Local).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 20, 9, 52, 46, 304, DateTimeKind.Local).AddTicks(8447), new DateTime(2025, 2, 20, 9, 52, 46, 304, DateTimeKind.Local).AddTicks(8449) });

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
    }
}

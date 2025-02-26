using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ridewithme.Service.Migrations
{
    /// <inheritdoc />
    public partial class DostignucaSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dostignuca",
                columns: new[] { "Id", "Naziv", "Opis" },
                values: new object[,]
                {
                    { 1, "Prva vožnja", "Završio si svoju prvu vožnju! Dobrodošao u zajednicu!" },
                    { 2, "Desetka!", "Odradio si 10 vožnji! Postaješ pravi profesionalac!" },
                    { 3, "Carpool majstor", "50 vožnji! Već si legenda na putu!" },
                    { 4, "Legenda na cesti", "100 vožnji! Tvoj auto sada zna put napamet!" },
                    { 5, "Putni veteran", "500 vožnji! Obišao si pola zemlje!" },
                    { 6, "Putevi su moj dom", "1000 vožnji! Jesi li siguran da ne živiš u autu?" },
                    { 7, "Pet zvjezdica, molim!", "5/5 ocjena! Samo rijetki uspiju ovako!" },
                    { 8, "Pustolov na putu", "Vozio si se u 10 različitih gradova! Avantura te zove!" }
                });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 26, 10, 0, 15, 650, DateTimeKind.Local).AddTicks(5984), new DateTime(2025, 2, 26, 10, 0, 15, 650, DateTimeKind.Local).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 26, 10, 0, 15, 650, DateTimeKind.Local).AddTicks(5992), new DateTime(2025, 2, 26, 10, 0, 15, 650, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 26, 10, 0, 15, 650, DateTimeKind.Local).AddTicks(5998), new DateTime(2025, 2, 26, 10, 0, 15, 650, DateTimeKind.Local).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 26, 10, 0, 15, 650, DateTimeKind.Local).AddTicks(6005), new DateTime(2025, 2, 26, 10, 0, 15, 650, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 26, 10, 0, 15, 650, DateTimeKind.Local).AddTicks(6011), new DateTime(2025, 2, 26, 10, 0, 15, 650, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 26, 10, 0, 15, 649, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 26, 10, 0, 15, 649, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "KorisniciDostignuca",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 26, 10, 0, 15, 650, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 26, 10, 0, 15, 650, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 26, 10, 0, 15, 650, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 26, 10, 0, 15, 652, DateTimeKind.Local).AddTicks(4025), new DateTime(2025, 2, 26, 10, 0, 15, 652, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 26, 10, 0, 15, 652, DateTimeKind.Local).AddTicks(4036), new DateTime(2025, 2, 26, 10, 0, 15, 652, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 26, 10, 0, 15, 652, DateTimeKind.Local).AddTicks(4177), new DateTime(2025, 2, 26, 10, 0, 15, 652, DateTimeKind.Local).AddTicks(4183), new DateTime(2025, 2, 28, 10, 0, 15, 652, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 26, 10, 0, 15, 652, DateTimeKind.Local).AddTicks(4198), new DateTime(2025, 2, 26, 10, 0, 15, 652, DateTimeKind.Local).AddTicks(4201), new DateTime(2025, 2, 26, 12, 0, 15, 652, DateTimeKind.Local).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 26, 10, 0, 15, 652, DateTimeKind.Local).AddTicks(4209), new DateTime(2025, 2, 26, 10, 0, 15, 652, DateTimeKind.Local).AddTicks(4211), new DateTime(2025, 2, 26, 15, 0, 15, 652, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 26, 10, 0, 15, 652, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 26, 10, 0, 15, 652, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 26, 10, 0, 15, 652, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 26, 10, 0, 15, 652, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 26, 10, 0, 15, 652, DateTimeKind.Local).AddTicks(4089), new DateTime(2025, 2, 26, 10, 0, 15, 652, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 26, 10, 0, 15, 652, DateTimeKind.Local).AddTicks(4101), new DateTime(2025, 2, 26, 10, 0, 15, 652, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 26, 10, 0, 15, 652, DateTimeKind.Local).AddTicks(4108), new DateTime(2025, 2, 26, 10, 0, 15, 652, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 26, 10, 0, 15, 652, DateTimeKind.Local).AddTicks(4114), new DateTime(2025, 2, 26, 10, 0, 15, 652, DateTimeKind.Local).AddTicks(4116) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dostignuca",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dostignuca",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dostignuca",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dostignuca",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dostignuca",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dostignuca",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dostignuca",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dostignuca",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 185, DateTimeKind.Local).AddTicks(9252), new DateTime(2025, 2, 25, 14, 5, 32, 185, DateTimeKind.Local).AddTicks(9283) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 185, DateTimeKind.Local).AddTicks(9296), new DateTime(2025, 2, 25, 14, 5, 32, 185, DateTimeKind.Local).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 185, DateTimeKind.Local).AddTicks(9331), new DateTime(2025, 2, 25, 14, 5, 32, 185, DateTimeKind.Local).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 185, DateTimeKind.Local).AddTicks(9360), new DateTime(2025, 2, 25, 14, 5, 32, 185, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 185, DateTimeKind.Local).AddTicks(9379), new DateTime(2025, 2, 25, 14, 5, 32, 185, DateTimeKind.Local).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 25, 14, 5, 32, 177, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 25, 14, 5, 32, 177, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "KorisniciDostignuca",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2025, 2, 25, 14, 5, 32, 185, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 14, 5, 32, 180, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 14, 5, 32, 180, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7185), new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Kuponi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7211), new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7655), new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7664), new DateTime(2025, 2, 27, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7693), new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7701), new DateTime(2025, 2, 25, 16, 5, 32, 192, DateTimeKind.Local).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "Obavjestenja",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7722), new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7730), new DateTime(2025, 2, 25, 19, 5, 32, 192, DateTimeKind.Local).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "VrstaZalbe",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzmjene",
                value: new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7343), new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7367), new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7386), new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "Zalbe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumIzmjene", "DatumKreiranja" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7429), new DateTime(2025, 2, 25, 14, 5, 32, 192, DateTimeKind.Local).AddTicks(7527) });
        }
    }
}

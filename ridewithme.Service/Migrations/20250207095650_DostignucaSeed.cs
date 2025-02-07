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
            migrationBuilder.CreateTable(
                name: "Dogadjaji",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumPocetka = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumZavrsetka = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogadjaji", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dostignuca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dostignuca", x => x.Id);
                });

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
                name: "FAQs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pitanje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Odgovor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KorisnikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FAQs_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KorisniciDostignuca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikId = table.Column<int>(type: "int", nullable: false),
                    DostignuceId = table.Column<int>(type: "int", nullable: false),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisniciDostignuca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KorisniciDostignuca_Dostignuca",
                        column: x => x.DostignuceId,
                        principalTable: "Dostignuca",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KorisniciDostignuca_Korisnici",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id");
                });

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
                    KorisnikId = table.Column<int>(type: "int", nullable: false),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Obavjestenja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateMachine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Naslov = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Podnaslov = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumZavrsetka = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KorisnikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obavjestenja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Obavjestenja_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reklame",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivKlijenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NazivKampanje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SadrzajKampanje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slika = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    KorisnikId = table.Column<int>(type: "int", nullable: false),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reklame", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reklame_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    Cijena = table.Column<double>(type: "float", nullable: false),
                    GradOdId = table.Column<int>(type: "int", nullable: false),
                    GradDoId = table.Column<int>(type: "int", nullable: false),
                    VozacId = table.Column<int>(type: "int", nullable: false),
                    KlijentId = table.Column<int>(type: "int", nullable: true),
                    KuponId = table.Column<int>(type: "int", nullable: true),
                    DogadjajId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voznje", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Voznje_Dogadjaji_DogadjajId",
                        column: x => x.DogadjajId,
                        principalTable: "Dogadjaji",
                        principalColumn: "Id");
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
                    table.ForeignKey(
                        name: "FK_Voznje_Kuponi_KuponId",
                        column: x => x.KuponId,
                        principalTable: "Kuponi",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Zalbe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naslov = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sadrzaj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OdgovorNaZalbu = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Recenzije",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikId = table.Column<int>(type: "int", nullable: false),
                    VoznjaId = table.Column<int>(type: "int", nullable: false),
                    Ocjena = table.Column<int>(type: "int", nullable: false),
                    Komentar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzije", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recenzije_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recenzije_Voznje_VoznjaId",
                        column: x => x.VoznjaId,
                        principalTable: "Voznje",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    { 8, "Noćna ptica", "Vozio si se najmanje 10 puta između ponoći i 5 ujutro!" },
                    { 9, "Pustolov na putu", "Vozio si se u 10 različitih gradova! Avantura te zove!" },
                    { 10, "ridewithme beba", "Godinu dana na platformi! Početak sjajne priče!" },
                    { 11, "ridewithme pro", "5 godina vožnji! Pravi si veteran zajednice!" },
                    { 12, "Nestali saputnik", "Otkazao si vožnju u zadnji čas! Sljedeći put dolaziš?" },
                    { 13, "BlaBla influencer", "Tvoj profil je pregledan preko 1000 puta! Ljudi žele putovati s tobom!" }
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
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 7, 10, 56, 49, 452, DateTimeKind.Local).AddTicks(5259), "test@gmail.com", "Test", "test", "KaiUaS4zfaZiZnbuv7TN0r5OfeM=", "AglQFeC8HyIM/UV2yFOa0w==", "Korisnik" },
                    { 2, new DateTime(2025, 2, 7, 10, 56, 49, 452, DateTimeKind.Local).AddTicks(5345), "admin@gmail.com", "Admin", "admin", "KaiUaS4zfaZiZnbuv7TN0r5OfeM=", "AglQFeC8HyIM/UV2yFOa0w==", "Korisnik" }
                });

            migrationBuilder.InsertData(
                table: "Uloge",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 1, "Korisnik" },
                    { 2, "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "KorisniciDostignuca",
                columns: new[] { "Id", "DatumKreiranja", "DostignuceId", "KorisnikId" },
                values: new object[] { 1, new DateTime(2025, 2, 7, 10, 56, 49, 453, DateTimeKind.Local).AddTicks(6272), 1, 1 });

            migrationBuilder.InsertData(
                table: "KorisniciUloge",
                columns: new[] { "Id", "DatumIzmjene", "KorisnikId", "UlogaId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 7, 10, 56, 49, 453, DateTimeKind.Local).AddTicks(1230), 1, 1 },
                    { 2, new DateTime(2025, 2, 7, 10, 56, 49, 453, DateTimeKind.Local).AddTicks(1259), 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Kuponi",
                columns: new[] { "Id", "BrojIskoristivosti", "DatumIzmjene", "DatumPocetka", "Kod", "KorisnikId", "Naziv", "Popust", "StateMachine" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2025, 2, 7, 10, 56, 49, 454, DateTimeKind.Local).AddTicks(9316), new DateTime(2025, 2, 7, 10, 56, 49, 454, DateTimeKind.Local).AddTicks(9321), "TESTNI-KOD", 1, "Testni kod", 0.10000000000000001, "draft" },
                    { 2, 10, new DateTime(2025, 2, 7, 10, 56, 49, 454, DateTimeKind.Local).AddTicks(9327), new DateTime(2025, 2, 7, 10, 56, 49, 454, DateTimeKind.Local).AddTicks(9330), "WELCOME", 1, "Popust dobrodošlice", 0.5, "active" }
                });

            migrationBuilder.InsertData(
                table: "Obavjestenja",
                columns: new[] { "Id", "DatumIzmjene", "DatumKreiranja", "DatumZavrsetka", "KorisnikId", "Naslov", "Opis", "Podnaslov", "StateMachine" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 7, 10, 56, 49, 454, DateTimeKind.Local).AddTicks(9456), new DateTime(2025, 2, 7, 10, 56, 49, 454, DateTimeKind.Local).AddTicks(9460), new DateTime(2025, 2, 9, 10, 56, 49, 454, DateTimeKind.Local).AddTicks(9463), 2, "Ažuriranje pravila privatnosti", "Ažurirali smo naša pravila privatnosti kako bi ti pružili veću transparentnost i kontrolu nad tvojim podacima. Pregledaj nove postavke privatnosti u aplikaciji i prilagodi ih svojim potrebama.", "Više kontrole nad tvojim podacima", "active" },
                    { 2, new DateTime(2025, 2, 7, 10, 56, 49, 454, DateTimeKind.Local).AddTicks(9475), new DateTime(2025, 2, 7, 10, 56, 49, 454, DateTimeKind.Local).AddTicks(9477), new DateTime(2025, 2, 7, 12, 56, 49, 454, DateTimeKind.Local).AddTicks(9480), 2, "Stigli su novi alati za bolje iskustvo!", "RideWithMe je bogatiji za nove funkcionalnosti! Sada možeš lakše planirati putovanja, pratiti svoje vožnje i komunicirati s vozačima direktno iz aplikacije. Ažuriraj aplikaciju i isprobaj nove mogućnosti!", "Otkrij nove funkcije aplikacije", "active" },
                    { 3, new DateTime(2025, 2, 7, 10, 56, 49, 454, DateTimeKind.Local).AddTicks(9485), new DateTime(2025, 2, 7, 10, 56, 49, 454, DateTimeKind.Local).AddTicks(9487), new DateTime(2025, 2, 7, 15, 56, 49, 454, DateTimeKind.Local).AddTicks(9490), 2, "Poboljšana korisnička podrška", "Uveli smo nove opcije podrške u aplikaciji, uključujući chat uživo i detaljniji centar za pomoć. Kontaktiraj nas jednostavno putem aplikacije za bilo kakva pitanja ili sugestije!", "Brže rješenje tvojih upita", "active" }
                });

            migrationBuilder.InsertData(
                table: "VrstaZalbe",
                columns: new[] { "Id", "DatumIzmjene", "KorisnikId", "Naziv" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 7, 10, 56, 49, 454, DateTimeKind.Local).AddTicks(9216), 1, "Na vožnju" },
                    { 2, new DateTime(2025, 2, 7, 10, 56, 49, 454, DateTimeKind.Local).AddTicks(9240), 1, "Na vozača" },
                    { 3, new DateTime(2025, 2, 7, 10, 56, 49, 454, DateTimeKind.Local).AddTicks(9245), 1, "Na aplikaciju" },
                    { 4, new DateTime(2025, 2, 7, 10, 56, 49, 454, DateTimeKind.Local).AddTicks(9249), 1, "Ostalo" }
                });

            migrationBuilder.InsertData(
                table: "Zalbe",
                columns: new[] { "Id", "AdministratorId", "DatumIzmjene", "DatumKreiranja", "DatumPreuzimanja", "KorisnikId", "Naslov", "OdgovorNaZalbu", "Sadrzaj", "StateMachine", "VrstaZalbeId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 2, 7, 10, 56, 49, 454, DateTimeKind.Local).AddTicks(9374), new DateTime(2025, 2, 7, 10, 56, 49, 454, DateTimeKind.Local).AddTicks(9377), null, 1, "Problem prilikom prijave", null, "Prilikom pokušaja prijave na aplikaciju, ne mogu da se prijavim iako unosim ispravne podatke.", "active", 3 },
                    { 2, null, new DateTime(2025, 2, 7, 10, 56, 49, 454, DateTimeKind.Local).AddTicks(9383), new DateTime(2025, 2, 7, 10, 56, 49, 454, DateTimeKind.Local).AddTicks(9386), null, 1, "Vozač ne uzvraća poruke", null, "Potrebno je da dogovorim lokaciju polaska sa vozačem vožnje ID: 2 ali ne mogu da dobijem povratnu informaciju od vozača.", "active", 2 },
                    { 3, null, new DateTime(2025, 2, 7, 10, 56, 49, 454, DateTimeKind.Local).AddTicks(9391), new DateTime(2025, 2, 7, 10, 56, 49, 454, DateTimeKind.Local).AddTicks(9393), null, 1, "Vožnja nije bila do navedene lokacije", null, "Vožnja je naznačena da je do Sarajeva, a vozili smo se do Kaknja, molim za povrat novca.", "active", 1 },
                    { 4, null, new DateTime(2025, 2, 7, 10, 56, 49, 454, DateTimeKind.Local).AddTicks(9398), new DateTime(2025, 2, 7, 10, 56, 49, 454, DateTimeKind.Local).AddTicks(9400), null, 1, "Neiskoristiv kupon", null, "Naznačeno je da koristimo kupon 'WELCOME', ali on ne radi.", "active", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_KorisnikId",
                table: "FAQs",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciDostignuca_DostignuceId",
                table: "KorisniciDostignuca",
                column: "DostignuceId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciDostignuca_KorisnikId",
                table: "KorisniciDostignuca",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_KorisnikId",
                table: "KorisniciUloge",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_UlogaId",
                table: "KorisniciUloge",
                column: "UlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_Kuponi_KorisnikId",
                table: "Kuponi",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Obavjestenja_KorisnikId",
                table: "Obavjestenja",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzije_KorisnikId",
                table: "Recenzije",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzije_VoznjaId",
                table: "Recenzije",
                column: "VoznjaId");

            migrationBuilder.CreateIndex(
                name: "IX_Reklame_KorisnikId",
                table: "Reklame",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Voznje_DogadjajId",
                table: "Voznje",
                column: "DogadjajId");

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
                name: "IX_Voznje_KuponId",
                table: "Voznje",
                column: "KuponId");

            migrationBuilder.CreateIndex(
                name: "IX_Voznje_VozacId",
                table: "Voznje",
                column: "VozacId");

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
                name: "FAQs");

            migrationBuilder.DropTable(
                name: "KorisniciDostignuca");

            migrationBuilder.DropTable(
                name: "KorisniciUloge");

            migrationBuilder.DropTable(
                name: "Obavjestenja");

            migrationBuilder.DropTable(
                name: "Recenzije");

            migrationBuilder.DropTable(
                name: "Reklame");

            migrationBuilder.DropTable(
                name: "Zalbe");

            migrationBuilder.DropTable(
                name: "Dostignuca");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "Voznje");

            migrationBuilder.DropTable(
                name: "VrstaZalbe");

            migrationBuilder.DropTable(
                name: "Dogadjaji");

            migrationBuilder.DropTable(
                name: "Gradovi");

            migrationBuilder.DropTable(
                name: "Kuponi");

            migrationBuilder.DropTable(
                name: "Korisnici");
        }
    }
}

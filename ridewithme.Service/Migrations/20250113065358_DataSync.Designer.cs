﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ridewithme.Service.Database;

#nullable disable

namespace ridewithme.Service.Migrations
{
    [DbContext(typeof(RidewithmeContext))]
    [Migration("20250113065358_DataSync")]
    partial class DataSync
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ridewithme.Service.Database.Gradovi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Gradovi");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Latitude = 44.226100000000002,
                            Longitude = 17.665800000000001,
                            Naziv = "Travnik"
                        },
                        new
                        {
                            Id = 2,
                            Latitude = 43.848599999999998,
                            Longitude = 18.356400000000001,
                            Naziv = "Sarajevo"
                        },
                        new
                        {
                            Id = 3,
                            Latitude = 44.537300000000002,
                            Longitude = 18.676600000000001,
                            Naziv = "Tuzla"
                        },
                        new
                        {
                            Id = 4,
                            Latitude = 43.343800000000002,
                            Longitude = 17.8078,
                            Naziv = "Mostar"
                        },
                        new
                        {
                            Id = 5,
                            Latitude = 44.773499999999999,
                            Longitude = 17.1937,
                            Naziv = "Banja Luka"
                        },
                        new
                        {
                            Id = 6,
                            Latitude = 44.206400000000002,
                            Longitude = 17.6708,
                            Naziv = "Bugojno"
                        },
                        new
                        {
                            Id = 7,
                            Latitude = 44.117800000000003,
                            Longitude = 17.6111,
                            Naziv = "Jajce"
                        },
                        new
                        {
                            Id = 8,
                            Latitude = 43.612499999999997,
                            Longitude = 18.9725,
                            Naziv = "Foča"
                        },
                        new
                        {
                            Id = 9,
                            Latitude = 44.440600000000003,
                            Longitude = 17.221800000000002,
                            Naziv = "Prijedor"
                        },
                        new
                        {
                            Id = 10,
                            Latitude = 44.981099999999998,
                            Longitude = 15.7471,
                            Naziv = "Bihać"
                        },
                        new
                        {
                            Id = 11,
                            Latitude = 44.160800000000002,
                            Longitude = 19.1021,
                            Naziv = "Zvornik"
                        },
                        new
                        {
                            Id = 12,
                            Latitude = 43.200899999999997,
                            Longitude = 17.684699999999999,
                            Naziv = "Široki Brijeg"
                        },
                        new
                        {
                            Id = 13,
                            Latitude = 44.360799999999998,
                            Longitude = 18.805299999999999,
                            Naziv = "Lukavac"
                        },
                        new
                        {
                            Id = 14,
                            Latitude = 44.541200000000003,
                            Longitude = 17.365400000000001,
                            Naziv = "Gradiška"
                        },
                        new
                        {
                            Id = 15,
                            Latitude = 43.337800000000001,
                            Longitude = 17.8139,
                            Naziv = "Stolac"
                        },
                        new
                        {
                            Id = 16,
                            Latitude = 44.4664,
                            Longitude = 19.1736,
                            Naziv = "Bijeljina"
                        },
                        new
                        {
                            Id = 17,
                            Latitude = 43.828400000000002,
                            Longitude = 17.404299999999999,
                            Naziv = "Livno"
                        },
                        new
                        {
                            Id = 18,
                            Latitude = 43.769799999999996,
                            Longitude = 18.0578,
                            Naziv = "Konjic"
                        },
                        new
                        {
                            Id = 19,
                            Latitude = 44.124899999999997,
                            Longitude = 18.123200000000001,
                            Naziv = "Visoko"
                        },
                        new
                        {
                            Id = 20,
                            Latitude = 44.775199999999998,
                            Longitude = 17.192399999999999,
                            Naziv = "Doboj"
                        });
                });

            modelBuilder.Entity("ridewithme.Service.Database.Korisnici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DatumKreiranja")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(320)
                        .IsUnicode(false)
                        .HasColumnType("varchar(320)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LozinkaHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Korisnici", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DatumKreiranja = new DateTime(2025, 1, 13, 7, 53, 57, 145, DateTimeKind.Local).AddTicks(5413),
                            Email = "test@gmail.com",
                            Ime = "Test",
                            KorisnickoIme = "test",
                            LozinkaHash = "KaiUaS4zfaZiZnbuv7TN0r5OfeM=",
                            LozinkaSalt = "AglQFeC8HyIM/UV2yFOa0w==",
                            Prezime = "Korisnik"
                        });
                });

            modelBuilder.Entity("ridewithme.Service.Database.KorisniciUloge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DatumIzmjene")
                        .HasColumnType("datetime");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int")
                        .HasColumnName("KorisnikId");

                    b.Property<int>("UlogaId")
                        .HasColumnType("int")
                        .HasColumnName("UlogaId");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("UlogaId");

                    b.ToTable("KorisniciUloge", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DatumIzmjene = new DateTime(2025, 1, 13, 7, 53, 57, 146, DateTimeKind.Local).AddTicks(2580),
                            KorisnikId = 1,
                            UlogaId = 1
                        });
                });

            modelBuilder.Entity("ridewithme.Service.Database.Kuponi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrojIskoristivosti")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumIzmjene")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumPocetka")
                        .HasColumnType("datetime2");

                    b.Property<string>("Kod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Popust")
                        .HasColumnType("float");

                    b.Property<string>("StateMachine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Kuponi");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrojIskoristivosti = 5,
                            DatumIzmjene = new DateTime(2025, 1, 13, 7, 53, 57, 157, DateTimeKind.Local).AddTicks(14),
                            DatumPocetka = new DateTime(2025, 1, 13, 7, 53, 57, 157, DateTimeKind.Local).AddTicks(17),
                            Kod = "TESTNI-KOD",
                            KorisnikId = 1,
                            Naziv = "Testni kod",
                            Popust = 0.10000000000000001,
                            StateMachine = "draft"
                        },
                        new
                        {
                            Id = 2,
                            BrojIskoristivosti = 10,
                            DatumIzmjene = new DateTime(2025, 1, 13, 7, 53, 57, 157, DateTimeKind.Local).AddTicks(25),
                            DatumPocetka = new DateTime(2025, 1, 13, 7, 53, 57, 157, DateTimeKind.Local).AddTicks(28),
                            Kod = "WELCOME",
                            KorisnikId = 1,
                            Naziv = "Popust dobrodošlice",
                            Popust = 0.5,
                            StateMachine = "active"
                        });
                });

            modelBuilder.Entity("ridewithme.Service.Database.Uloge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Uloge", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Naziv = "Korisnik"
                        },
                        new
                        {
                            Id = 2,
                            Naziv = "Administrator"
                        });
                });

            modelBuilder.Entity("ridewithme.Service.Database.Voznje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Cijena")
                        .HasColumnType("float");

                    b.Property<DateTime?>("DatumVrijemePocetka")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumVrijemeZavrsetka")
                        .HasColumnType("datetime2");

                    b.Property<int>("GradDoId")
                        .HasColumnType("int");

                    b.Property<int>("GradOdId")
                        .HasColumnType("int");

                    b.Property<int?>("KlijentId")
                        .HasColumnType("int");

                    b.Property<int?>("KuponId")
                        .HasColumnType("int");

                    b.Property<string>("Napomena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Ocjena")
                        .HasColumnType("int");

                    b.Property<string>("StateMachine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VozacId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GradDoId");

                    b.HasIndex("GradOdId");

                    b.HasIndex("KlijentId");

                    b.HasIndex("KuponId");

                    b.HasIndex("VozacId");

                    b.ToTable("Voznje");
                });

            modelBuilder.Entity("ridewithme.Service.Database.VrstaZalbe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DatumIzmjene")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.ToTable("VrstaZalbe");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DatumIzmjene = new DateTime(2025, 1, 13, 7, 53, 57, 156, DateTimeKind.Local).AddTicks(9833),
                            KorisnikId = 1,
                            Naziv = "Na vožnju"
                        },
                        new
                        {
                            Id = 2,
                            DatumIzmjene = new DateTime(2025, 1, 13, 7, 53, 57, 156, DateTimeKind.Local).AddTicks(9915),
                            KorisnikId = 1,
                            Naziv = "Na vozača"
                        },
                        new
                        {
                            Id = 3,
                            DatumIzmjene = new DateTime(2025, 1, 13, 7, 53, 57, 156, DateTimeKind.Local).AddTicks(9920),
                            KorisnikId = 1,
                            Naziv = "Ostalo"
                        });
                });

            modelBuilder.Entity("ridewithme.Service.Database.Zalbe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AdministratorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumIzmjene")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumKreiranja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumPreuzimanja")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<string>("Naslov")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sadrzaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateMachine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VrstaZalbeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdministratorId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("VrstaZalbeId");

                    b.ToTable("Zalbe");
                });

            modelBuilder.Entity("ridewithme.Service.Database.KorisniciUloge", b =>
                {
                    b.HasOne("ridewithme.Service.Database.Korisnici", "Korisnik")
                        .WithMany("KorisniciUloge")
                        .HasForeignKey("KorisnikId")
                        .IsRequired()
                        .HasConstraintName("FK_KorisniciUloge_Korisnici");

                    b.HasOne("ridewithme.Service.Database.Uloge", "Uloga")
                        .WithMany("KorisniciUloge")
                        .HasForeignKey("UlogaId")
                        .IsRequired()
                        .HasConstraintName("FK_KorisniciUloge_Uloge");

                    b.Navigation("Korisnik");

                    b.Navigation("Uloga");
                });

            modelBuilder.Entity("ridewithme.Service.Database.Kuponi", b =>
                {
                    b.HasOne("ridewithme.Service.Database.Korisnici", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("ridewithme.Service.Database.Voznje", b =>
                {
                    b.HasOne("ridewithme.Service.Database.Gradovi", "GradDo")
                        .WithMany()
                        .HasForeignKey("GradDoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ridewithme.Service.Database.Gradovi", "GradOd")
                        .WithMany()
                        .HasForeignKey("GradOdId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ridewithme.Service.Database.Korisnici", "Klijent")
                        .WithMany()
                        .HasForeignKey("KlijentId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("ridewithme.Service.Database.Kuponi", "Kupon")
                        .WithMany()
                        .HasForeignKey("KuponId");

                    b.HasOne("ridewithme.Service.Database.Korisnici", "Vozac")
                        .WithMany()
                        .HasForeignKey("VozacId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("GradDo");

                    b.Navigation("GradOd");

                    b.Navigation("Klijent");

                    b.Navigation("Kupon");

                    b.Navigation("Vozac");
                });

            modelBuilder.Entity("ridewithme.Service.Database.VrstaZalbe", b =>
                {
                    b.HasOne("ridewithme.Service.Database.Korisnici", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("ridewithme.Service.Database.Zalbe", b =>
                {
                    b.HasOne("ridewithme.Service.Database.Korisnici", "Administrator")
                        .WithMany()
                        .HasForeignKey("AdministratorId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("ridewithme.Service.Database.Korisnici", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ridewithme.Service.Database.VrstaZalbe", "VrstaZalbe")
                        .WithMany()
                        .HasForeignKey("VrstaZalbeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Administrator");

                    b.Navigation("Korisnik");

                    b.Navigation("VrstaZalbe");
                });

            modelBuilder.Entity("ridewithme.Service.Database.Korisnici", b =>
                {
                    b.Navigation("KorisniciUloge");
                });

            modelBuilder.Entity("ridewithme.Service.Database.Uloge", b =>
                {
                    b.Navigation("KorisniciUloge");
                });
#pragma warning restore 612, 618
        }
    }
}
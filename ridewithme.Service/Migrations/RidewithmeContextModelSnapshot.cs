﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ridewithme.Service.Database;

#nullable disable

namespace ridewithme.Service.Migrations
{
    [DbContext(typeof(RidewithmeContext))]
    partial class RidewithmeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
                });

            modelBuilder.Entity("ridewithme.Service.Database.Voznje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DatumVrijemePocetka")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DatumVrijemeZavrsetka")
                        .HasColumnType("datetime");

                    b.Property<int?>("KlijentId")
                        .HasColumnType("int");

                    b.Property<string>("StateMachine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VozacId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KlijentId");

                    b.HasIndex("VozacId");

                    b.ToTable("Voznje", (string)null);
                });

            modelBuilder.Entity("ridewithme.Service.Database.KorisniciUloge", b =>
                {
                    b.HasOne("ridewithme.Service.Database.Korisnici", "Korisnik")
                        .WithMany("KorisniciUloge")
                        .HasForeignKey("KorisnikId")
                        .IsRequired()
                        .HasConstraintName("FK_KorisniciUloge_Korisnici");

                    b.HasOne("ridewithme.Service.Database.Uloge", "Uloga")
                        .WithMany("Korisnicis")
                        .HasForeignKey("UlogaId")
                        .IsRequired()
                        .HasConstraintName("FK_KorisniciUloge_Uloge");

                    b.Navigation("Korisnik");

                    b.Navigation("Uloga");
                });

            modelBuilder.Entity("ridewithme.Service.Database.Voznje", b =>
                {
                    b.HasOne("ridewithme.Service.Database.Korisnici", "Klijent")
                        .WithMany("VoznjeKlijents")
                        .HasForeignKey("KlijentId")
                        .HasConstraintName("FK_Klijent_Korisnik");

                    b.HasOne("ridewithme.Service.Database.Korisnici", "Vozac")
                        .WithMany("VoznjeVozacs")
                        .HasForeignKey("VozacId")
                        .IsRequired()
                        .HasConstraintName("FK_Vozac_Korisnik");

                    b.Navigation("Klijent");

                    b.Navigation("Vozac");
                });

            modelBuilder.Entity("ridewithme.Service.Database.Korisnici", b =>
                {
                    b.Navigation("KorisniciUloge");

                    b.Navigation("VoznjeKlijents");

                    b.Navigation("VoznjeVozacs");
                });

            modelBuilder.Entity("ridewithme.Service.Database.Uloge", b =>
                {
                    b.Navigation("Korisnicis");
                });
#pragma warning restore 612, 618
        }
    }
}

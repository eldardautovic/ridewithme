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
    [Migration("20241117134447_KorisniciUlogeAdd")]
    partial class KorisniciUlogeAdd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("UlogaId")
                        .HasColumnType("int");

                    b.Property<int?>("UlogeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UlogeId");

                    b.ToTable("Korisnici", (string)null);
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

                    b.Property<int?>("KorisniciId")
                        .HasColumnType("int");

                    b.Property<int>("VozacId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KlijentId");

                    b.HasIndex("KorisniciId");

                    b.HasIndex("VozacId");

                    b.ToTable("Voznje", (string)null);
                });

            modelBuilder.Entity("ridewithme.Service.Database.Korisnici", b =>
                {
                    b.HasOne("ridewithme.Service.Database.Uloge", null)
                        .WithMany("Korisnicis")
                        .HasForeignKey("UlogeId");
                });

            modelBuilder.Entity("ridewithme.Service.Database.Voznje", b =>
                {
                    b.HasOne("ridewithme.Service.Database.Korisnici", "Klijent")
                        .WithMany("VoznjeKlijents")
                        .HasForeignKey("KlijentId")
                        .HasConstraintName("FK_Klijent_Korisnik");

                    b.HasOne("ridewithme.Service.Database.Korisnici", null)
                        .WithMany("KorisniciUloge")
                        .HasForeignKey("KorisniciId");

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
﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ridewithme.Service.Database;

public partial class RidewithmeContext : DbContext
{
    public RidewithmeContext()
    {
    }

    public RidewithmeContext(DbContextOptions<RidewithmeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Korisnici> Korisnicis { get; set; }

    public virtual DbSet<Uloge> Uloges { get; set; }

    public virtual DbSet<Voznje> Voznjes { get; set; }

    public virtual DbSet<KorisniciUloge> KorisniciUloges { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-RE49RGT\\SQLEXPRESS;Database=ridewithme; user=DESKTOP-RE49RGT\\Eldar; Password=admin; TrustServerCertificate=True; Trusted_Connection=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Korisnici>(entity =>
        {
            entity.ToTable("Korisnici");

            entity.Property(e => e.DatumKreiranja)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(320)
                .IsUnicode(false);
            entity.Property(e => e.Ime)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.KorisnickoIme)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Prezime)
                .HasMaxLength(100)
                .IsUnicode(false);

        });

        modelBuilder.Entity<Uloge>(entity =>
        {
            entity.ToTable("Uloge");

            entity.Property(e => e.Naziv)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Voznje>(entity =>
        {
            entity.ToTable("Voznje");

            entity.Property(e => e.DatumVrijemePocetka).HasColumnType("datetime");
            entity.Property(e => e.DatumVrijemeZavrsetka).HasColumnType("datetime");

            entity.HasOne(d => d.Klijent).WithMany(p => p.VoznjeKlijents)
                .HasForeignKey(d => d.KlijentId)
                .HasConstraintName("FK_Klijent_Korisnik");

            entity.HasOne(d => d.Vozac).WithMany(p => p.VoznjeVozacs)
                .HasForeignKey(d => d.VozacId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vozac_Korisnik");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
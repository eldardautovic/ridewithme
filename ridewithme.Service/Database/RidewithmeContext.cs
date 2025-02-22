﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

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
    public virtual DbSet<Uloge> Uloge { get; set; }
    public virtual DbSet<Voznje> Voznje { get; set; }
    public virtual DbSet<Gradovi> Gradovi { get; set; }
    public virtual DbSet<KorisniciUloge> KorisniciUloge { get; set; }
    public virtual DbSet<Kuponi> Kuponi { get; set; }
    public virtual DbSet<VrstaZalbe> VrstaZalbe { get; set; }
    public virtual DbSet<Zalbe> Zalbe { get; set; }
    public virtual DbSet<Reklame> Reklame { get; set; }
    public virtual DbSet<Dogadjaji> Dogadjaji { get; set; }
    public virtual DbSet<Obavjestenja> Obavjestenja { get; set; }
    public virtual DbSet<FAQ> FAQs { get; set; }
    public virtual DbSet<KorisniciDostignuca> KorisniciDostignuca { get; set; }
    public virtual DbSet<Dostignuca> Dostignuca { get; set; }
    public virtual DbSet<Recenzija> Recenzije { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=localhost, 1436;Initial Catalog=ridewithme; user=sa; Password=Password_123!; TrustServerCertificate=True");

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

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

            entity.HasData(
                    new Korisnici { Id = 1, KorisnickoIme = "test", Ime = "Test", Prezime = "Korisnik", Email = "test@gmail.com", LozinkaHash = "KaiUaS4zfaZiZnbuv7TN0r5OfeM=", LozinkaSalt = "AglQFeC8HyIM/UV2yFOa0w==", DatumKreiranja = DateTime.Now },
                    new Korisnici { Id = 2, KorisnickoIme = "admin", Ime = "Admin", Prezime = "Korisnik", Email = "admin@gmail.com", LozinkaHash = "KaiUaS4zfaZiZnbuv7TN0r5OfeM=", LozinkaSalt = "AglQFeC8HyIM/UV2yFOa0w==", DatumKreiranja = DateTime.Now }
                ); //pw string
        });

        modelBuilder.Entity<Uloge>(entity =>
        {
            entity.ToTable("Uloge");

            entity.Property(e => e.Naziv)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasData(
               new Uloge { Id = 1, Naziv = "Korisnik" },
               new Uloge { Id = 2, Naziv = "Administrator" });
        });

        modelBuilder.Entity<KorisniciUloge>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.ToTable("KorisniciUloge");

            entity.Property(e => e.Id).HasColumnName("Id");
            entity.Property(e => e.DatumIzmjene).HasColumnType("datetime");
            entity.Property(e => e.KorisnikId).HasColumnName("KorisnikId");
            entity.Property(e => e.UlogaId).HasColumnName("UlogaId");

            entity.HasOne(d => d.Korisnik).WithMany(p => p.KorisniciUloge)
                .HasForeignKey(d => d.KorisnikId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KorisniciUloge_Korisnici");

            entity.HasOne(d => d.Uloga).WithMany(p => p.KorisniciUloge)
                .HasForeignKey(d => d.UlogaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KorisniciUloge_Uloge");

            entity.HasData(
               new KorisniciUloge { Id = 1, DatumIzmjene = DateTime.Now, KorisnikId = 1, UlogaId = 1 },
               new KorisniciUloge { Id = 2, DatumIzmjene = DateTime.Now, KorisnikId = 2, UlogaId = 2 });

        });

        modelBuilder.Entity<Dostignuca>(entity =>
        {
            entity.ToTable("Dostignuca");

            entity.Property(e => e.Naziv)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.HasData(
                new Dostignuca { Id = 1, Naziv = "Prva vožnja", Opis = "Završio si svoju prvu vožnju! Dobrodošao u zajednicu!" },
                new Dostignuca { Id = 2, Naziv = "Desetka!", Opis = "Odradio si 10 vožnji! Postaješ pravi profesionalac!" },
                new Dostignuca { Id = 3, Naziv = "Carpool majstor", Opis = "50 vožnji! Već si legenda na putu!" },
                new Dostignuca { Id = 4, Naziv = "Legenda na cesti", Opis = "100 vožnji! Tvoj auto sada zna put napamet!" },
                new Dostignuca { Id = 5, Naziv = "Putni veteran", Opis = "500 vožnji! Obišao si pola zemlje!" },
                new Dostignuca { Id = 6, Naziv = "Putevi su moj dom", Opis = "1000 vožnji! Jesi li siguran da ne živiš u autu?" },
                new Dostignuca { Id = 7, Naziv = "Pet zvjezdica, molim!", Opis = "5/5 ocjena! Samo rijetki uspiju ovako!" },
                new Dostignuca { Id = 8, Naziv = "Noćna ptica", Opis = "Vozio si se najmanje 10 puta između ponoći i 5 ujutro!" },
                new Dostignuca { Id = 9, Naziv = "Pustolov na putu", Opis = "Vozio si se u 10 različitih gradova! Avantura te zove!" },
                new Dostignuca { Id = 10, Naziv = "ridewithme beba", Opis = "Godinu dana na platformi! Početak sjajne priče!" },
                new Dostignuca { Id = 11, Naziv = "ridewithme pro", Opis = "5 godina vožnji! Pravi si veteran zajednice!" },
                new Dostignuca { Id = 12, Naziv = "Nestali saputnik", Opis = "Otkazao si vožnju u zadnji čas! Sljedeći put dolaziš?" },
                new Dostignuca { Id = 13, Naziv = "BlaBla influencer", Opis = "Tvoj profil je pregledan preko 1000 puta! Ljudi žele putovati s tobom!" }
        );

        });

        modelBuilder.Entity<KorisniciDostignuca>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.ToTable("KorisniciDostignuca");

            entity.Property(e => e.Id).HasColumnName("Id");
            entity.Property(e => e.DatumKreiranja).HasColumnType("datetime");
            entity.Property(e => e.KorisnikId).HasColumnName("KorisnikId");
            entity.Property(e => e.DostignuceId).HasColumnName("DostignuceId");

            entity.HasOne(d => d.Korisnik).WithMany(p => p.KorisniciDostignuca)
                .HasForeignKey(d => d.KorisnikId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KorisniciDostignuca_Korisnici");

            entity.HasOne(d => d.Dostignuce).WithMany(p => p.KorisniciDostignuca)
                .HasForeignKey(d => d.DostignuceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KorisniciDostignuca_Dostignuca");

            entity.HasData(
               new KorisniciDostignuca { Id = 1, DatumKreiranja = DateTime.Now, DostignuceId = 1, KorisnikId = 1 });
        });

        modelBuilder.Entity<FAQ>(entity =>
        {
            entity.HasData(
                 new FAQ { Id = 1, KorisnikId = 1, Pitanje = "Kako mogu promijeniti svoju lozinku?", Odgovor = "Lozinku možete promijeniti u postavkama profila pod opcijom 'Uredi profil'.", DatumIzmjene = DateTime.Now, DatumKreiranja = DateTime.Now },

                 new FAQ { Id = 3, KorisnikId = 1, Pitanje = "Kako mogu ocijeniti vozača ili saputnika?", Odgovor = "Nakon završene vožnje, možete ostaviti ocjenu i komentar u sekciji 'Vožnje u kojima ste (bili) putnici'.", DatumIzmjene = DateTime.Now, DatumKreiranja = DateTime.Now },

                 new FAQ { Id = 4, KorisnikId = 1, Pitanje = "Kako mogu dodati novu vožnju?", Odgovor = "Kliknite na (+) ikonicu, 'Dodaj vožnju', unesite detalje i objavite vožnju.", DatumIzmjene = DateTime.Now, DatumKreiranja = DateTime.Now },

                 new FAQ { Id = 5, KorisnikId = 1, Pitanje = "Da li mogu kontaktirati vozača prije vožnje?", Odgovor = "Da, možete poslati poruku vozaču putem chat opcije na platformi.", DatumIzmjene = DateTime.Now, DatumKreiranja = DateTime.Now },

                 new FAQ { Id = 6, KorisnikId = 1, Pitanje = "Šta ako vozač ne dođe na dogovorenu lokaciju?", Odgovor = "Možete prijaviti problem putem opcije 'Žalbe' u sekciji profila .", DatumIzmjene = DateTime.Now, DatumKreiranja = DateTime.Now }
             );

        });

        modelBuilder.Entity<Gradovi>(entity =>
        {
            entity.HasData(
                new Gradovi { Id = 1, Latitude = 44.2261, Longitude = 17.6658, Naziv = "Travnik" },
                new Gradovi { Id = 2, Latitude = 43.8486, Longitude = 18.3564, Naziv = "Sarajevo" },
                new Gradovi { Id = 3, Latitude = 44.5373, Longitude = 18.6766, Naziv = "Tuzla" },
                new Gradovi { Id = 4, Latitude = 43.3438, Longitude = 17.8078, Naziv = "Mostar" },
                new Gradovi { Id = 5, Latitude = 44.7735, Longitude = 17.1937, Naziv = "Banja Luka" },
                new Gradovi { Id = 6, Latitude = 44.2064, Longitude = 17.6708, Naziv = "Bugojno" },
                new Gradovi { Id = 7, Latitude = 44.1178, Longitude = 17.6111, Naziv = "Jajce" },
                new Gradovi { Id = 8, Latitude = 43.6125, Longitude = 18.9725, Naziv = "Foča" },
                new Gradovi { Id = 9, Latitude = 44.4406, Longitude = 17.2218, Naziv = "Prijedor" },
                new Gradovi { Id = 10, Latitude = 44.9811, Longitude = 15.7471, Naziv = "Bihać" },
                new Gradovi { Id = 11, Latitude = 44.1608, Longitude = 19.1021, Naziv = "Zvornik" },
                new Gradovi { Id = 12, Latitude = 43.2009, Longitude = 17.6847, Naziv = "Široki Brijeg" },
                new Gradovi { Id = 13, Latitude = 44.3608, Longitude = 18.8053, Naziv = "Lukavac" },
                new Gradovi { Id = 14, Latitude = 44.5412, Longitude = 17.3654, Naziv = "Gradiška" },
                new Gradovi { Id = 15, Latitude = 43.3378, Longitude = 17.8139, Naziv = "Stolac" },
                new Gradovi { Id = 16, Latitude = 44.4664, Longitude = 19.1736, Naziv = "Bijeljina" },
                new Gradovi { Id = 17, Latitude = 43.8284, Longitude = 17.4043, Naziv = "Livno" },
                new Gradovi { Id = 18, Latitude = 43.7698, Longitude = 18.0578, Naziv = "Konjic" },
                new Gradovi { Id = 19, Latitude = 44.1249, Longitude = 18.1232, Naziv = "Visoko" },
                new Gradovi { Id = 20, Latitude = 44.7752, Longitude = 17.1924, Naziv = "Doboj" }
            );
        });
            modelBuilder.Entity<Voznje>(entity =>
            {
                entity.HasKey(v => v.Id);

                entity.HasOne(v => v.GradOd)
                      .WithMany()
                      .HasForeignKey(v => v.GradOdId)
                      .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(v => v.GradDo)
                      .WithMany()
                      .HasForeignKey(v => v.GradDoId)
                      .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(v => v.Vozac)
                      .WithMany()
                      .HasForeignKey(v => v.VozacId)
                      .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(v => v.Klijent)
                      .WithMany()
                      .HasForeignKey(v => v.KlijentId)
                      .OnDelete(DeleteBehavior.NoAction);

            });

            modelBuilder.Entity<Zalbe>(entity =>
            {
                entity.HasKey(v => v.Id);

                entity.HasOne(v => v.Administrator)
                      .WithMany()
                      .HasForeignKey(v => v.AdministratorId)
                      .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(v => v.Korisnik)
                      .WithMany()
                      .HasForeignKey(v => v.KorisnikId)
                      .OnDelete(DeleteBehavior.NoAction);

            });

            modelBuilder.Entity<VrstaZalbe>(entity =>
            {
                entity.HasData(
                    new VrstaZalbe { Id = 1, Naziv = "Na vožnju", KorisnikId = 1, DatumIzmjene = DateTime.Now },
                    new VrstaZalbe { Id = 2, Naziv = "Na vozača", KorisnikId = 1, DatumIzmjene = DateTime.Now },
                    new VrstaZalbe { Id = 3, Naziv = "Na aplikaciju", KorisnikId = 1, DatumIzmjene = DateTime.Now },
                    new VrstaZalbe { Id = 4, Naziv = "Ostalo", KorisnikId = 1, DatumIzmjene = DateTime.Now }
                );
            });

            modelBuilder.Entity<Kuponi>(entity =>
            {
                entity.HasData(
                    new Kuponi { Id = 1, Naziv = "Testni kod", KorisnikId = 1, DatumIzmjene = DateTime.Now, BrojIskoristivosti = 5, DatumPocetka = DateTime.Now, Popust = 0.1, Kod = "TESTNI-KOD", StateMachine = "draft" },
                    new Kuponi { Id = 2, Naziv = "Popust dobrodošlice", KorisnikId = 1, DatumIzmjene = DateTime.Now, BrojIskoristivosti = 10, DatumPocetka = DateTime.Now, Popust = 0.5, Kod = "WELCOME", StateMachine = "active" }
                );
            });

            modelBuilder.Entity<Zalbe>(entity =>
            {
                entity.HasData(
                   new Zalbe { Id = 1, Naslov = "Problem prilikom prijave", Sadrzaj = "Prilikom pokušaja prijave na aplikaciju, ne mogu da se prijavim iako unosim ispravne podatke.", KorisnikId = 1, DatumIzmjene = DateTime.Now, DatumKreiranja = DateTime.Now, VrstaZalbeId = 3, StateMachine = "active" },
                   new Zalbe { Id = 2, Naslov = "Vozač ne uzvraća poruke", Sadrzaj = "Potrebno je da dogovorim lokaciju polaska sa vozačem vožnje ID: 2 ali ne mogu da dobijem povratnu informaciju od vozača.", KorisnikId = 1, DatumIzmjene = DateTime.Now, DatumKreiranja = DateTime.Now, VrstaZalbeId = 2, StateMachine = "active" },
                   new Zalbe { Id = 3, Naslov = "Vožnja nije bila do navedene lokacije", Sadrzaj = "Vožnja je naznačena da je do Sarajeva, a vozili smo se do Kaknja, molim za povrat novca.", KorisnikId = 1, DatumIzmjene = DateTime.Now, DatumKreiranja = DateTime.Now, VrstaZalbeId = 1, StateMachine = "active" },
                   new Zalbe { Id = 4, Naslov = "Neiskoristiv kupon", Sadrzaj = "Naznačeno je da koristimo kupon 'WELCOME', ali on ne radi.", KorisnikId = 1, DatumIzmjene = DateTime.Now, DatumKreiranja = DateTime.Now, VrstaZalbeId = 4, StateMachine = "active" }
                );
            });

            modelBuilder.Entity<Obavjestenja>(entity =>
            {

                entity.HasData(
                   new Obavjestenja { Id = 1, Naslov = "Ažuriranje pravila privatnosti", Opis = "Ažurirali smo naša pravila privatnosti kako bi ti pružili veću transparentnost i kontrolu nad tvojim podacima. Pregledaj nove postavke privatnosti u aplikaciji i prilagodi ih svojim potrebama.", Podnaslov= "Više kontrole nad tvojim podacima", DatumIzmjene = DateTime.Now, DatumKreiranja = DateTime.Now, DatumZavrsetka = DateTime.Now.AddDays(2),  KorisnikId= 2, StateMachine = "active"},
                   new Obavjestenja { Id = 2, Naslov = "Stigli su novi alati za bolje iskustvo!", Opis = "RideWithMe je bogatiji za nove funkcionalnosti! Sada možeš lakše planirati putovanja, pratiti svoje vožnje i komunicirati s vozačima direktno iz aplikacije. Ažuriraj aplikaciju i isprobaj nove mogućnosti!", Podnaslov = "Otkrij nove funkcije aplikacije", DatumIzmjene = DateTime.Now, DatumKreiranja = DateTime.Now, DatumZavrsetka = DateTime.Now.AddHours(2), KorisnikId = 2, StateMachine = "active" },
                   new Obavjestenja { Id = 3, Naslov= "Poboljšana korisnička podrška", Opis = "Uveli smo nove opcije podrške u aplikaciji, uključujući chat uživo i detaljniji centar za pomoć. Kontaktiraj nas jednostavno putem aplikacije za bilo kakva pitanja ili sugestije!", Podnaslov = "Brže rješenje tvojih upita", DatumIzmjene = DateTime.Now, DatumKreiranja = DateTime.Now, DatumZavrsetka = DateTime.Now.AddHours(5), KorisnikId = 2, StateMachine = "active" }
                );
            });

        OnModelCreatingPartial(modelBuilder);
    }


}

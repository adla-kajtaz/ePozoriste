﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ePozoriste.Services.Database;

#nullable disable

namespace ePozoriste.Services.Migrations
{
    [DbContext(typeof(ePozoristeContext))]
    [Migration("20230419132916_seed")]
    partial class seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ePozoriste.Services.Database.Drzava", b =>
                {
                    b.Property<int>("DrzavaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DrzavaId"), 1L, 1);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skracenica")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DrzavaId");

                    b.ToTable("Drzava", (string)null);

                    b.HasData(
                        new
                        {
                            DrzavaId = 1,
                            Naziv = "Bosna i Hercegovina",
                            Skracenica = "BiH"
                        },
                        new
                        {
                            DrzavaId = 2,
                            Naziv = "Hrvatska",
                            Skracenica = "HR"
                        });
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Glumac", b =>
                {
                    b.Property<int>("GlumacId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GlumacId"), 1L, 1);

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slika")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GlumacId");

                    b.ToTable("Glumac", (string)null);
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Grad", b =>
                {
                    b.Property<int>("GradId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradId"), 1L, 1);

                    b.Property<int?>("DrzavaId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostanskiBr")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GradId");

                    b.HasIndex("DrzavaId");

                    b.ToTable("Grad", (string)null);
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Kartum", b =>
                {
                    b.Property<int>("KartaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KartaId"), 1L, 1);

                    b.Property<bool?>("Aktivna")
                        .HasColumnType("bit");

                    b.Property<string>("Sjediste")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int?>("TerminId")
                        .HasColumnType("int");

                    b.HasKey("KartaId")
                        .HasName("PK__Karta__EC3FA9EE23583A11");

                    b.HasIndex("TerminId");

                    b.ToTable("Karta");
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Korisnik", b =>
                {
                    b.Property<int>("KorisnikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KorisnikId"), 1L, 1);

                    b.Property<bool?>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<string>("BrTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KorisnikId");

                    b.ToTable("Korisnik", (string)null);
                });

            modelBuilder.Entity("ePozoriste.Services.Database.KorisnikUloge", b =>
                {
                    b.Property<int>("KorisnikUlogeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KorisnikUlogeId"), 1L, 1);

                    b.Property<int?>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int?>("UlogaId")
                        .HasColumnType("int");

                    b.HasKey("KorisnikUlogeId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("UlogaId");

                    b.ToTable("KorisnikUloge", (string)null);
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Kupovina", b =>
                {
                    b.Property<int>("KupovinaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KupovinaId"), 1L, 1);

                    b.Property<int?>("Cijena")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DatumKupovine")
                        .HasColumnType("datetime");

                    b.Property<int?>("KartaId")
                        .HasColumnType("int");

                    b.Property<int?>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int?>("KorisnikId")
                        .HasColumnType("int");

                    b.HasKey("KupovinaId");

                    b.HasIndex("KartaId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Kupovina", (string)null);
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Obavijest", b =>
                {
                    b.Property<int>("ObavijestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ObavijestId"), 1L, 1);

                    b.Property<DateTime?>("DatumKreiranja")
                        .HasColumnType("datetime");

                    b.Property<int?>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<string>("Naslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ObavijestKategorijaId")
                        .HasColumnType("int");

                    b.Property<string>("Podnaslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sadrzaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slika")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ObavijestId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("ObavijestKategorijaId");

                    b.ToTable("Obavijest", (string)null);
                });

            modelBuilder.Entity("ePozoriste.Services.Database.ObavijestKategorija", b =>
                {
                    b.Property<int>("ObavijestKategorijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ObavijestKategorijaId"), 1L, 1);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ObavijestKategorijaId");

                    b.ToTable("ObavijestKategorija", (string)null);
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Pozoriste", b =>
                {
                    b.Property<int>("PozoristeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PozoristeId"), 1L, 1);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<string>("BrTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GradId")
                        .HasColumnType("int");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Webstranica")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PozoristeId");

                    b.HasIndex("GradId");

                    b.ToTable("Pozoriste", (string)null);
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Predstava", b =>
                {
                    b.Property<int>("PredstavaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PredstavaId"), 1L, 1);

                    b.Property<string>("Kostimografija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rezija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sadrzaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Scenografija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VrijemeTrajanje")
                        .HasColumnType("int");

                    b.HasKey("PredstavaId");

                    b.ToTable("Predstava", (string)null);
                });

            modelBuilder.Entity("ePozoriste.Services.Database.PredstavaGlumac", b =>
                {
                    b.Property<int>("PredstavaGlumacId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PredstavaGlumacId"), 1L, 1);

                    b.Property<int?>("GlumacId")
                        .HasColumnType("int");

                    b.Property<string>("NazivUloge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PredstavaId")
                        .HasColumnType("int");

                    b.HasKey("PredstavaGlumacId");

                    b.HasIndex("GlumacId");

                    b.HasIndex("PredstavaId");

                    b.ToTable("PredstavaGlumac", (string)null);
                });

            modelBuilder.Entity("ePozoriste.Services.Database.PredstavaVrstaPredstave", b =>
                {
                    b.Property<int>("PredstavaVpid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PredstavaVPId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PredstavaVpid"), 1L, 1);

                    b.Property<int?>("PredstavaId")
                        .HasColumnType("int");

                    b.Property<int?>("VrstaPredstaveId")
                        .HasColumnType("int");

                    b.HasKey("PredstavaVpid")
                        .HasName("PK__Predstav__D51F265A1B68304F");

                    b.HasIndex("PredstavaId");

                    b.HasIndex("VrstaPredstaveId");

                    b.ToTable("PredstavaVrstaPredstave", (string)null);
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Sala", b =>
                {
                    b.Property<int>("SalaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalaId"), 1L, 1);

                    b.Property<int?>("BrRedova")
                        .HasColumnType("int");

                    b.Property<int?>("BrSjedista")
                        .HasColumnType("int");

                    b.Property<int?>("BrSjedistaPoRedu")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PozoristeId")
                        .HasColumnType("int");

                    b.HasKey("SalaId");

                    b.HasIndex("PozoristeId");

                    b.ToTable("Sala", (string)null);
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Termin", b =>
                {
                    b.Property<int>("TerminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TerminId"), 1L, 1);

                    b.Property<int?>("CijenaKarte")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DatumVrijemeOdrzavanja")
                        .HasColumnType("datetime");

                    b.Property<bool?>("Predpremijera")
                        .HasColumnType("bit");

                    b.Property<int?>("PredstavaId")
                        .HasColumnType("int");

                    b.Property<bool?>("Premijera")
                        .HasColumnType("bit");

                    b.Property<int?>("SalaId")
                        .HasColumnType("int");

                    b.HasKey("TerminId");

                    b.HasIndex("PredstavaId");

                    b.HasIndex("SalaId");

                    b.ToTable("Termin", (string)null);
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Uloga", b =>
                {
                    b.Property<int>("UlogaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UlogaId"), 1L, 1);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UlogaId");

                    b.ToTable("Uloga", (string)null);
                });

            modelBuilder.Entity("ePozoriste.Services.Database.VrstaPredstave", b =>
                {
                    b.Property<int>("VrstaPredstaveId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VrstaPredstaveId"), 1L, 1);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VrstaPredstaveId");

                    b.ToTable("VrstaPredstave", (string)null);
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Grad", b =>
                {
                    b.HasOne("ePozoriste.Services.Database.Drzava", "Drzava")
                        .WithMany("Grads")
                        .HasForeignKey("DrzavaId")
                        .HasConstraintName("FK__Grad__DrzavaId__2E1BDC42");

                    b.Navigation("Drzava");
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Kartum", b =>
                {
                    b.HasOne("ePozoriste.Services.Database.Termin", "Termin")
                        .WithMany("Karta")
                        .HasForeignKey("TerminId")
                        .HasConstraintName("FK__Karta__TerminId__4D94879B");

                    b.Navigation("Termin");
                });

            modelBuilder.Entity("ePozoriste.Services.Database.KorisnikUloge", b =>
                {
                    b.HasOne("ePozoriste.Services.Database.Korisnik", "Korisnik")
                        .WithMany("KorisnikUloges")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK__KorisnikU__Koris__29572725");

                    b.HasOne("ePozoriste.Services.Database.Uloga", "Uloga")
                        .WithMany("KorisnikUloges")
                        .HasForeignKey("UlogaId")
                        .HasConstraintName("FK__KorisnikU__Uloga__286302EC");

                    b.Navigation("Korisnik");

                    b.Navigation("Uloga");
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Kupovina", b =>
                {
                    b.HasOne("ePozoriste.Services.Database.Kartum", "Karta")
                        .WithMany("Kupovinas")
                        .HasForeignKey("KartaId")
                        .HasConstraintName("FK__Kupovina__KartaI__5165187F");

                    b.HasOne("ePozoriste.Services.Database.Korisnik", "Korisnik")
                        .WithMany("Kupovinas")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK__Kupovina__Korisn__5070F446");

                    b.Navigation("Karta");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Obavijest", b =>
                {
                    b.HasOne("ePozoriste.Services.Database.Korisnik", "Korisnik")
                        .WithMany("Obavijests")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK__Obavijest__Koris__33D4B598");

                    b.HasOne("ePozoriste.Services.Database.ObavijestKategorija", "ObavijestKategorija")
                        .WithMany("Obavijests")
                        .HasForeignKey("ObavijestKategorijaId")
                        .HasConstraintName("FK__Obavijest__Obavi__32E0915F");

                    b.Navigation("Korisnik");

                    b.Navigation("ObavijestKategorija");
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Pozoriste", b =>
                {
                    b.HasOne("ePozoriste.Services.Database.Grad", "Grad")
                        .WithMany("Pozoristes")
                        .HasForeignKey("GradId")
                        .HasConstraintName("FK__Pozoriste__GradI__36B12243");

                    b.Navigation("Grad");
                });

            modelBuilder.Entity("ePozoriste.Services.Database.PredstavaGlumac", b =>
                {
                    b.HasOne("ePozoriste.Services.Database.Glumac", "Glumac")
                        .WithMany("PredstavaGlumacs")
                        .HasForeignKey("GlumacId")
                        .HasConstraintName("FK__Predstava__Gluma__45F365D3");

                    b.HasOne("ePozoriste.Services.Database.Predstava", "Predstava")
                        .WithMany("PredstavaGlumacs")
                        .HasForeignKey("PredstavaId")
                        .HasConstraintName("FK__Predstava__Preds__46E78A0C");

                    b.Navigation("Glumac");

                    b.Navigation("Predstava");
                });

            modelBuilder.Entity("ePozoriste.Services.Database.PredstavaVrstaPredstave", b =>
                {
                    b.HasOne("ePozoriste.Services.Database.Predstava", "Predstava")
                        .WithMany("PredstavaVrstaPredstaves")
                        .HasForeignKey("PredstavaId")
                        .HasConstraintName("FK__Predstava__Preds__4AB81AF0");

                    b.HasOne("ePozoriste.Services.Database.VrstaPredstave", "VrstaPredstave")
                        .WithMany("PredstavaVrstaPredstaves")
                        .HasForeignKey("VrstaPredstaveId")
                        .HasConstraintName("FK__Predstava__Vrsta__49C3F6B7");

                    b.Navigation("Predstava");

                    b.Navigation("VrstaPredstave");
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Sala", b =>
                {
                    b.HasOne("ePozoriste.Services.Database.Pozoriste", "Pozoriste")
                        .WithMany("Salas")
                        .HasForeignKey("PozoristeId")
                        .HasConstraintName("FK__Sala__PozoristeI__398D8EEE");

                    b.Navigation("Pozoriste");
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Termin", b =>
                {
                    b.HasOne("ePozoriste.Services.Database.Predstava", "Predstava")
                        .WithMany("Termins")
                        .HasForeignKey("PredstavaId")
                        .HasConstraintName("FK__Termin__Predstav__4316F928");

                    b.HasOne("ePozoriste.Services.Database.Sala", "Sala")
                        .WithMany("Termins")
                        .HasForeignKey("SalaId")
                        .HasConstraintName("FK__Termin__SalaId__4222D4EF");

                    b.Navigation("Predstava");

                    b.Navigation("Sala");
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Drzava", b =>
                {
                    b.Navigation("Grads");
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Glumac", b =>
                {
                    b.Navigation("PredstavaGlumacs");
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Grad", b =>
                {
                    b.Navigation("Pozoristes");
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Kartum", b =>
                {
                    b.Navigation("Kupovinas");
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Korisnik", b =>
                {
                    b.Navigation("KorisnikUloges");

                    b.Navigation("Kupovinas");

                    b.Navigation("Obavijests");
                });

            modelBuilder.Entity("ePozoriste.Services.Database.ObavijestKategorija", b =>
                {
                    b.Navigation("Obavijests");
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Pozoriste", b =>
                {
                    b.Navigation("Salas");
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Predstava", b =>
                {
                    b.Navigation("PredstavaGlumacs");

                    b.Navigation("PredstavaVrstaPredstaves");

                    b.Navigation("Termins");
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Sala", b =>
                {
                    b.Navigation("Termins");
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Termin", b =>
                {
                    b.Navigation("Karta");
                });

            modelBuilder.Entity("ePozoriste.Services.Database.Uloga", b =>
                {
                    b.Navigation("KorisnikUloges");
                });

            modelBuilder.Entity("ePozoriste.Services.Database.VrstaPredstave", b =>
                {
                    b.Navigation("PredstavaVrstaPredstaves");
                });
#pragma warning restore 612, 618
        }
    }
}

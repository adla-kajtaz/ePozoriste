using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePozoriste.Services.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzava",
                columns: table => new
                {
                    DrzavaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skracenica = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzava", x => x.DrzavaId);
                });

            migrationBuilder.CreateTable(
                name: "Glumac",
                columns: table => new
                {
                    GlumacId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slika = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Glumac", x => x.GlumacId);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrTelefona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LozinkaHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LozinkaSalt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aktivan = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.KorisnikId);
                });

            migrationBuilder.CreateTable(
                name: "ObavijestKategorija",
                columns: table => new
                {
                    ObavijestKategorijaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObavijestKategorija", x => x.ObavijestKategorijaId);
                });

            migrationBuilder.CreateTable(
                name: "Predstava",
                columns: table => new
                {
                    PredstavaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sadrzaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slika = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VrijemeTrajanje = table.Column<int>(type: "int", nullable: true),
                    Rezija = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Scenografija = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kostimografija = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Predstava", x => x.PredstavaId);
                });

            migrationBuilder.CreateTable(
                name: "Uloga",
                columns: table => new
                {
                    UlogaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloga", x => x.UlogaId);
                });

            migrationBuilder.CreateTable(
                name: "VrstaPredstave",
                columns: table => new
                {
                    VrstaPredstaveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaPredstave", x => x.VrstaPredstaveId);
                });

            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    GradId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostanskiBr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrzavaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.GradId);
                    table.ForeignKey(
                        name: "FK__Grad__DrzavaId__2E1BDC42",
                        column: x => x.DrzavaId,
                        principalTable: "Drzava",
                        principalColumn: "DrzavaId");
                });

            migrationBuilder.CreateTable(
                name: "Obavijest",
                columns: table => new
                {
                    ObavijestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naslov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Podnaslov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sadrzaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slika = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime", nullable: true),
                    ObavijestKategorijaId = table.Column<int>(type: "int", nullable: true),
                    KorisnikId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obavijest", x => x.ObavijestId);
                    table.ForeignKey(
                        name: "FK__Obavijest__Koris__33D4B598",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId");
                    table.ForeignKey(
                        name: "FK__Obavijest__Obavi__32E0915F",
                        column: x => x.ObavijestKategorijaId,
                        principalTable: "ObavijestKategorija",
                        principalColumn: "ObavijestKategorijaId");
                });

            migrationBuilder.CreateTable(
                name: "PredstavaGlumac",
                columns: table => new
                {
                    PredstavaGlumacId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GlumacId = table.Column<int>(type: "int", nullable: true),
                    PredstavaId = table.Column<int>(type: "int", nullable: true),
                    NazivUloge = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PredstavaGlumac", x => x.PredstavaGlumacId);
                    table.ForeignKey(
                        name: "FK__Predstava__Gluma__45F365D3",
                        column: x => x.GlumacId,
                        principalTable: "Glumac",
                        principalColumn: "GlumacId");
                    table.ForeignKey(
                        name: "FK__Predstava__Preds__46E78A0C",
                        column: x => x.PredstavaId,
                        principalTable: "Predstava",
                        principalColumn: "PredstavaId");
                });

            migrationBuilder.CreateTable(
                name: "KorisnikUloge",
                columns: table => new
                {
                    KorisnikUlogeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UlogaId = table.Column<int>(type: "int", nullable: true),
                    KorisnikId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikUloge", x => x.KorisnikUlogeId);
                    table.ForeignKey(
                        name: "FK__KorisnikU__Koris__29572725",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId");
                    table.ForeignKey(
                        name: "FK__KorisnikU__Uloga__286302EC",
                        column: x => x.UlogaId,
                        principalTable: "Uloga",
                        principalColumn: "UlogaId");
                });

            migrationBuilder.CreateTable(
                name: "PredstavaVrstaPredstave",
                columns: table => new
                {
                    PredstavaVPId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VrstaPredstaveId = table.Column<int>(type: "int", nullable: true),
                    PredstavaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Predstav__D51F265A1B68304F", x => x.PredstavaVPId);
                    table.ForeignKey(
                        name: "FK__Predstava__Preds__4AB81AF0",
                        column: x => x.PredstavaId,
                        principalTable: "Predstava",
                        principalColumn: "PredstavaId");
                    table.ForeignKey(
                        name: "FK__Predstava__Vrsta__49C3F6B7",
                        column: x => x.VrstaPredstaveId,
                        principalTable: "VrstaPredstave",
                        principalColumn: "VrstaPredstaveId");
                });

            migrationBuilder.CreateTable(
                name: "Pozoriste",
                columns: table => new
                {
                    PozoristeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Webstranica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrTelefona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aktivan = table.Column<bool>(type: "bit", nullable: true),
                    GradId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pozoriste", x => x.PozoristeId);
                    table.ForeignKey(
                        name: "FK__Pozoriste__GradI__36B12243",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "GradId");
                });

            migrationBuilder.CreateTable(
                name: "Sala",
                columns: table => new
                {
                    SalaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrSjedista = table.Column<int>(type: "int", nullable: true),
                    BrRedova = table.Column<int>(type: "int", nullable: true),
                    BrSjedistaPoRedu = table.Column<int>(type: "int", nullable: true),
                    PozoristeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sala", x => x.SalaId);
                    table.ForeignKey(
                        name: "FK__Sala__PozoristeI__398D8EEE",
                        column: x => x.PozoristeId,
                        principalTable: "Pozoriste",
                        principalColumn: "PozoristeId");
                });

            migrationBuilder.CreateTable(
                name: "Termin",
                columns: table => new
                {
                    TerminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalaId = table.Column<int>(type: "int", nullable: true),
                    PredstavaId = table.Column<int>(type: "int", nullable: true),
                    Premijera = table.Column<bool>(type: "bit", nullable: true),
                    Predpremijera = table.Column<bool>(type: "bit", nullable: true),
                    CijenaKarte = table.Column<int>(type: "int", nullable: true),
                    DatumVrijemeOdrzavanja = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Termin", x => x.TerminId);
                    table.ForeignKey(
                        name: "FK__Termin__Predstav__4316F928",
                        column: x => x.PredstavaId,
                        principalTable: "Predstava",
                        principalColumn: "PredstavaId");
                    table.ForeignKey(
                        name: "FK__Termin__SalaId__4222D4EF",
                        column: x => x.SalaId,
                        principalTable: "Sala",
                        principalColumn: "SalaId");
                });

            migrationBuilder.CreateTable(
                name: "Karta",
                columns: table => new
                {
                    KartaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aktivna = table.Column<bool>(type: "bit", nullable: true),
                    TerminId = table.Column<int>(type: "int", nullable: true),
                    Sjediste = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Karta__EC3FA9EE23583A11", x => x.KartaId);
                    table.ForeignKey(
                        name: "FK__Karta__TerminId__4D94879B",
                        column: x => x.TerminId,
                        principalTable: "Termin",
                        principalColumn: "TerminId");
                });

            migrationBuilder.CreateTable(
                name: "Kupovina",
                columns: table => new
                {
                    KupovinaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kolicina = table.Column<int>(type: "int", nullable: true),
                    Cijena = table.Column<int>(type: "int", nullable: true),
                    DatumKupovine = table.Column<DateTime>(type: "datetime", nullable: true),
                    KorisnikId = table.Column<int>(type: "int", nullable: true),
                    KartaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kupovina", x => x.KupovinaId);
                    table.ForeignKey(
                        name: "FK__Kupovina__KartaI__5165187F",
                        column: x => x.KartaId,
                        principalTable: "Karta",
                        principalColumn: "KartaId");
                    table.ForeignKey(
                        name: "FK__Kupovina__Korisn__5070F446",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grad_DrzavaId",
                table: "Grad",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_Karta_TerminId",
                table: "Karta",
                column: "TerminId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikUloge_KorisnikId",
                table: "KorisnikUloge",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikUloge_UlogaId",
                table: "KorisnikUloge",
                column: "UlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupovina_KartaId",
                table: "Kupovina",
                column: "KartaId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupovina_KorisnikId",
                table: "Kupovina",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Obavijest_KorisnikId",
                table: "Obavijest",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Obavijest_ObavijestKategorijaId",
                table: "Obavijest",
                column: "ObavijestKategorijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pozoriste_GradId",
                table: "Pozoriste",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_PredstavaGlumac_GlumacId",
                table: "PredstavaGlumac",
                column: "GlumacId");

            migrationBuilder.CreateIndex(
                name: "IX_PredstavaGlumac_PredstavaId",
                table: "PredstavaGlumac",
                column: "PredstavaId");

            migrationBuilder.CreateIndex(
                name: "IX_PredstavaVrstaPredstave_PredstavaId",
                table: "PredstavaVrstaPredstave",
                column: "PredstavaId");

            migrationBuilder.CreateIndex(
                name: "IX_PredstavaVrstaPredstave_VrstaPredstaveId",
                table: "PredstavaVrstaPredstave",
                column: "VrstaPredstaveId");

            migrationBuilder.CreateIndex(
                name: "IX_Sala_PozoristeId",
                table: "Sala",
                column: "PozoristeId");

            migrationBuilder.CreateIndex(
                name: "IX_Termin_PredstavaId",
                table: "Termin",
                column: "PredstavaId");

            migrationBuilder.CreateIndex(
                name: "IX_Termin_SalaId",
                table: "Termin",
                column: "SalaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KorisnikUloge");

            migrationBuilder.DropTable(
                name: "Kupovina");

            migrationBuilder.DropTable(
                name: "Obavijest");

            migrationBuilder.DropTable(
                name: "PredstavaGlumac");

            migrationBuilder.DropTable(
                name: "PredstavaVrstaPredstave");

            migrationBuilder.DropTable(
                name: "Uloga");

            migrationBuilder.DropTable(
                name: "Karta");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "ObavijestKategorija");

            migrationBuilder.DropTable(
                name: "Glumac");

            migrationBuilder.DropTable(
                name: "VrstaPredstave");

            migrationBuilder.DropTable(
                name: "Termin");

            migrationBuilder.DropTable(
                name: "Predstava");

            migrationBuilder.DropTable(
                name: "Sala");

            migrationBuilder.DropTable(
                name: "Pozoriste");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "Drzava");
        }
    }
}

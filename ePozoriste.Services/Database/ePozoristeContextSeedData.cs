using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Services.Database
{
    public partial class ePozoristeContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drzava>().HasData(new Drzava[]
             {
                new Drzava()
                {
                    DrzavaId = 1,
                    Naziv = "Bosna i Hercegovina",
                    Skracenica = "BiH"
                },
                new Drzava()
                {
                    DrzavaId = 2,
                    Naziv = "Hrvatska",
                    Skracenica = "HR"
                }
            });

            modelBuilder.Entity<Grad>().HasData(new Grad[]
             {
                new Grad()
                {
                    GradId = 1,
                    Naziv = "Mostar",
                    PostanskiBr = "88104",
                    DrzavaId = 1
                },
                new Grad()
                {
                    GradId = 2,
                    Naziv = "Sarajevo",
                    PostanskiBr = "71000",
                    DrzavaId = 1
                }
            });

            modelBuilder.Entity<Uloga>().HasData(new Uloga[]
             {
                new Uloga()
                {
                    UlogaId = 1,
                    Naziv = "Admin"
                },
                new Uloga()
                {
                    UlogaId = 2,
                    Naziv = "Kupac"
                }
            });

            modelBuilder.Entity<Korisnik>().HasData(new Korisnik[]
             {
                new Korisnik()
                {
                    KorisnikId = 1,
                    Ime = "Admin",
                    Prezime = "Admin",
                    KorisnickoIme = "admin",
                    Email = "admin@epozoriste.ba",
                    BrTelefona = "062 045-456",
                    Aktivan = true,
                    LozinkaHash = "523l3SXvXt/OIGacFmI0PUlXkJM=",
                    LozinkaSalt = "ORNOSgr59Nd5PGJx/GNMKg=="
                }
            });;

            modelBuilder.Entity<KorisnikUloge>().HasData(new KorisnikUloge[]
            {
                new KorisnikUloge()
                {
                    KorisnikUlogeId = 1,
                    KorisnikId = 1,
                    UlogaId = 1
                }
           });

            modelBuilder.Entity<ObavijestKategorija>().HasData(new ObavijestKategorija[]
             {
                new ObavijestKategorija()
                {
                    ObavijestKategorijaId = 1,
                    Naziv = "Novosti"
                }
            });

            modelBuilder.Entity<Obavijest>().HasData(new Obavijest[]
            {
                new Obavijest()
                {
                    ObavijestId = 1,
                    Naslov = "Uskoro u prodaji karte za predstavu Ćelava pjevačica",
                    Podnaslov = "Uskoro u prodaji karte za predstavu Ćelava pjevačica",
                    Sadrzaj = "Ulaznice su u prodaji na blagajni NPM-a od ponedjeljka, 5.6.2023. svakim radnim danom od 9 - 14 sati, na dan igranja predstave od 9 do 14 sati te od 18 do 20 sati. Rezervacije: na broj 036/550-128, mail: marketing@npm.ba, porukom u inbox na Facebook stranici Narodnog pozorišta Mostar.",
                    DatumKreiranja = DateTime.Now,
                    KorisnikId = 1,
                    ObavijestKategorijaId = 1
                }
            });

            modelBuilder.Entity<Pozoriste>().HasData(new Pozoriste[]
            {
                new Pozoriste()
                {
                    PozoristeId = 1,
                    Naziv = "Narodno pozoriste Mostar",
                    Adresa = "Brkića br. 2",
                    Webstranica = "https://www.npm.ba/",
                    Email = "info@npm.ba",
                    BrTelefona = "036 550-128",
                    Aktivan = true,
                    GradId = 1
                }
           });

            modelBuilder.Entity<Sala>().HasData(new Sala[]
            {
                new Sala()
                {
                    SalaId = 1,
                    Naziv = "Velika sala",
                    BrSjedista = 300,
                    BrRedova = 15,
                    BrSjedistaPoRedu = 15,
                    PozoristeId = 1
                },
                new Sala()
                {
                    SalaId = 2,
                    Naziv = "Mala sala",
                    BrSjedista = 100,
                    BrRedova = 10,
                    BrSjedistaPoRedu = 10,
                    PozoristeId = 1
                }
           });

            modelBuilder.Entity<VrstaPredstave>().HasData(new VrstaPredstave[]
            {
                new VrstaPredstave()
                {
                    VrstaPredstaveId = 1,
                    Naziv = "Drama",
                },
                new VrstaPredstave()
                {
                    VrstaPredstaveId = 2,
                    Naziv = "Komedija",
                }
           });

            modelBuilder.Entity<Glumac>().HasData(new Glumac[]
            {
                new Glumac()
                {
                    GlumacId = 1,
                    Ime = "Ajla",
                    Prezime = "Hamzić",
                    ImePrezime = "Ajla Hamzić"
                },
                new Glumac()
                {
                    GlumacId = 2,
                    Ime = "Emir",
                    Prezime = "Spahić",
                    ImePrezime = "Emir Spahić"
                }
           });

            modelBuilder.Entity<Predstava>().HasData(new Predstava[]
            {
                new Predstava()
                {
                    PredstavaId = 1,
                    Naziv = "Ćelava pjevačica",
                    Sadrzaj = "“Kao i Jonesko, mi, ekipa predstave željeli smo kroz 'Ćelavu pjevačicu' efektom 'čudnovatog', ironijom, non-sensom, karikaturom izraziti svoj protest protiv društva u kojem živimo i stanja u kome se nalazimo. 'Ćelava pjevačica' ismijava nepresušnu potrebu naroda da stalno govori, o svemu ima mišljenje i bude u toku svih dešavanja - najčešće i najbanalnijih. Govor se dovodi do apsurda. Riječi gube smisao. Misao devalvira. Sve dok glas izlazi iz grla govor ne prestaje. I tako u nedogled. A svaki vid akcije, djelovanja izostaje. I to neko koristi. Jedni iznutra, drugi izvana. Da li govorim o životu ili o predstavi? Svejedno. Na žalost, Joneskov besmisao nigdje nije smislenije postaviti nego u Mostaru. Vođena mišlju da će neki novi klinci po prvi put vidjeti Joneskov komad u teatru i možda biti isprovocirani njime (kakogod) te odluče se, konačno, na neki vid djelovanja... To je jedini način izlaska iz apsurda koji živimo”, zapisala je o predstavi rediteljica Lajla Kaikčija",
                    VrijemeTrajanje = 45,
                    Rezija = "Lajla Kaikčija",
                    Scenografija = "Sabina Trnka",
                    Kostimografija = "Sabina Trnka"
                }
           });

            modelBuilder.Entity<PredstavaVrstaPredstave>().HasData(new PredstavaVrstaPredstave[]
            {
                new PredstavaVrstaPredstave()
                {
                    PredstavaVpid = 1,
                    VrstaPredstaveId = 1,
                    PredstavaId = 1
                }
           });

            modelBuilder.Entity<PredstavaGlumac>().HasData(new PredstavaGlumac[]
            {
                new PredstavaGlumac()
                {
                    PredstavaGlumacId = 1,
                    GlumacId = 2,
                    PredstavaId = 1,
                    NazivUloge = "G. Smit"
                }
           });

            modelBuilder.Entity<Termin>().HasData(new Termin[]
            {
                new Termin()
                {
                    TerminId = 1,
                    SalaId = 1,
                    PredstavaId = 1,
                    Predpremijera = true,
                    Premijera = false,
                    CijenaKarte = 20,
                    DatumOdrzavanja = DateTime.Now.Date,
                    VrijemeOdrzavanja = "20:00"
                }
            });
        }
       
    }
}

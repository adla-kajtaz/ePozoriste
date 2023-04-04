using System;
using System.Collections.Generic;

namespace ePozoriste.Services.Database
{
    public partial class Kupovina
    {
        public int KupovinaId { get; set; }
        public int? Kolicina { get; set; }
        public int? Cijena { get; set; }
        public DateTime? DatumKupovine { get; set; }
        public int? KorisnikId { get; set; }
        public int? KartaId { get; set; }

        public virtual Kartum? Karta { get; set; }
        public virtual Korisnik? Korisnik { get; set; }
    }
}

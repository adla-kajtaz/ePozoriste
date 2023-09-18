using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Model
{
    public class Kupovina
    {
        public int KupovinaId { get; set; }
        public int? Kolicina { get; set; }
        public int? Cijena { get; set; }
        public DateTime? DatumKupovine { get; set; }
        public int? KorisnikId { get; set; }
        public virtual Korisnik? Korisnik { get; set; }
    }
}

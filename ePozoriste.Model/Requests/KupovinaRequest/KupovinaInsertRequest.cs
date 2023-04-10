using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Model.Requests
{
    public class KupovinaInsertRequest
    {
        public int Kolicina { get; set; }
        public int Cijena { get; set; }
        public DateTime DatumKupovine { get; set; }
        public int? KorisnikId { get; set; }
        public int? KartaId { get; set; }
    }
}

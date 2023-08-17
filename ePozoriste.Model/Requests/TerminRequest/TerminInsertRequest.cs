using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Model.Requests
{
    public class TerminInsertRequest
    {
        public bool Premijera { get; set; }
        public bool Predpremijera { get; set; }
        public int CijenaKarte { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public string VrijemeOdrzavanja { get; set; }

        public int? SalaId { get; set; }
        public int? PredstavaId { get; set; }
    }
}

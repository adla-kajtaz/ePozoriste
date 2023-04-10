using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Model
{
    public class Karta
    {
        public int KartaId { get; set; }
        public bool Aktivna { get; set; }
        public int? TerminId { get; set; }
        public virtual Termin? Termin { get; set; }
        public string Sjediste { get; set; }

    }
}

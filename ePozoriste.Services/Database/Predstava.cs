using System;
using System.Collections.Generic;

namespace ePozoriste.Services.Database
{
    public partial class Predstava
    {
        public Predstava()
        {
            PredstavaGlumacs = new HashSet<PredstavaGlumac>();
            PredstavaVrstaPredstaves = new HashSet<PredstavaVrstaPredstave>();
            Termins = new HashSet<Termin>();
        }

        public int PredstavaId { get; set; }
        public string? Naziv { get; set; }
        public string? Sadrzaj { get; set; }
        public string? Slika { get; set; }
        public int? VrijemeTrajanje { get; set; }
        public string? Rezija { get; set; }
        public string? Scenografija { get; set; }
        public string? Kostimografija { get; set; }

        public virtual ICollection<PredstavaGlumac> PredstavaGlumacs { get; set; }
        public virtual ICollection<PredstavaVrstaPredstave> PredstavaVrstaPredstaves { get; set; }
        public virtual ICollection<Termin> Termins { get; set; }
    }
}

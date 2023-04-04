using System;
using System.Collections.Generic;

namespace ePozoriste.Services.Database
{
    public partial class VrstaPredstave
    {
        public VrstaPredstave()
        {
            PredstavaVrstaPredstaves = new HashSet<PredstavaVrstaPredstave>();
        }

        public int VrstaPredstaveId { get; set; }
        public string? Naziv { get; set; }

        public virtual ICollection<PredstavaVrstaPredstave> PredstavaVrstaPredstaves { get; set; }
    }
}

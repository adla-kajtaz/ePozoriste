using System;
using System.Collections.Generic;

namespace ePozoriste.Services.Database
{
    public partial class PredstavaVrstaPredstave
    {
        public int PredstavaVpid { get; set; }
        public int? VrstaPredstaveId { get; set; }
        public int? PredstavaId { get; set; }

        public virtual Predstava? Predstava { get; set; }
        public virtual VrstaPredstave? VrstaPredstave { get; set; }
    }
}

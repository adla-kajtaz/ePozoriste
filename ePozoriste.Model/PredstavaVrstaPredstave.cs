using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Model
{
    public class PredstavaVrstaPredstave
    {
        public int PredstavaVpid { get; set; }
        public int? VrstaPredstaveId { get; set; }
        public int? PredstavaId { get; set; }

        public virtual Predstava? Predstava { get; set; }
        public virtual VrstaPredstave? VrstaPredstave { get; set; }
    }
}

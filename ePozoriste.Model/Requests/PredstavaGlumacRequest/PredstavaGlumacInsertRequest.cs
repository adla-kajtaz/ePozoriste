using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Model.Requests
{
    public class PredstavaGlumacInsertRequest
    {
        public int GlumacId { get; set; }
        public int PredstavaId { get; set; }
        public string NazivUloge { get; set; }
    }
}

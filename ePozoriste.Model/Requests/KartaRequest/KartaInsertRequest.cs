using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Model.Requests
{
    public class KartaInsertRequest
    {
        public bool Aktivna { get; set; }
        public int? TerminId { get; set; }
        public string Sjediste { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Model.Requests
{
    public class KorisnikUlogeInsertRequest
    {
        public int UlogaId { get; set; }
        public int KorisnikId { get; set; }
    }
}

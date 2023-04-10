using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Model.SearchObjects
{
    public class PredstavaVrstaPredstaveSearchObject : BaseSearchObject
    {
        public int? VrstaPredstaveId { get; set; }
        public int? PredstavaId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Model.Requests
{
    public class PredstavaVrstaPredstaveInsertRequest
    {
        [Required]
        public int VrstaPredstaveId { get; set; }

        [Required]
        public int PredstavaId { get; set; }
    }
}

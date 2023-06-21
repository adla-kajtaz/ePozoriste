using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Model.Requests
{
    public class PozoristeInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Adresa { get; set; }

        //[RegularExpression("^(https?://)?([A-Za-z0-9-]+\\.)+[A-Za-z]{2,}(\\:\\d+)?(/.*)?$")]
        public string Webstranica { get; set; }

        [Required(AllowEmptyStrings = false)]
        //[EmailAddress()]
        public string Email { get; set; }

        //[RegularExpression("^\\d{3}-\\d{3}-(\\d{4}|\\d{3})$")]
        public string BrTelefona { get; set; }

        public string? Logo { get; set; }
        public bool Aktivan { get; set; }
        public int GradId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Model.Requests
{
    public class KorisnikInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Ime { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Prezime { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string KorisnickoIme { get; set; }

        [Required(AllowEmptyStrings = false)]
        [EmailAddress()]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false)]
        [RegularExpression("^\\d{3}-\\d{3}-(\\d{4}|\\d{3})$")]
        public string BrTelefona { get; set; }

        [Required]
        public bool? Aktivan { get; set; }

        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")]
        [MinLength(8)]
        [Required(AllowEmptyStrings = false)]
        public string? Lozinka { get; set; }

        [Compare("Lozinka")]
        [Required(AllowEmptyStrings = false)]
        public string? LozinkaProvjera { get; set; }

        public List<int>? Uloge { get; set; } = new List<int>();
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Model.Requests
{
    public class LoginRequest
    {
        [Required]
        [MinLength(4)]
        public string KorisnickoIme { get; set; }

        [Required]
        [MinLength(8)]
        public string Lozinka { get; set; }
    }
}

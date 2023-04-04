using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Model
{
    public class Drzava
    {
        public int DrzavaId { get; set; }
        public string Naziv { get; set; }
        public string Skracenica { get; set; }
        public virtual ICollection<Grad> Grads { get; set; }
    }
}

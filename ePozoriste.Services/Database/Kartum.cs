using System;
using System.Collections.Generic;

namespace ePozoriste.Services.Database
{
    public partial class Kartum
    {
        public Kartum()
        {
            Kupovinas = new HashSet<Kupovina>();
        }

        public int KartaId { get; set; }
        public bool? Aktivna { get; set; }
        public int? TerminId { get; set; }
        public string? Sjediste { get; set; }

        public virtual Termin? Termin { get; set; }
        public virtual ICollection<Kupovina> Kupovinas { get; set; }
    }
}

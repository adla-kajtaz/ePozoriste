﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Model.Requests
{
    public class ObavijestInsertRequest
    {
        public string Naslov { get; set; }
        public string Podnaslov { get; set; }
        public string Sadrzaj { get; set; }
        public string Slika { get; set; }
        public DateTime DatumKreiranja { get; set; }

        public int ObavijestKategorijaId { get; set; }

        public int KorisnikId { get; set; }
    }
}

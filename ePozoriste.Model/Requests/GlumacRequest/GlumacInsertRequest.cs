﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Model.Requests
{
    public class GlumacInsertRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string? Slika { get; set; }
    }
}

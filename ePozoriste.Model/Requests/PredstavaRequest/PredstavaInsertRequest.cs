﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Model.Requests
{
    public class PredstavaInsertRequest
    {
        public string Naziv { get; set; }
        public string Sadrzaj { get; set; }
        public string? Slika { get; set; }
        public int VrijemeTrajanje { get; set; }
        public string Rezija { get; set; }
        public string Scenografija { get; set; }
        public string Kostimografija { get; set; }
    }
}
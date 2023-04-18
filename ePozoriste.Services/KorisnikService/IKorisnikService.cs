﻿using ePozoriste.Model.Requests;
using ePozoriste.Model.SearchObjects;
using ePozoriste.Services.BaseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Services
{
    public interface IKorisnikService : IBaseCRUDService<Model.Korisnik, BaseSearchObject, KorisnikInsertRequest, KorisnikInsertRequest>
    {
        Task<Model.Korisnik> Login(string korisnickoIme, string lozinka);
        Model.Korisnik GetByUsername(string korisnickoIme);
    }
}

﻿using AutoMapper;
using ePozoriste.Model.Requests;
using ePozoriste.Model.SearchObjects;
using ePozoriste.Services.BaseService;
using ePozoriste.Services.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Services
{
    public class KupovinaService : BaseCRUDService<Model.Kupovina, Database.Kupovina, KupovinaSearchObject, KupovinaInsertRequest, KupovinaInsertRequest>, IKupovinaService
    {
        IKartaService _kartaService { get; set; }

        public KupovinaService(ePozoristeContext context, IMapper mapper, IKartaService kartaService) : base(context, mapper)
        {
            _kartaService = kartaService;
        }

        public override IQueryable<ePozoriste.Services.Database.Kupovina> AddInclude(IQueryable<ePozoriste.Services.Database.Kupovina> query, KupovinaSearchObject search = null)
        {
            query = query.Include(x => x.Korisnik).Include(x=>x.Termin).Include(x=>x.Termin.Predstava);
            return base.AddInclude(query, search);
        }

        public override IQueryable<ePozoriste.Services.Database.Kupovina> AddFilter(IQueryable<ePozoriste.Services.Database.Kupovina> query, KupovinaSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search.KorisnikId != null)
                filteredQuery = filteredQuery.Where(x => x.KorisnikId == search.KorisnikId);
            return filteredQuery;
        }

        public override Model.Kupovina Insert(KupovinaInsertRequest request)
        {
            var termin = _context.Termins.First(x => x.TerminId == request.TerminId);
            if (termin == null)
                throw new Exception("Termin nije pronađen");

            Kupovina kupovina = new Kupovina();
            kupovina.KorisnikId = (int)request.KorisnikId;
            kupovina.DatumKupovine = request.DatumKupovine;
            kupovina.Kolicina = request.Karte.Count();
            kupovina.Cijena = request.Cijena;
            kupovina.TerminId = request.TerminId;
            _context.Add(kupovina);
            _context.SaveChanges();
            var entity = _mapper.Map<Model.Kupovina>(kupovina);
            foreach(var item in request.Karte)
            {
                var karta = _context.Karta.Find(item);
                if(karta == null)
                    throw new Exception("Karta nije pronađena");
                _kartaService.ChangeStatus(karta.KartaId, entity.KupovinaId);
            }
            //_context.SaveChanges();
            return _mapper.Map<Model.Kupovina>(kupovina);
        }
    }
}

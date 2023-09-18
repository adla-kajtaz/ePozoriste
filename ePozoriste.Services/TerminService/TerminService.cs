using AutoMapper;
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
    public class TerminService : BaseCRUDService<Model.Termin, Database.Termin, TerminSearchObject, TerminInsertRequest, TerminInsertRequest>, ITerminService
    {
        public TerminService(ePozoristeContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IQueryable<ePozoriste.Services.Database.Termin> AddInclude(IQueryable<ePozoriste.Services.Database.Termin> query, TerminSearchObject search = null)
        {
            query = query.Include(x => x.Predstava).Include(x=>x.Sala).Include(x => x.Sala.Pozoriste).Include(x => x.Sala.Pozoriste.Grad).Include(x => x.Sala.Pozoriste.Grad.Drzava);
            return base.AddInclude(query, search);
        }

        public override IQueryable<ePozoriste.Services.Database.Termin> AddFilter(IQueryable<ePozoriste.Services.Database.Termin> query, TerminSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search.PredstavaId != null)
                filteredQuery = filteredQuery.Where(x => x.PredstavaId == search.PredstavaId);
            if (search.SalaId != null)
                filteredQuery = filteredQuery.Where(x => x.SalaId == search.SalaId);
            if (search.Premijera != null)
                filteredQuery = filteredQuery.Where(x => x.Premijera == search.Premijera);
            if (search.Predpremijera != null)
                filteredQuery = filteredQuery.Where(x => x.Predpremijera == search.Predpremijera);
            if (search.DatumOdrzavanja != null)
                filteredQuery = filteredQuery.Where(x => x.DatumOdrzavanja == search.DatumOdrzavanja);
            return filteredQuery;
        }

        public override Model.Termin Delete(int id)
        {
            var entity = _context.Termins.Find(id);
            var karte = _context.Karta.Where(e => e.TerminId == id).ToList();

            if (karte != null && karte.Any())
            {
                return null;
            }
            else if (entity == null)
            {
                return null;
            }
            else
            {
                _context.Termins.Remove(entity);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Termin>(entity);
        }
    }
}

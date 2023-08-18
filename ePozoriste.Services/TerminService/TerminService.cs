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

        public override IEnumerable<Model.Termin> GetAll(TerminSearchObject search = null)
        {
            var entity = _context.Termins.Include(x=>x.Predstava).Include(x=>x.Sala).Include(x=>x.Sala.Pozoriste).Include(x=>x.Sala.Pozoriste.Grad).Include(x => x.Sala.Pozoriste.Grad.Drzava).AsQueryable();

            if (search.SalaId != null && search.PredstavaId != null && search.Premijera != null && search.Predpremijera != null && search.DatumOdrzavanja != null)
            {
                entity = entity.Where(e => e.SalaId == search.SalaId && e.PredstavaId == search.PredstavaId 
                                        && e.Premijera == search.Premijera && e.Predpremijera == search.Predpremijera && e.DatumOdrzavanja == search.DatumOdrzavanja);
            }
            else if (search.SalaId != null || search.PredstavaId != null || search.Premijera != null || search.Predpremijera != null || search.DatumOdrzavanja != null)
            {
                entity = entity.Where(e => e.SalaId == search.SalaId || e.PredstavaId == search.PredstavaId
                                        || e.Premijera == search.Premijera || e.Predpremijera == search.Predpremijera || e.DatumOdrzavanja == search.DatumOdrzavanja);
            }

            var list = entity.ToList();
            return _mapper.Map<IList<Model.Termin>>(list);
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

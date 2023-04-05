using AutoMapper;
using ePozoriste.Model.Requests;
using ePozoriste.Model.SearchObjects;
using ePozoriste.Services.BaseService;
using ePozoriste.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Services
{
    public class GlumacService : BaseCRUDService<Model.Glumac, Database.Glumac, BaseSearchObject, GlumacInsertRequest, GlumacInsertRequest>, IGlumacService
    {
        public GlumacService(ePozoristeContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IEnumerable<Model.Glumac> GetAll(BaseSearchObject search = null)
        {
            var entity = _context.Set<Database.Glumac>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Tekst))
            {
                entity = entity.Where(e => e.Ime.ToLower().Contains(search.Tekst.ToLower()) 
                                        || e.Prezime.ToLower().Contains(search.Tekst.ToLower()));
            }

            var list = entity.ToList();
            return _mapper.Map<IList<Model.Glumac>>(list);
        }

        public override Model.Glumac Delete(int id)
        {
            var entity = _context.Glumacs.Find(id);
            var glumciPredstave = _context.PredstavaGlumacs.Where(e => e.GlumacId == id).ToList();

            if (glumciPredstave != null && glumciPredstave.Any())
            {
                return null;
            }
            else
            {
                _context.Glumacs.Remove(entity);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Glumac>(entity);
        }
    }
}

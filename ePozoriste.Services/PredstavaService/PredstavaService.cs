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
    public class PredstavaService : BaseCRUDService<Model.Predstava, Database.Predstava, BaseSearchObject, PredstavaInsertRequest, PredstavaInsertRequest>, IPredstavaService
    {
        public PredstavaService(ePozoristeContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IEnumerable<Model.Predstava> GetAll(BaseSearchObject search = null)
        {
            var entity = _context.Set<Database.Predstava>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Tekst))
            {
                entity = entity.Where(e => e.Naziv.ToLower().Contains(search.Tekst.ToLower()));
            }

            var list = entity.ToList();
            return _mapper.Map<IList<Model.Predstava>>(list);
        }

        public override Model.Predstava Delete(int id)
        {
            var entity = _context.Predstavas.Find(id);
            var termini = _context.Termins.Where(e => e.PredstavaId == id).ToList();
            var predGlumac = _context.PredstavaGlumacs.Where(e => e.PredstavaId == id).ToList();
            var predVrsta = _context.PredstavaVrstaPredstaves.Where(e => e.PredstavaId == id).ToList();

            if ((termini != null && termini.Any()) || (predGlumac != null && predGlumac.Any()) || (predVrsta != null && predVrsta.Any()))
            {
                return null;
            }
            else if (entity == null)
            {
                return null;
            }
            else
            {
                _context.Predstavas.Remove(entity);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Predstava>(entity);
        }
    }
}

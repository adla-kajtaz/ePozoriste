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

        public override IQueryable<ePozoriste.Services.Database.Predstava> AddFilter(IQueryable<ePozoriste.Services.Database.Predstava> query, BaseSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Tekst))
                filteredQuery = filteredQuery.Where(x => x.Naziv.ToLower().Contains(search.Tekst.ToLower()));
            return filteredQuery;
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

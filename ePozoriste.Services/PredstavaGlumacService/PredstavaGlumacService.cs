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
    public class PredstavaGlumacService : BaseCRUDService<Model.PredstavaGlumac, Database.PredstavaGlumac, PredstavaGlumacSearchObject, PredstavaGlumacInsertRequest, PredstavaGlumacInsertRequest>, IPredstavaGlumacService
    {
        public PredstavaGlumacService(ePozoristeContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IEnumerable<Model.PredstavaGlumac> GetAll(PredstavaGlumacSearchObject search = null)
        {
            var entity = _context.PredstavaGlumacs.Include(x=>x.Glumac).Include(x=>x.Predstava).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Tekst) && search.PredstavaId != null && search.GlumacId != null)
            {
                entity = entity.Where(e => e.NazivUloge.Contains(search.Tekst) && e.PredstavaId == search.PredstavaId && e.GlumacId == search.GlumacId);
            }
            else if (!string.IsNullOrWhiteSpace(search.Tekst) || search.PredstavaId != null || search.GlumacId != null)
            {
                entity = entity.Where(e => e.PredstavaId == search.PredstavaId || e.GlumacId == search.GlumacId || e.NazivUloge.Contains(search.Tekst));
            }

            var list = entity.ToList();
            return _mapper.Map<IList<Model.PredstavaGlumac>>(list);
        }



    }
}

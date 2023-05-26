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
    public class PredstavaVrstaPredstaveService : BaseCRUDService<Model.PredstavaVrstaPredstave, Database.PredstavaVrstaPredstave, PredstavaVrstaPredstaveSearchObject, PredstavaVrstaPredstaveInsertRequest, PredstavaVrstaPredstaveInsertRequest>, IPredstavaVrstaPredstaveService
    {

        public PredstavaVrstaPredstaveService(ePozoristeContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IEnumerable<Model.PredstavaVrstaPredstave> GetAll(PredstavaVrstaPredstaveSearchObject search = null)
        {
            var entity = _context.PredstavaVrstaPredstaves.Include(x=>x.Predstava).Include(x=>x.VrstaPredstave).AsQueryable();

            if (search.PredstavaId != null && search.VrstaPredstaveId != null)
            {
                entity = entity.Where(e=> e.PredstavaId == search.PredstavaId && e.VrstaPredstaveId == search.VrstaPredstaveId);
            }
            else if (search.PredstavaId != null || search.VrstaPredstaveId != null)
            {
                entity = entity.Where(e => e.PredstavaId == search.PredstavaId || e.VrstaPredstaveId == search.VrstaPredstaveId);
            }

            var list = entity.ToList();
            return _mapper.Map<IList<Model.PredstavaVrstaPredstave>>(list);
        }
    }
}

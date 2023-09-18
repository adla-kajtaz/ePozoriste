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

        public override IQueryable<ePozoriste.Services.Database.PredstavaVrstaPredstave> AddInclude(IQueryable<ePozoriste.Services.Database.PredstavaVrstaPredstave> query, PredstavaVrstaPredstaveSearchObject search = null)
        {
            query = query.Include(x => x.Predstava).Include(x => x.VrstaPredstave);
            return base.AddInclude(query, search);
        }

        public override IQueryable<ePozoriste.Services.Database.PredstavaVrstaPredstave> AddFilter(IQueryable<ePozoriste.Services.Database.PredstavaVrstaPredstave> query, PredstavaVrstaPredstaveSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search.PredstavaId != null)
                filteredQuery = filteredQuery.Where(x => x.PredstavaId == search.PredstavaId);
            if (search.VrstaPredstaveId != null)
                filteredQuery = filteredQuery.Where(x => x.VrstaPredstaveId == search.VrstaPredstaveId);
            return filteredQuery;
        }
    }
}

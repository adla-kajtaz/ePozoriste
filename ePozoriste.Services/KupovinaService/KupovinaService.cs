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
    public class KupovinaService : BaseCRUDService<Model.Kupovina, Database.Kupovina, KupovinaSearchObject, KupovinaInsertRequest, KupovinaInsertRequest>, IKupovinaService
    {
        public KupovinaService(ePozoristeContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IQueryable<ePozoriste.Services.Database.Kupovina> AddInclude(IQueryable<ePozoriste.Services.Database.Kupovina> query, KupovinaSearchObject search = null)
        {
            query = query.Include(x => x.Korisnik);
            return base.AddInclude(query, search);
        }

        public override IQueryable<ePozoriste.Services.Database.Kupovina> AddFilter(IQueryable<ePozoriste.Services.Database.Kupovina> query, KupovinaSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search.KorisnikId != null)
                filteredQuery = filteredQuery.Where(x => x.KorisnikId == search.KorisnikId);
            return filteredQuery;
        }
    }
}

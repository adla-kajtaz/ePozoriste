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
    public class KupovinaService : BaseCRUDService<Model.Kupovina, Database.Kupovina, KupovinaSearchObject, KupovinaInsertRequest, KupovinaInsertRequest>, IKupovinaService
    {
        public KupovinaService(ePozoristeContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IEnumerable<Model.Kupovina> GetAll(KupovinaSearchObject search = null)
        {
            var entity = _context.Set<Database.Kupovina>().AsQueryable();

            if (search.KartaId != null && search.KorisnikId != null)
            {
                entity = entity.Where(e => e.KartaId == search.KartaId && e.KorisnikId == search.KorisnikId);
            }
            else if (search.KartaId != null || search.KorisnikId != null)
            {
                entity = entity.Where(e => e.KartaId == search.KartaId || e.KorisnikId == search.KorisnikId);
            }

            var list = entity.ToList();
            return _mapper.Map<IList<Model.Kupovina>>(list);
        }
    }
}

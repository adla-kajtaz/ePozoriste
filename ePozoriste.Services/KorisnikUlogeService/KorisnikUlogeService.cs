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
    public class KorisnikUlogeService : BaseCRUDService<Model.KorisnikUloge, Database.KorisnikUloge, KorisnikUlogeSearchObject, KorisnikUlogeInsertRequest, KorisnikUlogeInsertRequest>, IKorisnikUlogeService
    {
        public KorisnikUlogeService(ePozoristeContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IEnumerable<Model.KorisnikUloge> GetAll(KorisnikUlogeSearchObject search = null)
        {
            var entity = _context.KorisnikUloges.Include(x => x.Uloga).Include(x=>x.Korisnik).AsQueryable();

            if (search.KorisnikId != null && search.UlogaId != null)
            {
                entity = entity.Where(e => e.KorisnikId == search.KorisnikId && e.UlogaId == search.UlogaId);
            }
            else if (search.KorisnikId != null || search.UlogaId != null)
            {
                entity = entity.Where(e => e.UlogaId == search.UlogaId || e.KorisnikId == search.KorisnikId);
            }

            var list = entity.ToList();
            return _mapper.Map<IList<Model.KorisnikUloge>>(list);
        }
    }
}

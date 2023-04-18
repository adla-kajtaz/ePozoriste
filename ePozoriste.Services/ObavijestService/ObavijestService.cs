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
    public class ObavijestService : BaseCRUDService<Model.Obavijest, Database.Obavijest, ObavijestSearchObject, ObavijestInsertRequest, ObavijestInsertRequest>, IObavijestService
    {
        public ObavijestService(ePozoristeContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IEnumerable<Model.Obavijest> GetAll(ObavijestSearchObject search = null)
        {
            var entity = _context.Set<Database.Obavijest>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Tekst) && search.ObavijestKategorijaId != null)
            {
                entity = entity.Where(e => e.Naslov.Contains(search.Tekst) && e.Podnaslov.Contains(search.Tekst)
                         && e.Sadrzaj.Contains(search.Tekst) && e.ObavijestKategorijaId == search.ObavijestKategorijaId);
            }
            else if (!string.IsNullOrWhiteSpace(search.Tekst) || search.ObavijestKategorijaId != null)
            {
                entity = entity.Where(e => e.ObavijestKategorijaId == search.ObavijestKategorijaId || e.Naslov.Contains(search.Tekst)
                         || e.Podnaslov.Contains(search.Tekst) || e.Sadrzaj.Contains(search.Tekst));
            }

            var list = entity.ToList();
            return _mapper.Map<IList<Model.Obavijest>>(list);
        }
    }
}

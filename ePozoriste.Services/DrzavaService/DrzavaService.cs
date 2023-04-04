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

namespace ePozoriste.Services.DrzavaService
{
    public class DrzavaService : BaseCRUDService<Model.Drzava, Database.Drzava, BaseSearchObject, DrzavaInsertRequest, DrzavaInsertRequest>, IDrzavaService
    {
        public DrzavaService(ePozoristeContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public IEnumerable<Model.Drzava> GetAll(BaseSearchObject search = null)
        {
            var entity = _context.Set<Database.Drzava>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Tekst))
            {
                entity = entity.Where(e => e.Naziv.Contains(search.Tekst));
            }

            var list = entity.ToList();
            return _mapper.Map<IList<Model.Drzava>>(list);
        }
    }
}

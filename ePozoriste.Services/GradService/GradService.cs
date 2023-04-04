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
    public class GradService : BaseCRUDService <Model.Grad, Database.Grad, GradSearchObject, GradInsertRequest, GradInsertRequest>, IGradService
    {
        public GradService(ePozoristeContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IEnumerable<Model.Grad> GetAll(GradSearchObject search = null)
        {
            var entity = _context.Set<Database.Grad>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Tekst) && search.DrzavaId != null)
            {
                entity = entity.Where(e => e.Naziv.Contains(search.Tekst) && e.DrzavaId == search.DrzavaId);
            }
            else if (!string.IsNullOrWhiteSpace(search.Tekst) || search.DrzavaId != null)
            {
                entity = entity.Where(e => e.DrzavaId == search.DrzavaId || e.Naziv.Contains(search.Tekst));
            }

            var list = entity.ToList();
            return _mapper.Map<IList<Model.Grad>>(list);
        }
    }
}

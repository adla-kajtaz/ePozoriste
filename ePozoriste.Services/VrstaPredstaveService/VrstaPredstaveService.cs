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
    public class VrstaPredstaveService : BaseCRUDService<Model.VrstaPredstave, Database.VrstaPredstave, BaseSearchObject, VrstaPredstaveInsertRequest, VrstaPredstaveInsertRequest>, IVrstaPredstaveService
    {
        public VrstaPredstaveService(ePozoristeContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IEnumerable<Model.VrstaPredstave> GetAll(BaseSearchObject search = null)
        {
            var entity = _context.Set<Database.VrstaPredstave>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Tekst))
            {
                entity = entity.Where(e => e.Naziv.ToLower().Contains(search.Tekst.ToLower()));
            }

            var list = entity.ToList();
            return _mapper.Map<IList<Model.VrstaPredstave>>(list);
        }

        public override Model.VrstaPredstave Delete(int id)
        {
            var entity = _context.VrstaPredstaves.Find(id);
            var predstaveVrste = _context.PredstavaVrstaPredstaves.Where(e => e.VrstaPredstaveId == id).ToList();

            if (predstaveVrste != null && predstaveVrste.Any())
            {
                return null;
            }
            else
            {
                _context.VrstaPredstaves.Remove(entity);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.VrstaPredstave>(entity);
        }
    }
}

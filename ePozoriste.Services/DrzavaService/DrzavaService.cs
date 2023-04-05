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
    public class DrzavaService : BaseCRUDService<Model.Drzava, Database.Drzava, BaseSearchObject, DrzavaInsertRequest, DrzavaInsertRequest>, IDrzavaService
    {
        public DrzavaService(ePozoristeContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IEnumerable<Model.Drzava> GetAll(BaseSearchObject search = null)
        {
            var entity = _context.Set<Database.Drzava>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Tekst))
            {
                entity = entity.Where(e => e.Naziv.ToLower().Contains(search.Tekst.ToLower()));
            }

            var list = entity.ToList();
            return _mapper.Map<IList<Model.Drzava>>(list);
        }

        public override Model.Drzava Delete(int id)
        {
            var entity = _context.Drzavas.Find(id);
            var gradovi = _context.Grads.Where(e => e.DrzavaId == id).ToList();

            if(gradovi != null && gradovi.Any())
            {
                return null;
            }
            else
            {
                _context.Drzavas.Remove(entity);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Drzava>(entity);
        }
    }
}

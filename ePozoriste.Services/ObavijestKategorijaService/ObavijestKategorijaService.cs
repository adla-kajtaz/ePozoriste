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
    public class ObavijestKategorijaService : BaseCRUDService<Model.ObavijestKategorija, Database.ObavijestKategorija, BaseSearchObject, ObavijestKategorijaInsertRequest, ObavijestKategorijaInsertRequest>, IObavijestKategorijaService
    {
        public ObavijestKategorijaService(ePozoristeContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IEnumerable<Model.ObavijestKategorija> GetAll(BaseSearchObject search = null)
        {
            var entity = _context.Set<Database.ObavijestKategorija>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Tekst))
            {
                entity = entity.Where(e => e.Naziv.ToLower().Contains(search.Tekst.ToLower()));
            }

            var list = entity.ToList();
            return _mapper.Map<IList<Model.ObavijestKategorija>>(list);
        }

        public override Model.ObavijestKategorija Delete(int id)
        {
            var entity = _context.ObavijestKategorijas.Find(id);
            var obavijesti = _context.Obavijests.Where(e => e.ObavijestKategorijaId == id).ToList();

            if (obavijesti != null && obavijesti.Any())
            {
                return null;
            }
            else
            {
                _context.ObavijestKategorijas.Remove(entity);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.ObavijestKategorija>(entity);
        }
    }
}

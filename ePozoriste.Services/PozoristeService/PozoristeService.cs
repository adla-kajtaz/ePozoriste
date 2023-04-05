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
    public class PozoristeService : BaseCRUDService <Model.Pozoriste, Database.Pozoriste, PozoristeSearchObject, PozoristeInsertRequest, PozoristeInsertRequest>, IPozoristeService
    {
        public PozoristeService(ePozoristeContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IEnumerable<Model.Pozoriste> GetAll(PozoristeSearchObject search = null)
        {
            var entity = _context.Set<Database.Pozoriste>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Tekst) && search.GradId != null)
            {
                entity = entity.Where(e => e.Naziv.Contains(search.Tekst) && e.GradId == search.GradId);
            }
            else if (!string.IsNullOrWhiteSpace(search.Tekst) || search.GradId != null)
            {
                entity = entity.Where(e => e.GradId == search.GradId || e.Naziv.Contains(search.Tekst));
            }

            var list = entity.ToList();
            return _mapper.Map<IList<Model.Pozoriste>>(list);
        }

        public override Model.Pozoriste Delete(int id)
        {
            var entity = _context.Pozoristes.Find(id);
            var sale = _context.Salas.Where(e => e.PozoristeId == id).ToList();

            if (sale != null && sale.Any())
            {
                return null;
            }
            else
            {
                _context.Pozoristes.Remove(entity);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Pozoriste>(entity);
        }
    }
}

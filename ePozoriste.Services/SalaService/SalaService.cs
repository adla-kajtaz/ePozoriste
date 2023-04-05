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
    public class SalaService : BaseCRUDService <Model.Sala, Database.Sala, SalaSearchObject, SalaInsertRequest, SalaInsertRequest>, ISalaService
    {
        public SalaService(ePozoristeContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IEnumerable<Model.Sala> GetAll(SalaSearchObject search = null)
        {
            var entity = _context.Set<Database.Sala>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Tekst) && search.PozoristeId != null)
            {
                entity = entity.Where(e => e.Naziv.Contains(search.Tekst) && e.PozoristeId == search.PozoristeId);
            }
            else if (!string.IsNullOrWhiteSpace(search.Tekst) || search.PozoristeId != null)
            {
                entity = entity.Where(e => e.PozoristeId == search.PozoristeId || e.Naziv.Contains(search.Tekst));
            }

            var list = entity.ToList();
            return _mapper.Map<IList<Model.Sala>>(list);
        }

        public override Model.Sala Delete(int id)
        {
            var entity = _context.Salas.Find(id);
            var termini = _context.Termins.Where(e => e.SalaId == id).ToList();

            if (termini != null && termini.Any())
            {
                return null;
            }
            else
            {
                _context.Salas.Remove(entity);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Sala>(entity);
        }
    }
}

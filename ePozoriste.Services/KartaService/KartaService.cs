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
    public class KartaService : BaseCRUDService<Model.Karta, Database.Kartum, KartaSearchObject, KartaInsertRequest, KartaInsertRequest>, IKartaService
    {
        public KartaService(ePozoristeContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IEnumerable<Model.Karta> GetAll(KartaSearchObject search = null)
        {
            var entity = _context.Karta.Include(x=>x.Termin).Include(x => x.Termin.Predstava).Include(x => x.Termin.Sala).Include(x => x.Termin.Sala.Pozoriste).Include(x => x.Termin.Sala.Pozoriste.Grad).Include(x => x.Termin.Sala.Pozoriste.Grad.Drzava).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Tekst) && search.TerminId != null && search.Aktivan != null)
            {
                entity = entity.Where(e => e.Sjediste.Contains(search.Tekst) && e.TerminId == search.TerminId && e.Aktivna == search.Aktivan);
            }
            else if (!string.IsNullOrWhiteSpace(search.Tekst) || search.TerminId != null)
            {
                entity = entity.Where(e => e.TerminId == search.TerminId || e.Aktivna == search.Aktivan || e.Sjediste.Contains(search.Tekst));
            }

            var list = entity.ToList();
            return _mapper.Map<IList<Model.Karta>>(list);
        }

        public override Model.Karta Delete(int id)
        {
            var entity = _context.Karta.Find(id);
            var kupovine = _context.Kupovinas.Where(e => e.KartaId == id).ToList();

            if (kupovine != null && kupovine.Any())
            {
                return null;
            }
            else if (entity == null)
            {
                return null;
            }
            else
            {
                _context.Karta.Remove(entity);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Karta>(entity);
        }

    }
}

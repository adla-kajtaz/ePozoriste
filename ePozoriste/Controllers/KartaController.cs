using ePozoriste.Model.Requests;
using ePozoriste.Model.SearchObjects;
using ePozoriste.Services;
using Microsoft.AspNetCore.Mvc;

namespace ePozoriste.Controllers
{
    public class KartaController : BaseCRUDController<Model.Karta, KartaSearchObject, KartaInsertRequest, KartaInsertRequest>
    {
        public IKartaService _service { get; set; }
        public KartaController(IKartaService service) : base(service)
        {
            _service = service;
        }

        [HttpPatch("{id}")]
        public Model.Karta changeStatus(int id)
        {
            return _service.ChangeStatus(id);
        }

        [HttpGet("{id}")]
        public IEnumerable<Model.Karta> GetByTerminId(int id)
        {
            return _service.GetByTerminId(id);
        }
    }
}

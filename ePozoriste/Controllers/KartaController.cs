using ePozoriste.Model.Requests;
using ePozoriste.Model.SearchObjects;
using ePozoriste.Services;

namespace ePozoriste.Controllers
{
    public class KartaController : BaseCRUDController<Model.Karta, KartaSearchObject, KartaInsertRequest, KartaInsertRequest>
    {
        public IKartaService _service { get; set; }
        public KartaController(IKartaService service) : base(service)
        {
            _service = service;
        }
    }
}

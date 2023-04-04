using ePozoriste.Model.Requests;
using ePozoriste.Model.SearchObjects;
using ePozoriste.Services.DrzavaService;

namespace ePozoriste.Controllers
{
    public class DrzavaController : BaseCRUDController <Model.Drzava, BaseSearchObject, DrzavaInsertRequest, DrzavaInsertRequest>
    {
        public IDrzavaService _service { get; set; }
        public DrzavaController(IDrzavaService service) : base(service)
        {
            _service = service;
        }
    }
}

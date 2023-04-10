using ePozoriste.Model.Requests;
using ePozoriste.Model.SearchObjects;
using ePozoriste.Services;

namespace ePozoriste.Controllers
{
    public class KupovinaController : BaseCRUDController<Model.Kupovina, KupovinaSearchObject, KupovinaInsertRequest, KupovinaInsertRequest>
    {
        public IKupovinaService _service { get; set; }
        public KupovinaController(IKupovinaService service) : base(service)
        {
            _service = service;
        }
    }
}

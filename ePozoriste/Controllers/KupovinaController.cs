using ePozoriste.Model.Requests;
using ePozoriste.Model.SearchObjects;
using ePozoriste.Services;
using Microsoft.AspNetCore.Mvc;

namespace ePozoriste.Controllers
{
    public class KupovinaController : BaseCRUDController<Model.Kupovina, KupovinaSearchObject, KupovinaInsertRequest, KupovinaInsertRequest>
    {
        public IKupovinaService _service { get; set; }
        public IKartaService _kartaService { get; set; }
        public KupovinaController(IKupovinaService service, IKartaService kartaService) : base(service)
        {
            _service = service;
            _kartaService = kartaService;
        }

        public override Model.Kupovina Insert([FromBody] KupovinaInsertRequest request)
        {
            return base.Insert(request);
        }
    }
}

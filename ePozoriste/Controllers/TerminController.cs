using ePozoriste.Model;
using ePozoriste.Model.Requests;
using ePozoriste.Model.SearchObjects;
using ePozoriste.Services;
using ePozoriste.Services.BaseService;
using Microsoft.AspNetCore.Mvc;

namespace ePozoriste.Controllers
{
    public class TerminController : BaseCRUDController<Model.Termin, TerminSearchObject, TerminInsertRequest, TerminInsertRequest>
    {
        public ITerminService _service { get; set; }
        public TerminController (ITerminService service) : base(service)
        {
            _service = service;
        }

        public override Model.Termin Insert([FromBody] TerminInsertRequest request)
        {
            return base.Insert(request);
        }

        [HttpGet("recommend/{id}")]
        public List<Model.Termin> Recommend(int id)
        {
            return _service.TerminRecommenderSystem(id);
        }
    }
}

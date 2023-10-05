using ePozoriste.Model;
using ePozoriste.Model.Requests;
using ePozoriste.Model.SearchObjects;
using ePozoriste.Services;
using ePozoriste.Services.BaseService;
using Microsoft.AspNetCore.Mvc;

namespace ePozoriste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TerminController : BaseCRUDController<Model.Termin, TerminSearchObject, TerminInsertRequest, TerminInsertRequest>
    {
        public ITerminService _service { get; set; }
        public TerminController (ITerminService service) : base(service)
        {

        }
    }
}

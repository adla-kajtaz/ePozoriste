using ePozoriste.Model.Requests;
using ePozoriste.Model.SearchObjects;
using ePozoriste.Services;

namespace ePozoriste.Controllers
{
    public class PredstavaVrstaPredstaveController : BaseCRUDController<Model.PredstavaVrstaPredstave, PredstavaVrstaPredstaveSearchObject, PredstavaVrstaPredstaveInsertRequest, PredstavaVrstaPredstaveInsertRequest>
    {
        public IPredstavaVrstaPredstaveService _service { get; set; }
        public PredstavaVrstaPredstaveController(IPredstavaVrstaPredstaveService service) : base(service)
        {
            _service = service;
        }
    }
}

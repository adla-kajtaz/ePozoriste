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
        public PayPalService _payPalService { get; set; }

        public KupovinaController(IKupovinaService service, IKartaService kartaService, PayPalService payPalService) : base(service)
        {
            _service = service;
            _kartaService = kartaService;
            _payPalService = payPalService;
        }

        public override Model.Kupovina Insert([FromBody] KupovinaInsertRequest request)
        {
            return base.Insert(request);
        }

        [HttpGet("getByKorisnikId/{id}")]
        public IEnumerable<Model.Kupovina> GetByKorisnikId(int id)
        {
            return _service.GetByKorisnikId(id);
        }

        [HttpGet("getClient")]
        public Task<string> GetClientToken()
        {
            return _payPalService.GetClientToken();
        }

        public class NonceDto
        {
            public int iznos { get; set; }
            public string nonce { get; set; }
        };

        [HttpPost("purchase")]
        public IActionResult Purchase([FromBody] NonceDto nonceDto)
        {
            return Ok(_payPalService.MakeTransaction(nonceDto.iznos, nonceDto.nonce));
        }

    }
}

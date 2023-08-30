using ePozoriste.Model.Requests;
using ePozoriste.Model.SearchObjects;
using ePozoriste.Services;
using Microsoft.AspNetCore.Mvc;

namespace ePozoriste.Controllers
{
    public class KorisnikController : BaseCRUDController<Model.Korisnik, BaseSearchObject, KorisnikInsertRequest, KorisnikInsertRequest>
    {
        public IKorisnikService _service { get; set; }
        public KorisnikController(IKorisnikService service) : base(service)
        {
            _service = service;
        }
        public override Model.Korisnik Insert([FromBody] KorisnikInsertRequest request)
        {
            return base.Insert(request);
        }

        public override Model.Korisnik Update(int id, [FromBody] KorisnikInsertRequest request)
        {
            return base.Update(id, request);
        }

        [HttpPost("login")]
        public Task<Model.Korisnik> Login(string korisnickoIme, string lozinka)
        {
            return _service.Login(korisnickoIme, lozinka);
        }

        [HttpPost("register")]
        public Model.Korisnik Register([FromBody] KorisnikInsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}

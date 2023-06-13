using AutoMapper;
using ePozoriste.Model.Requests;
using ePozoriste.Model.SearchObjects;
using ePozoriste.Services.BaseService;
using ePozoriste.Services.Database;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Services
{
    public class KorisnikService : BaseCRUDService<Model.Korisnik, Database.Korisnik, BaseSearchObject, KorisnikInsertRequest, KorisnikInsertRequest>, IKorisnikService
    {
        public KorisnikService(ePozoristeContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IEnumerable<Model.Korisnik> GetAll(BaseSearchObject search = null)
        {
            var entity = _context.Set<Database.Korisnik>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Tekst))
            {
                entity = entity.Where(x => x.Ime.Contains(search.Tekst)
                 || x.Prezime.Contains(search.Tekst)
                 || x.KorisnickoIme.Contains(search.Tekst));
            }

            var list = entity.ToList();
            return _mapper.Map<List<Model.Korisnik>>(list);
        }

        public override Model.Korisnik Insert(KorisnikInsertRequest request)
        {
            var korisnici = _context.Set<Database.Korisnik>().AsQueryable();

            if (korisnici.Any(x => x.KorisnickoIme == request.KorisnickoIme))
            {
                return null;
            }

            var entity = _mapper.Map<Database.Korisnik>(request);
            _context.Add(entity);

            if (request.Lozinka != request.LozinkaProvjera)
            {
                return null;
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Lozinka);
            _context.SaveChanges();

            foreach (var role in request.Uloge)
            {
                Database.KorisnikUloge korisnikUloge = new Database.KorisnikUloge
                {
                    KorisnikId = entity.KorisnikId,
                    UlogaId = role
                };

                _context.KorisnikUloges.Add(korisnikUloge);
            }

            _context.SaveChanges();

            return _mapper.Map<Model.Korisnik>(entity);
        }

        public override Model.Korisnik Update(int id, KorisnikInsertRequest request)
        {
            var entity = _context.Korisniks.Include(x => x.KorisnikUloges).FirstOrDefault(x => x.KorisnikId == id);
            var stariLozinkaHash = entity.LozinkaHash;
            var stariLozinkaSalt = entity.LozinkaSalt;
            _mapper.Map(request, entity);
            if (string.IsNullOrEmpty(request.Lozinka))
            {
                entity.LozinkaSalt = stariLozinkaSalt;
                entity.LozinkaHash = stariLozinkaHash;
            }
            else
            {
                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Lozinka);
            }
            _context.Korisniks.Update(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Korisnik>(entity);
        }

        public Model.Korisnik GetByUsername(string korisnickoIme)
        {
            var korisnik = _context.Korisniks.Where(x => x.KorisnickoIme == korisnickoIme).FirstOrDefault();
            return _mapper.Map<Model.Korisnik>(korisnik);
        }

        public async Task<Model.Korisnik> Login(string korisnickoIme, string lozinka)
        {
            var entity = await _context.Korisniks.Include("KorisnikUloges.Uloga").FirstOrDefaultAsync(x => x.KorisnickoIme == korisnickoIme);

            if (entity == null)
            {
                return null;
            }

            var hash = GenerateHash(lozinka, entity.LozinkaSalt);

            if (hash != entity.LozinkaHash)
            {
                return null;
            }
            return _mapper.Map<Model.Korisnik>(entity);
        }

        public override Model.Korisnik Delete(int id)
        {
            var entity = _context.Korisniks.Find(id);
            var korisnikUloge = _context.KorisnikUloges.Where(e => e.KorisnikId == id).ToList();

            if (korisnikUloge != null && korisnikUloge.Any())
            {
                var uloga = _context.KorisnikUloges.Where(e => e.KorisnikId == id).ToList();
                foreach(var ulogaUloge in uloga)
                {
                    _context.KorisnikUloges.Remove(ulogaUloge);
                }
                _context.Korisniks.Remove(entity);
            }
            else if (entity == null)
            {
                return null;
            }
            else
            {
                _context.Korisniks.Remove(entity);
            }
           
            _context.SaveChanges();
            return _mapper.Map<Model.Korisnik>(entity);
        }

        public string GenerateHash(string input, string salt)
        {
            var valueBytes = KeyDerivation.Pbkdf2(
                password: input,
                salt: Encoding.UTF8.GetBytes(salt),
                prf: KeyDerivationPrf.HMACSHA512,
                iterationCount: 10000,
                numBytesRequested: 256 / 8
            );

            return Convert.ToBase64String(valueBytes);
        }

        public string GenerateSalt()
        {
            byte[] randomBytes = new byte[128 / 8];

            using (var generator = RandomNumberGenerator.Create())
            {
                generator.GetBytes(randomBytes);
                return Convert.ToBase64String(randomBytes);
            }
        }
    }
}

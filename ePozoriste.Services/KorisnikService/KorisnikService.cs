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

        public override IQueryable<ePozoriste.Services.Database.Korisnik> AddFilter(IQueryable<ePozoriste.Services.Database.Korisnik> query, BaseSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Tekst))
                filteredQuery = filteredQuery.Where(x => x.Ime.ToLower().Contains(search.Tekst.ToLower()) || x.Prezime.ToLower().Contains(search.Tekst.ToLower()) || x.KorisnickoIme.ToLower().Contains(search.Tekst.ToLower()));
            return filteredQuery;
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

            entity.LozinkaSalt = Helper.PasswordHelper.GenerateSalt();
            entity.LozinkaHash = Helper.PasswordHelper.GenerateHash(entity.LozinkaSalt, request.Lozinka);
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
                entity.LozinkaSalt = Helper.PasswordHelper.GenerateSalt();
                entity.LozinkaHash = Helper.PasswordHelper.GenerateHash(entity.LozinkaSalt, request.Lozinka);
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
            var entity = await _context.Korisniks.Include(x => x.KorisnikUloges).FirstOrDefaultAsync(x => x.KorisnickoIme == korisnickoIme);

            if (entity == null)
            {
                return null;
                //throw new UserException("Kredencijali nisu ispravni");
            }

            var hash = Helper.PasswordHelper.GenerateHash(entity.LozinkaSalt, lozinka);

            if (hash != entity.LozinkaHash)
            {
                return null;
                //throw new UserException("Kredencijali nisu ispravni");
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
    }
}

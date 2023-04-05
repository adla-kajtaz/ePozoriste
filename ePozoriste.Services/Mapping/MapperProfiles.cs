using AutoMapper;
using ePozoriste.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Services.Mapping
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<Database.Drzava, Model.Drzava>();
            CreateMap<Database.Grad, Model.Grad>();
            CreateMap<Database.Uloga, Model.Uloga>();
            CreateMap<Database.ObavijestKategorija, Model.ObavijestKategorija>();
            CreateMap<Database.Obavijest, Model.Obavijest>();
            CreateMap<Database.Pozoriste, Model.Pozoriste>();
            CreateMap<Database.Sala, Model.Sala>();
            CreateMap<Database.VrstaPredstave, Model.VrstaPredstave>();
            CreateMap<Database.Glumac, Model.Glumac>();




            CreateMap<DrzavaInsertRequest, Database.Drzava>();
            CreateMap<GradInsertRequest, Database.Grad>();
            CreateMap<ObavijestKategorijaInsertRequest, Database.ObavijestKategorija>();
            CreateMap<ObavijestInsertRequest, Database.Obavijest>();
            CreateMap<PozoristeInsertRequest, Database.Pozoriste>();
            CreateMap<SalaInsertRequest, Database.Sala>();
            CreateMap<VrstaPredstaveInsertRequest, Database.VrstaPredstave>();
            CreateMap<GlumacInsertRequest, Database.Glumac>();





        }
    }
}

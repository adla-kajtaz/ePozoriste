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

            CreateMap<DrzavaInsertRequest, Database.Drzava>();
        }
    }
}

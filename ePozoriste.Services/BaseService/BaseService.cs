﻿using AutoMapper;
using ePozoriste.Model.SearchObjects;
using ePozoriste.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Services.BaseService
{
    public class BaseService <T, TDb, TSearch> : IBaseService<T, TSearch> where T : class where TDb : class where TSearch : BaseSearchObject
    {
        public ePozoristeContext _context { get; set; }
        public IMapper _mapper { get; set; }
        public BaseService(ePozoristeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<T> GetAll(TSearch search = null)
        {
            var entity = _context.Set<TDb>();

            var list = entity.ToList();
            return _mapper.Map<IList<T>>(list);
        }
        

        public T GetById(int id)
        {
            var set = _context.Set<TDb>();

            var entity = set.Find(id);

            return _mapper.Map<T>(entity);
        }
    }
}

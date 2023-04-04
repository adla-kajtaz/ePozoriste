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
    public class BaseCRUDService<T, TDb, TSearch, TInsert, TUpdate> : BaseService<T, TDb, TSearch>, IBaseCRUDService<T, TSearch, TInsert, TUpdate> where T : class where TDb : class where TSearch : BaseSearchObject where TInsert : class where TUpdate : class
    {
        public BaseCRUDService(ePozoristeContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public virtual T Insert(TInsert insert)
        {
            var set = _context.Set<TDb>();

            TDb entity = _mapper.Map<TDb>(insert);

            set.Add(entity);

            _context.SaveChanges();

            return _mapper.Map<T>(entity);

        }

        public virtual T Update(int id, TUpdate update)
        {
            var set = _context.Set<TDb>();

            var entity = set.Find(id);

            if (entity != null)
            {
                _mapper.Map(update, entity);
            }
            else
            {
                return null;
            }

            _context.SaveChanges();

            return _mapper.Map<T>(entity);
        }

        public virtual T Delete(int id)
        {

            var set = _context.Set<TDb>();

            var entity = set.Find(id);

            if (entity != null)
            {
                set.Remove(entity);
            }
            else
            {
                return null;
            }

            _context.SaveChanges();

            return _mapper.Map<T>(entity);
        }
    }
}

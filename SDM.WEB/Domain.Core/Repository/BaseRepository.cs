﻿using Domain.Core.Interfaces;
using Domain.Entities.BaseEntity;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Repository
{
    public abstract class BaseRepository<TEntity> : IDisposable, IRepository<TEntity> where TEntity : class
    {

        private readonly INFRA.DATA.Context.dbContext _ctx;

        public BaseRepository(INFRA.DATA.Context.dbContext ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _ctx.Set<TEntity>();
        }

        public IQueryable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public TEntity Find(params object[] key)
        {
            return _ctx.Set<TEntity>().Find(key);
        }

        public void Update(TEntity obj)
        {
            _ctx.Set<TEntity>().Attach(obj);
            _ctx.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            _ctx.SaveChanges();

        }

        public void SaveAll()
        {
            _ctx.SaveChanges();
        }

        public void Add(TEntity obj)
        {
            _ctx.Set<TEntity>().Add(obj);
            _ctx.SaveChanges();
        }

        public void Exclude(Func<TEntity, bool> predicate)
        {
            _ctx.Set<TEntity>()
                .Where(predicate).ToList()
                .ForEach(del => _ctx.Set<TEntity>().Remove(del));
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }

    }
}
